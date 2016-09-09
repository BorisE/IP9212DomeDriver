namespace ASCOM.IP9212_rolloffroof3
{
    partial class SetupDialogForm
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
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.port = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.TextBox();
            this.ipaddr = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.closed_port_state_type = new System.Windows.Forms.CheckBox();
            this.opened_port_state_type = new System.Windows.Forms.CheckBox();
            this.switch_port_type = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.closedstateport = new System.Windows.Forms.TextBox();
            this.opened_port = new System.Windows.Forms.TextBox();
            this.switchport = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblDriverInfo = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.linkAviosys = new System.Windows.Forms.LinkLabel();
            this.linkAstromania = new System.Windows.Forms.LinkLabel();
            this.picAstromania = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbLang = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNetworkTimeout = new System.Windows.Forms.TextBox();
            this.txtCacheReadReduced = new System.Windows.Forms.TextBox();
            this.txtCacheRead = new System.Windows.Forms.TextBox();
            this.txtCacheConnect = new System.Windows.Forms.TextBox();
            this.chkTrace = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkSafetyCheck = new System.Windows.Forms.CheckBox();
            this.txtTelescopeDriverId = new System.Windows.Forms.TextBox();
            this.btnTelescopeChoose = new System.Windows.Forms.Button();
            this.btnTelescopeSetup = new System.Windows.Forms.Button();
            this.btnTelescopeConnect = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAstromania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdOK
            // 
            this.cmdOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdOK.Location = new System.Drawing.Point(524, 383);
            this.cmdOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(166, 46);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(708, 383);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(160, 48);
            this.cmdCancel.TabIndex = 5;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Pass";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "IP addr";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(312, 40);
            this.port.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(72, 31);
            this.port.TabIndex = 1;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(96, 140);
            this.pass.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pass.MaxLength = 14;
            this.pass.Multiline = true;
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(180, 35);
            this.pass.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(96, 90);
            this.login.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(180, 31);
            this.login.TabIndex = 2;
            // 
            // ipaddr
            // 
            this.ipaddr.Location = new System.Drawing.Point(96, 40);
            this.ipaddr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ipaddr.Name = "ipaddr";
            this.ipaddr.Size = new System.Drawing.Size(180, 31);
            this.ipaddr.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.closed_port_state_type);
            this.groupBox2.Controls.Add(this.opened_port_state_type);
            this.groupBox2.Controls.Add(this.switch_port_type);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.closedstateport);
            this.groupBox2.Controls.Add(this.opened_port);
            this.groupBox2.Controls.Add(this.switchport);
            this.groupBox2.Location = new System.Drawing.Point(22, 225);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new System.Drawing.Size(416, 206);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IP9212 settings";
            // 
            // closed_port_state_type
            // 
            this.closed_port_state_type.AutoSize = true;
            this.closed_port_state_type.Location = new System.Drawing.Point(294, 152);
            this.closed_port_state_type.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closed_port_state_type.Name = "closed_port_state_type";
            this.closed_port_state_type.Size = new System.Drawing.Size(87, 29);
            this.closed_port_state_type.TabIndex = 5;
            this.closed_port_state_type.Text = "NOff";
            this.closed_port_state_type.UseVisualStyleBackColor = true;
            // 
            // opened_port_state_type
            // 
            this.opened_port_state_type.AutoSize = true;
            this.opened_port_state_type.Location = new System.Drawing.Point(294, 102);
            this.opened_port_state_type.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.opened_port_state_type.Name = "opened_port_state_type";
            this.opened_port_state_type.Size = new System.Drawing.Size(87, 29);
            this.opened_port_state_type.TabIndex = 3;
            this.opened_port_state_type.Text = "NOff";
            this.opened_port_state_type.UseVisualStyleBackColor = true;
            // 
            // switch_port_type
            // 
            this.switch_port_type.AutoSize = true;
            this.switch_port_type.Checked = true;
            this.switch_port_type.CheckState = System.Windows.Forms.CheckState.Checked;
            this.switch_port_type.Location = new System.Drawing.Point(294, 54);
            this.switch_port_type.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.switch_port_type.Name = "switch_port_type";
            this.switch_port_type.Size = new System.Drawing.Size(87, 29);
            this.switch_port_type.TabIndex = 1;
            this.switch_port_type.Text = "NOff";
            this.switch_port_type.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Closed state port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 104);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Opened state port";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 54);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Press button port";
            // 
            // closedstateport
            // 
            this.closedstateport.Location = new System.Drawing.Point(202, 146);
            this.closedstateport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.closedstateport.Name = "closedstateport";
            this.closedstateport.Size = new System.Drawing.Size(72, 31);
            this.closedstateport.TabIndex = 4;
            // 
            // opened_port
            // 
            this.opened_port.Location = new System.Drawing.Point(204, 98);
            this.opened_port.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.opened_port.Name = "opened_port";
            this.opened_port.Size = new System.Drawing.Size(72, 31);
            this.opened_port.TabIndex = 2;
            // 
            // switchport
            // 
            this.switchport.Location = new System.Drawing.Point(204, 48);
            this.switchport.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.switchport.Name = "switchport";
            this.switchport.Size = new System.Drawing.Size(72, 31);
            this.switchport.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ipaddr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.login);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.port);
            this.groupBox1.Location = new System.Drawing.Point(22, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(416, 198);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "IP9212 device";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblDriverInfo);
            this.groupBox6.Controls.Add(this.lblVersion);
            this.groupBox6.Controls.Add(this.linkAviosys);
            this.groupBox6.Controls.Add(this.linkAstromania);
            this.groupBox6.Controls.Add(this.picAstromania);
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(462, 17);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox6.Size = new System.Drawing.Size(522, 354);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "About";
            // 
            // lblDriverInfo
            // 
            this.lblDriverInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDriverInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblDriverInfo.Location = new System.Drawing.Point(120, 27);
            this.lblDriverInfo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDriverInfo.Name = "lblDriverInfo";
            this.lblDriverInfo.Size = new System.Drawing.Size(390, 150);
            this.lblDriverInfo.TabIndex = 11;
            this.lblDriverInfo.Text = "Driver name";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblVersion.Location = new System.Drawing.Point(120, 179);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(146, 26);
            this.lblVersion.TabIndex = 2;
            this.lblVersion.Text = "Driver version";
            // 
            // linkAviosys
            // 
            this.linkAviosys.AutoSize = true;
            this.linkAviosys.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkAviosys.Location = new System.Drawing.Point(240, 308);
            this.linkAviosys.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkAviosys.Name = "linkAviosys";
            this.linkAviosys.Size = new System.Drawing.Size(188, 25);
            this.linkAviosys.TabIndex = 2;
            this.linkAviosys.TabStop = true;
            this.linkAviosys.Text = "Device by Aviosys";
            this.linkAviosys.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAviosys_LinkClicked);
            // 
            // linkAstromania
            // 
            this.linkAstromania.AutoSize = true;
            this.linkAstromania.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.linkAstromania.Location = new System.Drawing.Point(20, 306);
            this.linkAstromania.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.linkAstromania.Name = "linkAstromania";
            this.linkAstromania.Size = new System.Drawing.Size(212, 25);
            this.linkAstromania.TabIndex = 1;
            this.linkAstromania.TabStop = true;
            this.linkAstromania.Text = "Driver by Astromania";
            this.linkAstromania.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAstromania_LinkClicked);
            // 
            // picAstromania
            // 
            this.picAstromania.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picAstromania.Image = global::ASCOM.IP9212_rolloffroof3.Properties.Resources.logo_48_blue;
            this.picAstromania.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.picAstromania.Location = new System.Drawing.Point(18, 44);
            this.picAstromania.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.picAstromania.Name = "picAstromania";
            this.picAstromania.Size = new System.Drawing.Size(48, 48);
            this.picAstromania.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAstromania.TabIndex = 3;
            this.picAstromania.TabStop = false;
            this.picAstromania.Click += new System.EventHandler(this.BrowseToAstromania);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::ASCOM.IP9212_rolloffroof3.Properties.Resources.ASCOM;
            this.pictureBox1.Location = new System.Drawing.Point(18, 179);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.cmbLang);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtNetworkTimeout);
            this.groupBox4.Controls.Add(this.txtCacheReadReduced);
            this.groupBox4.Controls.Add(this.txtCacheRead);
            this.groupBox4.Controls.Add(this.txtCacheConnect);
            this.groupBox4.Controls.Add(this.chkTrace);
            this.groupBox4.Location = new System.Drawing.Point(22, 442);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox4.Size = new System.Drawing.Size(962, 281);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Advanced";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(218, 37);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Language";
            // 
            // cmbLang
            // 
            this.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLang.FormattingEnabled = true;
            this.cmbLang.Location = new System.Drawing.Point(340, 29);
            this.cmbLang.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbLang.Name = "cmbLang";
            this.cmbLang.Size = new System.Drawing.Size(260, 33);
            this.cmbLang.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(632, 227);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 25);
            this.label16.TabIndex = 11;
            this.label16.Text = "sec";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(632, 179);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "sec";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(632, 90);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 25);
            this.label11.TabIndex = 5;
            this.label11.Text = "sec";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(632, 135);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 25);
            this.label12.TabIndex = 8;
            this.label12.Text = "sec";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(14, 227);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Caching switch ouput port data during open/close for";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(14, 179);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(339, 25);
            this.label13.TabIndex = 9;
            this.label13.Text = "Caching switch ouput port data for";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(12, 90);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(166, 25);
            this.label14.TabIndex = 3;
            this.label14.Text = "Network timeout";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(12, 135);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(307, 25);
            this.label15.TabIndex = 6;
            this.label15.Text = "Caching check connections for";
            // 
            // txtNetworkTimeout
            // 
            this.txtNetworkTimeout.Location = new System.Drawing.Point(554, 85);
            this.txtNetworkTimeout.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNetworkTimeout.Name = "txtNetworkTimeout";
            this.txtNetworkTimeout.Size = new System.Drawing.Size(62, 31);
            this.txtNetworkTimeout.TabIndex = 2;
            // 
            // txtCacheReadReduced
            // 
            this.txtCacheReadReduced.Location = new System.Drawing.Point(554, 221);
            this.txtCacheReadReduced.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCacheReadReduced.Name = "txtCacheReadReduced";
            this.txtCacheReadReduced.Size = new System.Drawing.Size(62, 31);
            this.txtCacheReadReduced.TabIndex = 5;
            // 
            // txtCacheRead
            // 
            this.txtCacheRead.Location = new System.Drawing.Point(554, 173);
            this.txtCacheRead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCacheRead.Name = "txtCacheRead";
            this.txtCacheRead.Size = new System.Drawing.Size(62, 31);
            this.txtCacheRead.TabIndex = 4;
            // 
            // txtCacheConnect
            // 
            this.txtCacheConnect.Location = new System.Drawing.Point(554, 129);
            this.txtCacheConnect.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtCacheConnect.Name = "txtCacheConnect";
            this.txtCacheConnect.Size = new System.Drawing.Size(62, 31);
            this.txtCacheConnect.TabIndex = 3;
            // 
            // chkTrace
            // 
            this.chkTrace.AutoSize = true;
            this.chkTrace.Checked = true;
            this.chkTrace.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTrace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.chkTrace.Location = new System.Drawing.Point(16, 37);
            this.chkTrace.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkTrace.Name = "chkTrace";
            this.chkTrace.Size = new System.Drawing.Size(129, 29);
            this.chkTrace.TabIndex = 0;
            this.chkTrace.Text = "Trace on";
            this.chkTrace.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkSafetyCheck);
            this.groupBox3.Controls.Add(this.txtTelescopeDriverId);
            this.groupBox3.Controls.Add(this.btnTelescopeConnect);
            this.groupBox3.Controls.Add(this.btnTelescopeSetup);
            this.groupBox3.Controls.Add(this.btnTelescopeChoose);
            this.groupBox3.Location = new System.Drawing.Point(22, 735);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox3.Size = new System.Drawing.Size(962, 139);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Safety check";
            // 
            // chkSafetyCheck
            // 
            this.chkSafetyCheck.AutoSize = true;
            this.chkSafetyCheck.Checked = true;
            this.chkSafetyCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSafetyCheck.Location = new System.Drawing.Point(7, 36);
            this.chkSafetyCheck.Margin = new System.Windows.Forms.Padding(6);
            this.chkSafetyCheck.Name = "chkSafetyCheck";
            this.chkSafetyCheck.Size = new System.Drawing.Size(445, 29);
            this.chkSafetyCheck.TabIndex = 1;
            this.chkSafetyCheck.Text = "Close shutter only when telescope parked";
            this.chkSafetyCheck.UseVisualStyleBackColor = true;
            // 
            // txtTelescopeDriverId
            // 
            this.txtTelescopeDriverId.Location = new System.Drawing.Point(7, 77);
            this.txtTelescopeDriverId.Margin = new System.Windows.Forms.Padding(6);
            this.txtTelescopeDriverId.Name = "txtTelescopeDriverId";
            this.txtTelescopeDriverId.ReadOnly = true;
            this.txtTelescopeDriverId.Size = new System.Drawing.Size(427, 31);
            this.txtTelescopeDriverId.TabIndex = 2;
            // 
            // btnTelescopeChoose
            // 
            this.btnTelescopeChoose.Location = new System.Drawing.Point(450, 69);
            this.btnTelescopeChoose.Margin = new System.Windows.Forms.Padding(6);
            this.btnTelescopeChoose.Name = "btnTelescopeChoose";
            this.btnTelescopeChoose.Size = new System.Drawing.Size(166, 46);
            this.btnTelescopeChoose.TabIndex = 4;
            this.btnTelescopeChoose.Text = "Choose";
            this.btnTelescopeChoose.UseVisualStyleBackColor = true;
            this.btnTelescopeChoose.Click += new System.EventHandler(this.btnTelescopeChoose_Click);
            // 
            // btnTelescopeSetup
            // 
            this.btnTelescopeSetup.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTelescopeSetup.Location = new System.Drawing.Point(628, 69);
            this.btnTelescopeSetup.Margin = new System.Windows.Forms.Padding(6);
            this.btnTelescopeSetup.Name = "btnTelescopeSetup";
            this.btnTelescopeSetup.Size = new System.Drawing.Size(166, 46);
            this.btnTelescopeSetup.TabIndex = 4;
            this.btnTelescopeSetup.Text = "Setup";
            this.btnTelescopeSetup.UseVisualStyleBackColor = true;
            this.btnTelescopeSetup.Click += new System.EventHandler(this.btnTelescopeSetup_Click);
            // 
            // btnTelescopeConnect
            // 
            this.btnTelescopeConnect.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnTelescopeConnect.Location = new System.Drawing.Point(806, 69);
            this.btnTelescopeConnect.Margin = new System.Windows.Forms.Padding(6);
            this.btnTelescopeConnect.Name = "btnTelescopeConnect";
            this.btnTelescopeConnect.Size = new System.Drawing.Size(145, 46);
            this.btnTelescopeConnect.TabIndex = 4;
            this.btnTelescopeConnect.Text = "Connect";
            this.btnTelescopeConnect.UseVisualStyleBackColor = true;
            this.btnTelescopeConnect.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // SetupDialogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 889);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetupDialogForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IP9212_rolloffroof2 Setup";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAstromania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox ipaddr;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox closed_port_state_type;
        private System.Windows.Forms.CheckBox opened_port_state_type;
        private System.Windows.Forms.CheckBox switch_port_type;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox closedstateport;
        private System.Windows.Forms.TextBox opened_port;
        private System.Windows.Forms.TextBox switchport;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkAviosys;
        private System.Windows.Forms.LinkLabel linkAstromania;
        private System.Windows.Forms.PictureBox picAstromania;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbLang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNetworkTimeout;
        private System.Windows.Forms.TextBox txtCacheRead;
        private System.Windows.Forms.TextBox txtCacheConnect;
        private System.Windows.Forms.CheckBox chkTrace;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCacheReadReduced;
        private System.Windows.Forms.Label lblDriverInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkSafetyCheck;
        private System.Windows.Forms.TextBox txtTelescopeDriverId;
        private System.Windows.Forms.Button btnTelescopeConnect;
        private System.Windows.Forms.Button btnTelescopeSetup;
        private System.Windows.Forms.Button btnTelescopeChoose;
    }
}