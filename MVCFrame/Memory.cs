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
    class Memory : INotifyPropertyChanged
    {
        long occupiedSize;
        public long OccupiedSize {
            get
            {
                return occupiedSize;
            }
            set
            {
                occupiedSize = value;
                FreeSize = Size - occupiedSize;
                OnPropertyChanged();
            }
        }
        public long Size { 
            get; 
            private set; 
        }
        public long FreeSize
        {
            get {return Size - occupiedSize; }
            private set { }
        }
        public Memory Save(long size)
        {
            this.Size = size;
            occupiedSize = 0;
            return this;
        }
        public Memory Clear()
        {
            occupiedSize = 0;
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
