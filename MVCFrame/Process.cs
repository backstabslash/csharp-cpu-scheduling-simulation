using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;


namespace MVCFrame
{
    public enum ProcessStatus
    {
        ready,
        running,
        waiting,
        terminated
    };
    public enum DeviceNumber
    {
        first,
        second
    }
    class Process : IComparable<Process>
    {
        long id;
        string name;
        long workTime = 0;
        int priority;
        public int minPriority = 0;
        public int maxPriority = 20 ;
        Random random = new Random();
        public long BurstTime { get; set; }
        public ProcessStatus status { get; set; }
        public DeviceNumber deviceNumber { get; set; }
        public long ArrivalTime { get; set; } // время поступления процесса в систему
        public long CommonWorkingTime { get; set; }
        public long ReadyQueueArrivalTime { get; set; } // время последней постановки в очередь готовых процессов
        public long AddrSpace { get; private set; }
        public int Priority { get; set; }

        public event EventHandler FreeingResource;
        private void OnFreeingResource()
        {
            if (FreeingResource != null)
                FreeingResource(this, null);
        }
        public int CompareTo(Process otherProcess)
        {
            if (otherProcess == null) return 1;
            return otherProcess.Priority.CompareTo(this.Priority);
        }
        public Process(long addrSpace, long pId)
        {
            id = pId;
            AddrSpace = addrSpace;
            name = "p" + id.ToString();
            this.status = ProcessStatus.ready;
        }
        public Process(){}
        public void IncreaseWorkTime()
        {
            if (workTime == BurstTime)
            {
                if (status == ProcessStatus.running)
                {
                    int number = random.Next(0, 2);
                   if (number == 0)
                        status = ProcessStatus.terminated;
                    else
                        status = ProcessStatus.waiting;
                }
                else
                    status = ProcessStatus.ready;
                OnFreeingResource();
            }
            else
                workTime++;
        }
        public override string ToString()
        {
            int prior = Priority;
            prior++;
            return "Id: " + id + " Status: " + status + " Burst: " + BurstTime + " Space: " + AddrSpace + " Priority: " + prior;
        }
        public void resetWorkTime()
        {
            workTime = 0;
        }
    }
}
