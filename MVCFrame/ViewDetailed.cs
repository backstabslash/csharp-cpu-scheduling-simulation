using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Globalization;
using Queues;


namespace MVCFrame
{
    class ViewDetailed : View
    {
        public ViewDetailed(Model model, Controller controller, FrmDetailed frm)
           : base(model, controller)
        {
            this.frm = frm;
        }
        public override void DataBind()
        {
            // привязка счетчика тактов
            frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));

            // привязка активных процессов 
            frm.TbCpu.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess"));
            frm.TbDevice.DataBindings.Add(new Binding("Text", model.Device, "ActiveProcess"));
            frm.TbDevice2.DataBindings.Add(new Binding("Text", model.Device2, "ActiveProcess"));

            // привязка свободной памяти
            frm.LblFreeMemValue.DataBindings.Add(new Binding("Text", model.Ram, "FreeSize"));

            // привязка задействованной памяти
            frm.LblOccupateMemValue.DataBindings.Add(new Binding("Text", model.Ram, "OccupiedSize"));

            // настройка системы
            Binding intensityBinding = new Binding("Value", model.ModelSettings, "MaxValueOfBurstTime", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding burstMinBinding = new Binding("Value", model.ModelSettings, "MinValueOfBurstTime", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding burstMaxBinding = new Binding("Value", model.ModelSettings, "Intensity", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding addrSpaceMinBinding = new Binding("Value", model.ModelSettings, "MinValueOfAddrSpace", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding addrSpaceMaxBinding = new Binding("Value", model.ModelSettings, "MaxValueOfAddrSpace", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding maxPriorityBinding = new Binding("Value", model.ModelSettings, "MaxPriority", true, DataSourceUpdateMode.OnPropertyChanged);
            Binding ramSizeBinding = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAMSize", true, DataSourceUpdateMode.OnPropertyChanged);

            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            burstMinBinding.ControlUpdateMode = ControlUpdateMode.Never;
            burstMaxBinding.ControlUpdateMode = ControlUpdateMode.Never;
            addrSpaceMinBinding.ControlUpdateMode = ControlUpdateMode.Never;
            addrSpaceMaxBinding.ControlUpdateMode = ControlUpdateMode.Never;
            maxPriorityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;

            frm.NudIntesity.DataBindings.Add(intensityBinding);
            frm.NudBurstMin.DataBindings.Add(burstMinBinding);
            frm.NudBurstMax.DataBindings.Add(burstMaxBinding);
            frm.NudAddrSpaceMin.DataBindings.Add(addrSpaceMinBinding);
            frm.NudAddrSpaceMax.DataBindings.Add(addrSpaceMaxBinding);
            frm.NudMaxPriority.DataBindings.Add(maxPriorityBinding);
            frm.CbRamSize.DataBindings.Add(ramSizeBinding);

            Subscribe();
        }
        public override void DataUnbind()   
        {
            Unsubscribe();
            frm.LblTime.DataBindings.RemoveAt(0);
            frm.TbDevice2.DataBindings.RemoveAt(0);
            frm.TbCpu.DataBindings.RemoveAt(0);
            frm.TbDevice.DataBindings.RemoveAt(0);
            frm.LblFreeMemValue.DataBindings.RemoveAt(0);
            frm.LblOccupateMemValue.DataBindings.RemoveAt(0);
            frm.NudIntesity.DataBindings.RemoveAt(0);
            frm.NudBurstMin.DataBindings.RemoveAt(0);
            frm.NudBurstMax.DataBindings.RemoveAt(0);
            frm.NudMaxPriority.DataBindings.RemoveAt(0);
            frm.NudAddrSpaceMin.DataBindings.RemoveAt(0);
            frm.NudAddrSpaceMax.DataBindings.RemoveAt(0);
            frm.CbRamSize.DataBindings.RemoveAt(0);
        }
        private FrmDetailed frm;
        // подписчик
        /// <summary>/// Подписаться на свойство/// </summary>
        private void Subscribe()
        {
            model.PropertyChanged += PropertyChangedHandler;
        }
        /// <summary>/// Снять подписку со свойства/// </summary>
        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
        }
        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "ReadyQueue":
                    updateListBox(model.ReadyQueue, frm.LbCPUQueue);
                break;
                case "DeviceQueue":
                    updateListBox(model.DeviceQueue, frm.LbDeviceQueue);
                    break;
                case "DeviceQueue2":
                    updateListBox(model.DeviceQueue2, frm.LbDeviceQueue2);
                    break;
                default: break;
            }
        }
        private void updateListBox(IQueueable<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }
        private void objectToInt(object sender, ConvertEventArgs e)
        {
            if (e.DesiredType == typeof(int))
                e.Value = int.Parse(e.Value.ToString(), NumberStyles.Integer, null);
        }
    }
}

