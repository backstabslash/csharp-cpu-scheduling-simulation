using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVCFrame
{
    class Resource : INotifyPropertyChanged
    {
        Process activeProcess;
        public Process ActiveProcess
        {
            get
            {
                return activeProcess;
            }
            set
            {
                activeProcess = value;
                OnPropertyChanged();
            }
        }
        public void WorkingCycle()
        {
            if (!Free())
            {
                activeProcess.IncreaseWorkTime();
            }
        }
        public bool Free()
        {
            return activeProcess == null;
        }
        public Resource Clear()
        {
            activeProcess = null;
            return this;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
