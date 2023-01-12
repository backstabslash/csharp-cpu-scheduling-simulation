using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVCFrame
{
     partial class FrmStatistics : Form
    {
       
        private ViewStatistics viewStatistics;

        public FrmStatistics(Model model)
        {
            InitializeComponent();
            viewStatistics = new ViewStatistics(model, new Controller(), this);
            viewStatistics.DataBind();
        }
        public Label LblCommonTime { get { return lblCommonTime; } }
        public Label LblArivalProcessesCount { get { return lblArrivalProcessesCount; } }
        public Label LblRejectedProcessesCount { get { return lblRejectedProcessesCount; } }
        public Label LblCommonWaitingTime { get { return lblCommonWaitingTime; } }
        public Label LblMaxReadyQueueLength { get { return lblMaxReadyQueueLength; } }
        public Label LblCommonTurnAroundTime { get { return lblCommonTurnAroundTime; } }
        public Label LblCpuIdleTime { get { return lblCpuIdleTime; } }
        public Label LblTerminatedProcessCount { get { return lblTerminatedProcessesCount; } }
        public Label LblCpuUtilization { get { return lblCpuUtilization; } }
        public Label LblSystemPerformance { get { return lblSystemPerformance; } }
        public Label LblAvgWaitingTime { get { return lblAvgWaitingTime; } }
        public Label LblAvgTurnAroundTime { get { return lblAvgTurnAroundTime;} }
        public Label LblAvgReadyQueueLength { get { return lblAvgReadyQueueLength; } }
        private void lblCpuUtilization_Paint(object sender, PaintEventArgs e) {}
    }
}
