using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    class IdGenerator
    {
        public long Id
        {
            get
            {
                return id == long.MaxValue ? 0 : ++id;
            }
        }
        public IdGenerator Clear()
        {
            if (this != null)
            {
                id = 0;
            }
            return this;
        }
        private long id;
    }
}
