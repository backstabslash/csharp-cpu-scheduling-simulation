using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    class Settings
    {
        public double Intensity { get; set; }
        public int MinValueOfBurstTime { get; set; }
        public int MaxValueOfBurstTime { get; set; }
        public int MinValueOfAddrSpace { get; set; }
        public int MaxValueOfAddrSpace { get; set; }
        public int ValueOfRAMSize { get; set; }
        public int MaxPriority { get; set; }
        public void Save(int ramsize1)
        {
            ValueOfRAMSize = ramsize1;
        }
        public void Clear()
        {
            Intensity = 0;
            MinValueOfBurstTime = 0;
            MaxValueOfBurstTime = 0;
        }
    }
}
