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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabCVEIS = new System.Windows.Forms.TabPage();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBoxEISResult = new System.Windows.Forms.GroupBox();
            this.EISlistView = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EISzedGraphControl = new ZedGraph.ZedGraphControl();
            this.groupBoxCVResult = new System.Windows.Forms.GroupBox();
            this.CVlistView = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.statusCtrlVoltage = new System.Windows.Forms.ProgressBar();
            this.btnApplyVoltage = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxVoltage2 = new System.Windows.Forms.ComboBox();
            this.comboBoxVoltage1 = new System.Windows.Forms.ComboBox();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.statusCOM = new System.Windows.Forms.ProgressBar();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.selectPort = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.labelVoltage2 = new System.Windows.Forms.Label();
            this.labelVoltage1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBoxDetection = new System.Windows.Forms.GroupBox();
            this.groupBoxEISMeasure = new System.Windows.Forms.GroupBox();
            this.EISprogressBar = new System.Windows.Forms.ProgressBar();
            this.EISbtnExport = new System.Windows.Forms.Button();
            this.EISbtnImport = new System.Windows.Forms.Button();
            this.EISbtnClearAll = new System.Windows.Forms.Button();
            this.EISbtnMeasure = new System.Windows.Forms.Button();
            this.groupBoxShowSweepTimes = new System.Windows.Forms.GroupBox();
            this.EISradioBtn6th = new System.Windows.Forms.RadioButton();
            this.EISradioBtn5th = new System.Windows.Forms.RadioButton();
            this.EISradioBtn4th = new System.Windows.Forms.RadioButton();
            this.EISradioBtn3rd = new System.Windows.Forms.RadioButton();
            this.EISradioBtn2nd = new System.Windows.Forms.RadioButton();
            this.EISradioBtn1st = new System.Windows.Forms.RadioButton();
            this.groupBoxCVMeasure = new System.Windows.Forms.GroupBox();
            this.CVprogressBar = new System.Windows.Forms.ProgressBar();
            this.CVbtnExport = new System.Windows.Forms.Button();
            this.CVbtnImport = new System.Windows.Forms.Button();
            this.CVbtnClearAll = new System.Windows.Forms.Button();
            this.CVbtnMeasure = new System.Windows.Forms.Button();
            this.groupBoxEISParam = new System.Windows.Forms.GroupBox();
            this.EIScheckBoxLog = new System.Windows.Forms.CheckBox();
            this.EISnumericStartFreq = new System.Windows.Forms.NumericUpDown();
            this.EIScheckBoxSweepEn = new System.Windows.Forms.CheckBox();
            this.EISnumericStopFreq = new System.Windows.Forms.NumericUpDown();
            this.EISnumericSweepPoints = new System.Windows.Forms.NumericUpDown();
            this.EISnumericRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.groupBoxCVSweep = new System.Windows.Forms.GroupBox();
            this.CVradioBtn6th = new System.Windows.Forms.RadioButton();
            this.CVradioBtn5th = new System.Windows.Forms.RadioButton();
            this.CVradioBtn4th = new System.Windows.Forms.RadioButton();
            this.CVradioBtn3rd = new System.Windows.Forms.RadioButton();
            this.CVradioBtn2nd = new System.Windows.Forms.RadioButton();
            this.CVradioBtn1st = new System.Windows.Forms.RadioButton();
            this.CVradioBtnShowAllSweeps = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.groupBoxCVParam = new System.Windows.Forms.GroupBox();
            this.CVnumericStartVolt = new System.Windows.Forms.NumericUpDown();
            this.CVnumericEndVolt = new System.Windows.Forms.NumericUpDown();
            this.CVnumericStep = new System.Windows.Forms.NumericUpDown();
            this.CVnumericRepeatTimes = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.CVzedGraphControl = new ZedGraph.ZedGraphControl();
            this.tabEIS = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tabCV = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCVEIS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.groupBoxEISResult.SuspendLayout();
            this.groupBoxCVResult.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.groupBoxDetection.SuspendLayout();
            this.groupBoxEISMeasure.SuspendLayout();
            this.groupBoxShowSweepTimes.SuspendLayout();
            this.groupBoxCVMeasure.SuspendLayout();
            this.groupBoxEISParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStartFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStopFreq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericSweepPoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericRepeatTimes)).BeginInit();
            this.groupBoxCVSweep.SuspendLayout();
            this.groupBoxCVParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStartVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericEndVolt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericRepeatTimes)).BeginInit();
            this.tabEIS.SuspendLayout();
            this.tabCV.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabCVEIS
            // 
            this.tabCVEIS.BackColor = System.Drawing.Color.AliceBlue;
            this.tabCVEIS.Controls.Add(this.pictureBox6);
            this.tabCVEIS.Controls.Add(this.groupBoxEISResult);
            this.tabCVEIS.Controls.Add(this.EISzedGraphControl);
            this.tabCVEIS.Controls.Add(this.groupBoxCVResult);
            this.tabCVEIS.Controls.Add(this.groupBox7);
            this.tabCVEIS.Controls.Add(this.groupBox13);
            this.tabCVEIS.Controls.Add(this.groupBox12);
            this.tabCVEIS.Controls.Add(this.label16);
            this.tabCVEIS.Controls.Add(this.pictureBox5);
            this.tabCVEIS.Controls.Add(this.label15);
            this.tabCVEIS.Controls.Add(this.groupBoxDetection);
            this.tabCVEIS.Controls.Add(this.CVzedGraphControl);
            this.tabCVEIS.Location = new System.Drawing.Point(4, 25);
            this.tabCVEIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCVEIS.Name = "tabCVEIS";
            this.tabCVEIS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabCVEIS.Size = new System.Drawing.Size(1431, 791);
            this.tabCVEIS.TabIndex = 2;
            this.tabCVEIS.Text = "Menu";
            this.tabCVEIS.Click += new System.EventHandler(this.tabCVEIS_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Electrochemical_Potentiostat.Properties.Resources.Logo_ĐH_Quốc_Gia_Hà_Nội_VNU;
            this.pictureBox6.Location = new System.Drawing.Point(463, 7);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(57, 54);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 33;
            this.pictureBox6.TabStop = false;
            // 
            // groupBoxEISResult
            // 
            this.groupBoxEISResult.Controls.Add(this.EISlistView);
            this.groupBoxEISResult.Location = new System.Drawing.Point(1067, 84);
            this.groupBoxEISResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEISResult.Name = "groupBoxEISResult";
            this.groupBoxEISResult.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEISResult.Size = new System.Drawing.Size(241, 692);
            this.groupBoxEISResult.TabIndex = 32;
            this.groupBoxEISResult.TabStop = false;
            this.groupBoxEISResult.Text = "List Result Values";
            // 
            // EISlistView
            // 
            this.EISlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.EISlistView.GridLines = true;
            this.EISlistView.HideSelection = false;
            this.EISlistView.Location = new System.Drawing.Point(8, 23);
            this.EISlistView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISlistView.Name = "EISlistView";
            this.EISlistView.Size = new System.Drawing.Size(224, 656);
            this.EISlistView.TabIndex = 0;
            this.EISlistView.UseCompatibleStateImageBehavior = false;
            this.EISlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Time (ms)";
            this.columnHeader8.Width = 50;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = " Magtitude (Ω)";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 56;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Phase (°)";
            this.columnHeader10.Width = 64;
            // 
            // EISzedGraphControl
            // 
            this.EISzedGraphControl.Location = new System.Drawing.Point(407, 366);
            this.EISzedGraphControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.EISzedGraphControl.Name = "EISzedGraphControl";
            this.EISzedGraphControl.ScrollGrace = 0D;
            this.EISzedGraphControl.ScrollMaxX = 0D;
            this.EISzedGraphControl.ScrollMaxY = 0D;
            this.EISzedGraphControl.ScrollMaxY2 = 0D;
            this.EISzedGraphControl.ScrollMinX = 0D;
            this.EISzedGraphControl.ScrollMinY = 0D;
            this.EISzedGraphControl.ScrollMinY2 = 0D;
            this.EISzedGraphControl.Size = new System.Drawing.Size(601, 410);
            this.EISzedGraphControl.TabIndex = 31;
            this.EISzedGraphControl.UseExtendedPrintDialog = true;
            // 
            // groupBoxCVResult
            // 
            this.groupBoxCVResult.Controls.Add(this.CVlistView);
            this.groupBoxCVResult.Location = new System.Drawing.Point(1067, 84);
            this.groupBoxCVResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCVResult.Name = "groupBoxCVResult";
            this.groupBoxCVResult.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCVResult.Size = new System.Drawing.Size(241, 692);
            this.groupBoxCVResult.TabIndex = 30;
            this.groupBoxCVResult.TabStop = false;
            this.groupBoxCVResult.Text = "List Result Values";
            // 
            // CVlistView
            // 
            this.CVlistView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.CVlistView.GridLines = true;
            this.CVlistView.HideSelection = false;
            this.CVlistView.Location = new System.Drawing.Point(8, 25);
            this.CVlistView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVlistView.Name = "CVlistView";
            this.CVlistView.Size = new System.Drawing.Size(221, 655);
            this.CVlistView.TabIndex = 0;
            this.CVlistView.UseCompatibleStateImageBehavior = false;
            this.CVlistView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Voltage (mV)";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Current (uA)";
            this.columnHeader7.Width = 80;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.statusCtrlVoltage);
            this.groupBox7.Controls.Add(this.btnApplyVoltage);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.comboBoxVoltage2);
            this.groupBox7.Controls.Add(this.comboBoxVoltage1);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(53, 174);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(295, 129);
            this.groupBox7.TabIndex = 27;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Preconcentration";
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // statusCtrlVoltage
            // 
            this.statusCtrlVoltage.Location = new System.Drawing.Point(164, 92);
            this.statusCtrlVoltage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusCtrlVoltage.Name = "statusCtrlVoltage";
            this.statusCtrlVoltage.Size = new System.Drawing.Size(97, 25);
            this.statusCtrlVoltage.TabIndex = 5;
            this.statusCtrlVoltage.Click += new System.EventHandler(this.statusCtrlVoltage_Click);
            // 
            // btnApplyVoltage
            // 
            this.btnApplyVoltage.Location = new System.Drawing.Point(56, 92);
            this.btnApplyVoltage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnApplyVoltage.Name = "btnApplyVoltage";
            this.btnApplyVoltage.Size = new System.Drawing.Size(100, 28);
            this.btnApplyVoltage.TabIndex = 6;
            this.btnApplyVoltage.Text = "Apply";
            this.btnApplyVoltage.UseVisualStyleBackColor = true;
            this.btnApplyVoltage.Click += new System.EventHandler(this.btnApplyVoltage_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(52, 58);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 17);
            this.label18.TabIndex = 3;
            this.label18.Text = "Voltage 2 (V)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(52, 25);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 17);
            this.label17.TabIndex = 2;
            this.label17.Text = "Voltage 1 (V)";
            // 
            // comboBoxVoltage2
            // 
            this.comboBoxVoltage2.FormattingEnabled = true;
            this.comboBoxVoltage2.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85"});
            this.comboBoxVoltage2.Location = new System.Drawing.Point(160, 54);
            this.comboBoxVoltage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxVoltage2.Name = "comboBoxVoltage2";
            this.comboBoxVoltage2.Size = new System.Drawing.Size(103, 25);
            this.comboBoxVoltage2.TabIndex = 1;
            this.comboBoxVoltage2.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoltage2_SelectedIndexChanged);
            // 
            // comboBoxVoltage1
            // 
            this.comboBoxVoltage1.FormattingEnabled = true;
            this.comboBoxVoltage1.Items.AddRange(new object[] {
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85"});
            this.comboBoxVoltage1.Location = new System.Drawing.Point(161, 21);
            this.comboBoxVoltage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxVoltage1.Name = "comboBoxVoltage1";
            this.comboBoxVoltage1.Size = new System.Drawing.Size(101, 25);
            this.comboBoxVoltage1.TabIndex = 0;
            this.comboBoxVoltage1.SelectedIndexChanged += new System.EventHandler(this.comboBoxVoltage1_SelectedIndexChanged);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.statusCOM);
            this.groupBox13.Controls.Add(this.btnDisconnect);
            this.groupBox13.Controls.Add(this.btnConnect);
            this.groupBox13.Controls.Add(this.selectPort);
            this.groupBox13.Controls.Add(this.label29);
            this.groupBox13.Location = new System.Drawing.Point(53, 80);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox13.Size = new System.Drawing.Size(295, 95);
            this.groupBox13.TabIndex = 26;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Serial Port Control";
            // 
            // statusCOM
            // 
            this.statusCOM.Location = new System.Drawing.Point(172, 26);
            this.statusCOM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statusCOM.Name = "statusCOM";
            this.statusCOM.Size = new System.Drawing.Size(97, 25);
            this.statusCOM.TabIndex = 4;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(169, 58);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 28);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(56, 58);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // selectPort
            // 
            this.selectPort.FormattingEnabled = true;
            this.selectPort.Location = new System.Drawing.Point(56, 25);
            this.selectPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectPort.Name = "selectPort";
            this.selectPort.Size = new System.Drawing.Size(99, 24);
            this.selectPort.TabIndex = 1;
            this.selectPort.SelectedIndexChanged += new System.EventHandler(this.selectPort_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(9, 28);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(34, 16);
            this.label29.TabIndex = 0;
            this.label29.Text = "Port:";
            // 
            // groupBox12
            // 
            this.groupBox12.BackgroundImage = global::Electrochemical_Potentiostat.Properties.Resources.chip_design;
            this.groupBox12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox12.Controls.Add(this.labelVoltage2);
            this.groupBox12.Controls.Add(this.labelVoltage1);
            this.groupBox12.Location = new System.Drawing.Point(408, 118);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox12.Size = new System.Drawing.Size(600, 240);
            this.groupBox12.TabIndex = 21;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Cấu trúc chip";
            // 
            // labelVoltage2
            // 
            this.labelVoltage2.AutoSize = true;
            this.labelVoltage2.BackColor = System.Drawing.Color.Transparent;
            this.labelVoltage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltage2.ForeColor = System.Drawing.Color.Firebrick;
            this.labelVoltage2.Location = new System.Drawing.Point(537, 91);
            this.labelVoltage2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoltage2.Name = "labelVoltage2";
            this.labelVoltage2.Size = new System.Drawing.Size(40, 20);
            this.labelVoltage2.TabIndex = 35;
            this.labelVoltage2.Text = "N/A";
            // 
            // labelVoltage1
            // 
            this.labelVoltage1.AutoSize = true;
            this.labelVoltage1.BackColor = System.Drawing.Color.Transparent;
            this.labelVoltage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoltage1.ForeColor = System.Drawing.Color.Firebrick;
            this.labelVoltage1.Location = new System.Drawing.Point(19, 90);
            this.labelVoltage1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVoltage1.Name = "labelVoltage1";
            this.labelVoltage1.Size = new System.Drawing.Size(40, 20);
            this.labelVoltage1.TabIndex = 34;
            this.labelVoltage1.Text = "N/A";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label16.Location = new System.Drawing.Point(368, 62);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(636, 44);
            this.label16.TabIndex = 18;
            this.label16.Text = "Hệ thống đo đọc tín hiệu từ chip sinh học tập trung và phát hiện protein NSE \r\n(M" +
    "ã số: NĐT.101.TW/21)\r\n";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Electrochemical_Potentiostat.Properties.Resources.Logo_ĐH_Công_Nghệ_UET;
            this.pictureBox5.Location = new System.Drawing.Point(871, 7);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(57, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label15.Location = new System.Drawing.Point(527, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(317, 46);
            this.label15.TabIndex = 0;
            this.label15.Text = "ĐẠI HỌC QUỐC GIA HÀ NỘI\r\nTRƯỜNG ĐẠI HỌC CÔNG NGHỆ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // groupBoxDetection
            // 
            this.groupBoxDetection.Controls.Add(this.groupBoxEISMeasure);
            this.groupBoxDetection.Controls.Add(this.groupBoxShowSweepTimes);
            this.groupBoxDetection.Controls.Add(this.groupBoxCVMeasure);
            this.groupBoxDetection.Controls.Add(this.groupBoxEISParam);
            this.groupBoxDetection.Controls.Add(this.groupBoxCVSweep);
            this.groupBoxDetection.Controls.Add(this.label21);
            this.groupBoxDetection.Controls.Add(this.comboBoxMethod);
            this.groupBoxDetection.Controls.Add(this.groupBoxCVParam);
            this.groupBoxDetection.Location = new System.Drawing.Point(53, 302);
            this.groupBoxDetection.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.groupBoxDetection.Name = "groupBoxDetection";
            this.groupBoxDetection.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDetection.Size = new System.Drawing.Size(295, 482);
            this.groupBoxDetection.TabIndex = 28;
            this.groupBoxDetection.TabStop = false;
            this.groupBoxDetection.Text = "Detection";
            // 
            // groupBoxEISMeasure
            // 
            this.groupBoxEISMeasure.Controls.Add(this.EISprogressBar);
            this.groupBoxEISMeasure.Controls.Add(this.EISbtnExport);
            this.groupBoxEISMeasure.Controls.Add(this.EISbtnImport);
            this.groupBoxEISMeasure.Controls.Add(this.EISbtnClearAll);
            this.groupBoxEISMeasure.Controls.Add(this.EISbtnMeasure);
            this.groupBoxEISMeasure.Location = new System.Drawing.Point(29, 348);
            this.groupBoxEISMeasure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.groupBoxEISMeasure.Name = "groupBoxEISMeasure";
            this.groupBoxEISMeasure.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxEISMeasure.Size = new System.Drawing.Size(236, 132);
            this.groupBoxEISMeasure.TabIndex = 12;
            this.groupBoxEISMeasure.TabStop = false;
            this.groupBoxEISMeasure.Text = "Program Control";
            // 
            // EISprogressBar
            // 
            this.EISprogressBar.Location = new System.Drawing.Point(8, 25);
            this.EISprogressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISprogressBar.Name = "EISprogressBar";
            this.EISprogressBar.Size = new System.Drawing.Size(219, 18);
            this.EISprogressBar.TabIndex = 4;
            this.EISprogressBar.Click += new System.EventHandler(this.EISprogressBar_Click);
            // 
            // EISbtnExport
            // 
            this.EISbtnExport.Location = new System.Drawing.Point(121, 90);
            this.EISbtnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISbtnExport.Name = "EISbtnExport";
            this.EISbtnExport.Size = new System.Drawing.Size(100, 28);
            this.EISbtnExport.TabIndex = 3;
            this.EISbtnExport.Text = "Export File";
            this.EISbtnExport.UseVisualStyleBackColor = true;
            this.EISbtnExport.Click += new System.EventHandler(this.EISbtnExport_Click);
            // 
            // EISbtnImport
            // 
            this.EISbtnImport.Location = new System.Drawing.Point(12, 90);
            this.EISbtnImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISbtnImport.Name = "EISbtnImport";
            this.EISbtnImport.Size = new System.Drawing.Size(100, 28);
            this.EISbtnImport.TabIndex = 2;
            this.EISbtnImport.Text = "Import File";
            this.EISbtnImport.UseVisualStyleBackColor = true;
            this.EISbtnImport.Click += new System.EventHandler(this.EISbtnImport_Click);
            // 
            // EISbtnClearAll
            // 
            this.EISbtnClearAll.Location = new System.Drawing.Point(121, 50);
            this.EISbtnClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISbtnClearAll.Name = "EISbtnClearAll";
            this.EISbtnClearAll.Size = new System.Drawing.Size(100, 28);
            this.EISbtnClearAll.TabIndex = 1;
            this.EISbtnClearAll.Text = "Clear All";
            this.EISbtnClearAll.UseVisualStyleBackColor = true;
            this.EISbtnClearAll.Click += new System.EventHandler(this.EISbtnClearAll_Click);
            // 
            // EISbtnMeasure
            // 
            this.EISbtnMeasure.Location = new System.Drawing.Point(12, 50);
            this.EISbtnMeasure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISbtnMeasure.Name = "EISbtnMeasure";
            this.EISbtnMeasure.Size = new System.Drawing.Size(100, 28);
            this.EISbtnMeasure.TabIndex = 0;
            this.EISbtnMeasure.Text = "Measure";
            this.EISbtnMeasure.UseVisualStyleBackColor = true;
            this.EISbtnMeasure.Click += new System.EventHandler(this.EISbtnMeasure_Click);
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
            this.groupBoxShowSweepTimes.Location = new System.Drawing.Point(29, 258);
            this.groupBoxShowSweepTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxShowSweepTimes.Name = "groupBoxShowSweepTimes";
            this.groupBoxShowSweepTimes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxShowSweepTimes.Size = new System.Drawing.Size(236, 90);
            this.groupBoxShowSweepTimes.TabIndex = 12;
            this.groupBoxShowSweepTimes.TabStop = false;
            this.groupBoxShowSweepTimes.Text = "Show sweep times";
            // 
            // EISradioBtn6th
            // 
            this.EISradioBtn6th.AutoSize = true;
            this.EISradioBtn6th.Location = new System.Drawing.Point(163, 55);
            this.EISradioBtn6th.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISradioBtn6th.Name = "EISradioBtn6th";
            this.EISradioBtn6th.Size = new System.Drawing.Size(45, 20);
            this.EISradioBtn6th.TabIndex = 6;
            this.EISradioBtn6th.Text = "6th";
            this.EISradioBtn6th.UseVisualStyleBackColor = true;
            // 
            // EISradioBtn5th
            // 
            this.EISradioBtn5th.AutoSize = true;
            this.EISradioBtn5th.Location = new System.Drawing.Point(85, 55);
            this.EISradioBtn5th.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISradioBtn5th.Name = "EISradioBtn5th";
            this.EISradioBtn5th.Size = new System.Drawing.Size(45, 20);
            this.EISradioBtn5th.TabIndex = 5;
            this.EISradioBtn5th.Text = "5th";
            this.EISradioBtn5th.UseVisualStyleBackColor = true;
            // 
            // EISradioBtn4th
            // 
            this.EISradioBtn4th.AutoSize = true;
            this.EISradioBtn4th.Location = new System.Drawing.Point(13, 55);
            this.EISradioBtn4th.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISradioBtn4th.Name = "EISradioBtn4th";
            this.EISradioBtn4th.Size = new System.Drawing.Size(45, 20);
            this.EISradioBtn4th.TabIndex = 4;
            this.EISradioBtn4th.Text = "4th";
            this.EISradioBtn4th.UseVisualStyleBackColor = true;
            // 
            // EISradioBtn3rd
            // 
            this.EISradioBtn3rd.AutoSize = true;
            this.EISradioBtn3rd.Location = new System.Drawing.Point(163, 23);
            this.EISradioBtn3rd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISradioBtn3rd.Name = "EISradioBtn3rd";
            this.EISradioBtn3rd.Size = new System.Drawing.Size(47, 20);
            this.EISradioBtn3rd.TabIndex = 3;
            this.EISradioBtn3rd.Text = "3rd";
            this.EISradioBtn3rd.UseVisualStyleBackColor = true;
            // 
            // EISradioBtn2nd
            // 
            this.EISradioBtn2nd.AutoSize = true;
            this.EISradioBtn2nd.Checked = true;
            this.EISradioBtn2nd.Location = new System.Drawing.Point(85, 23);
            this.EISradioBtn2nd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISradioBtn2nd.Name = "EISradioBtn2nd";
            this.EISradioBtn2nd.Size = new System.Drawing.Size(50, 20);
            this.EISradioBtn2nd.TabIndex = 2;
            this.EISradioBtn2nd.TabStop = true;
            this.EISradioBtn2nd.Text = "2nd";
            this.EISradioBtn2nd.UseVisualStyleBackColor = true;
            // 
            // EISradioBtn1st
            // 
            this.EISradioBtn1st.AutoSize = true;
            this.EISradioBtn1st.Location = new System.Drawing.Point(13, 23);
            this.EISradioBtn1st.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EISradioBtn1st.Name = "EISradioBtn1st";
            this.EISradioBtn1st.Size = new System.Drawing.Size(45, 20);
            this.EISradioBtn1st.TabIndex = 1;
            this.EISradioBtn1st.Text = "1st";
            this.EISradioBtn1st.UseVisualStyleBackColor = true;
            // 
            // groupBoxCVMeasure
            // 
            this.groupBoxCVMeasure.Controls.Add(this.CVprogressBar);
            this.groupBoxCVMeasure.Controls.Add(this.CVbtnExport);
            this.groupBoxCVMeasure.Controls.Add(this.CVbtnImport);
            this.groupBoxCVMeasure.Controls.Add(this.CVbtnClearAll);
            this.groupBoxCVMeasure.Controls.Add(this.CVbtnMeasure);
            this.groupBoxCVMeasure.Location = new System.Drawing.Point(29, 348);
            this.groupBoxCVMeasure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.groupBoxCVMeasure.Name = "groupBoxCVMeasure";
            this.groupBoxCVMeasure.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCVMeasure.Size = new System.Drawing.Size(236, 130);
            this.groupBoxCVMeasure.TabIndex = 11;
            this.groupBoxCVMeasure.TabStop = false;
            this.groupBoxCVMeasure.Text = "Program Control";
            // 
            // CVprogressBar
            // 
            this.CVprogressBar.Location = new System.Drawing.Point(8, 25);
            this.CVprogressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVprogressBar.Name = "CVprogressBar";
            this.CVprogressBar.Size = new System.Drawing.Size(219, 18);
            this.CVprogressBar.TabIndex = 4;
            // 
            // CVbtnExport
            // 
            this.CVbtnExport.Location = new System.Drawing.Point(121, 90);
            this.CVbtnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVbtnExport.Name = "CVbtnExport";
            this.CVbtnExport.Size = new System.Drawing.Size(100, 28);
            this.CVbtnExport.TabIndex = 3;
            this.CVbtnExport.Text = "Export File";
            this.CVbtnExport.UseVisualStyleBackColor = true;
            this.CVbtnExport.Click += new System.EventHandler(this.CVbtnExport_Click);
            // 
            // CVbtnImport
            // 
            this.CVbtnImport.Location = new System.Drawing.Point(12, 90);
            this.CVbtnImport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVbtnImport.Name = "CVbtnImport";
            this.CVbtnImport.Size = new System.Drawing.Size(100, 28);
            this.CVbtnImport.TabIndex = 2;
            this.CVbtnImport.Text = "Import File";
            this.CVbtnImport.UseVisualStyleBackColor = true;
            this.CVbtnImport.Click += new System.EventHandler(this.CVbtnImport_Click);
            // 
            // CVbtnClearAll
            // 
            this.CVbtnClearAll.Location = new System.Drawing.Point(121, 50);
            this.CVbtnClearAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVbtnClearAll.Name = "CVbtnClearAll";
            this.CVbtnClearAll.Size = new System.Drawing.Size(100, 28);
            this.CVbtnClearAll.TabIndex = 1;
            this.CVbtnClearAll.Text = "Clear All";
            this.CVbtnClearAll.UseVisualStyleBackColor = true;
            this.CVbtnClearAll.Click += new System.EventHandler(this.CVbtnClearAll_Click);
            // 
            // CVbtnMeasure
            // 
            this.CVbtnMeasure.Location = new System.Drawing.Point(12, 50);
            this.CVbtnMeasure.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVbtnMeasure.Name = "CVbtnMeasure";
            this.CVbtnMeasure.Size = new System.Drawing.Size(100, 28);
            this.CVbtnMeasure.TabIndex = 0;
            this.CVbtnMeasure.Text = "Measure";
            this.CVbtnMeasure.UseVisualStyleBackColor = true;
            this.CVbtnMeasure.Click += new System.EventHandler(this.CVbtnMeasure_Click);
            // 
            // groupBoxEISParam
            // 
            this.groupBoxEISParam.Controls.Add(this.EIScheckBoxLog);
            this.groupBoxEISParam.Controls.Add(this.EISnumericStartFreq);
            this.groupBoxEISParam.Controls.Add(this.EIScheckBoxSweepEn);
            this.groupBoxEISParam.Controls.Add(this.EISnumericStopFreq);
            this.groupBoxEISParam.Controls.Add(this.EISnumericSweepPoints);
            this.groupBoxEISParam.Controls.Add(this.EISnumericRepeatTimes);
            this.groupBoxEISParam.Controls.Add(this.label26);
            this.groupBoxEISParam.Controls.Add(this.label27);
            this.groupBoxEISParam.Controls.Add(this.label28);
            this.groupBoxEISParam.Controls.Add(this.label30);
            this.groupBoxEISParam.Location = new System.Drawing.Point(29, 48);
            this.groupBoxEISParam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.groupBoxEISParam.Name = "groupBoxEISParam";
            this.groupBoxEISParam.Padding = new System.Windows.Forms.Padding(4, 4, 4, 2);
            this.groupBoxEISParam.Size = new System.Drawing.Size(236, 207);
            this.groupBoxEISParam.TabIndex = 12;
            this.groupBoxEISParam.TabStop = false;
            this.groupBoxEISParam.Text = "Parameter config";
            this.groupBoxEISParam.Enter += new System.EventHandler(this.groupBoxEISParam_Enter);
            // 
            // EIScheckBoxLog
            // 
            this.EIScheckBoxLog.AutoSize = true;
            this.EIScheckBoxLog.Enabled = false;
            this.EIScheckBoxLog.Location = new System.Drawing.Point(12, 47);
            this.EIScheckBoxLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EIScheckBoxLog.Name = "EIScheckBoxLog";
            this.EIScheckBoxLog.Size = new System.Drawing.Size(98, 20);
            this.EIScheckBoxLog.TabIndex = 1;
            this.EIScheckBoxLog.Text = "Logarithmic";
            this.EIScheckBoxLog.UseVisualStyleBackColor = true;
            // 
            // EISnumericStartFreq
            // 
            this.EISnumericStartFreq.Location = new System.Drawing.Point(131, 74);
            this.EISnumericStartFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.EISnumericStartFreq.Size = new System.Drawing.Size(93, 22);
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
            this.EIScheckBoxSweepEn.Location = new System.Drawing.Point(13, 23);
            this.EIScheckBoxSweepEn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EIScheckBoxSweepEn.Name = "EIScheckBoxSweepEn";
            this.EIScheckBoxSweepEn.Size = new System.Drawing.Size(116, 20);
            this.EIScheckBoxSweepEn.TabIndex = 0;
            this.EIScheckBoxSweepEn.Text = "Sweep enable";
            this.EIScheckBoxSweepEn.UseVisualStyleBackColor = true;
            this.EIScheckBoxSweepEn.CheckedChanged += new System.EventHandler(this.EIScheckBoxSweepEn_CheckedChanged);
            // 
            // EISnumericStopFreq
            // 
            this.EISnumericStopFreq.Enabled = false;
            this.EISnumericStopFreq.Location = new System.Drawing.Point(132, 106);
            this.EISnumericStopFreq.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.EISnumericStopFreq.Size = new System.Drawing.Size(93, 22);
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
            this.EISnumericSweepPoints.Location = new System.Drawing.Point(132, 138);
            this.EISnumericSweepPoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.EISnumericSweepPoints.Size = new System.Drawing.Size(93, 22);
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
            this.EISnumericRepeatTimes.Location = new System.Drawing.Point(132, 170);
            this.EISnumericRepeatTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.EISnumericRepeatTimes.Size = new System.Drawing.Size(93, 22);
            this.EISnumericRepeatTimes.TabIndex = 4;
            this.EISnumericRepeatTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EISnumericRepeatTimes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(7, 172);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(93, 16);
            this.label26.TabIndex = 6;
            this.label26.Text = "Repeat Times";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(7, 140);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(89, 16);
            this.label27.TabIndex = 4;
            this.label27.Text = "Sweep Points";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(5, 108);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(93, 16);
            this.label28.TabIndex = 2;
            this.label28.Text = "Stop Freq (Hz)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(5, 76);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(92, 16);
            this.label30.TabIndex = 0;
            this.label30.Text = "Start Freq (Hz)";
            // 
            // groupBoxCVSweep
            // 
            this.groupBoxCVSweep.Controls.Add(this.CVradioBtn6th);
            this.groupBoxCVSweep.Controls.Add(this.CVradioBtn5th);
            this.groupBoxCVSweep.Controls.Add(this.CVradioBtn4th);
            this.groupBoxCVSweep.Controls.Add(this.CVradioBtn3rd);
            this.groupBoxCVSweep.Controls.Add(this.CVradioBtn2nd);
            this.groupBoxCVSweep.Controls.Add(this.CVradioBtn1st);
            this.groupBoxCVSweep.Controls.Add(this.CVradioBtnShowAllSweeps);
            this.groupBoxCVSweep.Location = new System.Drawing.Point(29, 220);
            this.groupBoxCVSweep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCVSweep.Name = "groupBoxCVSweep";
            this.groupBoxCVSweep.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCVSweep.Size = new System.Drawing.Size(236, 121);
            this.groupBoxCVSweep.TabIndex = 10;
            this.groupBoxCVSweep.TabStop = false;
            this.groupBoxCVSweep.Text = "Show sweep times";
            // 
            // CVradioBtn6th
            // 
            this.CVradioBtn6th.AutoSize = true;
            this.CVradioBtn6th.Location = new System.Drawing.Point(163, 87);
            this.CVradioBtn6th.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVradioBtn6th.Name = "CVradioBtn6th";
            this.CVradioBtn6th.Size = new System.Drawing.Size(45, 20);
            this.CVradioBtn6th.TabIndex = 6;
            this.CVradioBtn6th.Text = "6th";
            this.CVradioBtn6th.UseVisualStyleBackColor = true;
            // 
            // CVradioBtn5th
            // 
            this.CVradioBtn5th.AutoSize = true;
            this.CVradioBtn5th.Location = new System.Drawing.Point(85, 87);
            this.CVradioBtn5th.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVradioBtn5th.Name = "CVradioBtn5th";
            this.CVradioBtn5th.Size = new System.Drawing.Size(45, 20);
            this.CVradioBtn5th.TabIndex = 5;
            this.CVradioBtn5th.Text = "5th";
            this.CVradioBtn5th.UseVisualStyleBackColor = true;
            // 
            // CVradioBtn4th
            // 
            this.CVradioBtn4th.AutoSize = true;
            this.CVradioBtn4th.Location = new System.Drawing.Point(13, 87);
            this.CVradioBtn4th.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVradioBtn4th.Name = "CVradioBtn4th";
            this.CVradioBtn4th.Size = new System.Drawing.Size(45, 20);
            this.CVradioBtn4th.TabIndex = 4;
            this.CVradioBtn4th.Text = "4th";
            this.CVradioBtn4th.UseVisualStyleBackColor = true;
            // 
            // CVradioBtn3rd
            // 
            this.CVradioBtn3rd.AutoSize = true;
            this.CVradioBtn3rd.Location = new System.Drawing.Point(163, 55);
            this.CVradioBtn3rd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVradioBtn3rd.Name = "CVradioBtn3rd";
            this.CVradioBtn3rd.Size = new System.Drawing.Size(47, 20);
            this.CVradioBtn3rd.TabIndex = 3;
            this.CVradioBtn3rd.Text = "3rd";
            this.CVradioBtn3rd.UseVisualStyleBackColor = true;
            // 
            // CVradioBtn2nd
            // 
            this.CVradioBtn2nd.AutoSize = true;
            this.CVradioBtn2nd.Location = new System.Drawing.Point(85, 55);
            this.CVradioBtn2nd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVradioBtn2nd.Name = "CVradioBtn2nd";
            this.CVradioBtn2nd.Size = new System.Drawing.Size(50, 20);
            this.CVradioBtn2nd.TabIndex = 2;
            this.CVradioBtn2nd.Text = "2nd";
            this.CVradioBtn2nd.UseVisualStyleBackColor = true;
            // 
            // CVradioBtn1st
            // 
            this.CVradioBtn1st.AutoSize = true;
            this.CVradioBtn1st.Location = new System.Drawing.Point(13, 55);
            this.CVradioBtn1st.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVradioBtn1st.Name = "CVradioBtn1st";
            this.CVradioBtn1st.Size = new System.Drawing.Size(45, 20);
            this.CVradioBtn1st.TabIndex = 1;
            this.CVradioBtn1st.Text = "1st";
            this.CVradioBtn1st.UseVisualStyleBackColor = true;
            // 
            // CVradioBtnShowAllSweeps
            // 
            this.CVradioBtnShowAllSweeps.AutoSize = true;
            this.CVradioBtnShowAllSweeps.Checked = true;
            this.CVradioBtnShowAllSweeps.Location = new System.Drawing.Point(13, 23);
            this.CVradioBtnShowAllSweeps.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CVradioBtnShowAllSweeps.Name = "CVradioBtnShowAllSweeps";
            this.CVradioBtnShowAllSweeps.Size = new System.Drawing.Size(128, 20);
            this.CVradioBtnShowAllSweeps.TabIndex = 0;
            this.CVradioBtnShowAllSweeps.TabStop = true;
            this.CVradioBtnShowAllSweeps.Text = "Show all sweeps";
            this.CVradioBtnShowAllSweeps.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(36, 20);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 16);
            this.label21.TabIndex = 8;
            this.label21.Text = "Detection method";
            // 
            // comboBoxMethod
            // 
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Items.AddRange(new object[] {
            "CV",
            "EIS"});
            this.comboBoxMethod.Location = new System.Drawing.Point(161, 16);
            this.comboBoxMethod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(101, 24);
            this.comboBoxMethod.TabIndex = 1;
            this.comboBoxMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxMethod_SelectedIndexChanged);
            // 
            // groupBoxCVParam
            // 
            this.groupBoxCVParam.Controls.Add(this.CVnumericStartVolt);
            this.groupBoxCVParam.Controls.Add(this.CVnumericEndVolt);
            this.groupBoxCVParam.Controls.Add(this.CVnumericStep);
            this.groupBoxCVParam.Controls.Add(this.CVnumericRepeatTimes);
            this.groupBoxCVParam.Controls.Add(this.label22);
            this.groupBoxCVParam.Controls.Add(this.label23);
            this.groupBoxCVParam.Controls.Add(this.label24);
            this.groupBoxCVParam.Controls.Add(this.label25);
            this.groupBoxCVParam.Location = new System.Drawing.Point(29, 48);
            this.groupBoxCVParam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 7);
            this.groupBoxCVParam.Name = "groupBoxCVParam";
            this.groupBoxCVParam.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxCVParam.Size = new System.Drawing.Size(236, 160);
            this.groupBoxCVParam.TabIndex = 9;
            this.groupBoxCVParam.TabStop = false;
            this.groupBoxCVParam.Text = "Parameter config";
            // 
            // CVnumericStartVolt
            // 
            this.CVnumericStartVolt.Location = new System.Drawing.Point(133, 25);
            this.CVnumericStartVolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.CVnumericStartVolt.Size = new System.Drawing.Size(93, 22);
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
            this.CVnumericEndVolt.Location = new System.Drawing.Point(133, 57);
            this.CVnumericEndVolt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.CVnumericEndVolt.Size = new System.Drawing.Size(93, 22);
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
            this.CVnumericStep.Location = new System.Drawing.Point(133, 89);
            this.CVnumericStep.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.CVnumericStep.Size = new System.Drawing.Size(93, 22);
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
            this.CVnumericRepeatTimes.Location = new System.Drawing.Point(133, 121);
            this.CVnumericRepeatTimes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.CVnumericRepeatTimes.Size = new System.Drawing.Size(93, 22);
            this.CVnumericRepeatTimes.TabIndex = 4;
            this.CVnumericRepeatTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CVnumericRepeatTimes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(8, 123);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(93, 16);
            this.label22.TabIndex = 6;
            this.label22.Text = "Repeat Times";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 89);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 16);
            this.label23.TabIndex = 4;
            this.label23.Text = "Step (mV)";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(8, 59);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 16);
            this.label24.TabIndex = 2;
            this.label24.Text = "End Voltage (mV)";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(8, 27);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(115, 16);
            this.label25.TabIndex = 0;
            this.label25.Text = "Start Voltage (mV)";
            // 
            // CVzedGraphControl
            // 
            this.CVzedGraphControl.Location = new System.Drawing.Point(407, 366);
            this.CVzedGraphControl.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.CVzedGraphControl.Name = "CVzedGraphControl";
            this.CVzedGraphControl.ScrollGrace = 0D;
            this.CVzedGraphControl.ScrollMaxX = 0D;
            this.CVzedGraphControl.ScrollMaxY = 0D;
            this.CVzedGraphControl.ScrollMaxY2 = 0D;
            this.CVzedGraphControl.ScrollMinX = 0D;
            this.CVzedGraphControl.ScrollMinY = 0D;
            this.CVzedGraphControl.ScrollMinY2 = 0D;
            this.CVzedGraphControl.Size = new System.Drawing.Size(601, 410);
            this.CVzedGraphControl.TabIndex = 29;
            this.CVzedGraphControl.UseExtendedPrintDialog = true;
            // 
            // tabEIS
            // 
            this.tabEIS.BackColor = System.Drawing.Color.Lavender;
            this.tabEIS.Controls.Add(this.label3);
            this.tabEIS.Location = new System.Drawing.Point(4, 25);
            this.tabEIS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEIS.Name = "tabEIS";
            this.tabEIS.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabEIS.Size = new System.Drawing.Size(1431, 791);
            this.tabEIS.TabIndex = 1;
            this.tabEIS.Text = "dump2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 681);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Design by MEMs - UET";
            // 
            // tabCV
            // 
            this.tabCV.BackColor = System.Drawing.Color.LightCyan;
            this.tabCV.Controls.Add(this.label8);
            this.tabCV.Location = new System.Drawing.Point(4, 25);
            this.tabCV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCV.Name = "tabCV";
            this.tabCV.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCV.Size = new System.Drawing.Size(1431, 791);
            this.tabCV.TabIndex = 0;
            this.tabCV.Text = "dump1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 681);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Design by MEMs - UET";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCVEIS);
            this.tabControl1.Controls.Add(this.tabCV);
            this.tabControl1.Controls.Add(this.tabEIS);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1439, 820);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 821);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electrochemical Potentiostat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabCVEIS.ResumeLayout(false);
            this.tabCVEIS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.groupBoxEISResult.ResumeLayout(false);
            this.groupBoxCVResult.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.groupBoxDetection.ResumeLayout(false);
            this.groupBoxDetection.PerformLayout();
            this.groupBoxEISMeasure.ResumeLayout(false);
            this.groupBoxShowSweepTimes.ResumeLayout(false);
            this.groupBoxShowSweepTimes.PerformLayout();
            this.groupBoxCVMeasure.ResumeLayout(false);
            this.groupBoxEISParam.ResumeLayout(false);
            this.groupBoxEISParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStartFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericStopFreq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericSweepPoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EISnumericRepeatTimes)).EndInit();
            this.groupBoxCVSweep.ResumeLayout(false);
            this.groupBoxCVSweep.PerformLayout();
            this.groupBoxCVParam.ResumeLayout(false);
            this.groupBoxCVParam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStartVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericEndVolt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CVnumericRepeatTimes)).EndInit();
            this.tabEIS.ResumeLayout(false);
            this.tabEIS.PerformLayout();
            this.tabCV.ResumeLayout(false);
            this.tabCV.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage tabCVEIS;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.ProgressBar statusCOM;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ComboBox selectPort;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabEIS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabCV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ComboBox comboBoxVoltage1;
        private System.Windows.Forms.Button btnApplyVoltage;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxVoltage2;
        private System.Windows.Forms.GroupBox groupBoxDetection;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox comboBoxMethod;
        private System.Windows.Forms.GroupBox groupBoxCVSweep;
        private System.Windows.Forms.RadioButton CVradioBtn6th;
        private System.Windows.Forms.RadioButton CVradioBtn5th;
        private System.Windows.Forms.RadioButton CVradioBtn4th;
        private System.Windows.Forms.RadioButton CVradioBtn3rd;
        private System.Windows.Forms.RadioButton CVradioBtn2nd;
        private System.Windows.Forms.RadioButton CVradioBtn1st;
        private System.Windows.Forms.RadioButton CVradioBtnShowAllSweeps;
        private System.Windows.Forms.GroupBox groupBoxCVParam;
        private System.Windows.Forms.NumericUpDown CVnumericStartVolt;
        private System.Windows.Forms.NumericUpDown CVnumericEndVolt;
        private System.Windows.Forms.NumericUpDown CVnumericStep;
        private System.Windows.Forms.NumericUpDown CVnumericRepeatTimes;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.GroupBox groupBoxCVResult;
        private System.Windows.Forms.ListView CVlistView;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private ZedGraph.ZedGraphControl CVzedGraphControl;
        private System.Windows.Forms.GroupBox groupBoxCVMeasure;
        private System.Windows.Forms.ProgressBar CVprogressBar;
        private System.Windows.Forms.Button CVbtnExport;
        private System.Windows.Forms.Button CVbtnImport;
        private System.Windows.Forms.Button CVbtnClearAll;
        private System.Windows.Forms.Button CVbtnMeasure;
        private System.Windows.Forms.GroupBox groupBoxEISParam;
        private System.Windows.Forms.CheckBox EIScheckBoxLog;
        private System.Windows.Forms.NumericUpDown EISnumericStartFreq;
        private System.Windows.Forms.CheckBox EIScheckBoxSweepEn;
        private System.Windows.Forms.NumericUpDown EISnumericStopFreq;
        private System.Windows.Forms.NumericUpDown EISnumericSweepPoints;
        private System.Windows.Forms.NumericUpDown EISnumericRepeatTimes;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.GroupBox groupBoxEISMeasure;
        private System.Windows.Forms.ProgressBar EISprogressBar;
        private System.Windows.Forms.Button EISbtnExport;
        private System.Windows.Forms.Button EISbtnImport;
        private System.Windows.Forms.Button EISbtnClearAll;
        private System.Windows.Forms.Button EISbtnMeasure;
        private System.Windows.Forms.GroupBox groupBoxShowSweepTimes;
        private System.Windows.Forms.RadioButton EISradioBtn6th;
        private System.Windows.Forms.RadioButton EISradioBtn5th;
        private System.Windows.Forms.RadioButton EISradioBtn4th;
        private System.Windows.Forms.RadioButton EISradioBtn3rd;
        private System.Windows.Forms.RadioButton EISradioBtn2nd;
        private System.Windows.Forms.RadioButton EISradioBtn1st;
        private ZedGraph.ZedGraphControl EISzedGraphControl;
        private System.Windows.Forms.GroupBox groupBoxEISResult;
        private System.Windows.Forms.ListView EISlistView;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ProgressBar statusCtrlVoltage;
        private System.Windows.Forms.Label labelVoltage2;
        private System.Windows.Forms.Label labelVoltage1;
    }
}



