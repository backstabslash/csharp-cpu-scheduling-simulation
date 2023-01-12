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
    public partial class FrmDetailed : Form
    {
        Model model = new Model();
        private ViewDetailed viewDetailed;
        public FrmDetailed()
        {
            InitializeComponent();
            cbRamSize.SelectedIndex = 0;
            tbCpu.ReadOnly = true;
            tbDevice.ReadOnly = true;
            tbDevice2.ReadOnly = true;
            bWorkSyc.Enabled = false;

            viewDetailed = new ViewDetailed(model, new Controller(), this);
            viewDetailed.DataBind();
        }
        bool stop;

        public Label LblTime { get { return lblTime; } }
        public Label LblFreeMemValue { get { return lblFreeMemValue; } }
        public Label LblOccupateMemValue { get { return lblOccupateMemValue; } }
        public NumericUpDown NudIntesity { get { return nudIntesity; } }
        public TextBox TbCpu { get { return tbCpu; } }
        public TextBox TbDevice { get { return tbDevice; } }
        public TextBox TbDevice2 { get { return tbDevice2; } }
        public NumericUpDown NudBurstMin { get { return nudBurstMin; } }
        public NumericUpDown NudBurstMax { get { return nudBurstMax; } }
        public NumericUpDown NudAddrSpaceMin { get { return nudAddrSpaceMin; } }
        public NumericUpDown NudAddrSpaceMax { get { return nudAddrSpaceMax; } }
        public ComboBox CbRamSize { get { return cbRamSize; } }
        public ListBox LbCPUQueue { get { return lbCPUQueue; } }
        public ListBox LbDeviceQueue { get { return lbDeviceQueue; } }
        public ListBox LbDeviceQueue2 { get { return lbDeviceQueue2; } }
        public NumericUpDown NudMaxPriority { get { return nudMaxPriority; } }

        private void tbCpu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbCPUQueue_Click(object sender, EventArgs e)
        {

        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void tbDevice_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbRamSize_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bSaveSets_Click(object sender, EventArgs e)
        {
            sessionPreparation();
            viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
        }

        private async void bWorkSyc_Click(object sender, EventArgs e)
        {
            stop = true;
            if (rbAuto.Checked)
            {
                bWorkSyc.Enabled = false;
                //rbManual.Enabled = false;
                while (rbAuto.Checked && stop)
                {
                    viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
                    await Task.Delay(TimeSpan.FromSeconds(.2));
                }
            }
            else
            {
                viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.Clear);
            lbDeviceQueue.Items.Clear();
            lbDeviceQueue2.Items.Clear();
            endOfSession();
            UpdateSettings();
        }

        private void sessionPreparation()
        {
            bSaveSets.Enabled = false;
            bClear.Enabled = true;
            if (rbManual.Checked || rbAuto.Checked)
            {
                bWorkSyc.Enabled = true;
            }
            tableLayoutPanel2.Enabled = false;
        }

        private void endOfSession()
        {
            rbAuto.Checked = false;
            rbManual.Checked = true;
            bClear.Enabled = false;
            bSaveSets.Enabled = true;
            bWorkSyc.Enabled = false;
            tableLayoutPanel2.Enabled = true;
            //rbManual.Enabled = true;
            tbCpu.Clear();
        }

        private void UpdateSettings()
        {
            nudBurstMax.Value = 0.5m;
            nudBurstMin.Value = nudBurstMin.Minimum;
            nudIntesity.Value = nudIntesity.Minimum;
            nudAddrSpaceMin.Value = nudAddrSpaceMin.Minimum;
            nudAddrSpaceMax.Value = nudAddrSpaceMax.Minimum;
            nudMaxPriority.Value = 5m;
            cbRamSize.SelectedItem = cbRamSize.Items[0];
        }

        private void lbDeviceQueue_SelectedIndexChanged(object sender, EventArgs e) {}

        private void bStat_Click(object sender, EventArgs e)
        {
            bWorkSyc.Enabled = true;
            stop = false;
            //rbManual.Enabled = true;
            FrmStatistics frmStatistics = new FrmStatistics(model);
            frmStatistics.Show();
        }

        private void nudBurstMin_ValueChanged(object sender, EventArgs e) {}

        private void tbDevice2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbDeviceQueue2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (bWorkSyc.Enabled == false && bSaveSets.Enabled == false)
            {
                bWorkSyc.Enabled = true;
            }
        }

        private void rbAuto_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
