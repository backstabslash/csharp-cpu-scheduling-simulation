using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Queues;

namespace MVCFrame
{
    class DeviceScheduler
    {
        Resource resource;
        IQueueable<Process> queue;
        public DeviceScheduler(Resource resource, IQueueable<Process> queue)
        {
            this.resource = resource;
            this.queue = queue;
        }
        public IQueueable<Process> Session()
        {
            if (queue.Count != 0)
            {
                Process newActiveProcess = queue.Item();
                queue.Remove();
                resource.ActiveProcess = newActiveProcess;
            }
            else
                resource.ActiveProcess = null;
            return queue;
        }
    }
}
