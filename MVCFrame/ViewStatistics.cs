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
    class ViewStatistics : View
    {
        private FrmStatistics frmStatistics;
        Model model1 = new Model();

        public ViewStatistics(Model model, Controller controller, FrmStatistics frmStatistics)
            :base(model, controller)
        {
            this.model1 = model;
            this.frmStatistics = frmStatistics;
        }
        public override void DataBind()
        {
            frmStatistics.LblCommonTime.DataBindings.Add(new Binding("Text",model.Statistics, "CommonTime"));
            frmStatistics.LblArivalProcessesCount.DataBindings.Add(new Binding("Text", model.Statistics, "ArivalProcessesCount"));
            frmStatistics.LblRejectedProcessesCount.DataBindings.Add(new Binding("Text", model.Statistics, "RejectedProcessesCount"));
            frmStatistics.LblCommonWaitingTime.DataBindings.Add(new Binding("Text", model.Statistics, "CommonWaitingTime"));
            frmStatistics.LblMaxReadyQueueLength.DataBindings.Add(new Binding("Text", model.Statistics, "MaxReadyQueueLength"));
            frmStatistics.LblCommonTurnAroundTime.DataBindings.Add(new Binding("Text", model.Statistics, "CommonTurnAroundTime"));
            frmStatistics.LblCpuIdleTime.DataBindings.Add(new Binding("Text", model.Statistics, "CpuIdleTime"));
            frmStatistics.LblTerminatedProcessCount.DataBindings.Add(new Binding("Text", model.Statistics, "TerminatedProcessCount"));
            frmStatistics.LblCpuUtilization.DataBindings.Add(new Binding("Text", model.Statistics, "CpuUtilization", true, DataSourceUpdateMode.OnPropertyChanged, null, "0.####"));
            frmStatistics.LblSystemPerformance.DataBindings.Add(new Binding("Text", model.Statistics, "SystemPerformance", true, DataSourceUpdateMode.OnPropertyChanged, null, "0.####"));
            frmStatistics.LblAvgWaitingTime.DataBindings.Add(new Binding("Text", model.Statistics, "AvgWaitingTime", true, DataSourceUpdateMode.OnPropertyChanged, null, "##.####"));
            frmStatistics.LblAvgTurnAroundTime.DataBindings.Add(new Binding("Text", model.Statistics, "AvgTurnAroundTime", true, DataSourceUpdateMode.OnPropertyChanged, null, "##.####"));
            frmStatistics.LblAvgReadyQueueLength.DataBindings.Add(new Binding("Text", model.Statistics, "AvgReadyQueueLength"));
        }
        public override void DataUnbind()
        {
            frmStatistics.LblCommonTime.DataBindings.RemoveAt(0);
            frmStatistics.LblArivalProcessesCount.DataBindings.RemoveAt(0);
            frmStatistics.LblRejectedProcessesCount.DataBindings.RemoveAt(0);
            frmStatistics.LblCommonWaitingTime.DataBindings.RemoveAt(0);
            frmStatistics.LblMaxReadyQueueLength.DataBindings.RemoveAt(0);
            frmStatistics.LblCommonTurnAroundTime.DataBindings.RemoveAt(0);
            frmStatistics.LblCpuIdleTime.DataBindings.RemoveAt(0);
            frmStatistics.LblTerminatedProcessCount.DataBindings.RemoveAt(0);
            frmStatistics.LblCpuUtilization.DataBindings.RemoveAt(0);
            frmStatistics.LblSystemPerformance.DataBindings.RemoveAt(0);
            frmStatistics.LblAvgWaitingTime.DataBindings.RemoveAt(0);
            frmStatistics.LblAvgTurnAroundTime.DataBindings.RemoveAt(0);
            frmStatistics.LblAvgReadyQueueLength.DataBindings.RemoveAt(0);
        }
    }
}
