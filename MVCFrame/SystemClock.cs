using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Queues;
using Structures;

namespace MVCFrame
{
    class SystemClock : INotifyPropertyChanged
    {
        long clock = 0;
        public long Clock 
        { 
            get
            { 
                return clock;
            } 
            set
            {
                clock = value;
                OnPropertyChanged();
            } 
        }
        public void WorkingCycle()
        {
            Clock++;
        }
        public void Clear()
        {
            Clock = 0;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
