namespace Scanner
{
    partial class Scanner
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxLogs = new System.Windows.Forms.RichTextBox();
            this.radioButtonUEBand = new System.Windows.Forms.RadioButton();
            this.radioButtonChineeseBand = new System.Windows.Forms.RadioButton();
            this.radioButtonChineeseBand2 = new System.Windows.Forms.RadioButton();
            this.radioButtonUSBand = new System.Windows.Forms.RadioButton();
            this.checkBoxRegionSingle = new System.Windows.Forms.CheckBox();
            this.buttonSetRegion = new System.Windows.Forms.Button();
            this.labelMaxfre = new System.Windows.Forms.Label();
            this.labelMinfre = new System.Windows.Forms.Label();
            this.comboBoxDminfre = new System.Windows.Forms.ComboBox();
            this.comboBoxDmaxfre = new System.Windows.Forms.ComboBox();
            this.buttonSetBaudRate = new System.Windows.Forms.Button();
            this.comboBoxSetBaudRate = new System.Windows.Forms.ComboBox();
            this.labeldBM = new System.Windows.Forms.Label();
            this.buttonSetPower = new System.Windows.Forms.Button();
            this.comboBoxPower = new System.Windows.Forms.ComboBox();
            this.buttonGetBuffLength = new System.Windows.Forms.Button();
            this.radioButton496bitBuff = new System.Windows.Forms.RadioButton();
            this.radioButton128bitBuff = new System.Windows.Forms.RadioButton();
            this.buttonSetBufferLength = new System.Windows.Forms.Button();
            this.radioButtonBeepClose = new System.Windows.Forms.RadioButton();
            this.radioButtonBeepOpen = new System.Windows.Forms.RadioButton();
            this.buttonBeepSet = new System.Windows.Forms.Button();
            this.textBoxFirmwareVersion = new System.Windows.Forms.TextBox();
            this.checkBoxINT2 = new System.Windows.Forms.CheckBox();
            this.checkBoxINT1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOUT2 = new System.Windows.Forms.CheckBox();
            this.checkBoxOUT1 = new System.Windows.Forms.CheckBox();
            this.buttonGetGPIO = new System.Windows.Forms.Button();
            this.buttonSetGPIO = new System.Windows.Forms.Button();
            this.textBoxReaderSerialNumber = new System.Windows.Forms.TextBox();
            this.buttonReadSerial = new System.Windows.Forms.Button();
            this.textBoxReaderAddress = new System.Windows.Forms.TextBox();
            this.buttonSetReaderAddress = new System.Windows.Forms.Button();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.groupBoxRegion = new System.Windows.Forms.GroupBox();
            this.groupBoxBaudRate = new System.Windows.Forms.GroupBox();
            this.groupBoxPower = new System.Windows.Forms.GroupBox();
            this.groupBoxBufferLength = new System.Windows.Forms.GroupBox();
            this.groupBoxBeep = new System.Windows.Forms.GroupBox();
            this.groupBoxFirmwareVersion = new System.Windows.Forms.GroupBox();
            this.groupBoxOperationGPIO = new System.Windows.Forms.GroupBox();
            this.groupBoxReaderSerialNumber = new System.Windows.Forms.GroupBox();
            this.groupBoxReaderAddress = new System.Windows.Forms.GroupBox();
            this.groupBoxRS232 = new System.Windows.Forms.GroupBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.ScanTimer = new System.Windows.Forms.Timer(this.components);
            this.labelMaxScanTime = new System.Windows.Forms.Label();
            this.comboBoxScanTime = new System.Windows.Forms.ComboBox();
            this.groupBoxRegion.SuspendLayout();
            this.groupBoxBaudRate.SuspendLayout();
            this.groupBoxPower.SuspendLayout();
            this.groupBoxBufferLength.SuspendLayout();
            this.groupBoxBeep.SuspendLayout();
            this.groupBoxFirmwareVersion.SuspendLayout();
            this.groupBoxOperationGPIO.SuspendLayout();
            this.groupBoxReaderSerialNumber.SuspendLayout();
            this.groupBoxReaderAddress.SuspendLayout();
            this.groupBoxRS232.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRefresh.Location = new System.Drawing.Point(562, 408);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(96, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = false;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(31, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operation records:";
            // 
            // richTextBoxLogs
            // 
            this.richTextBoxLogs.Location = new System.Drawing.Point(12, 434);
            this.richTextBoxLogs.Name = "richTextBoxLogs";
            this.richTextBoxLogs.Size = new System.Drawing.Size(658, 96);
            this.richTextBoxLogs.TabIndex = 5;
            this.richTextBoxLogs.Text = "";
            // 
            // radioButtonUEBand
            // 
            this.radioButtonUEBand.AutoSize = true;
            this.radioButtonUEBand.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUEBand.Location = new System.Drawing.Point(225, 52);
            this.radioButtonUEBand.Name = "radioButtonUEBand";
            this.radioButtonUEBand.Size = new System.Drawing.Size(80, 21);
            this.radioButtonUEBand.TabIndex = 2;
            this.radioButtonUEBand.TabStop = true;
            this.radioButtonUEBand.Text = "EU band";
            this.radioButtonUEBand.UseVisualStyleBackColor = true;
            // 
            // radioButtonChineeseBand
            // 
            this.radioButtonChineeseBand.AutoSize = true;
            this.radioButtonChineeseBand.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonChineeseBand.Location = new System.Drawing.Point(46, 51);
            this.radioButtonChineeseBand.Name = "radioButtonChineeseBand";
            this.radioButtonChineeseBand.Size = new System.Drawing.Size(124, 21);
            this.radioButtonChineeseBand.TabIndex = 2;
            this.radioButtonChineeseBand.TabStop = true;
            this.radioButtonChineeseBand.Text = "Chineese band";
            this.radioButtonChineeseBand.UseVisualStyleBackColor = true;
            // 
            // radioButtonChineeseBand2
            // 
            this.radioButtonChineeseBand2.AutoSize = true;
            this.radioButtonChineeseBand2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonChineeseBand2.Location = new System.Drawing.Point(46, 22);
            this.radioButtonChineeseBand2.Name = "radioButtonChineeseBand2";
            this.radioButtonChineeseBand2.Size = new System.Drawing.Size(131, 21);
            this.radioButtonChineeseBand2.TabIndex = 2;
            this.radioButtonChineeseBand2.TabStop = true;
            this.radioButtonChineeseBand2.Text = "Chineese band2";
            this.radioButtonChineeseBand2.UseVisualStyleBackColor = true;
            // 
            // radioButtonUSBand
            // 
            this.radioButtonUSBand.AutoSize = true;
            this.radioButtonUSBand.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonUSBand.Location = new System.Drawing.Point(226, 22);
            this.radioButtonUSBand.Name = "radioButtonUSBand";
            this.radioButtonUSBand.Size = new System.Drawing.Size(79, 21);
            this.radioButtonUSBand.TabIndex = 2;
            this.radioButtonUSBand.TabStop = true;
            this.radioButtonUSBand.Text = "US band";
            this.radioButtonUSBand.UseVisualStyleBackColor = true;
            // 
            // checkBoxRegionSingle
            // 
            this.checkBoxRegionSingle.AutoSize = true;
            this.checkBoxRegionSingle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxRegionSingle.Location = new System.Drawing.Point(550, 19);
            this.checkBoxRegionSingle.Name = "checkBoxRegionSingle";
            this.checkBoxRegionSingle.Size = new System.Drawing.Size(64, 21);
            this.checkBoxRegionSingle.TabIndex = 2;
            this.checkBoxRegionSingle.Text = "Single";
            this.checkBoxRegionSingle.UseVisualStyleBackColor = true;
            // 
            // buttonSetRegion
            // 
            this.buttonSetRegion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonSetRegion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetRegion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetRegion.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSetRegion.Location = new System.Drawing.Point(550, 51);
            this.buttonSetRegion.Name = "buttonSetRegion";
            this.buttonSetRegion.Size = new System.Drawing.Size(96, 23);
            this.buttonSetRegion.TabIndex = 1;
            this.buttonSetRegion.Text = "Set";
            this.buttonSetRegion.UseVisualStyleBackColor = false;
            this.buttonSetRegion.Click += new System.EventHandler(this.buttonSetRegion_Click);
            // 
            // labelMaxfre
            // 
            this.labelMaxfre.AutoSize = true;
            this.labelMaxfre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxfre.Location = new System.Drawing.Point(338, 54);
            this.labelMaxfre.Name = "labelMaxfre";
            this.labelMaxfre.Size = new System.Drawing.Size(54, 17);
            this.labelMaxfre.TabIndex = 3;
            this.labelMaxfre.Text = "Maxfre:";
            // 
            // labelMinfre
            // 
            this.labelMinfre.AutoSize = true;
            this.labelMinfre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMinfre.Location = new System.Drawing.Point(339, 24);
            this.labelMinfre.Name = "labelMinfre";
            this.labelMinfre.Size = new System.Drawing.Size(50, 17);
            this.labelMinfre.TabIndex = 3;
            this.labelMinfre.Text = "Minfre:";
            // 
            // comboBoxDminfre
            // 
            this.comboBoxDminfre.FormattingEnabled = true;
            this.comboBoxDminfre.Location = new System.Drawing.Point(409, 17);
            this.comboBoxDminfre.Name = "comboBoxDminfre";
            this.comboBoxDminfre.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDminfre.TabIndex = 2;
            // 
            // comboBoxDmaxfre
            // 
            this.comboBoxDmaxfre.FormattingEnabled = true;
            this.comboBoxDmaxfre.Location = new System.Drawing.Point(409, 50);
            this.comboBoxDmaxfre.Name = "comboBoxDmaxfre";
            this.comboBoxDmaxfre.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDmaxfre.TabIndex = 2;
            // 
            // buttonSetBaudRate
            // 
            this.buttonSetBaudRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonSetBaudRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetBaudRate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetBaudRate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSetBaudRate.Location = new System.Drawing.Point(216, 22);
            this.buttonSetBaudRate.Name = "buttonSetBaudRate";
            this.buttonSetBaudRate.Size = new System.Drawing.Size(96, 23);
            this.buttonSetBaudRate.TabIndex = 1;
            this.buttonSetBaudRate.Text = "Set";
            this.buttonSetBaudRate.UseVisualStyleBackColor = false;
            this.buttonSetBaudRate.Click += new System.EventHandler(this.buttonSetBaudRate_Click);
            // 
            // comboBoxSetBaudRate
            // 
            this.comboBoxSetBaudRate.FormattingEnabled = true;
            this.comboBoxSetBaudRate.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.comboBoxSetBaudRate.Location = new System.Drawing.Point(89, 22);
            this.comboBoxSetBaudRate.Name = "comboBoxSetBaudRate";
            this.comboBoxSetBaudRate.Size = new System.Drawing.Size(121, 24);
            this.comboBoxSetBaudRate.TabIndex = 2;
            // 
            // labeldBM
            // 
            this.labeldBM.AutoSize = true;
            this.labeldBM.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labeldBM.Location = new System.Drawing.Point(173, 28);
            this.labeldBM.Name = "labeldBM";
            this.labeldBM.Size = new System.Drawing.Size(37, 17);
            this.labeldBM.TabIndex = 3;
            this.labeldBM.Text = "dBm";
            // 
            // buttonSetPower
            // 
            this.buttonSetPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonSetPower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetPower.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetPower.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSetPower.Location = new System.Drawing.Point(216, 22);
            this.buttonSetPower.Name = "buttonSetPower";
            this.buttonSetPower.Size = new System.Drawing.Size(96, 23);
            this.buttonSetPower.TabIndex = 1;
            this.buttonSetPower.Text = "Set";
            this.buttonSetPower.UseVisualStyleBackColor = false;
            this.buttonSetPower.Click += new System.EventHandler(this.buttonSetPower_Click);
            // 
            // comboBoxPower
            // 
            this.comboBoxPower.FormattingEnabled = true;
            this.comboBoxPower.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26"});
            this.comboBoxPower.Location = new System.Drawing.Point(46, 25);
            this.comboBoxPower.Name = "comboBoxPower";
            this.comboBoxPower.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPower.TabIndex = 2;
            // 
            // buttonGetBuffLength
            // 
            this.buttonGetBuffLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonGetBuffLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetBuffLength.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetBuffLength.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGetBuffLength.Location = new System.Drawing.Point(100, 52);
            this.buttonGetBuffLength.Name = "buttonGetBuffLength";
            this.buttonGetBuffLength.Size = new System.Drawing.Size(96, 23);
            this.buttonGetBuffLength.TabIndex = 1;
            this.buttonGetBuffLength.Text = "Get";
            this.buttonGetBuffLength.UseVisualStyleBackColor = false;
            this.buttonGetBuffLength.Click += new System.EventHandler(this.buttonGetBuffLength_Click);
            // 
            // radioButton496bitBuff
            // 
            this.radioButton496bitBuff.AutoSize = true;
            this.radioButton496bitBuff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton496bitBuff.Location = new System.Drawing.Point(19, 51);
            this.radioButton496bitBuff.Name = "radioButton496bitBuff";
            this.radioButton496bitBuff.Size = new System.Drawing.Size(64, 21);
            this.radioButton496bitBuff.TabIndex = 2;
            this.radioButton496bitBuff.Text = "496bit";
            this.radioButton496bitBuff.UseVisualStyleBackColor = true;
            // 
            // radioButton128bitBuff
            // 
            this.radioButton128bitBuff.AutoSize = true;
            this.radioButton128bitBuff.Checked = true;
            this.radioButton128bitBuff.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton128bitBuff.Location = new System.Drawing.Point(19, 24);
            this.radioButton128bitBuff.Name = "radioButton128bitBuff";
            this.radioButton128bitBuff.Size = new System.Drawing.Size(64, 21);
            this.radioButton128bitBuff.TabIndex = 2;
            this.radioButton128bitBuff.TabStop = true;
            this.radioButton128bitBuff.Text = "128bit";
            this.radioButton128bitBuff.UseVisualStyleBackColor = true;
            // 
            // buttonSetBufferLength
            // 
            this.buttonSetBufferLength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonSetBufferLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetBufferLength.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetBufferLength.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSetBufferLength.Location = new System.Drawing.Point(100, 23);
            this.buttonSetBufferLength.Name = "buttonSetBufferLength";
            this.buttonSetBufferLength.Size = new System.Drawing.Size(96, 23);
            this.buttonSetBufferLength.TabIndex = 1;
            this.buttonSetBufferLength.Text = "Set";
            this.buttonSetBufferLength.UseVisualStyleBackColor = false;
            this.buttonSetBufferLength.Click += new System.EventHandler(this.buttonSetBufferLength_Click);
            // 
            // radioButtonBeepClose
            // 
            this.radioButtonBeepClose.AutoSize = true;
            this.radioButtonBeepClose.Checked = true;
            this.radioButtonBeepClose.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonBeepClose.Location = new System.Drawing.Point(19, 50);
            this.radioButtonBeepClose.Name = "radioButtonBeepClose";
            this.radioButtonBeepClose.Size = new System.Drawing.Size(62, 21);
            this.radioButtonBeepClose.TabIndex = 2;
            this.radioButtonBeepClose.TabStop = true;
            this.radioButtonBeepClose.Text = "Close";
            this.radioButtonBeepClose.UseVisualStyleBackColor = true;
            // 
            // radioButtonBeepOpen
            // 
            this.radioButtonBeepOpen.AutoSize = true;
            this.radioButtonBeepOpen.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButtonBeepOpen.Location = new System.Drawing.Point(19, 24);
            this.radioButtonBeepOpen.Name = "radioButtonBeepOpen";
            this.radioButtonBeepOpen.Size = new System.Drawing.Size(62, 21);
            this.radioButtonBeepOpen.TabIndex = 2;
            this.radioButtonBeepOpen.Text = "Open";
            this.radioButtonBeepOpen.UseVisualStyleBackColor = true;
            // 
            // buttonBeepSet
            // 
            this.buttonBeepSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonBeepSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBeepSet.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBeepSet.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonBeepSet.Location = new System.Drawing.Point(87, 24);
            this.buttonBeepSet.Name = "buttonBeepSet";
            this.buttonBeepSet.Size = new System.Drawing.Size(96, 23);
            this.buttonBeepSet.TabIndex = 1;
            this.buttonBeepSet.Text = "Set";
            this.buttonBeepSet.UseVisualStyleBackColor = false;
            this.buttonBeepSet.Click += new System.EventHandler(this.buttonBeepSet_Click);
            // 
            // textBoxFirmwareVersion
            // 
            this.textBoxFirmwareVersion.Location = new System.Drawing.Point(16, 35);
            this.textBoxFirmwareVersion.Name = "textBoxFirmwareVersion";
            this.textBoxFirmwareVersion.Size = new System.Drawing.Size(205, 23);
            this.textBoxFirmwareVersion.TabIndex = 2;
            // 
            // checkBoxINT2
            // 
            this.checkBoxINT2.AutoSize = true;
            this.checkBoxINT2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxINT2.Location = new System.Drawing.Point(152, 51);
            this.checkBoxINT2.Name = "checkBoxINT2";
            this.checkBoxINT2.Size = new System.Drawing.Size(52, 21);
            this.checkBoxINT2.TabIndex = 2;
            this.checkBoxINT2.Text = "INT2";
            this.checkBoxINT2.UseVisualStyleBackColor = true;
            // 
            // checkBoxINT1
            // 
            this.checkBoxINT1.AutoSize = true;
            this.checkBoxINT1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxINT1.Location = new System.Drawing.Point(89, 51);
            this.checkBoxINT1.Name = "checkBoxINT1";
            this.checkBoxINT1.Size = new System.Drawing.Size(52, 21);
            this.checkBoxINT1.TabIndex = 2;
            this.checkBoxINT1.Text = "INT1";
            this.checkBoxINT1.UseVisualStyleBackColor = true;
            // 
            // checkBoxOUT2
            // 
            this.checkBoxOUT2.AutoSize = true;
            this.checkBoxOUT2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxOUT2.Location = new System.Drawing.Point(152, 24);
            this.checkBoxOUT2.Name = "checkBoxOUT2";
            this.checkBoxOUT2.Size = new System.Drawing.Size(58, 21);
            this.checkBoxOUT2.TabIndex = 2;
            this.checkBoxOUT2.Text = "OUT2";
            this.checkBoxOUT2.UseVisualStyleBackColor = true;
            // 
            // checkBoxOUT1
            // 
            this.checkBoxOUT1.AutoSize = true;
            this.checkBoxOUT1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkBoxOUT1.Location = new System.Drawing.Point(88, 24);
            this.checkBoxOUT1.Name = "checkBoxOUT1";
            this.checkBoxOUT1.Size = new System.Drawing.Size(58, 21);
            this.checkBoxOUT1.TabIndex = 2;
            this.checkBoxOUT1.Text = "OUT1";
            this.checkBoxOUT1.UseVisualStyleBackColor = true;
            // 
            // buttonGetGPIO
            // 
            this.buttonGetGPIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonGetGPIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGetGPIO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGetGPIO.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGetGPIO.Location = new System.Drawing.Point(216, 49);
            this.buttonGetGPIO.Name = "buttonGetGPIO";
            this.buttonGetGPIO.Size = new System.Drawing.Size(96, 23);
            this.buttonGetGPIO.TabIndex = 1;
            this.buttonGetGPIO.Text = "Get";
            this.buttonGetGPIO.UseVisualStyleBackColor = false;
            this.buttonGetGPIO.Click += new System.EventHandler(this.buttonGetGPIO_Click);
            // 
            // buttonSetGPIO
            // 
            this.buttonSetGPIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonSetGPIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetGPIO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetGPIO.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSetGPIO.Location = new System.Drawing.Point(216, 20);
            this.buttonSetGPIO.Name = "buttonSetGPIO";
            this.buttonSetGPIO.Size = new System.Drawing.Size(96, 23);
            this.buttonSetGPIO.TabIndex = 1;
            this.buttonSetGPIO.Text = "Set";
            this.buttonSetGPIO.UseVisualStyleBackColor = false;
            this.buttonSetGPIO.Click += new System.EventHandler(this.buttonSetGPIO_Click);
            // 
            // textBoxReaderSerialNumber
            // 
            this.textBoxReaderSerialNumber.Location = new System.Drawing.Point(89, 26);
            this.textBoxReaderSerialNumber.Name = "textBoxReaderSerialNumber";
            this.textBoxReaderSerialNumber.Size = new System.Drawing.Size(121, 23);
            this.textBoxReaderSerialNumber.TabIndex = 2;
            // 
            // buttonReadSerial
            // 
            this.buttonReadSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonReadSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReadSerial.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonReadSerial.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReadSerial.Location = new System.Drawing.Point(216, 26);
            this.buttonReadSerial.Name = "buttonReadSerial";
            this.buttonReadSerial.Size = new System.Drawing.Size(96, 23);
            this.buttonReadSerial.TabIndex = 1;
            this.buttonReadSerial.Text = "Read";
            this.buttonReadSerial.UseVisualStyleBackColor = false;
            this.buttonReadSerial.Click += new System.EventHandler(this.buttonReadSerial_Click);
            // 
            // textBoxReaderAddress
            // 
            this.textBoxReaderAddress.Location = new System.Drawing.Point(89, 26);
            this.textBoxReaderAddress.Name = "textBoxReaderAddress";
            this.textBoxReaderAddress.Size = new System.Drawing.Size(121, 23);
            this.textBoxReaderAddress.TabIndex = 2;
            this.textBoxReaderAddress.Text = "00";
            // 
            // buttonSetReaderAddress
            // 
            this.buttonSetReaderAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonSetReaderAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSetReaderAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSetReaderAddress.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSetReaderAddress.Location = new System.Drawing.Point(216, 26);
            this.buttonSetReaderAddress.Name = "buttonSetReaderAddress";
            this.buttonSetReaderAddress.Size = new System.Drawing.Size(96, 23);
            this.buttonSetReaderAddress.TabIndex = 1;
            this.buttonSetReaderAddress.Text = "Set";
            this.buttonSetReaderAddress.UseVisualStyleBackColor = false;
            this.buttonSetReaderAddress.Click += new System.EventHandler(this.buttonSetReaderAddress_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonConnect.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonConnect.Location = new System.Drawing.Point(216, 21);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(96, 23);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = false;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBaudRate.Location = new System.Drawing.Point(12, 57);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(75, 17);
            this.labelBaudRate.TabIndex = 3;
            this.labelBaudRate.Text = "Baud rate:";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisconnect.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDisconnect.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDisconnect.Location = new System.Drawing.Point(216, 54);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(96, 23);
            this.buttonDisconnect.TabIndex = 1;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = false;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPort.Location = new System.Drawing.Point(15, 24);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(38, 17);
            this.labelPort.TabIndex = 3;
            this.labelPort.Text = "Port:";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9"});
            this.comboBoxCOM.Location = new System.Drawing.Point(89, 21);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 24);
            this.comboBoxCOM.TabIndex = 2;
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.comboBoxBaud.Location = new System.Drawing.Point(89, 54);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(121, 24);
            this.comboBoxBaud.TabIndex = 2;
            // 
            // groupBoxRegion
            // 
            this.groupBoxRegion.Controls.Add(this.radioButtonUEBand);
            this.groupBoxRegion.Controls.Add(this.radioButtonChineeseBand);
            this.groupBoxRegion.Controls.Add(this.radioButtonChineeseBand2);
            this.groupBoxRegion.Controls.Add(this.radioButtonUSBand);
            this.groupBoxRegion.Controls.Add(this.checkBoxRegionSingle);
            this.groupBoxRegion.Controls.Add(this.buttonSetRegion);
            this.groupBoxRegion.Controls.Add(this.labelMaxfre);
            this.groupBoxRegion.Controls.Add(this.labelMinfre);
            this.groupBoxRegion.Controls.Add(this.comboBoxDminfre);
            this.groupBoxRegion.Controls.Add(this.comboBoxDmaxfre);
            this.groupBoxRegion.Enabled = false;
            this.groupBoxRegion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRegion.Location = new System.Drawing.Point(12, 222);
            this.groupBoxRegion.Name = "groupBoxRegion";
            this.groupBoxRegion.Size = new System.Drawing.Size(658, 87);
            this.groupBoxRegion.TabIndex = 4;
            this.groupBoxRegion.TabStop = false;
            this.groupBoxRegion.Text = "Region";
            // 
            // groupBoxBaudRate
            // 
            this.groupBoxBaudRate.Controls.Add(this.buttonSetBaudRate);
            this.groupBoxBaudRate.Controls.Add(this.comboBoxSetBaudRate);
            this.groupBoxBaudRate.Enabled = false;
            this.groupBoxBaudRate.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBaudRate.Location = new System.Drawing.Point(346, 161);
            this.groupBoxBaudRate.Name = "groupBoxBaudRate";
            this.groupBoxBaudRate.Size = new System.Drawing.Size(324, 60);
            this.groupBoxBaudRate.TabIndex = 4;
            this.groupBoxBaudRate.TabStop = false;
            this.groupBoxBaudRate.Text = "RS232/485 baud rate";
            // 
            // groupBoxPower
            // 
            this.groupBoxPower.Controls.Add(this.labeldBM);
            this.groupBoxPower.Controls.Add(this.buttonSetPower);
            this.groupBoxPower.Controls.Add(this.comboBoxPower);
            this.groupBoxPower.Enabled = false;
            this.groupBoxPower.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxPower.Location = new System.Drawing.Point(12, 161);
            this.groupBoxPower.Name = "groupBoxPower";
            this.groupBoxPower.Size = new System.Drawing.Size(324, 60);
            this.groupBoxPower.TabIndex = 4;
            this.groupBoxPower.TabStop = false;
            this.groupBoxPower.Text = "Power";
            // 
            // groupBoxBufferLength
            // 
            this.groupBoxBufferLength.Controls.Add(this.buttonGetBuffLength);
            this.groupBoxBufferLength.Controls.Add(this.radioButton496bitBuff);
            this.groupBoxBufferLength.Controls.Add(this.radioButton128bitBuff);
            this.groupBoxBufferLength.Controls.Add(this.buttonSetBufferLength);
            this.groupBoxBufferLength.Enabled = false;
            this.groupBoxBufferLength.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBufferLength.Location = new System.Drawing.Point(12, 309);
            this.groupBoxBufferLength.Name = "groupBoxBufferLength";
            this.groupBoxBufferLength.Size = new System.Drawing.Size(210, 87);
            this.groupBoxBufferLength.TabIndex = 4;
            this.groupBoxBufferLength.TabStop = false;
            this.groupBoxBufferLength.Text = "Buffer EPC/TID length";
            // 
            // groupBoxBeep
            // 
            this.groupBoxBeep.Controls.Add(this.radioButtonBeepClose);
            this.groupBoxBeep.Controls.Add(this.radioButtonBeepOpen);
            this.groupBoxBeep.Controls.Add(this.buttonBeepSet);
            this.groupBoxBeep.Enabled = false;
            this.groupBoxBeep.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxBeep.Location = new System.Drawing.Point(228, 310);
            this.groupBoxBeep.Name = "groupBoxBeep";
            this.groupBoxBeep.Size = new System.Drawing.Size(194, 86);
            this.groupBoxBeep.TabIndex = 4;
            this.groupBoxBeep.TabStop = false;
            this.groupBoxBeep.Text = "Beep";
            // 
            // groupBoxFirmwareVersion
            // 
            this.groupBoxFirmwareVersion.Controls.Add(this.textBoxFirmwareVersion);
            this.groupBoxFirmwareVersion.Enabled = false;
            this.groupBoxFirmwareVersion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxFirmwareVersion.Location = new System.Drawing.Point(435, 310);
            this.groupBoxFirmwareVersion.Name = "groupBoxFirmwareVersion";
            this.groupBoxFirmwareVersion.Size = new System.Drawing.Size(235, 86);
            this.groupBoxFirmwareVersion.TabIndex = 4;
            this.groupBoxFirmwareVersion.TabStop = false;
            this.groupBoxFirmwareVersion.Text = "Firmware version";
            // 
            // groupBoxOperationGPIO
            // 
            this.groupBoxOperationGPIO.Controls.Add(this.checkBoxINT2);
            this.groupBoxOperationGPIO.Controls.Add(this.checkBoxINT1);
            this.groupBoxOperationGPIO.Controls.Add(this.checkBoxOUT2);
            this.groupBoxOperationGPIO.Controls.Add(this.checkBoxOUT1);
            this.groupBoxOperationGPIO.Controls.Add(this.buttonGetGPIO);
            this.groupBoxOperationGPIO.Controls.Add(this.buttonSetGPIO);
            this.groupBoxOperationGPIO.Enabled = false;
            this.groupBoxOperationGPIO.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxOperationGPIO.Location = new System.Drawing.Point(346, 12);
            this.groupBoxOperationGPIO.Name = "groupBoxOperationGPIO";
            this.groupBoxOperationGPIO.Size = new System.Drawing.Size(324, 87);
            this.groupBoxOperationGPIO.TabIndex = 4;
            this.groupBoxOperationGPIO.TabStop = false;
            this.groupBoxOperationGPIO.Text = "GPIO Operation";
            // 
            // groupBoxReaderSerialNumber
            // 
            this.groupBoxReaderSerialNumber.Controls.Add(this.textBoxReaderSerialNumber);
            this.groupBoxReaderSerialNumber.Controls.Add(this.buttonReadSerial);
            this.groupBoxReaderSerialNumber.Enabled = false;
            this.groupBoxReaderSerialNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxReaderSerialNumber.Location = new System.Drawing.Point(346, 100);
            this.groupBoxReaderSerialNumber.Name = "groupBoxReaderSerialNumber";
            this.groupBoxReaderSerialNumber.Size = new System.Drawing.Size(324, 60);
            this.groupBoxReaderSerialNumber.TabIndex = 4;
            this.groupBoxReaderSerialNumber.TabStop = false;
            this.groupBoxReaderSerialNumber.Text = "Reader serial number";
            // 
            // groupBoxReaderAddress
            // 
            this.groupBoxReaderAddress.Controls.Add(this.textBoxReaderAddress);
            this.groupBoxReaderAddress.Controls.Add(this.buttonSetReaderAddress);
            this.groupBoxReaderAddress.Enabled = false;
            this.groupBoxReaderAddress.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxReaderAddress.Location = new System.Drawing.Point(12, 100);
            this.groupBoxReaderAddress.Name = "groupBoxReaderAddress";
            this.groupBoxReaderAddress.Size = new System.Drawing.Size(324, 60);
            this.groupBoxReaderAddress.TabIndex = 4;
            this.groupBoxReaderAddress.TabStop = false;
            this.groupBoxReaderAddress.Text = "Reader address";
            // 
            // groupBoxRS232
            // 
            this.groupBoxRS232.Controls.Add(this.buttonConnect);
            this.groupBoxRS232.Controls.Add(this.labelBaudRate);
            this.groupBoxRS232.Controls.Add(this.buttonDisconnect);
            this.groupBoxRS232.Controls.Add(this.labelPort);
            this.groupBoxRS232.Controls.Add(this.comboBoxCOM);
            this.groupBoxRS232.Controls.Add(this.comboBoxBaud);
            this.groupBoxRS232.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxRS232.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRS232.Name = "groupBoxRS232";
            this.groupBoxRS232.Size = new System.Drawing.Size(324, 87);
            this.groupBoxRS232.TabIndex = 4;
            this.groupBoxRS232.TabStop = false;
            this.groupBoxRS232.Text = "RS232";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(53)))), ((int)(((byte)(60)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStart.Location = new System.Drawing.Point(451, 408);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(96, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // ScanTimer
            // 
            this.ScanTimer.Tick += new System.EventHandler(this.ScanTimer_Tick);
            // 
            // labelMaxScanTime
            // 
            this.labelMaxScanTime.AutoSize = true;
            this.labelMaxScanTime.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMaxScanTime.Location = new System.Drawing.Point(228, 411);
            this.labelMaxScanTime.Name = "labelMaxScanTime";
            this.labelMaxScanTime.Size = new System.Drawing.Size(106, 17);
            this.labelMaxScanTime.TabIndex = 3;
            this.labelMaxScanTime.Text = "Max-Scan Time:";
            // 
            // comboBoxScanTime
            // 
            this.comboBoxScanTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxScanTime.FormattingEnabled = true;
            this.comboBoxScanTime.Location = new System.Drawing.Point(346, 408);
            this.comboBoxScanTime.Name = "comboBoxScanTime";
            this.comboBoxScanTime.Size = new System.Drawing.Size(93, 23);
            this.comboBoxScanTime.TabIndex = 2;
            this.comboBoxScanTime.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 548);
            this.Controls.Add(this.comboBoxScanTime);
            this.Controls.Add(this.labelMaxScanTime);
            this.Controls.Add(this.groupBoxRS232);
            this.Controls.Add(this.groupBoxReaderAddress);
            this.Controls.Add(this.groupBoxReaderSerialNumber);
            this.Controls.Add(this.groupBoxOperationGPIO);
            this.Controls.Add(this.groupBoxFirmwareVersion);
            this.Controls.Add(this.groupBoxBeep);
            this.Controls.Add(this.groupBoxBufferLength);
            this.Controls.Add(this.groupBoxPower);
            this.Controls.Add(this.groupBoxBaudRate);
            this.Controls.Add(this.groupBoxRegion);
            this.Controls.Add(this.richTextBoxLogs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonRefresh);
            this.Name = "Scanner";
            this.Text = "Scanner";
            this.Load += new System.EventHandler(this.Scanner_Load);
            this.groupBoxRegion.ResumeLayout(false);
            this.groupBoxRegion.PerformLayout();
            this.groupBoxBaudRate.ResumeLayout(false);
            this.groupBoxPower.ResumeLayout(false);
            this.groupBoxPower.PerformLayout();
            this.groupBoxBufferLength.ResumeLayout(false);
            this.groupBoxBufferLength.PerformLayout();
            this.groupBoxBeep.ResumeLayout(false);
            this.groupBoxBeep.PerformLayout();
            this.groupBoxFirmwareVersion.ResumeLayout(false);
            this.groupBoxFirmwareVersion.PerformLayout();
            this.groupBoxOperationGPIO.ResumeLayout(false);
            this.groupBoxOperationGPIO.PerformLayout();
            this.groupBoxReaderSerialNumber.ResumeLayout(false);
            this.groupBoxReaderSerialNumber.PerformLayout();
            this.groupBoxReaderAddress.ResumeLayout(false);
            this.groupBoxReaderAddress.PerformLayout();
            this.groupBoxRS232.ResumeLayout(false);
            this.groupBoxRS232.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxLogs;
        private System.Windows.Forms.RadioButton radioButtonUEBand;
        private System.Windows.Forms.RadioButton radioButtonChineeseBand;
        private System.Windows.Forms.RadioButton radioButtonChineeseBand2;
        private System.Windows.Forms.RadioButton radioButtonUSBand;
        private System.Windows.Forms.CheckBox checkBoxRegionSingle;
        private System.Windows.Forms.Button buttonSetRegion;
        private System.Windows.Forms.Label labelMaxfre;
        private System.Windows.Forms.Label labelMinfre;
        private System.Windows.Forms.ComboBox comboBoxDminfre;
        private System.Windows.Forms.ComboBox comboBoxDmaxfre;
        private System.Windows.Forms.Button buttonSetBaudRate;
        private System.Windows.Forms.ComboBox comboBoxSetBaudRate;
        private System.Windows.Forms.Label labeldBM;
        private System.Windows.Forms.Button buttonSetPower;
        private System.Windows.Forms.ComboBox comboBoxPower;
        private System.Windows.Forms.Button buttonGetBuffLength;
        private System.Windows.Forms.RadioButton radioButton496bitBuff;
        private System.Windows.Forms.RadioButton radioButton128bitBuff;
        private System.Windows.Forms.Button buttonSetBufferLength;
        private System.Windows.Forms.RadioButton radioButtonBeepClose;
        private System.Windows.Forms.RadioButton radioButtonBeepOpen;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxINT2;
        private System.Windows.Forms.CheckBox checkBoxINT1;
        private System.Windows.Forms.CheckBox checkBoxOUT2;
        private System.Windows.Forms.CheckBox checkBoxOUT1;
        private System.Windows.Forms.Button buttonGetGPIO;
        private System.Windows.Forms.Button buttonSetGPIO;
        private System.Windows.Forms.TextBox textBoxReaderSerialNumber;
        private System.Windows.Forms.Button buttonReadSerial;
        private System.Windows.Forms.TextBox textBoxReaderAddress;
        private System.Windows.Forms.Button buttonSetReaderAddress;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.GroupBox groupBoxRegion;
        private System.Windows.Forms.GroupBox groupBoxBaudRate;
        private System.Windows.Forms.GroupBox groupBoxPower;
        private System.Windows.Forms.GroupBox groupBoxBufferLength;
        private System.Windows.Forms.GroupBox groupBoxBeep;
        private System.Windows.Forms.GroupBox groupBoxFirmwareVersion;
        private System.Windows.Forms.GroupBox groupBoxOperationGPIO;
        private System.Windows.Forms.GroupBox groupBoxReaderSerialNumber;
        private System.Windows.Forms.GroupBox groupBoxReaderAddress;
        private System.Windows.Forms.GroupBox groupBoxRS232;
        private System.Windows.Forms.Button buttonBeepSet;
        private System.Windows.Forms.TextBox textBoxFirmwareVersion;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Timer ScanTimer;
        private System.Windows.Forms.Label labelMaxScanTime;
        private System.Windows.Forms.ComboBox comboBoxScanTime;
    }
}

