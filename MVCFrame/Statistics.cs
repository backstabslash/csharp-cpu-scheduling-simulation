using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCFrame
{
    class Statistics
    {
        public void Save(Settings settings)
        {
            this.settings = settings;
        }
        public double CpuUtilization { get; set; }
        public double SystemPerformance { get; set; }
        public double AvgWaitingTime { get; set; }
        public double AvgTurnAroundTime { get; set; }
        public double AvgReadyQueueLength { get; set; }
        public long CommonTime { get; set; }
        public long ArivalProcessesCount { get; set; }
        public long RejectedProcessesCount { get; set; }
        public long CommonWaitingTime { get; set; }
        public long MaxReadyQueueLength { get; set; }
        public long CommonTurnAroundTime { get; set; }
        public string CpuIdleTime { get; set; }
        public double TerminatedProcessCount { get; set; }
        public int cpuFree { get; set; }
        public int maxLength { get; set; }
        public int counter { get; set; }
        public int avgWaiting { get; set; }

        private Settings settings;
        public void Clear()
        {
            CommonTime = 0;
            ArivalProcessesCount = 0;
            RejectedProcessesCount = 0;
            CommonWaitingTime = 0;
            MaxReadyQueueLength = 0;
            CommonTurnAroundTime = 0;
            CpuIdleTime = "0";
            TerminatedProcessCount = 0;
            CpuUtilization = 0;
            SystemPerformance = 0;
            AvgWaitingTime = 0;
            AvgTurnAroundTime = 0;
            AvgReadyQueueLength = 0;
            cpuFree = 0;
            maxLength = 0;
            counter = 0;
            avgWaiting = 0;
        }
    }
}

