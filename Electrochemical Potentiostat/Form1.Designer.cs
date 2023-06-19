namespace Electrochemical_Potentiostat
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCV = new System.Windows.Forms.TabPage();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CVzedGraphControl = new ZedGraph.ZedGraphControl();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CVlistView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CVradioBtn6th = new System.Windows.Forms.RadioButton();
            this.CVradioBtn5th = new System.Windows.Forms.RadioButton();
            this.CVradioBtn4th = new System.Windows.Forms.RadioButton();
            this.CVradioBtn3rd = new System.Windows.Forms.RadioButton();
            this.CVradioBtn2nd = new System.Windows.Forms.RadioButton();
            this.CVradioBtn1st = new System.Windows.Forms.RadioButton();
            this.CVradioBtnShowAllSweeps = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CVnumericStartVolt = new System.Windows.Forms.NumericUpDown();
            this.CVnumericEndVolt = new System.Windows.Forms.NumericUpDown();
            this.CVnumericStep = new System.Windows.Forms.NumericUpDown();
            this.CVnumericRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CVprogressBar = new System.Windows.Forms.ProgressBar();
            this.CVbtnExport = new System.Windows.Forms.Button();
            this.CVbtnImport = new System.Windows.Forms.Button();
            this.CVbtnClearAll = new System.Windows.Forms.Button();
            this.CVbtnMeasure = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CVstatusCOM = new System.Windows.Forms.ProgressBar();
            this.CVbtnDisconnect = new System.Windows.Forms.Button();
            this.CVbtnConnect = new System.Windows.Forms.Button();
            this.CVselectPort = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabEIS = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.EISzedGraphControl = new ZedGraph.ZedGraphControl();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.EISlistView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxShowSweepTimes = new System.Windows.Forms.GroupBox();
            this.EISradioBtn6th = new System.Windows.Forms.RadioButton();
            this.EISradioBtn5th = new System.Windows.Forms.RadioButton();
            this.EISradioBtn4th = new System.Windows.Forms.RadioButton();
            this.EISradioBtn3rd = new System.Windows.Forms.RadioButton();
            this.EISradioBtn2nd = new System.Windows.Forms.RadioButton();
            this.EISradioBtn1st = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.EIScheckBoxLog = new System.Windows.Forms.CheckBox();
            this.EISnumericStartFreq = new System.Windows.Forms.NumericUpDown();
            this.EIScheckBoxSweepEn = new System.Windows.Forms.CheckBox();
            this.EISnumericStopFreq = new System.Windows.Forms.NumericUpDown();
            this.EISnumericSweepPoints = new System.Windows.Forms.NumericUpDown();
            this.EISnumericRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.EISprogressBar = new System.Windows.Forms.ProgressBar();
            this.EISbtnExport = new System.Windows.Forms.Button();
            this.EISbtnImport = new System.Windows.Forms.Button();
            this.EISbtnClearAll = new System.Windows.Forms.Button();
            this.EISbtnMeasure = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.EISstatusCOM = new System.Windows.Forms.ProgressBar();
            this.EISbtnDisconnect = new System.Windows.Forms.Button();
            this.EISbtnConnect = new System.Windows.Forms.Button();
            this.EISselectPort = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabCVEIS = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.cbVoltage2 = new System.Windows.Forms.CheckBox();
            this.tbVoltage2 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbVoltage1 = new System.Windows.Forms.CheckBox();
            this.tbVoltage1 = new System.Windows.Forms.TextBox();
            this.btnExtraAdd = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.bntExtraSub = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.statusCOM = new System.Windows.Forms.ProgressBar();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.selectPort = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabCV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStartVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericEndVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericRepeatTimes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabEIS.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxShowSweepTimes.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStartFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStopFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericSweepPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericRepeatTimes)).BeginInit();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabCVEIS.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCV);
            this.tabControl1.Controls.Add(this.tabEIS);
            this.tabControl1.Controls.Add(this.tabCVEIS);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1079, 666);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabCV
            // 
            this.tabCV.BackColor = System.Drawing.Color.LightCyan;
            this.tabCV.Controls.Add(this.vScrollBar1);
            this.tabCV.Controls.Add(this.label1);
            this.tabCV.Controls.Add(this.pictureBox2);
            this.tabCV.Controls.Add(this.pictureBox1);
            this.tabCV.Controls.Add(this.CVzedGraphControl);
            this.tabCV.Controls.Add(this.label8);
            this.tabCV.Controls.Add(this.groupBox6);
            this.tabCV.Controls.Add(this.groupBox5);
            this.tabCV.Controls.Add(this.groupBox4);
            this.tabCV.Controls.Add(this.groupBox3);
            this.tabCV.Controls.Add(this.groupBox1);
            this.tabCV.Location = new System.Drawing.Point(4, 22);
            this.tabCV.Name = "tabCV";
            this.tabCV.Padding = new System.Windows.Forms.Padding(3);
            this.tabCV.Size = new System.Drawing.Size(1071, 640);
            this.tabCV.TabIndex = 0;
            this.tabCV.Text = "Cyclic Voltammetry";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(8, 8);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 11;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cyclic Voltammetry";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Electrochemical_Potentiostat.Properties.Resources.Logo_ĐH_Công_Nghệ_UET;
            this.pictureBox2.Location = new System.Drawing.Point(943, 6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Electrochemical_Potentiostat.Properties.Resources.Logo_ĐH_Quốc_Gia_Hà_Nội_VNU;
            this.pictureBox1.Location = new System.Drawing.Point(857, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // CVzedGraphControl
            // 
            this.CVzedGraphControl.Location = new System.Drawing.Point(191, 84);
            this.CVzedGraphControl.Margin = new System.Windows.Forms.Padding(4);
            this.CVzedGraphControl.Name = "CVzedGraphControl";
            this.CVzedGraphControl.ScrollGrace = 0D;
            this.CVzedGraphControl.ScrollMaxX = 0D;
            this.CVzedGraphControl.ScrollMaxY = 0D;
            this.CVzedGraphControl.ScrollMaxY2 = 0D;
            this.CVzedGraphControl.ScrollMinX = 0D;
            this.CVzedGraphControl.ScrollMinY = 0D;
            this.CVzedGraphControl.ScrollMinY2 = 0D;
            this.CVzedGraphControl.Size = new System.Drawing.Size(655, 479);
            this.CVzedGraphControl.TabIndex = 7;
            this.CVzedGraphControl.UseExtendedPrintDialog = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Design by MEMs - UET";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CVlistView);
            this.groupBox6.Location = new System.Drawing.Point(852, 95);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(177, 468);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "List Result Values";
            // 
            // CVlistView
            // 
            this.CVlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.CVlistView.GridLines = true;
            this.CVlistView.HideSelection = false;
            this.CVlistView.Location = new System.Drawing.Point(6, 19);
            this.CVlistView.Name = "CVlistView";
            this.CVlistView.Size = new System.Drawing.Size(165, 443);
            this.CVlistView.TabIndex = 0;
            this.CVlistView.UseCompatibleStateImageBehavior = false;
            this.CVlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Voltage (mV)";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Current (uA)";
            this.columnHeader2.Width = 80;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CVradioBtn6th);
            this.groupBox5.Controls.Add(this.CVradioBtn5th);
            this.groupBox5.Controls.Add(this.CVradioBtn4th);
            this.groupBox5.Controls.Add(this.CVradioBtn3rd);
            this.groupBox5.Controls.Add(this.CVradioBtn2nd);
            this.groupBox5.Controls.Add(this.CVradioBtn1st);
            this.groupBox5.Controls.Add(this.CVradioBtnShowAllSweeps);
            this.groupBox5.Location = new System.Drawing.Point(8, 428);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(177, 110);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Show sweep times";
            // 
            // CVradioBtn6th
            // 
            this.CVradioBtn6th.AutoSize = true;
            this.CVradioBtn6th.Location = new System.Drawing.Point(122, 71);
            this.CVradioBtn6th.Name = "CVradioBtn6th";
            this.CVradioBtn6th.Size = new System.Drawing.Size(40, 17);
            this.CVradioBtn6th.TabIndex = 6;
            this.CVradioBtn6th.Text = "6th";
            this.CVradioBtn6th.UseVisualStyleBackColor = true;
            this.CVradioBtn6th.Click += new System.EventHandler(this.CVradioBtnShowAllSweeps_Click);
            // 
            // CVradioBtn5th
            // 
            this.CVradioBtn5th.AutoSize = true;
            this.CVradioBtn5th.Location = new System.Drawing.Point(64, 71);
            this.CVradioBtn5th.Name = "CVradioBtn5th";
            this.CVradioBtn5th.Size = new System.Drawing.Size(40, 17);
            this.CVradioBtn5th.TabIndex = 5;
            this.CVradioBtn5th.Text = "5th";
            this.CVradioBtn5th.UseVisualStyleBackColor = true;
            this.CVradioBtn5th.Click += new System.EventHandler(this.CVradioBtnShowAllSweeps_Click);
            // 
            // CVradioBtn4th
            // 
            this.CVradioBtn4th.AutoSize = true;
            this.CVradioBtn4th.Location = new System.Drawing.Point(10, 71);
            this.CVradioBtn4th.Name = "CVradioBtn4th";
            this.CVradioBtn4th.Size = new System.Drawing.Size(40, 17);
            this.CVradioBtn4th.TabIndex = 4;
            this.CVradioBtn4th.Text = "4th";
            this.CVradioBtn4th.UseVisualStyleBackColor = true;
            this.CVradioBtn4th.Click += new System.EventHandler(this.CVradioBtnShowAllSweeps_Click);
            // 
            // CVradioBtn3rd
            // 
            this.CVradioBtn3rd.AutoSize = true;
            this.CVradioBtn3rd.Location = new System.Drawing.Point(122, 45);
            this.CVradioBtn3rd.Name = "CVradioBtn3rd";
            this.CVradioBtn3rd.Size = new System.Drawing.Size(40, 17);
            this.CVradioBtn3rd.TabIndex = 3;
            this.CVradioBtn3rd.Text = "3rd";
            this.CVradioBtn3rd.UseVisualStyleBackColor = true;
            this.CVradioBtn3rd.Click += new System.EventHandler(this.CVradioBtnShowAllSweeps_Click);
            // 
            // CVradioBtn2nd
            // 
            this.CVradioBtn2nd.AutoSize = true;
            this.CVradioBtn2nd.Location = new System.Drawing.Point(64, 45);
            this.CVradioBtn2nd.Name = "CVradioBtn2nd";
            this.CVradioBtn2nd.Size = new System.Drawing.Size(43, 17);
            this.CVradioBtn2nd.TabIndex = 2;
            this.CVradioBtn2nd.Text = "2nd";
            this.CVradioBtn2nd.UseVisualStyleBackColor = true;
            this.CVradioBtn2nd.Click += new System.EventHandler(this.CVradioBtnShowAllSweeps_Click);
            // 
            // CVradioBtn1st
            // 
            this.CVradioBtn1st.AutoSize = true;
            this.CVradioBtn1st.Location = new System.Drawing.Point(10, 45);
            this.CVradioBtn1st.Name = "CVradioBtn1st";
            this.CVradioBtn1st.Size = new System.Drawing.Size(39, 17);
            this.CVradioBtn1st.TabIndex = 1;
            this.CVradioBtn1st.Text = "1st";
            this.CVradioBtn1st.UseVisualStyleBackColor = true;
            this.CVradioBtn1st.Click += new System.EventHandler(this.CVradioBtnShowAllSweeps_Click);
            // 
            // CVradioBtnShowAllSweeps
            // 
            this.CVradioBtnShowAllSweeps.AutoSize = true;
            this.CVradioBtnShowAllSweeps.Checked = true;
            this.CVradioBtnShowAllSweeps.Location = new System.Drawing.Point(10, 19);
            this.CVradioBtnShowAllSweeps.Name = "CVradioBtnShowAllSweeps";
            this.CVradioBtnShowAllSweeps.Size = new System.Drawing.Size(104, 17);
            this.CVradioBtnShowAllSweeps.TabIndex = 0;
            this.CVradioBtnShowAllSweeps.TabStop = true;
            this.CVradioBtnShowAllSweeps.Text = "Show all sweeps";
            this.CVradioBtnShowAllSweeps.UseVisualStyleBackColor = true;
            this.CVradioBtnShowAllSweeps.Click += new System.EventHandler(this.CVradioBtnShowAllSweeps_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CVnumericStartVolt);
            this.groupBox4.Controls.Add(this.CVnumericEndVolt);
            this.groupBox4.Controls.Add(this.CVnumericStep);
            this.groupBox4.Controls.Add(this.CVnumericRepeatTimes);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(8, 289);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(177, 130);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parameter config";
            // 
            // CVnumericStartVolt
            // 
            this.CVnumericStartVolt.Location = new System.Drawing.Point(100, 20);
            this.CVnumericStartVolt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.CVnumericStartVolt.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.CVnumericStartVolt.Name = "CVnumericStartVolt";
            this.CVnumericStartVolt.Size = new System.Drawing.Size(70, 20);
            this.CVnumericStartVolt.TabIndex = 9;
            this.CVnumericStartVolt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CVnumericStartVolt.Value = new decimal(new int[] {
            500,
            0,
            0,
            -2147483648});
            // 
            // CVnumericEndVolt
            // 
            this.CVnumericEndVolt.Location = new System.Drawing.Point(100, 46);
            this.CVnumericEndVolt.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.CVnumericEndVolt.Minimum = new decimal(new int[] {
            5000,
            0,
            0,
            -2147483648});
            this.CVnumericEndVolt.Name = "CVnumericEndVolt";
            this.CVnumericEndVolt.Size = new System.Drawing.Size(70, 20);
            this.CVnumericEndVolt.TabIndex = 8;
            this.CVnumericEndVolt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CVnumericEndVolt.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // CVnumericStep
            // 
            this.CVnumericStep.Location = new System.Drawing.Point(100, 72);
            this.CVnumericStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.CVnumericStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CVnumericStep.Name = "CVnumericStep";
            this.CVnumericStep.Size = new System.Drawing.Size(70, 20);
            this.CVnumericStep.TabIndex = 7;
            this.CVnumericStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CVnumericStep.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // CVnumericRepeatTimes
            // 
            this.CVnumericRepeatTimes.Location = new System.Drawing.Point(100, 98);
            this.CVnumericRepeatTimes.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.CVnumericRepeatTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CVnumericRepeatTimes.Name = "CVnumericRepeatTimes";
            this.CVnumericRepeatTimes.Size = new System.Drawing.Size(70, 20);
            this.CVnumericRepeatTimes.TabIndex = 4;
            this.CVnumericRepeatTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CVnumericRepeatTimes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Repeat Times";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Step (mV)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "End Voltage (mV)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Start Voltage (mV)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CVprogressBar);
            this.groupBox3.Controls.Add(this.CVbtnExport);
            this.groupBox3.Controls.Add(this.CVbtnImport);
            this.groupBox3.Controls.Add(this.CVbtnClearAll);
            this.groupBox3.Controls.Add(this.CVbtnMeasure);
            this.groupBox3.Location = new System.Drawing.Point(8, 172);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(177, 108);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Program Control";
            // 
            // CVprogressBar
            // 
            this.CVprogressBar.Location = new System.Drawing.Point(6, 20);
            this.CVprogressBar.Name = "CVprogressBar";
            this.CVprogressBar.Size = new System.Drawing.Size(164, 15);
            this.CVprogressBar.TabIndex = 4;
            // 
            // CVbtnExport
            // 
            this.CVbtnExport.Location = new System.Drawing.Point(91, 73);
            this.CVbtnExport.Name = "CVbtnExport";
            this.CVbtnExport.Size = new System.Drawing.Size(75, 23);
            this.CVbtnExport.TabIndex = 3;
            this.CVbtnExport.Text = "Export File";
            this.CVbtnExport.UseVisualStyleBackColor = true;
            this.CVbtnExport.Click += new System.EventHandler(this.CVbtnExport_Click);
            // 
            // CVbtnImport
            // 
            this.CVbtnImport.Location = new System.Drawing.Point(9, 73);
            this.CVbtnImport.Name = "CVbtnImport";
            this.CVbtnImport.Size = new System.Drawing.Size(75, 23);
            this.CVbtnImport.TabIndex = 2;
            this.CVbtnImport.Text = "Import File";
            this.CVbtnImport.UseVisualStyleBackColor = true;
            this.CVbtnImport.Click += new System.EventHandler(this.CVbtnImport_Click);
            // 
            // CVbtnClearAll
            // 
            this.CVbtnClearAll.Location = new System.Drawing.Point(91, 41);
            this.CVbtnClearAll.Name = "CVbtnClearAll";
            this.CVbtnClearAll.Size = new System.Drawing.Size(75, 23);
            this.CVbtnClearAll.TabIndex = 1;
            this.CVbtnClearAll.Text = "Clear All";
            this.CVbtnClearAll.UseVisualStyleBackColor = true;
            this.CVbtnClearAll.Click += new System.EventHandler(this.CVbtnClearAll_Click);
            // 
            // CVbtnMeasure
            // 
            this.CVbtnMeasure.Location = new System.Drawing.Point(9, 41);
            this.CVbtnMeasure.Name = "CVbtnMeasure";
            this.CVbtnMeasure.Size = new System.Drawing.Size(75, 23);
            this.CVbtnMeasure.TabIndex = 0;
            this.CVbtnMeasure.Text = "Measure";
            this.CVbtnMeasure.UseVisualStyleBackColor = true;
            this.CVbtnMeasure.Click += new System.EventHandler(this.CVbtnMeasure_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CVstatusCOM);
            this.groupBox1.Controls.Add(this.CVbtnDisconnect);
            this.groupBox1.Controls.Add(this.CVbtnConnect);
            this.groupBox1.Controls.Add(this.CVselectPort);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(8, 84);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 79);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Control";
            // 
            // CVstatusCOM
            // 
            this.CVstatusCOM.Location = new System.Drawing.Point(123, 20);
            this.CVstatusCOM.Name = "CVstatusCOM";
            this.CVstatusCOM.Size = new System.Drawing.Size(47, 20);
            this.CVstatusCOM.TabIndex = 4;
            // 
            // CVbtnDisconnect
            // 
            this.CVbtnDisconnect.Enabled = false;
            this.CVbtnDisconnect.Location = new System.Drawing.Point(91, 47);
            this.CVbtnDisconnect.Name = "CVbtnDisconnect";
            this.CVbtnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.CVbtnDisconnect.TabIndex = 3;
            this.CVbtnDisconnect.Text = "Disconnect";
            this.CVbtnDisconnect.UseVisualStyleBackColor = true;
            this.CVbtnDisconnect.Click += new System.EventHandler(this.CVbtnDisconnect_Click);
            // 
            // CVbtnConnect
            // 
            this.CVbtnConnect.Location = new System.Drawing.Point(10, 47);
            this.CVbtnConnect.Name = "CVbtnConnect";
            this.CVbtnConnect.Size = new System.Drawing.Size(75, 23);
            this.CVbtnConnect.TabIndex = 2;
            this.CVbtnConnect.Text = "Connect";
            this.CVbtnConnect.UseVisualStyleBackColor = true;
            this.CVbtnConnect.Click += new System.EventHandler(this.CVbtnConnect_Click);
            // 
            // CVselectPort
            // 
            this.CVselectPort.FormattingEnabled = true;
            this.CVselectPort.Location = new System.Drawing.Point(42, 20);
            this.CVselectPort.Name = "CVselectPort";
            this.CVselectPort.Size = new System.Drawing.Size(70, 21);
            this.CVselectPort.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port:";
            // 
            // tabEIS
            // 
            this.tabEIS.BackColor = System.Drawing.Color.Lavender;
            this.tabEIS.Controls.Add(this.label14);
            this.tabEIS.Controls.Add(this.EISzedGraphControl);
            this.tabEIS.Controls.Add(this.label3);
            this.tabEIS.Controls.Add(this.groupBox2);
            this.tabEIS.Controls.Add(this.groupBoxShowSweepTimes);
            this.tabEIS.Controls.Add(this.groupBox8);
            this.tabEIS.Controls.Add(this.groupBox9);
            this.tabEIS.Controls.Add(this.groupBox10);
            this.tabEIS.Controls.Add(this.pictureBox3);
            this.tabEIS.Controls.Add(this.pictureBox4);
            this.tabEIS.Location = new System.Drawing.Point(4, 22);
            this.tabEIS.Name = "tabEIS";
            this.tabEIS.Padding = new System.Windows.Forms.Padding(3);
            this.tabEIS.Size = new System.Drawing.Size(1071, 640);
            this.tabEIS.TabIndex = 1;
            this.tabEIS.Text = "Electrochemical Impedance Spectroscopy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(101, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(648, 37);
            this.label14.TabIndex = 17;
            this.label14.Text = "Electrochemical Impedance Spectroscopy";
            // 
            // EISzedGraphControl
            // 
            this.EISzedGraphControl.Location = new System.Drawing.Point(191, 84);
            this.EISzedGraphControl.Margin = new System.Windows.Forms.Padding(4);
            this.EISzedGraphControl.Name = "EISzedGraphControl";
            this.EISzedGraphControl.ScrollGrace = 0D;
            this.EISzedGraphControl.ScrollMaxX = 0D;
            this.EISzedGraphControl.ScrollMaxY = 0D;
            this.EISzedGraphControl.ScrollMaxY2 = 0D;
            this.EISzedGraphControl.ScrollMinX = 0D;
            this.EISzedGraphControl.ScrollMinY = 0D;
            this.EISzedGraphControl.ScrollMinY2 = 0D;
            this.EISzedGraphControl.Size = new System.Drawing.Size(655, 479);
            this.EISzedGraphControl.TabIndex = 14;
            this.EISzedGraphControl.UseExtendedPrintDialog = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 553);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Design by MEMs - UET";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.EISlistView);
            this.groupBox2.Location = new System.Drawing.Point(852, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(177, 468);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "List Result Values";
            // 
            // EISlistView
            // 
            this.EISlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.EISlistView.GridLines = true;
            this.EISlistView.HideSelection = false;
            this.EISlistView.Location = new System.Drawing.Point(6, 19);
            this.EISlistView.Name = "EISlistView";
            this.EISlistView.Size = new System.Drawing.Size(165, 443);
            this.EISlistView.TabIndex = 0;
            this.EISlistView.UseCompatibleStateImageBehavior = false;
            this.EISlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Time (ms)";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = " Magtitude (Ω)";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phase (°)";
            this.columnHeader5.Width = 50;
            // 
            // groupBoxShowSweepTimes
            // 
            this.groupBoxShowSweepTimes.Controls.Add(this.EISradioBtn6th);
            this.groupBoxShowSweepTimes.Controls.Add(this.EISradioBtn5th);
            this.groupBoxShowSweepTimes.Controls.Add(this.EISradioBtn4th);
            this.groupBoxShowSweepTimes.Controls.Add(this.EISradioBtn3rd);
            this.groupBoxShowSweepTimes.Controls.Add(this.EISradioBtn2nd);
            this.groupBoxShowSweepTimes.Controls.Add(this.EISradioBtn1st);
            this.groupBoxShowSweepTimes.Enabled = false;
            this.groupBoxShowSweepTimes.Location = new System.Drawing.Point(8, 477);
            this.groupBoxShowSweepTimes.Name = "groupBoxShowSweepTimes";
            this.groupBoxShowSweepTimes.Size = new System.Drawing.Size(177, 73);
            this.groupBoxShowSweepTimes.TabIndex = 11;
            this.groupBoxShowSweepTimes.TabStop = false;
            this.groupBoxShowSweepTimes.Text = "Show sweep times";
            // 
            // EISradioBtn6th
            // 
            this.EISradioBtn6th.AutoSize = true;
            this.EISradioBtn6th.Location = new System.Drawing.Point(122, 45);
            this.EISradioBtn6th.Name = "EISradioBtn6th";
            this.EISradioBtn6th.Size = new System.Drawing.Size(40, 17);
            this.EISradioBtn6th.TabIndex = 6;
            this.EISradioBtn6th.Text = "6th";
            this.EISradioBtn6th.UseVisualStyleBackColor = true;
            this.EISradioBtn6th.Click += new System.EventHandler(this.EISradioBtn1st_Click);
            // 
            // EISradioBtn5th
            // 
            this.EISradioBtn5th.AutoSize = true;
            this.EISradioBtn5th.Location = new System.Drawing.Point(64, 45);
            this.EISradioBtn5th.Name = "EISradioBtn5th";
            this.EISradioBtn5th.Size = new System.Drawing.Size(40, 17);
            this.EISradioBtn5th.TabIndex = 5;
            this.EISradioBtn5th.Text = "5th";
            this.EISradioBtn5th.UseVisualStyleBackColor = true;
            this.EISradioBtn5th.Click += new System.EventHandler(this.EISradioBtn1st_Click);
            // 
            // EISradioBtn4th
            // 
            this.EISradioBtn4th.AutoSize = true;
            this.EISradioBtn4th.Location = new System.Drawing.Point(10, 45);
            this.EISradioBtn4th.Name = "EISradioBtn4th";
            this.EISradioBtn4th.Size = new System.Drawing.Size(40, 17);
            this.EISradioBtn4th.TabIndex = 4;
            this.EISradioBtn4th.Text = "4th";
            this.EISradioBtn4th.UseVisualStyleBackColor = true;
            this.EISradioBtn4th.Click += new System.EventHandler(this.EISradioBtn1st_Click);
            // 
            // EISradioBtn3rd
            // 
            this.EISradioBtn3rd.AutoSize = true;
            this.EISradioBtn3rd.Location = new System.Drawing.Point(122, 19);
            this.EISradioBtn3rd.Name = "EISradioBtn3rd";
            this.EISradioBtn3rd.Size = new System.Drawing.Size(40, 17);
            this.EISradioBtn3rd.TabIndex = 3;
            this.EISradioBtn3rd.Text = "3rd";
            this.EISradioBtn3rd.UseVisualStyleBackColor = true;
            this.EISradioBtn3rd.Click += new System.EventHandler(this.EISradioBtn1st_Click);
            // 
            // EISradioBtn2nd
            // 
            this.EISradioBtn2nd.AutoSize = true;
            this.EISradioBtn2nd.Checked = true;
            this.EISradioBtn2nd.Location = new System.Drawing.Point(64, 19);
            this.EISradioBtn2nd.Name = "EISradioBtn2nd";
            this.EISradioBtn2nd.Size = new System.Drawing.Size(43, 17);
            this.EISradioBtn2nd.TabIndex = 2;
            this.EISradioBtn2nd.TabStop = true;
            this.EISradioBtn2nd.Text = "2nd";
            this.EISradioBtn2nd.UseVisualStyleBackColor = true;
            this.EISradioBtn2nd.Click += new System.EventHandler(this.EISradioBtn1st_Click);
            // 
            // EISradioBtn1st
            // 
            this.EISradioBtn1st.AutoSize = true;
            this.EISradioBtn1st.Location = new System.Drawing.Point(10, 19);
            this.EISradioBtn1st.Name = "EISradioBtn1st";
            this.EISradioBtn1st.Size = new System.Drawing.Size(39, 17);
            this.EISradioBtn1st.TabIndex = 1;
            this.EISradioBtn1st.Text = "1st";
            this.EISradioBtn1st.UseVisualStyleBackColor = true;
            this.EISradioBtn1st.Click += new System.EventHandler(this.EISradioBtn1st_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.EIScheckBoxLog);
            this.groupBox8.Controls.Add(this.EISnumericStartFreq);
            this.groupBox8.Controls.Add(this.EIScheckBoxSweepEn);
            this.groupBox8.Controls.Add(this.EISnumericStopFreq);
            this.groupBox8.Controls.Add(this.EISnumericSweepPoints);
            this.groupBox8.Controls.Add(this.EISnumericRepeatTimes);
            this.groupBox8.Controls.Add(this.label9);
            this.groupBox8.Controls.Add(this.label10);
            this.groupBox8.Controls.Add(this.label11);
            this.groupBox8.Controls.Add(this.label12);
            this.groupBox8.Location = new System.Drawing.Point(8, 289);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(177, 179);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Parameter config";
            // 
            // EIScheckBoxLog
            // 
            this.EIScheckBoxLog.AutoSize = true;
            this.EIScheckBoxLog.Enabled = false;
            this.EIScheckBoxLog.Location = new System.Drawing.Point(10, 42);
            this.EIScheckBoxLog.Name = "EIScheckBoxLog";
            this.EIScheckBoxLog.Size = new System.Drawing.Size(80, 17);
            this.EIScheckBoxLog.TabIndex = 1;
            this.EIScheckBoxLog.Text = "Logarithmic";
            this.EIScheckBoxLog.UseVisualStyleBackColor = true;
            // 
            // EISnumericStartFreq
            // 
            this.EISnumericStartFreq.Location = new System.Drawing.Point(100, 69);
            this.EISnumericStartFreq.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.EISnumericStartFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EISnumericStartFreq.Name = "EISnumericStartFreq";
            this.EISnumericStartFreq.Size = new System.Drawing.Size(70, 20);
            this.EISnumericStartFreq.TabIndex = 9;
            this.EISnumericStartFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EISnumericStartFreq.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // EIScheckBoxSweepEn
            // 
            this.EIScheckBoxSweepEn.AutoSize = true;
            this.EIScheckBoxSweepEn.Location = new System.Drawing.Point(10, 19);
            this.EIScheckBoxSweepEn.Name = "EIScheckBoxSweepEn";
            this.EIScheckBoxSweepEn.Size = new System.Drawing.Size(94, 17);
            this.EIScheckBoxSweepEn.TabIndex = 0;
            this.EIScheckBoxSweepEn.Text = "Sweep enable";
            this.EIScheckBoxSweepEn.UseVisualStyleBackColor = true;
            this.EIScheckBoxSweepEn.CheckedChanged += new System.EventHandler(this.EIScheckBoxSweepEn_CheckedChanged);
            // 
            // EISnumericStopFreq
            // 
            this.EISnumericStopFreq.Enabled = false;
            this.EISnumericStopFreq.Location = new System.Drawing.Point(101, 95);
            this.EISnumericStopFreq.Maximum = new decimal(new int[] {
            200000,
            0,
            0,
            0});
            this.EISnumericStopFreq.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EISnumericStopFreq.Name = "EISnumericStopFreq";
            this.EISnumericStopFreq.Size = new System.Drawing.Size(70, 20);
            this.EISnumericStopFreq.TabIndex = 8;
            this.EISnumericStopFreq.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EISnumericStopFreq.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // EISnumericSweepPoints
            // 
            this.EISnumericSweepPoints.Enabled = false;
            this.EISnumericSweepPoints.Location = new System.Drawing.Point(101, 121);
            this.EISnumericSweepPoints.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.EISnumericSweepPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EISnumericSweepPoints.Name = "EISnumericSweepPoints";
            this.EISnumericSweepPoints.Size = new System.Drawing.Size(70, 20);
            this.EISnumericSweepPoints.TabIndex = 7;
            this.EISnumericSweepPoints.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EISnumericSweepPoints.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // EISnumericRepeatTimes
            // 
            this.EISnumericRepeatTimes.Enabled = false;
            this.EISnumericRepeatTimes.Location = new System.Drawing.Point(101, 147);
            this.EISnumericRepeatTimes.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.EISnumericRepeatTimes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.EISnumericRepeatTimes.Name = "EISnumericRepeatTimes";
            this.EISnumericRepeatTimes.Size = new System.Drawing.Size(70, 20);
            this.EISnumericRepeatTimes.TabIndex = 4;
            this.EISnumericRepeatTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EISnumericRepeatTimes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Repeat Times";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Sweep Points";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Stop Freq (Hz)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Start Freq (Hz)";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.EISprogressBar);
            this.groupBox9.Controls.Add(this.EISbtnExport);
            this.groupBox9.Controls.Add(this.EISbtnImport);
            this.groupBox9.Controls.Add(this.EISbtnClearAll);
            this.groupBox9.Controls.Add(this.EISbtnMeasure);
            this.groupBox9.Location = new System.Drawing.Point(8, 172);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(177, 108);
            this.groupBox9.TabIndex = 9;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Program Control";
            // 
            // EISprogressBar
            // 
            this.EISprogressBar.Location = new System.Drawing.Point(6, 20);
            this.EISprogressBar.Name = "EISprogressBar";
            this.EISprogressBar.Size = new System.Drawing.Size(164, 15);
            this.EISprogressBar.TabIndex = 4;
            // 
            // EISbtnExport
            // 
            this.EISbtnExport.Location = new System.Drawing.Point(91, 73);
            this.EISbtnExport.Name = "EISbtnExport";
            this.EISbtnExport.Size = new System.Drawing.Size(75, 23);
            this.EISbtnExport.TabIndex = 3;
            this.EISbtnExport.Text = "Export File";
            this.EISbtnExport.UseVisualStyleBackColor = true;
            this.EISbtnExport.Click += new System.EventHandler(this.EISbtnExport_Click);
            // 
            // EISbtnImport
            // 
            this.EISbtnImport.Location = new System.Drawing.Point(9, 73);
            this.EISbtnImport.Name = "EISbtnImport";
            this.EISbtnImport.Size = new System.Drawing.Size(75, 23);
            this.EISbtnImport.TabIndex = 2;
            this.EISbtnImport.Text = "Import File";
            this.EISbtnImport.UseVisualStyleBackColor = true;
            this.EISbtnImport.Click += new System.EventHandler(this.EISbtnImport_Click);
            // 
            // EISbtnClearAll
            // 
            this.EISbtnClearAll.Location = new System.Drawing.Point(91, 41);
            this.EISbtnClearAll.Name = "EISbtnClearAll";
            this.EISbtnClearAll.Size = new System.Drawing.Size(75, 23);
            this.EISbtnClearAll.TabIndex = 1;
            this.EISbtnClearAll.Text = "Clear All";
            this.EISbtnClearAll.UseVisualStyleBackColor = true;
            this.EISbtnClearAll.Click += new System.EventHandler(this.EISbtnClearAll_Click);
            // 
            // EISbtnMeasure
            // 
            this.EISbtnMeasure.Location = new System.Drawing.Point(9, 41);
            this.EISbtnMeasure.Name = "EISbtnMeasure";
            this.EISbtnMeasure.Size = new System.Drawing.Size(75, 23);
            this.EISbtnMeasure.TabIndex = 0;
            this.EISbtnMeasure.Text = "Measure";
            this.EISbtnMeasure.UseVisualStyleBackColor = true;
            this.EISbtnMeasure.Click += new System.EventHandler(this.EISbtnMeasure_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.EISstatusCOM);
            this.groupBox10.Controls.Add(this.EISbtnDisconnect);
            this.groupBox10.Controls.Add(this.EISbtnConnect);
            this.groupBox10.Controls.Add(this.EISselectPort);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Location = new System.Drawing.Point(8, 84);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(177, 79);
            this.groupBox10.TabIndex = 8;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Serial Port Control";
            // 
            // EISstatusCOM
            // 
            this.EISstatusCOM.Location = new System.Drawing.Point(123, 20);
            this.EISstatusCOM.Name = "EISstatusCOM";
            this.EISstatusCOM.Size = new System.Drawing.Size(47, 20);
            this.EISstatusCOM.TabIndex = 4;
            // 
            // EISbtnDisconnect
            // 
            this.EISbtnDisconnect.Enabled = false;
            this.EISbtnDisconnect.Location = new System.Drawing.Point(91, 47);
            this.EISbtnDisconnect.Name = "EISbtnDisconnect";
            this.EISbtnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.EISbtnDisconnect.TabIndex = 3;
            this.EISbtnDisconnect.Text = "Disconnect";
            this.EISbtnDisconnect.UseVisualStyleBackColor = true;
            this.EISbtnDisconnect.Click += new System.EventHandler(this.EISbtnDisconnect_Click);
            // 
            // EISbtnConnect
            // 
            this.EISbtnConnect.Location = new System.Drawing.Point(10, 47);
            this.EISbtnConnect.Name = "EISbtnConnect";
            this.EISbtnConnect.Size = new System.Drawing.Size(75, 23);
            this.EISbtnConnect.TabIndex = 2;
            this.EISbtnConnect.Text = "Connect";
            this.EISbtnConnect.UseVisualStyleBackColor = true;
            this.EISbtnConnect.Click += new System.EventHandler(this.EISbtnConnect_Click);
            // 
            // EISselectPort
            // 
            this.EISselectPort.FormattingEnabled = true;
            this.EISselectPort.Location = new System.Drawing.Point(42, 20);
            this.EISselectPort.Name = "EISselectPort";
            this.EISselectPort.Size = new System.Drawing.Size(70, 21);
            this.EISselectPort.TabIndex = 1;
            this.EISselectPort.SelectedIndexChanged += new System.EventHandler(this.EISselectPort_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Port:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Electrochemical_Potentiostat.Properties.Resources.Logo_ĐH_Công_Nghệ_UET;
            this.pictureBox3.Location = new System.Drawing.Point(943, 6);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Electrochemical_Potentiostat.Properties.Resources.Logo_ĐH_Quốc_Gia_Hà_Nội_VNU;
            this.pictureBox4.Location = new System.Drawing.Point(857, 6);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // tabCVEIS
            // 
            this.tabCVEIS.BackColor = System.Drawing.Color.Honeydew;
            this.tabCVEIS.Controls.Add(this.groupBox7);
            this.tabCVEIS.Controls.Add(this.groupBox13);
            this.tabCVEIS.Controls.Add(this.groupBox12);
            this.tabCVEIS.Controls.Add(this.label16);
            this.tabCVEIS.Controls.Add(this.pictureBox5);
            this.tabCVEIS.Controls.Add(this.label15);
            this.tabCVEIS.Location = new System.Drawing.Point(4, 22);
            this.tabCVEIS.Margin = new System.Windows.Forms.Padding(2);
            this.tabCVEIS.Name = "tabCVEIS";
            this.tabCVEIS.Padding = new System.Windows.Forms.Padding(2);
            this.tabCVEIS.Size = new System.Drawing.Size(1071, 640);
            this.tabCVEIS.TabIndex = 2;
            this.tabCVEIS.Text = "Voltage Control";
            this.tabCVEIS.Click += new System.EventHandler(this.tabCVEIS_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label20);
            this.groupBox7.Controls.Add(this.cbVoltage2);
            this.groupBox7.Controls.Add(this.tbVoltage2);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.cbVoltage1);
            this.groupBox7.Controls.Add(this.tbVoltage1);
            this.groupBox7.Controls.Add(this.btnExtraAdd);
            this.groupBox7.Controls.Add(this.btnAdd);
            this.groupBox7.Controls.Add(this.btnSub);
            this.groupBox7.Controls.Add(this.bntExtraSub);
            this.groupBox7.Location = new System.Drawing.Point(48, 288);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(345, 283);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuration";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(215, 197);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(16, 16);
            this.label19.TabIndex = 11;
            this.label19.Text = "V";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(30, 195);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 16);
            this.label20.TabIndex = 10;
            this.label20.Text = "Voltage 2";
            // 
            // cbVoltage2
            // 
            this.cbVoltage2.AutoSize = true;
            this.cbVoltage2.Location = new System.Drawing.Point(270, 197);
            this.cbVoltage2.Name = "cbVoltage2";
            this.cbVoltage2.Size = new System.Drawing.Size(15, 14);
            this.cbVoltage2.TabIndex = 9;
            this.cbVoltage2.UseVisualStyleBackColor = true;
            this.cbVoltage2.CheckedChanged += new System.EventHandler(this.cbVoltage2_CheckedChanged);
            // 
            // tbVoltage2
            // 
            this.tbVoltage2.Location = new System.Drawing.Point(109, 194);
            this.tbVoltage2.Name = "tbVoltage2";
            this.tbVoltage2.ReadOnly = true;
            this.tbVoltage2.Size = new System.Drawing.Size(100, 20);
            this.tbVoltage2.TabIndex = 8;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(215, 152);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(16, 16);
            this.label18.TabIndex = 7;
            this.label18.Text = "V";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 16);
            this.label17.TabIndex = 6;
            this.label17.Text = "Voltage 1";
            // 
            // cbVoltage1
            // 
            this.cbVoltage1.AutoSize = true;
            this.cbVoltage1.Checked = true;
            this.cbVoltage1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbVoltage1.Location = new System.Drawing.Point(270, 152);
            this.cbVoltage1.Name = "cbVoltage1";
            this.cbVoltage1.Size = new System.Drawing.Size(15, 14);
            this.cbVoltage1.TabIndex = 5;
            this.cbVoltage1.UseVisualStyleBackColor = true;
            this.cbVoltage1.CheckedChanged += new System.EventHandler(this.cbVoltage1_CheckedChanged);
            // 
            // tbVoltage1
            // 
            this.tbVoltage1.Location = new System.Drawing.Point(109, 149);
            this.tbVoltage1.Name = "tbVoltage1";
            this.tbVoltage1.ReadOnly = true;
            this.tbVoltage1.Size = new System.Drawing.Size(100, 20);
            this.tbVoltage1.TabIndex = 4;
            this.tbVoltage1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnExtraAdd
            // 
            this.btnExtraAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnExtraAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraAdd.Location = new System.Drawing.Point(260, 55);
            this.btnExtraAdd.Name = "btnExtraAdd";
            this.btnExtraAdd.Size = new System.Drawing.Size(59, 35);
            this.btnExtraAdd.TabIndex = 3;
            this.btnExtraAdd.Text = "+ +";
            this.btnExtraAdd.UseVisualStyleBackColor = false;
            this.btnExtraAdd.Click += new System.EventHandler(this.btnExtraAdd_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(185, 55);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 35);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSub
            // 
            this.btnSub.BackColor = System.Drawing.Color.Red;
            this.btnSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSub.Location = new System.Drawing.Point(93, 55);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(59, 35);
            this.btnSub.TabIndex = 1;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = false;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // bntExtraSub
            // 
            this.bntExtraSub.BackColor = System.Drawing.Color.Red;
            this.bntExtraSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntExtraSub.Location = new System.Drawing.Point(17, 55);
            this.bntExtraSub.Name = "bntExtraSub";
            this.bntExtraSub.Size = new System.Drawing.Size(59, 35);
            this.bntExtraSub.TabIndex = 0;
            this.bntExtraSub.Text = "- -";
            this.bntExtraSub.UseVisualStyleBackColor = false;
            this.bntExtraSub.Click += new System.EventHandler(this.bntExtraSub_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.statusCOM);
            this.groupBox13.Controls.Add(this.btnDisconnect);
            this.groupBox13.Controls.Add(this.btnConnect);
            this.groupBox13.Controls.Add(this.selectPort);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Location = new System.Drawing.Point(48, 193);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(345, 86);
            this.groupBox13.TabIndex = 26;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Serial Port Control";
            // 
            // statusCOM
            // 
            this.statusCOM.Location = new System.Drawing.Point(127, 21);
            this.statusCOM.Name = "statusCOM";
            this.statusCOM.Size = new System.Drawing.Size(73, 20);
            this.statusCOM.TabIndex = 4;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(127, 47);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(42, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // selectPort
            // 
            this.selectPort.FormattingEnabled = true;
            this.selectPort.Location = new System.Drawing.Point(42, 20);
            this.selectPort.Name = "selectPort";
            this.selectPort.Size = new System.Drawing.Size(75, 21);
            this.selectPort.TabIndex = 1;
            this.selectPort.SelectedIndexChanged += new System.EventHandler(this.selectPort_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 13);
            this.label29.TabIndex = 0;
            this.label29.Text = "Port:";
            // 
            // groupBox12
            // 
            this.groupBox12.BackgroundImage = global::Electrochemical_Potentiostat.Properties.Resources.chip_draw1;
            this.groupBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox12.Location = new System.Drawing.Point(416, 193);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox12.Size = new System.Drawing.Size(564, 378);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Cấu trúc chip";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(118, 111);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(803, 52);
            this.label16.TabIndex = 18;
            this.label16.Text = "Hệ thống đo đọc tín hiệu từ chip sinh học tập trung và phát hiện protein NSE \r\n(M" +
    "ã số: NĐT.101.TW/21)\r\n";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Electrochemical_Potentiostat.Properties.Resources.Logo_ĐH_Công_Nghệ_UET;
            this.pictureBox5.Location = new System.Drawing.Point(236, 21);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 71);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(322, 32);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(436, 62);
            this.label15.TabIndex = 0;
            this.label15.Text = "ĐẠI HỌC QUỐC GIA HÀ NỘI\r\nTRƯỜNG ĐẠI HỌC CÔNG NGHỆ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ReadBufferSize = 8192;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 667);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrochemical Potentiostat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabCV.ResumeLayout(false);
            this.tabCV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStartVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericEndVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericRepeatTimes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabEIS.ResumeLayout(false);
            this.tabEIS.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBoxShowSweepTimes.ResumeLayout(false);
            this.groupBoxShowSweepTimes.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStartFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStopFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericSweepPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericRepeatTimes)).EndInit();
            this.groupBox9.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabCVEIS.ResumeLayout(false);
            this.tabCVEIS.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCV;
        private System.Windows.Forms.TabPage tabEIS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar CVstatusCOM;
        private System.Windows.Forms.Button CVbtnDisconnect;
        private System.Windows.Forms.Button CVbtnConnect;
        private System.Windows.Forms.ComboBox CVselectPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ProgressBar CVprogressBar;
        private System.Windows.Forms.Button CVbtnExport;
        private System.Windows.Forms.Button CVbtnImport;
        private System.Windows.Forms.Button CVbtnClearAll;
        private System.Windows.Forms.Button CVbtnMeasure;
        private System.Windows.Forms.NumericUpDown CVnumericRepeatTimes;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListView CVlistView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton CVradioBtn6th;
        private System.Windows.Forms.RadioButton CVradioBtn5th;
        private System.Windows.Forms.RadioButton CVradioBtn4th;
        private System.Windows.Forms.RadioButton CVradioBtn3rd;
        private System.Windows.Forms.RadioButton CVradioBtn2nd;
        private System.Windows.Forms.RadioButton CVradioBtn1st;
        private System.Windows.Forms.RadioButton CVradioBtnShowAllSweeps;
        private System.Windows.Forms.NumericUpDown CVnumericStartVolt;
        private System.Windows.Forms.NumericUpDown CVnumericEndVolt;
        private System.Windows.Forms.NumericUpDown CVnumericStep;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private ZedGraph.ZedGraphControl CVzedGraphControl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ZedGraph.ZedGraphControl EISzedGraphControl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxShowSweepTimes;
        private System.Windows.Forms.RadioButton EISradioBtn6th;
        private System.Windows.Forms.RadioButton EISradioBtn5th;
        private System.Windows.Forms.RadioButton EISradioBtn4th;
        private System.Windows.Forms.RadioButton EISradioBtn3rd;
        private System.Windows.Forms.RadioButton EISradioBtn2nd;
        private System.Windows.Forms.RadioButton EISradioBtn1st;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.NumericUpDown EISnumericSweepPoints;
        private System.Windows.Forms.NumericUpDown EISnumericRepeatTimes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ProgressBar EISprogressBar;
        private System.Windows.Forms.Button EISbtnExport;
        private System.Windows.Forms.Button EISbtnImport;
        private System.Windows.Forms.Button EISbtnClearAll;
        private System.Windows.Forms.Button EISbtnMeasure;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ProgressBar EISstatusCOM;
        private System.Windows.Forms.Button EISbtnDisconnect;
        private System.Windows.Forms.Button EISbtnConnect;
        private System.Windows.Forms.ComboBox EISselectPort;
        private System.Windows.Forms.Label label13;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView EISlistView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox EIScheckBoxLog;
        private System.Windows.Forms.CheckBox EIScheckBoxSweepEn;
        private System.Windows.Forms.NumericUpDown EISnumericStopFreq;
        private System.Windows.Forms.NumericUpDown EISnumericStartFreq;
        private System.Windows.Forms.TabPage tabCVEIS;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ProgressBar statusCOM;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox selectPort;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbVoltage1;
        private System.Windows.Forms.TextBox tbVoltage1;
        private System.Windows.Forms.Button btnExtraAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button bntExtraSub;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.CheckBox cbVoltage2;
        private System.Windows.Forms.TextBox tbVoltage2;
    }
}



