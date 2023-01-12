using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    class MemoryManager
    {
       Memory memory;
       public Memory Allocate(long size)
        {
            if (size <= memory.FreeSize)
            {
                memory.OccupiedSize += size;
                return memory;
            }
            return null;
        }
        public Memory Free(long size)
        {
            memory.OccupiedSize -= size;
            return memory;
        }
        public void Save(Memory memory)
        {
            this.memory = memory;
        } 
    }
}
