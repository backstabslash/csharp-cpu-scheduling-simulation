
namespace MVCFrame
{
    partial class FrmDetailed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTime = new System.Windows.Forms.Label();
            this.tbCpu = new System.Windows.Forms.TextBox();
            this.tbDevice = new System.Windows.Forms.TextBox();
            this.lblFreeMemValue = new System.Windows.Forms.Label();
            this.lblOccupateMemValue = new System.Windows.Forms.Label();
            this.nudIntesity = new System.Windows.Forms.NumericUpDown();
            this.nudBurstMin = new System.Windows.Forms.NumericUpDown();
            this.nudBurstMax = new System.Windows.Forms.NumericUpDown();
            this.lblDeviceQueue = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.cbRamSize = new System.Windows.Forms.ComboBox();
            this.nudAddrSpaceMin = new System.Windows.Forms.NumericUpDown();
            this.nudAddrSpaceMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nudMaxPriority = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbDeviceQueue = new System.Windows.Forms.ListBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbCPUQueue = new System.Windows.Forms.ListBox();
            this.lbDeviceQueue2 = new System.Windows.Forms.ListBox();
            this.tbDevice2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.bWorkSyc = new System.Windows.Forms.Button();
            this.bClear = new System.Windows.Forms.Button();
            this.bStat = new System.Windows.Forms.Button();
            this.bSaveSets = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMode = new System.Windows.Forms.Label();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.rbManual = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudIntesity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPriority)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(24, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(35, 13);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "label1";
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
            // 
            // tbCpu
            // 
            this.tbCpu.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCpu.Location = new System.Drawing.Point(3, 22);
            this.tbCpu.Name = "tbCpu";
            this.tbCpu.Size = new System.Drawing.Size(292, 20);
            this.tbCpu.TabIndex = 1;
            this.tbCpu.TextChanged += new System.EventHandler(this.tbCpu_TextChanged);
            // 
            // tbDevice
            // 
            this.tbDevice.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDevice.Location = new System.Drawing.Point(301, 22);
            this.tbDevice.Name = "tbDevice";
            this.tbDevice.Size = new System.Drawing.Size(289, 20);
            this.tbDevice.TabIndex = 2;
            this.tbDevice.TextChanged += new System.EventHandler(this.tbDevice_TextChanged);
            // 
            // lblFreeMemValue
            // 
            this.lblFreeMemValue.AutoSize = true;
            this.lblFreeMemValue.Location = new System.Drawing.Point(227, 0);
            this.lblFreeMemValue.Name = "lblFreeMemValue";
            this.lblFreeMemValue.Size = new System.Drawing.Size(35, 13);
            this.lblFreeMemValue.TabIndex = 3;
            this.lblFreeMemValue.Text = "label1";
            // 
            // lblOccupateMemValue
            // 
            this.lblOccupateMemValue.AutoSize = true;
            this.lblOccupateMemValue.Location = new System.Drawing.Point(227, 0);
            this.lblOccupateMemValue.Name = "lblOccupateMemValue";
            this.lblOccupateMemValue.Size = new System.Drawing.Size(35, 13);
            this.lblOccupateMemValue.TabIndex = 4;
            this.lblOccupateMemValue.Text = "label2";
            // 
            // nudIntesity
            // 
            this.nudIntesity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudIntesity.Location = new System.Drawing.Point(239, 76);
            this.nudIntesity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudIntesity.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudIntesity.Name = "nudIntesity";
            this.nudIntesity.Size = new System.Drawing.Size(123, 20);
            this.nudIntesity.TabIndex = 5;
            this.nudIntesity.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nudBurstMin
            // 
            this.nudBurstMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMin.Location = new System.Drawing.Point(118, 76);
            this.nudBurstMin.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudBurstMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBurstMin.Name = "nudBurstMin";
            this.nudBurstMin.Size = new System.Drawing.Size(115, 20);
            this.nudBurstMin.TabIndex = 6;
            this.nudBurstMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBurstMin.ValueChanged += new System.EventHandler(this.nudBurstMin_ValueChanged);
            // 
            // nudBurstMax
            // 
            this.nudBurstMax.DecimalPlaces = 1;
            this.nudBurstMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudBurstMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBurstMax.Location = new System.Drawing.Point(3, 76);
            this.nudBurstMax.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBurstMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBurstMax.Name = "nudBurstMax";
            this.nudBurstMax.Size = new System.Drawing.Size(109, 20);
            this.nudBurstMax.TabIndex = 7;
            this.nudBurstMax.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // lblDeviceQueue
            // 
            this.lblDeviceQueue.AutoSize = true;
            this.lblDeviceQueue.Location = new System.Drawing.Point(301, 0);
            this.lblDeviceQueue.Name = "lblDeviceQueue";
            this.lblDeviceQueue.Size = new System.Drawing.Size(121, 13);
            this.lblDeviceQueue.TabIndex = 12;
            this.lblDeviceQueue.Text = "Внешнее устройство 1";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.73949F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.26051F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 128F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.Controls.Add(this.label11, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudIntesity, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudBurstMin, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudBurstMax, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbRamSize, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudAddrSpaceMin, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.nudAddrSpaceMax, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label7, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.nudMaxPriority, 6, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(910, 111);
            this.tableLayoutPanel2.TabIndex = 10;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label11.Location = new System.Drawing.Point(782, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 26);
            this.label11.TabIndex = 23;
            this.label11.Text = "Максимальный приоритет";
            // 
            // cbRamSize
            // 
            this.cbRamSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbRamSize.FormattingEnabled = true;
            this.cbRamSize.Items.AddRange(new object[] {
            "32000",
            "64000"});
            this.cbRamSize.Location = new System.Drawing.Point(368, 76);
            this.cbRamSize.Name = "cbRamSize";
            this.cbRamSize.Size = new System.Drawing.Size(122, 21);
            this.cbRamSize.TabIndex = 10;
            this.cbRamSize.SelectedIndexChanged += new System.EventHandler(this.cbRamSize_SelectedIndexChanged);
            // 
            // nudAddrSpaceMin
            // 
            this.nudAddrSpaceMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMin.Location = new System.Drawing.Point(496, 76);
            this.nudAddrSpaceMin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAddrSpaceMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAddrSpaceMin.Name = "nudAddrSpaceMin";
            this.nudAddrSpaceMin.Size = new System.Drawing.Size(134, 20);
            this.nudAddrSpaceMin.TabIndex = 13;
            this.nudAddrSpaceMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAddrSpaceMax
            // 
            this.nudAddrSpaceMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudAddrSpaceMax.Location = new System.Drawing.Point(636, 76);
            this.nudAddrSpaceMax.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudAddrSpaceMax.Name = "nudAddrSpaceMax";
            this.nudAddrSpaceMax.Size = new System.Drawing.Size(140, 20);
            this.nudAddrSpaceMax.TabIndex = 14;
            this.nudAddrSpaceMax.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 39);
            this.label4.TabIndex = 15;
            this.label4.Text = "Интенсивность поступления процессов";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(118, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 52);
            this.label5.TabIndex = 16;
            this.label5.Text = "Минимальное значение промежутка работы на ЦП";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label6.Location = new System.Drawing.Point(239, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 39);
            this.label6.TabIndex = 17;
            this.label6.Text = "Максимальное значение промежутка на ЦП";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label8.Location = new System.Drawing.Point(636, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 26);
            this.label8.TabIndex = 19;
            this.label8.Text = "Максимальный размер адресного пространства";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label9.Location = new System.Drawing.Point(368, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 26);
            this.label9.TabIndex = 20;
            this.label9.Text = "Размер оперивной памяти";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(496, 47);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 26);
            this.label7.TabIndex = 18;
            this.label7.Text = "Минимальный размер адресного пространства";
            // 
            // nudMaxPriority
            // 
            this.nudMaxPriority.Location = new System.Drawing.Point(782, 76);
            this.nudMaxPriority.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudMaxPriority.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudMaxPriority.Name = "nudMaxPriority";
            this.nudMaxPriority.Size = new System.Drawing.Size(123, 20);
            this.nudMaxPriority.TabIndex = 22;
            this.nudMaxPriority.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.26551F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73449F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 560);
            this.tableLayoutPanel1.TabIndex = 13;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint_1);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.21978F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.78022F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.tableLayoutPanel3.Controls.Add(this.lblDeviceQueue, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbDeviceQueue, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lb1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lbCPUQueue, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbCpu, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tbDevice, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbDeviceQueue2, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.tbDevice2, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 129);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 202F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(910, 271);
            this.tableLayoutPanel3.TabIndex = 11;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // lbDeviceQueue
            // 
            this.lbDeviceQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDeviceQueue.FormattingEnabled = true;
            this.lbDeviceQueue.Location = new System.Drawing.Point(301, 43);
            this.lbDeviceQueue.Name = "lbDeviceQueue";
            this.lbDeviceQueue.Size = new System.Drawing.Size(289, 196);
            this.lbDeviceQueue.TabIndex = 13;
            this.lbDeviceQueue.SelectedIndexChanged += new System.EventHandler(this.lbDeviceQueue_SelectedIndexChanged);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(3, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(133, 13);
            this.lb1.TabIndex = 3;
            this.lb1.Text = "Центральный процессор";
            // 
            // lbCPUQueue
            // 
            this.lbCPUQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCPUQueue.FormattingEnabled = true;
            this.lbCPUQueue.Location = new System.Drawing.Point(3, 43);
            this.lbCPUQueue.Name = "lbCPUQueue";
            this.lbCPUQueue.Size = new System.Drawing.Size(292, 196);
            this.lbCPUQueue.TabIndex = 12;
            // 
            // lbDeviceQueue2
            // 
            this.lbDeviceQueue2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDeviceQueue2.FormattingEnabled = true;
            this.lbDeviceQueue2.Location = new System.Drawing.Point(596, 43);
            this.lbDeviceQueue2.Name = "lbDeviceQueue2";
            this.lbDeviceQueue2.Size = new System.Drawing.Size(311, 196);
            this.lbDeviceQueue2.TabIndex = 14;
            this.lbDeviceQueue2.SelectedIndexChanged += new System.EventHandler(this.lbDeviceQueue2_SelectedIndexChanged);
            // 
            // tbDevice2
            // 
            this.tbDevice2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDevice2.Location = new System.Drawing.Point(596, 22);
            this.tbDevice2.Name = "tbDevice2";
            this.tbDevice2.Size = new System.Drawing.Size(311, 20);
            this.tbDevice2.TabIndex = 15;
            this.tbDevice2.TextChanged += new System.EventHandler(this.tbDevice2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(596, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Внешнее устройство 2";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 406);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.65306F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.34694F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(910, 41);
            this.tableLayoutPanel4.TabIndex = 12;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lblFreeMemValue, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(449, 22);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Размер свободной памяти:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.lblOccupateMemValue, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(458, 16);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(449, 22);
            this.tableLayoutPanel6.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Размер памяти, занятой процессами";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = " Оперативная память";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 453);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(910, 104);
            this.panel1.TabIndex = 13;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 6;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.09711F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.90289F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel7.Controls.Add(this.lblTime, 0, 0);
            this.tableLayoutPanel7.Controls.Add(this.bWorkSyc, 3, 0);
            this.tableLayoutPanel7.Controls.Add(this.bClear, 4, 0);
            this.tableLayoutPanel7.Controls.Add(this.bStat, 5, 0);
            this.tableLayoutPanel7.Controls.Add(this.bSaveSets, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(910, 104);
            this.tableLayoutPanel7.TabIndex = 4;
            // 
            // bWorkSyc
            // 
            this.bWorkSyc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bWorkSyc.Location = new System.Drawing.Point(517, 3);
            this.bWorkSyc.Name = "bWorkSyc";
            this.bWorkSyc.Size = new System.Drawing.Size(110, 56);
            this.bWorkSyc.TabIndex = 2;
            this.bWorkSyc.Text = "Рабочий такт";
            this.bWorkSyc.UseVisualStyleBackColor = true;
            this.bWorkSyc.Click += new System.EventHandler(this.bWorkSyc_Click);
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.Location = new System.Drawing.Point(649, 3);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(110, 56);
            this.bClear.TabIndex = 3;
            this.bClear.Text = "Очистка";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // bStat
            // 
            this.bStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bStat.Location = new System.Drawing.Point(800, 3);
            this.bStat.Name = "bStat";
            this.bStat.Size = new System.Drawing.Size(107, 56);
            this.bStat.TabIndex = 5;
            this.bStat.Text = "Статистика";
            this.bStat.UseVisualStyleBackColor = true;
            this.bStat.Click += new System.EventHandler(this.bStat_Click);
            // 
            // bSaveSets
            // 
            this.bSaveSets.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSaveSets.Location = new System.Drawing.Point(381, 3);
            this.bSaveSets.Name = "bSaveSets";
            this.bSaveSets.Size = new System.Drawing.Size(114, 56);
            this.bSaveSets.TabIndex = 1;
            this.bSaveSets.Text = "Сохранение настроек";
            this.bSaveSets.UseVisualStyleBackColor = true;
            this.bSaveSets.Click += new System.EventHandler(this.bSaveSets_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMode);
            this.panel2.Controls.Add(this.rbAuto);
            this.panel2.Controls.Add(this.rbManual);
            this.panel2.Location = new System.Drawing.Point(87, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 98);
            this.panel2.TabIndex = 6;
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Location = new System.Drawing.Point(13, 10);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(82, 13);
            this.lbMode.TabIndex = 2;
            this.lbMode.Text = "Режим работы";
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(128, 42);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(109, 17);
            this.rbAuto.TabIndex = 1;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Автоматический";
            this.rbAuto.UseVisualStyleBackColor = true;
            this.rbAuto.CheckedChanged += new System.EventHandler(this.rbAuto_CheckedChanged);
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Checked = true;
            this.rbManual.Location = new System.Drawing.Point(16, 40);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 0;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Ручной";
            this.rbManual.UseVisualStyleBackColor = true;
            this.rbManual.CheckedChanged += new System.EventHandler(this.rbManual_CheckedChanged);
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 560);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmDetailed";
            this.Text = "FrmDetailed";
            ((System.ComponentModel.ISupportInitialize)(this.nudIntesity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBurstMax)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAddrSpaceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxPriority)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox tbCpu;
        private System.Windows.Forms.TextBox tbDevice;
        private System.Windows.Forms.Label lblFreeMemValue;
        private System.Windows.Forms.Label lblOccupateMemValue;
        private System.Windows.Forms.NumericUpDown nudIntesity;
        private System.Windows.Forms.NumericUpDown nudBurstMin;
        private System.Windows.Forms.NumericUpDown nudBurstMax;
        private System.Windows.Forms.Label lblDeviceQueue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown nudAddrSpaceMin;
        private System.Windows.Forms.NumericUpDown nudAddrSpaceMax;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.ListBox lbCPUQueue;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bWorkSyc;
        private System.Windows.Forms.Button bSaveSets;
        private System.Windows.Forms.ComboBox cbRamSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button bStat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbDeviceQueue;
        private System.Windows.Forms.ListBox lbDeviceQueue2;
        private System.Windows.Forms.TextBox tbDevice2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudMaxPriority;
    }
}