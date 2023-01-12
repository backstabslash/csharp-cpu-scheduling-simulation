using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Queues;
using Structures;
using System.Globalization;

namespace MVCFrame
{
    class Model : INotifyPropertyChanged
    {
        // операции модели
        public Model() // создание
        {
            // создание компонентов вычислительной системы:

            // 1.   часов - счётчика рабочих тактов;
            Clock = new SystemClock();
            // 2.   процессора;
            Cpu = new Resource();
            // 3.   оперативной памяти;
            Ram = new Memory();
            // 4.   внешнего устройства;
            Device = new Resource();
            Device2 = new Resource();
            // 5.   генератора идентификаторов процессов;
            idGen = new IdGenerator();
            // 6.   очереди готовых процессов (к процессору);
            readyQueue = new QueueArray<Process>();
            // 7.   очереди к внешнему устройству;
            deviceQueue = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            deviceQueue2 = new FIFOQueue<Process, SimpleArray<Process>>(new SimpleArray<Process>());
            // 8.   планировщика процессора;
            cpuScheduler = new CPUScheduler(Cpu, readyQueue);
            // 9.   планировщика памяти;
            memoryManager = new MemoryManager();
            // 10.  планировщика внешнего устройства;
            deviceScheduler = new DeviceScheduler(Device, deviceQueue);
            deviceScheduler2 = new DeviceScheduler(Device2, deviceQueue2);
            // 11.  настроек модели предметной области; 
            ModelSettings = new Settings();
            // 12. статистика - показатели работы системы
            Statistics = new Statistics();
            // 13.  генератора случайных чисел.
            processRand = new Random();
            DeviceRandom = new Random();
        }
        public void SaveSettings()
        {
            Ram.Save(ModelSettings.ValueOfRAMSize);
            memoryManager.Save(Ram);
        }
        public void WorkingCycle() // рабочий такт вычислительной системы
        {
            Statistics.avgWaiting += ReadyQueue.Count;
            
            if (Cpu.Free())
            {
                Statistics.cpuFree++;
            }
            if (Statistics.maxLength < readyQueue.Count)
            {
                Statistics.maxLength = readyQueue.Count;
                Statistics.MaxReadyQueueLength = Statistics.maxLength;
            }
            Clock.WorkingCycle();
            Statistics.CommonTime = Clock.Clock;
            if (processRand.NextDouble() <= ModelSettings.Intensity)
            {
                Process proc = new Process(processRand.Next(ModelSettings.MinValueOfAddrSpace, ModelSettings.MaxValueOfAddrSpace + 1), idGen.Id);
                proc.maxPriority = ModelSettings.MaxPriority;
                proc.Priority = processRand.Next(proc.minPriority, proc.maxPriority);
                proc.CommonWorkingTime++;
                Statistics.ArivalProcessesCount++;
                if (memoryManager.Allocate(proc.AddrSpace) != null)
                {
                    proc.ArrivalTime = Clock.Clock; // фикс время поступления процесса в систему
                    proc.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1); //предполагаемое время работы процесса
                    ReadyQueue = ReadyQueue.Put(proc);
                    Statistics.counter++;
                    Statistics.AvgReadyQueueLength = (Statistics.avgWaiting / Statistics.counter) * ModelSettings.Intensity;
                    proc.ReadyQueueArrivalTime = Clock.Clock;
                    if (Cpu.Free())
                    {
                        ReadyQueue = cpuScheduler.Session();
                        Subscribe(Cpu);
                    }
                }
                else
                {
                    Statistics.RejectedProcessesCount++;
                }

            }
            Cpu.WorkingCycle();
            Device.WorkingCycle();
            Device2.WorkingCycle();
            Statistics.SystemPerformance = (double)(Statistics.TerminatedProcessCount) / Clock.Clock;
            Statistics.CpuUtilization = (double)(Clock.Clock - Statistics.cpuFree) / Clock.Clock;
            Statistics.CpuIdleTime = Convert.ToString(Statistics.CommonTime) + "/" + Statistics.cpuFree;
        }
        public void Clear() // очистка (подготовка вычислительной системы к следующему сеансу работы)
        {
            Unsubscribe(Cpu);
            Unsubscribe(Device);
            Unsubscribe(Device2);
            // удаление процесса с процессора
            Cpu.Clear();
            // удаление процесса с внешнего устройства
            Device.Clear();
            Device2.Clear();
            // очистка памяти
            Ram.Clear();
            // очистка очереди готовых процессов
            readyQueue.Clear();
            // очистка очереди к устройству
            deviceQueue.Clear();
            deviceQueue2.Clear();
            // очистка счётчика тактов
            Clock.Clear();
            // очистка генератора идентификаторов процесса
            idGen.Clear();
            // сброс настроек
            Statistics.Clear();                                         
        }

