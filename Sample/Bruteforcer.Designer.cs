namespace Bruteforcer
{
	partial class Bruteforcer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bruteforcer));
			this.textBoxLog = new System.Windows.Forms.TextBox();
			this.darkGroupBox1 = new DarkUI.Controls.DarkGroupBox();
			this.comboBoxJ2534Devices = new DarkUI.Controls.DarkComboBox();
			this.detectInstalledJ2534DevicesButton = new DarkUI.Controls.DarkButton();
			this.darkGroupBox2 = new DarkUI.Controls.DarkGroupBox();
			this.darkLabel1 = new DarkUI.Controls.DarkLabel();
			this.darkLabel2 = new DarkUI.Controls.DarkLabel();
			this.darkMenuStrip1 = new DarkUI.Controls.DarkMenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCANLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clearDeviceLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.j2534ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.detectDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.supportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.darkDockPanel1 = new DarkUI.Docking.DarkDockPanel();
			this.darkSectionPanel1 = new DarkUI.Controls.DarkSectionPanel();
			this.darkSectionPanel2 = new DarkUI.Controls.DarkSectionPanel();
			this.checkBoxFEPS = new DarkUI.Controls.DarkCheckBox();
			this.darkLabel7 = new DarkUI.Controls.DarkLabel();
			this.comboBoxCanbus = new DarkUI.Controls.DarkComboBox();
			this.darkLabel6 = new DarkUI.Controls.DarkLabel();
			this.darkLabel4 = new DarkUI.Controls.DarkLabel();
			this.textBoxEcuId = new DarkUI.Controls.DarkTextBox();
			this.darkLabel3 = new DarkUI.Controls.DarkLabel();
			this.comboBoxDiagSess = new DarkUI.Controls.DarkComboBox();
			this.darkSectionPanel6 = new DarkUI.Controls.DarkSectionPanel();
			this.pictureBox11 = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.labelCnc = new DarkUI.Controls.DarkLabel();
			this.labelSeedFound = new DarkUI.Controls.DarkLabel();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.darkLabel8 = new DarkUI.Controls.DarkLabel();
			this.textBoxSeed = new DarkUI.Controls.DarkTextBox();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.darkStatusStrip1 = new DarkUI.Controls.DarkStatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.darkLabel9 = new DarkUI.Controls.DarkLabel();
			this.darkGroupBox1.SuspendLayout();
			this.darkGroupBox2.SuspendLayout();
			this.darkMenuStrip1.SuspendLayout();
			this.darkSectionPanel1.SuspendLayout();
			this.darkSectionPanel2.SuspendLayout();
			this.darkSectionPanel6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
			this.darkStatusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxLog
			// 
			this.textBoxLog.BackColor = System.Drawing.Color.Black;
			this.textBoxLog.ForeColor = System.Drawing.Color.Aquamarine;
			this.textBoxLog.Location = new System.Drawing.Point(0, 19);
			this.textBoxLog.Multiline = true;
			this.textBoxLog.Name = "textBoxLog";
			this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxLog.Size = new System.Drawing.Size(235, 248);
			this.textBoxLog.TabIndex = 1;
			// 
			// darkGroupBox1
			// 
			this.darkGroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.darkGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.darkGroupBox1.Controls.Add(this.comboBoxJ2534Devices);
			this.darkGroupBox1.Controls.Add(this.detectInstalledJ2534DevicesButton);
			this.darkGroupBox1.Location = new System.Drawing.Point(12, 40);
			this.darkGroupBox1.Name = "darkGroupBox1";
			this.darkGroupBox1.Size = new System.Drawing.Size(392, 61);
			this.darkGroupBox1.TabIndex = 180;
			this.darkGroupBox1.TabStop = false;
			this.darkGroupBox1.Text = "J2534 Device Connection";
			// 
			// comboBoxJ2534Devices
			// 
			this.comboBoxJ2534Devices.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.comboBoxJ2534Devices.FormattingEnabled = true;
			this.comboBoxJ2534Devices.Location = new System.Drawing.Point(195, 26);
			this.comboBoxJ2534Devices.Name = "comboBoxJ2534Devices";
			this.comboBoxJ2534Devices.Size = new System.Drawing.Size(180, 21);
			this.comboBoxJ2534Devices.TabIndex = 171;
			// 
			// detectInstalledJ2534DevicesButton
			// 
			this.detectInstalledJ2534DevicesButton.Location = new System.Drawing.Point(12, 26);
			this.detectInstalledJ2534DevicesButton.Name = "detectInstalledJ2534DevicesButton";
			this.detectInstalledJ2534DevicesButton.Padding = new System.Windows.Forms.Padding(5);
			this.detectInstalledJ2534DevicesButton.Size = new System.Drawing.Size(177, 23);
			this.detectInstalledJ2534DevicesButton.TabIndex = 169;
			this.detectInstalledJ2534DevicesButton.Text = "Detect Installed J2534 Devices";
			this.detectInstalledJ2534DevicesButton.Click += new System.EventHandler(this.CmdDetectDevicesClick);
			// 
			// darkGroupBox2
			// 
			this.darkGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
			this.darkGroupBox2.Controls.Add(this.textBoxLog);
			this.darkGroupBox2.Location = new System.Drawing.Point(672, 28);
			this.darkGroupBox2.Name = "darkGroupBox2";
			this.darkGroupBox2.Size = new System.Drawing.Size(235, 267);
			this.darkGroupBox2.TabIndex = 181;
			this.darkGroupBox2.TabStop = false;
			this.darkGroupBox2.Text = "J2534 Log";
			// 
			// darkLabel1
			// 
			this.darkLabel1.AutoSize = true;
			this.darkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel1.Location = new System.Drawing.Point(990, 40);
			this.darkLabel1.Name = "darkLabel1";
			this.darkLabel1.Size = new System.Drawing.Size(181, 16);
			this.darkLabel1.TabIndex = 184;
			this.darkLabel1.Text = "Ford ECU Bruteforcer v1.0.2";
			// 
			// darkLabel2
			// 
			this.darkLabel2.AutoSize = true;
			this.darkLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel2.Location = new System.Drawing.Point(1056, 56);
			this.darkLabel2.Name = "darkLabel2";
			this.darkLabel2.Size = new System.Drawing.Size(114, 14);
			this.darkLabel2.TabIndex = 185;
			this.darkLabel2.Text = "0x27 Security Access";
			// 
			// darkMenuStrip1
			// 
			this.darkMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkMenuStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.j2534ToolStripMenuItem,
            this.supportToolStripMenuItem});
			this.darkMenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.darkMenuStrip1.Name = "darkMenuStrip1";
			this.darkMenuStrip1.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
			this.darkMenuStrip1.Size = new System.Drawing.Size(1180, 24);
			this.darkMenuStrip1.TabIndex = 188;
			this.darkMenuStrip1.Text = "darkMenuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCANLogToolStripMenuItem,
            this.clearDeviceLogToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveCANLogToolStripMenuItem
			// 
			this.saveCANLogToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.saveCANLogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.saveCANLogToolStripMenuItem.Name = "saveCANLogToolStripMenuItem";
			this.saveCANLogToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.saveCANLogToolStripMenuItem.Text = "Save Device Log";
			this.saveCANLogToolStripMenuItem.Click += new System.EventHandler(this.saveDeviceLogButton_Click);
			// 
			// clearDeviceLogToolStripMenuItem
			// 
			this.clearDeviceLogToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.clearDeviceLogToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.clearDeviceLogToolStripMenuItem.Name = "clearDeviceLogToolStripMenuItem";
			this.clearDeviceLogToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.clearDeviceLogToolStripMenuItem.Text = "Clear Device Log";
			this.clearDeviceLogToolStripMenuItem.Click += new System.EventHandler(this.CmdDetectDevicesClick);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// j2534ToolStripMenuItem
			// 
			this.j2534ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.j2534ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detectDevicesToolStripMenuItem,
            this.connectToolStripMenuItem});
			this.j2534ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.j2534ToolStripMenuItem.Name = "j2534ToolStripMenuItem";
			this.j2534ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.j2534ToolStripMenuItem.Text = "J2534";
			// 
			// detectDevicesToolStripMenuItem
			// 
			this.detectDevicesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.detectDevicesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.detectDevicesToolStripMenuItem.Name = "detectDevicesToolStripMenuItem";
			this.detectDevicesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.detectDevicesToolStripMenuItem.Text = "Detect Devices";
			this.detectDevicesToolStripMenuItem.Click += new System.EventHandler(this.CmdDetectDevicesClick);
			// 
			// connectToolStripMenuItem
			// 
			this.connectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.connectToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
			this.connectToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
			this.connectToolStripMenuItem.Text = "Connect";
			// 
			// supportToolStripMenuItem
			// 
			this.supportToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.supportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem,
            this.viewLicenseToolStripMenuItem});
			this.supportToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.supportToolStripMenuItem.Name = "supportToolStripMenuItem";
			this.supportToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
			this.supportToolStripMenuItem.Text = "Information";
			// 
			// informationToolStripMenuItem
			// 
			this.informationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.informationToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
			this.informationToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.informationToolStripMenuItem.Text = "Technical Support";
			this.informationToolStripMenuItem.Click += new System.EventHandler(this.supportInfoToolStripMenuItem_Click);
			// 
			// viewLicenseToolStripMenuItem
			// 
			this.viewLicenseToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.viewLicenseToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.viewLicenseToolStripMenuItem.Name = "viewLicenseToolStripMenuItem";
			this.viewLicenseToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
			this.viewLicenseToolStripMenuItem.Text = "View License";
			this.viewLicenseToolStripMenuItem.Click += new System.EventHandler(this.viewLicenseToolStripMenuItem_Click);
			// 
			// darkDockPanel1
			// 
			this.darkDockPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkDockPanel1.Location = new System.Drawing.Point(-18, 0);
			this.darkDockPanel1.Name = "darkDockPanel1";
			this.darkDockPanel1.Size = new System.Drawing.Size(1603, 845);
			this.darkDockPanel1.TabIndex = 189;
			// 
			// darkSectionPanel1
			// 
			this.darkSectionPanel1.Controls.Add(this.darkGroupBox1);
			this.darkSectionPanel1.Controls.Add(this.darkLabel1);
			this.darkSectionPanel1.Controls.Add(this.darkLabel2);
			this.darkSectionPanel1.Location = new System.Drawing.Point(0, 28);
			this.darkSectionPanel1.Name = "darkSectionPanel1";
			this.darkSectionPanel1.SectionHeader = null;
			this.darkSectionPanel1.Size = new System.Drawing.Size(1180, 115);
			this.darkSectionPanel1.TabIndex = 190;
			// 
			// darkSectionPanel2
			// 
			this.darkSectionPanel2.Controls.Add(this.darkLabel9);
			this.darkSectionPanel2.Controls.Add(this.checkBoxFEPS);
			this.darkSectionPanel2.Controls.Add(this.darkLabel7);
			this.darkSectionPanel2.Controls.Add(this.comboBoxCanbus);
			this.darkSectionPanel2.Controls.Add(this.darkLabel6);
			this.darkSectionPanel2.Controls.Add(this.darkLabel4);
			this.darkSectionPanel2.Controls.Add(this.textBoxEcuId);
			this.darkSectionPanel2.Controls.Add(this.darkLabel3);
			this.darkSectionPanel2.Controls.Add(this.comboBoxDiagSess);
			this.darkSectionPanel2.Location = new System.Drawing.Point(12, 149);
			this.darkSectionPanel2.Name = "darkSectionPanel2";
			this.darkSectionPanel2.SectionHeader = null;
			this.darkSectionPanel2.Size = new System.Drawing.Size(245, 295);
			this.darkSectionPanel2.TabIndex = 191;
			// 
			// checkBoxFEPS
			// 
			this.checkBoxFEPS.AutoSize = true;
			this.checkBoxFEPS.Location = new System.Drawing.Point(25, 182);
			this.checkBoxFEPS.Name = "checkBoxFEPS";
			this.checkBoxFEPS.Size = new System.Drawing.Size(142, 17);
			this.checkBoxFEPS.TabIndex = 175;
			this.checkBoxFEPS.Text = "FEPS 18 Volts on Pin 13";
			// 
			// darkLabel7
			// 
			this.darkLabel7.AutoSize = true;
			this.darkLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel7.Location = new System.Drawing.Point(4, 37);
			this.darkLabel7.Name = "darkLabel7";
			this.darkLabel7.Size = new System.Drawing.Size(122, 13);
			this.darkLabel7.TabIndex = 174;
			this.darkLabel7.Text = "Controller Area Network:";
			// 
			// comboBoxCanbus
			// 
			this.comboBoxCanbus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.comboBoxCanbus.FormattingEnabled = true;
			this.comboBoxCanbus.Items.AddRange(new object[] {
            "MidSpeed CAN ",
            "High Speed CAN"});
			this.comboBoxCanbus.Location = new System.Drawing.Point(19, 55);
			this.comboBoxCanbus.Name = "comboBoxCanbus";
			this.comboBoxCanbus.Size = new System.Drawing.Size(216, 21);
			this.comboBoxCanbus.TabIndex = 173;
			// 
			// darkLabel6
			// 
			this.darkLabel6.AutoSize = true;
			this.darkLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel6.Location = new System.Drawing.Point(82, 151);
			this.darkLabel6.Name = "darkLabel6";
			this.darkLabel6.Size = new System.Drawing.Size(20, 13);
			this.darkLabel6.TabIndex = 25;
			this.darkLabel6.Text = "Ox";
			// 
			// darkLabel4
			// 
			this.darkLabel4.AutoSize = true;
			this.darkLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel4.Location = new System.Drawing.Point(4, 133);
			this.darkLabel4.Name = "darkLabel4";
			this.darkLabel4.Size = new System.Drawing.Size(155, 13);
			this.darkLabel4.TabIndex = 24;
			this.darkLabel4.Text = "Hex ECU Address(CAN ID RX):";
			// 
			// textBoxEcuId
			// 
			this.textBoxEcuId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.textBoxEcuId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxEcuId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.textBoxEcuId.Location = new System.Drawing.Point(102, 149);
			this.textBoxEcuId.MaxLength = 3;
			this.textBoxEcuId.Name = "textBoxEcuId";
			this.textBoxEcuId.Size = new System.Drawing.Size(65, 20);
			this.textBoxEcuId.TabIndex = 23;
			// 
			// darkLabel3
			// 
			this.darkLabel3.AutoSize = true;
			this.darkLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel3.Location = new System.Drawing.Point(4, 82);
			this.darkLabel3.Name = "darkLabel3";
			this.darkLabel3.Size = new System.Drawing.Size(136, 13);
			this.darkLabel3.TabIndex = 22;
			this.darkLabel3.Text = "Diagnostic Session Control:";
			// 
			// comboBoxDiagSess
			// 
			this.comboBoxDiagSess.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.comboBoxDiagSess.FormattingEnabled = true;
			this.comboBoxDiagSess.Items.AddRange(new object[] {
            "0x1081 standardDiagnosticSession",
            "0x1083 ecuAdjustmentSession",
            "0x1085 ecuProgrammingSession",
            "0x1087 ecuAdjustmentSession",
            "0x10FE eolExtendedSession",
            "0x10FA systemSupplierSpecific",
            "0x1001 standardDiagnosticsUDS",
            "0x1002 ecuProgrammingSessionUDS",
            "0x1003 ecuAdjustmentSessionUDS"});
			this.comboBoxDiagSess.Location = new System.Drawing.Point(20, 100);
			this.comboBoxDiagSess.Name = "comboBoxDiagSess";
			this.comboBoxDiagSess.Size = new System.Drawing.Size(216, 21);
			this.comboBoxDiagSess.TabIndex = 21;
			// 
			// darkSectionPanel6
			// 
			this.darkSectionPanel6.Controls.Add(this.pictureBox11);
			this.darkSectionPanel6.Controls.Add(this.button1);
			this.darkSectionPanel6.Controls.Add(this.labelCnc);
			this.darkSectionPanel6.Controls.Add(this.labelSeedFound);
			this.darkSectionPanel6.Controls.Add(this.progressBar1);
			this.darkSectionPanel6.Controls.Add(this.darkLabel8);
			this.darkSectionPanel6.Controls.Add(this.textBoxSeed);
			this.darkSectionPanel6.Controls.Add(this.darkGroupBox2);
			this.darkSectionPanel6.Location = new System.Drawing.Point(263, 149);
			this.darkSectionPanel6.Name = "darkSectionPanel6";
			this.darkSectionPanel6.SectionHeader = null;
			this.darkSectionPanel6.Size = new System.Drawing.Size(923, 295);
			this.darkSectionPanel6.TabIndex = 192;
			// 
			// pictureBox11
			// 
			this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
			this.pictureBox11.Location = new System.Drawing.Point(13, 28);
			this.pictureBox11.Name = "pictureBox11";
			this.pictureBox11.Size = new System.Drawing.Size(231, 213);
			this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox11.TabIndex = 186;
			this.pictureBox11.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Crimson;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button1.Location = new System.Drawing.Point(321, 61);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(271, 46);
			this.button1.TabIndex = 185;
			this.button1.Text = "Bruteforce ECU";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.darkButton1_Click);
			// 
			// labelCnc
			// 
			this.labelCnc.AutoSize = true;
			this.labelCnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelCnc.ForeColor = System.Drawing.Color.Crimson;
			this.labelCnc.Location = new System.Drawing.Point(396, 203);
			this.labelCnc.Name = "labelCnc";
			this.labelCnc.Size = new System.Drawing.Size(155, 13);
			this.labelCnc.TabIndex = 184;
			this.labelCnc.Text = "CONDITIONS NOT CORRECT";
			this.labelCnc.Visible = false;
			// 
			// labelSeedFound
			// 
			this.labelSeedFound.AutoSize = true;
			this.labelSeedFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.labelSeedFound.ForeColor = System.Drawing.Color.Lime;
			this.labelSeedFound.Location = new System.Drawing.Point(417, 204);
			this.labelSeedFound.Name = "labelSeedFound";
			this.labelSeedFound.Size = new System.Drawing.Size(119, 13);
			this.labelSeedFound.TabIndex = 183;
			this.labelSeedFound.Text = "FOUND UNLOCK KEY!";
			this.labelSeedFound.Visible = false;
			// 
			// progressBar1
			// 
			this.progressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.progressBar1.Location = new System.Drawing.Point(13, 262);
			this.progressBar1.Maximum = 483;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(653, 17);
			this.progressBar1.Step = 1;
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 182;
			// 
			// darkLabel8
			// 
			this.darkLabel8.AutoSize = true;
			this.darkLabel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkLabel8.Location = new System.Drawing.Point(330, 166);
			this.darkLabel8.Name = "darkLabel8";
			this.darkLabel8.Size = new System.Drawing.Size(65, 13);
			this.darkLabel8.TabIndex = 175;
			this.darkLabel8.Text = "Unlock Key:";
			// 
			// textBoxSeed
			// 
			this.textBoxSeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
			this.textBoxSeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.textBoxSeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.textBoxSeed.Location = new System.Drawing.Point(397, 164);
			this.textBoxSeed.MaxLength = 3;
			this.textBoxSeed.Name = "textBoxSeed";
			this.textBoxSeed.Size = new System.Drawing.Size(154, 20);
			this.textBoxSeed.TabIndex = 175;
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "log";
			this.saveFileDialog1.FileName = "CANbus Log";
			// 
			// fileSystemWatcher1
			// 
			this.fileSystemWatcher1.EnableRaisingEvents = true;
			this.fileSystemWatcher1.SynchronizingObject = this;
			// 
			// darkStatusStrip1
			// 
			this.darkStatusStrip1.AutoSize = false;
			this.darkStatusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
			this.darkStatusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.darkStatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.darkStatusStrip1.Location = new System.Drawing.Point(0, 445);
			this.darkStatusStrip1.Name = "darkStatusStrip1";
			this.darkStatusStrip1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 3);
			this.darkStatusStrip1.Size = new System.Drawing.Size(1180, 34);
			this.darkStatusStrip1.SizingGrip = false;
			this.darkStatusStrip1.TabIndex = 195;
			this.darkStatusStrip1.Text = "darkStatusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(377, 21);
			this.toolStripStatusLabel1.Text = "Tester Present Specialist Automotive Solutions  -  testerPresent.com.au";
			// 
			// darkLabel9
			// 
			this.darkLabel9.AutoSize = true;
			this.darkLabel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.darkLabel9.ForeColor = System.Drawing.Color.Aqua;
			this.darkLabel9.Location = new System.Drawing.Point(-1, 7);
			this.darkLabel9.Name = "darkLabel9";
			this.darkLabel9.Size = new System.Drawing.Size(242, 13);
			this.darkLabel9.TabIndex = 176;
			this.darkLabel9.Text = "Select your CAN bus and Diagnostic Session type";
			// 
			// Bruteforcer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1180, 479);
			this.Controls.Add(this.darkStatusStrip1);
			this.Controls.Add(this.darkSectionPanel6);
			this.Controls.Add(this.darkSectionPanel2);
			this.Controls.Add(this.darkSectionPanel1);
			this.Controls.Add(this.darkMenuStrip1);
			this.Controls.Add(this.darkDockPanel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Bruteforcer";
			this.Text = "Ford ECU Bruteforcer";
			this.darkGroupBox1.ResumeLayout(false);
			this.darkGroupBox2.ResumeLayout(false);
			this.darkGroupBox2.PerformLayout();
			this.darkMenuStrip1.ResumeLayout(false);
			this.darkMenuStrip1.PerformLayout();
			this.darkSectionPanel1.ResumeLayout(false);
			this.darkSectionPanel1.PerformLayout();
			this.darkSectionPanel2.ResumeLayout(false);
			this.darkSectionPanel2.PerformLayout();
			this.darkSectionPanel6.ResumeLayout(false);
			this.darkSectionPanel6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
			this.darkStatusStrip1.ResumeLayout(false);
			this.darkStatusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxLog;
		private DarkUI.Controls.DarkGroupBox darkGroupBox1;
		private DarkUI.Controls.DarkGroupBox darkGroupBox2;
		private DarkUI.Controls.DarkLabel darkLabel1;
		private DarkUI.Controls.DarkLabel darkLabel2;
		private DarkUI.Controls.DarkMenuStrip darkMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveCANLogToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem j2534ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem detectDevicesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem supportToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
		private DarkUI.Docking.DarkDockPanel darkDockPanel1;
		private DarkUI.Controls.DarkSectionPanel darkSectionPanel1;
		private DarkUI.Controls.DarkSectionPanel darkSectionPanel2;
		private DarkUI.Controls.DarkComboBox comboBoxJ2534Devices;
		private DarkUI.Controls.DarkButton detectInstalledJ2534DevicesButton;
		private DarkUI.Controls.DarkSectionPanel darkSectionPanel6;
		private System.Windows.Forms.ToolStripMenuItem viewLicenseToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.IO.FileSystemWatcher fileSystemWatcher1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private DarkUI.Controls.DarkStatusStrip darkStatusStrip1;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripMenuItem clearDeviceLogToolStripMenuItem;
		private DarkUI.Controls.DarkLabel darkLabel6;
		private DarkUI.Controls.DarkLabel darkLabel4;
		private DarkUI.Controls.DarkTextBox textBoxEcuId;
		private DarkUI.Controls.DarkLabel darkLabel3;
		private DarkUI.Controls.DarkComboBox comboBoxDiagSess;
		private DarkUI.Controls.DarkLabel darkLabel7;
		private DarkUI.Controls.DarkComboBox comboBoxCanbus;
		private DarkUI.Controls.DarkLabel labelSeedFound;
		private System.Windows.Forms.ProgressBar progressBar1;
		private DarkUI.Controls.DarkLabel darkLabel8;
		private DarkUI.Controls.DarkTextBox textBoxSeed;
		private DarkUI.Controls.DarkLabel labelCnc;
		private DarkUI.Controls.DarkCheckBox checkBoxFEPS;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox11;
		private DarkUI.Controls.DarkLabel darkLabel9;
	}
}