        // компоненты модели:
        // 1.   часы;
        public readonly SystemClock Clock;
        // 2.   центральный процессор;
        public readonly Resource Cpu;
        // 3.   внешнее устройство;
        public readonly Resource Device;
        public readonly Resource Device2;
        // 4.   ОП
        public readonly Memory Ram;
        // 5.   генератор идентификаторов процессов;
        IdGenerator idGen;
        // 6.   очередь готовых процессов;
        IQueueable<Process> readyQueue;
        // 7.   очередь к внешнему устройству;
        IQueueable<Process> deviceQueue;
        IQueueable<Process> deviceQueue2;
        // 8    планировщик центрального процессора;
        CPUScheduler cpuScheduler;
        // 9.   планировщик памяти;
        MemoryManager memoryManager;
        // 10.  планировщик внешнего устройства;
        DeviceScheduler deviceScheduler;
        DeviceScheduler deviceScheduler2;
        // 11.  генератор процессов (генератор случайных чисел);
        Random processRand;
        // 12.  настройки модели предметной области.
        public readonly Settings ModelSettings;
        // 13. статистика - показатели работы системы
        public readonly Statistics Statistics;
        public Random DeviceRandom;

        private void FreeingResourceEventHandler(object Sender, EventArgs e)
        {
            Process resourceFreeingProcess = Sender as Process;
            if (resourceFreeingProcess == null)
                return;
            switch (resourceFreeingProcess.status)
            {
                case ProcessStatus.terminated:
                    Unsubscribe(Cpu);
                    Cpu.ActiveProcess = null;
                    memoryManager.Free(resourceFreeingProcess.AddrSpace);
                    if (readyQueue.Count != 0)
                    {
                        ReadyQueue = cpuScheduler.Session();
                        Subscribe(Cpu);
                    }
                    Statistics.TerminatedProcessCount++;
                    Statistics.CommonTurnAroundTime += resourceFreeingProcess.BurstTime;
                    Statistics.CommonWaitingTime += Clock.Clock - resourceFreeingProcess.ArrivalTime - resourceFreeingProcess.CommonWorkingTime;
                    Statistics.AvgWaitingTime = Statistics.avgWaiting / Statistics.TerminatedProcessCount;
                    Statistics.AvgTurnAroundTime = Statistics.CommonTurnAroundTime / Statistics.TerminatedProcessCount;
                    break;

                case ProcessStatus.waiting:
                    Unsubscribe(Cpu);
                    Cpu.ActiveProcess = null;
                    if (readyQueue.Count != 0)
                    {
                        ReadyQueue = cpuScheduler.Session();
                        Subscribe(Cpu);
                    }
                    resourceFreeingProcess.resetWorkTime();
                    resourceFreeingProcess.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    int deviceNumber = DeviceRandom.Next(0, 2);
                    switch (deviceNumber)
                    {
                        case 0:
                            resourceFreeingProcess.deviceNumber = DeviceNumber.first;
                            DeviceQueue = DeviceQueue.Put(resourceFreeingProcess);
                            if (Device.Free())
                            {
                                DeviceQueue = deviceScheduler.Session();
                                Subscribe(Device);
                            }
                            break;
                        case 1:
                            resourceFreeingProcess.deviceNumber = DeviceNumber.second;
                            DeviceQueue2 = DeviceQueue2.Put(resourceFreeingProcess);
                            if (Device2.Free())
                            {
                                DeviceQueue2 = deviceScheduler2.Session();
                                Subscribe(Device2);
                            }
                            break;
                    }
                    break;

                case ProcessStatus.ready:
                    switch (resourceFreeingProcess.deviceNumber)
                    {
                        case DeviceNumber.first:
                            Unsubscribe(Device);
                            Device.ActiveProcess = null;
                            if (deviceQueue.Count != 0)
                            {
                                DeviceQueue = deviceScheduler.Session();
                                Subscribe(Device);
                            }
                            break;
                        case DeviceNumber.second:
                            Unsubscribe(Device2);
                            Device2.ActiveProcess = null;
                            if (deviceQueue2.Count != 0)
                            {
                                DeviceQueue2 = deviceScheduler2.Session();
                                Subscribe(Device2);
                            }
                            break;
                    }
                    resourceFreeingProcess.resetWorkTime();
                    resourceFreeingProcess.BurstTime = processRand.Next(ModelSettings.MinValueOfBurstTime, ModelSettings.MaxValueOfBurstTime + 1);
                    ReadyQueue = readyQueue.Put(resourceFreeingProcess);
                    Statistics.counter++;
                    if (Cpu.Free())
                    {
                        ReadyQueue = cpuScheduler.Session();
                        Subscribe(Cpu);
                    }
                    break;
            }
        }
        private void Subscribe(Resource r)
        {
            r.ActiveProcess.FreeingResource += FreeingResourceEventHandler;
            if (Statistics.maxLength < readyQueue.Count)
            {
                Statistics.maxLength = readyQueue.Count;
                Statistics.MaxReadyQueueLength = Statistics.maxLength;
            }
        }
        private void Unsubscribe(Resource r)
        {
            if (r.ActiveProcess != null)
            {
                r.ActiveProcess.FreeingResource -= FreeingResourceEventHandler;
            }
        }
        // издатель события PropertyChangedEventHandler
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        public IQueueable<Process> ReadyQueue
        {
            get { return readyQueue; }
            set
            {
                readyQueue = value;
                OnPropertyChanged();
            }
        }
        public IQueueable<Process> DeviceQueue
        {
            get { return deviceQueue; }
            set
            {
                deviceQueue = value;
                OnPropertyChanged();
            }
        }
        public IQueueable<Process> DeviceQueue2
        {
            get { return deviceQueue2; }
            set
            {
                deviceQueue2 = value;
                OnPropertyChanged();
            }
        }
    }
}