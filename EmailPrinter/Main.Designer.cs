namespace EmailPrinter
{
    partial class Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabCtrlAbout = new MetroFramework.Controls.MetroTabControl();
            this.tabMain = new MetroFramework.Controls.MetroTabPage();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.dgvEmails = new MetroFramework.Controls.MetroGrid();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessageDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.htmlBody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmailDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Printed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabSettings = new MetroFramework.Controls.MetroTabPage();
            this.txtLicence = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel18 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel17 = new MetroFramework.Controls.MetroLabel();
            this.btnSaveSettings = new MetroFramework.Controls.MetroButton();
            this.txtInterval = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtTimeOut = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbxSSL = new MetroFramework.Controls.MetroCheckBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPort = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtImapServer = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tabAbout = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblLastCheckTime = new MetroFramework.Controls.MetroLabel();
            this.btnRunnow = new MetroFramework.Controls.MetroButton();
            this.tabCtrlAbout.SuspendLayout();
            this.tabMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).BeginInit();
            this.tabSettings.SuspendLayout();
            this.tabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlAbout
            // 
            this.tabCtrlAbout.Controls.Add(this.tabMain);
            this.tabCtrlAbout.Controls.Add(this.tabSettings);
            this.tabCtrlAbout.Controls.Add(this.tabAbout);
            this.tabCtrlAbout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlAbout.Location = new System.Drawing.Point(20, 60);
            this.tabCtrlAbout.Name = "tabCtrlAbout";
            this.tabCtrlAbout.SelectedIndex = 2;
            this.tabCtrlAbout.Size = new System.Drawing.Size(651, 297);
            this.tabCtrlAbout.TabIndex = 0;
            this.tabCtrlAbout.UseSelectable = true;
            this.tabCtrlAbout.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.metroProgressBar1);
            this.tabMain.Controls.Add(this.dgvEmails);
            this.tabMain.HorizontalScrollbarBarColor = true;
            this.tabMain.HorizontalScrollbarHighlightOnWheel = false;
            this.tabMain.HorizontalScrollbarSize = 10;
            this.tabMain.Location = new System.Drawing.Point(4, 38);
            this.tabMain.Name = "tabMain";
            this.tabMain.Size = new System.Drawing.Size(643, 255);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "E-Mails";
            this.tabMain.VerticalScrollbarBarColor = true;
            this.tabMain.VerticalScrollbarHighlightOnWheel = false;
            this.tabMain.VerticalScrollbarSize = 10;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(6, 111);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroProgressBar1.MinimumSize = new System.Drawing.Size(583, 10);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Blocks;
            this.metroProgressBar1.Size = new System.Drawing.Size(633, 25);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.TabIndex = 24;
            this.metroProgressBar1.UseWaitCursor = true;
            // 
            // dgvEmails
            // 
            this.dgvEmails.AllowUserToAddRows = false;
            this.dgvEmails.AllowUserToDeleteRows = false;
            this.dgvEmails.AllowUserToResizeRows = false;
            this.dgvEmails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvEmails.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmails.ColumnHeadersHeight = 30;
            this.dgvEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.emailId,
            this.Subject,
            this.MessageDetails,
            this.htmlBody,
            this.From,
            this.EmailDate,
            this.Printed,
            this.Print});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmails.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmails.EnableHeadersVisualStyles = false;
            this.dgvEmails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvEmails.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvEmails.HighLightPercentage = 0.5F;
            this.dgvEmails.Location = new System.Drawing.Point(6, 3);
            this.dgvEmails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvEmails.MultiSelect = false;
            this.dgvEmails.Name = "dgvEmails";
            this.dgvEmails.ReadOnly = true;
            this.dgvEmails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmails.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEmails.RowHeadersVisible = false;
            this.dgvEmails.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmails.Size = new System.Drawing.Size(633, 249);
            this.dgvEmails.TabIndex = 2;
            this.dgvEmails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmails_CellClick);
            // 
            // index
            // 
            this.index.DataPropertyName = "index";
            this.index.HeaderText = "Index";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            this.index.Width = 50;
            // 
            // emailId
            // 
            this.emailId.DataPropertyName = "emailId";
            this.emailId.HeaderText = "E-Mail-ID";
            this.emailId.Name = "emailId";
            this.emailId.ReadOnly = true;
            this.emailId.Visible = false;
            // 
            // Subject
            // 
            this.Subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Subject.DataPropertyName = "Subject";
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            this.Subject.ReadOnly = true;
            // 
            // MessageDetails
            // 
            this.MessageDetails.DataPropertyName = "MessageDetails";
            this.MessageDetails.HeaderText = "Message Details";
            this.MessageDetails.Name = "MessageDetails";
            this.MessageDetails.ReadOnly = true;
            this.MessageDetails.Width = 110;
            // 
            // htmlBody
            // 
            this.htmlBody.DataPropertyName = "htmlBody";
            this.htmlBody.HeaderText = "htmlBody";
            this.htmlBody.Name = "htmlBody";
            this.htmlBody.ReadOnly = true;
            this.htmlBody.Visible = false;
            // 
            // From
            // 
            this.From.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.From.DataPropertyName = "From";
            this.From.HeaderText = "From";
            this.From.Name = "From";
            this.From.ReadOnly = true;
            // 
            // EmailDate
            // 
            this.EmailDate.DataPropertyName = "EmailDate";
            this.EmailDate.HeaderText = "Email Date";
            this.EmailDate.Name = "EmailDate";
            this.EmailDate.ReadOnly = true;
            // 
            // Printed
            // 
            this.Printed.DataPropertyName = "Printed";
            dataGridViewCellStyle2.NullValue = "0";
            this.Printed.DefaultCellStyle = dataGridViewCellStyle2;
            this.Printed.HeaderText = "Printed";
            this.Printed.Name = "Printed";
            this.Printed.ReadOnly = true;
            this.Printed.Visible = false;
            // 
            // Print
            // 
            this.Print.FillWeight = 40F;
            this.Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Print.HeaderText = "Print";
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Text = "Print";
            this.Print.UseColumnTextForButtonValue = true;
            this.Print.Width = 50;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.txtLicence);
            this.tabSettings.Controls.Add(this.metroLabel18);
            this.tabSettings.Controls.Add(this.metroLabel17);
            this.tabSettings.Controls.Add(this.btnSaveSettings);
            this.tabSettings.Controls.Add(this.txtInterval);
            this.tabSettings.Controls.Add(this.metroLabel6);
            this.tabSettings.Controls.Add(this.txtTimeOut);
            this.tabSettings.Controls.Add(this.metroLabel5);
            this.tabSettings.Controls.Add(this.cbxSSL);
            this.tabSettings.Controls.Add(this.txtPassword);
            this.tabSettings.Controls.Add(this.metroLabel4);
            this.tabSettings.Controls.Add(this.txtUserName);
            this.tabSettings.Controls.Add(this.metroLabel3);
            this.tabSettings.Controls.Add(this.txtPort);
            this.tabSettings.Controls.Add(this.metroLabel1);
            this.tabSettings.Controls.Add(this.txtImapServer);
            this.tabSettings.Controls.Add(this.metroLabel2);
            this.tabSettings.HorizontalScrollbarBarColor = true;
            this.tabSettings.HorizontalScrollbarHighlightOnWheel = false;
            this.tabSettings.HorizontalScrollbarSize = 10;
            this.tabSettings.Location = new System.Drawing.Point(4, 38);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(643, 255);
            this.tabSettings.TabIndex = 1;
            this.tabSettings.Text = "Settings";
            this.tabSettings.VerticalScrollbarBarColor = true;
            this.tabSettings.VerticalScrollbarHighlightOnWheel = false;
            this.tabSettings.VerticalScrollbarSize = 10;
            // 
            // txtLicence
            // 
            // 
            // 
            // 
            this.txtLicence.CustomButton.Image = null;
            this.txtLicence.CustomButton.Location = new System.Drawing.Point(236, 2);
            this.txtLicence.CustomButton.Name = "";
            this.txtLicence.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtLicence.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLicence.CustomButton.TabIndex = 1;
            this.txtLicence.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLicence.CustomButton.UseSelectable = true;
            this.txtLicence.CustomButton.Visible = false;
            this.txtLicence.IconRight = true;
            this.txtLicence.Lines = new string[0];
            this.txtLicence.Location = new System.Drawing.Point(175, 117);
            this.txtLicence.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLicence.MaxLength = 32767;
            this.txtLicence.Name = "txtLicence";
            this.txtLicence.PasswordChar = '\0';
            this.txtLicence.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLicence.SelectedText = "";
            this.txtLicence.SelectionLength = 0;
            this.txtLicence.SelectionStart = 0;
            this.txtLicence.ShortcutsEnabled = true;
            this.txtLicence.Size = new System.Drawing.Size(258, 24);
            this.txtLicence.TabIndex = 15;
            this.txtLicence.UseSelectable = true;
            this.txtLicence.UseStyleColors = true;
            this.txtLicence.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLicence.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel18
            // 
            this.metroLabel18.AutoSize = true;
            this.metroLabel18.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel18.Location = new System.Drawing.Point(4, 117);
            this.metroLabel18.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel18.Name = "metroLabel18";
            this.metroLabel18.Size = new System.Drawing.Size(162, 19);
            this.metroLabel18.TabIndex = 14;
            this.metroLabel18.Text = "Mail Subject filter for Print";
            this.metroLabel18.UseStyleColors = true;
            // 
            // metroLabel17
            // 
            this.metroLabel17.AutoSize = true;
            this.metroLabel17.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel17.Location = new System.Drawing.Point(334, 85);
            this.metroLabel17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel17.Name = "metroLabel17";
            this.metroLabel17.Size = new System.Drawing.Size(78, 19);
            this.metroLabel17.TabIndex = 12;
            this.metroLabel17.Text = "Get Minutes";
            this.metroLabel17.UseStyleColors = true;
            // 
            // btnSaveSettings
            // 
            this.btnSaveSettings.Highlight = true;
            this.btnSaveSettings.Location = new System.Drawing.Point(441, 117);
            this.btnSaveSettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSaveSettings.Name = "btnSaveSettings";
            this.btnSaveSettings.Size = new System.Drawing.Size(122, 24);
            this.btnSaveSettings.TabIndex = 16;
            this.btnSaveSettings.Text = "Save";
            this.btnSaveSettings.UseSelectable = true;
            this.btnSaveSettings.Click += new System.EventHandler(this.btnSaveSettings_Click);
            // 
            // txtInterval
            // 
            // 
            // 
            // 
            this.txtInterval.CustomButton.Image = null;
            this.txtInterval.CustomButton.Location = new System.Drawing.Point(26, 2);
            this.txtInterval.CustomButton.Name = "";
            this.txtInterval.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtInterval.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtInterval.CustomButton.TabIndex = 1;
            this.txtInterval.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtInterval.CustomButton.UseSelectable = true;
            this.txtInterval.CustomButton.Visible = false;
            this.txtInterval.IconRight = true;
            this.txtInterval.Lines = new string[0];
            this.txtInterval.Location = new System.Drawing.Point(278, 85);
            this.txtInterval.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtInterval.MaxLength = 32767;
            this.txtInterval.Name = "txtInterval";
            this.txtInterval.PasswordChar = '\0';
            this.txtInterval.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtInterval.SelectedText = "";
            this.txtInterval.SelectionLength = 0;
            this.txtInterval.SelectionStart = 0;
            this.txtInterval.ShortcutsEnabled = true;
            this.txtInterval.Size = new System.Drawing.Size(48, 24);
            this.txtInterval.TabIndex = 11;
            this.txtInterval.UseSelectable = true;
            this.txtInterval.UseStyleColors = true;
            this.txtInterval.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtInterval.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtInterval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(218, 85);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(52, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Interval";
            this.metroLabel6.UseStyleColors = true;
            // 
            // txtTimeOut
            // 
            // 
            // 
            // 
            this.txtTimeOut.CustomButton.Image = null;
            this.txtTimeOut.CustomButton.Location = new System.Drawing.Point(35, 2);
            this.txtTimeOut.CustomButton.Name = "";
            this.txtTimeOut.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtTimeOut.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTimeOut.CustomButton.TabIndex = 1;
            this.txtTimeOut.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTimeOut.CustomButton.UseSelectable = true;
            this.txtTimeOut.CustomButton.Visible = false;
            this.txtTimeOut.IconRight = true;
            this.txtTimeOut.Lines = new string[0];
            this.txtTimeOut.Location = new System.Drawing.Point(110, 85);
            this.txtTimeOut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTimeOut.MaxLength = 32767;
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.PasswordChar = '\0';
            this.txtTimeOut.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTimeOut.SelectedText = "";
            this.txtTimeOut.SelectionLength = 0;
            this.txtTimeOut.SelectionStart = 0;
            this.txtTimeOut.ShortcutsEnabled = true;
            this.txtTimeOut.Size = new System.Drawing.Size(57, 24);
            this.txtTimeOut.TabIndex = 9;
            this.txtTimeOut.UseSelectable = true;
            this.txtTimeOut.UseStyleColors = true;
            this.txtTimeOut.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTimeOut.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTimeOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(31, 85);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(64, 19);
            this.metroLabel5.TabIndex = 8;
            this.metroLabel5.Text = "Time Out";
            this.metroLabel5.UseStyleColors = true;
            // 
            // cbxSSL
            // 
            this.cbxSSL.AutoSize = true;
            this.cbxSSL.Checked = true;
            this.cbxSSL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSSL.Location = new System.Drawing.Point(454, 89);
            this.cbxSSL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxSSL.Name = "cbxSSL";
            this.cbxSSL.Size = new System.Drawing.Size(41, 15);
            this.cbxSSL.TabIndex = 13;
            this.cbxSSL.Text = "SSL";
            this.cbxSSL.UseSelectable = true;
            this.cbxSSL.UseStyleColors = true;
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.IconRight = true;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(388, 41);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(175, 24);
            this.txtPassword.TabIndex = 7;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(388, 21);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(63, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Password";
            this.metroLabel4.UseStyleColors = true;
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(100, 2);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.IconRight = true;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(258, 41);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUserName.MaxLength = 32767;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(122, 24);
            this.txtUserName.TabIndex = 5;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.UseStyleColors = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(258, 21);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(75, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "User Name";
            this.metroLabel3.UseStyleColors = true;
            // 
            // txtPort
            // 
            // 
            // 
            // 
            this.txtPort.CustomButton.Image = null;
            this.txtPort.CustomButton.Location = new System.Drawing.Point(53, 2);
            this.txtPort.CustomButton.Name = "";
            this.txtPort.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtPort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPort.CustomButton.TabIndex = 1;
            this.txtPort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPort.CustomButton.UseSelectable = true;
            this.txtPort.CustomButton.Visible = false;
            this.txtPort.IconRight = true;
            this.txtPort.Lines = new string[0];
            this.txtPort.Location = new System.Drawing.Point(175, 41);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPort.MaxLength = 32767;
            this.txtPort.Name = "txtPort";
            this.txtPort.PasswordChar = '\0';
            this.txtPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPort.SelectedText = "";
            this.txtPort.SelectionLength = 0;
            this.txtPort.SelectionStart = 0;
            this.txtPort.ShortcutsEnabled = true;
            this.txtPort.Size = new System.Drawing.Size(75, 24);
            this.txtPort.TabIndex = 3;
            this.txtPort.UseSelectable = true;
            this.txtPort.UseStyleColors = true;
            this.txtPort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(175, 21);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Server Port";
            this.metroLabel1.UseStyleColors = true;
            // 
            // txtImapServer
            // 
            // 
            // 
            // 
            this.txtImapServer.CustomButton.Image = null;
            this.txtImapServer.CustomButton.Location = new System.Drawing.Point(141, 2);
            this.txtImapServer.CustomButton.Name = "";
            this.txtImapServer.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.txtImapServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtImapServer.CustomButton.TabIndex = 1;
            this.txtImapServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtImapServer.CustomButton.UseSelectable = true;
            this.txtImapServer.CustomButton.Visible = false;
            this.txtImapServer.IconRight = true;
            this.txtImapServer.Lines = new string[0];
            this.txtImapServer.Location = new System.Drawing.Point(4, 41);
            this.txtImapServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtImapServer.MaxLength = 32767;
            this.txtImapServer.Name = "txtImapServer";
            this.txtImapServer.PasswordChar = '\0';
            this.txtImapServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtImapServer.SelectedText = "";
            this.txtImapServer.SelectionLength = 0;
            this.txtImapServer.SelectionStart = 0;
            this.txtImapServer.ShortcutsEnabled = true;
            this.txtImapServer.Size = new System.Drawing.Size(163, 24);
            this.txtImapServer.TabIndex = 1;
            this.txtImapServer.UseSelectable = true;
            this.txtImapServer.UseStyleColors = true;
            this.txtImapServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtImapServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(4, 21);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(47, 19);
            this.metroLabel2.TabIndex = 0;
            this.metroLabel2.Text = "Server";
            this.metroLabel2.UseStyleColors = true;
            // 
            // tabAbout
            // 
            this.tabAbout.Controls.Add(this.metroLabel9);
            this.tabAbout.Controls.Add(this.metroLabel10);
            this.tabAbout.HorizontalScrollbarBarColor = true;
            this.tabAbout.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAbout.HorizontalScrollbarSize = 10;
            this.tabAbout.Location = new System.Drawing.Point(4, 38);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Size = new System.Drawing.Size(643, 255);
            this.tabAbout.TabIndex = 2;
            this.tabAbout.Text = "Info";
            this.tabAbout.VerticalScrollbarBarColor = true;
            this.tabAbout.VerticalScrollbarHighlightOnWheel = false;
            this.tabAbout.VerticalScrollbarSize = 10;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(24, 27);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(195, 19);
            this.metroLabel9.TabIndex = 23;
            this.metroLabel9.Text = "E-Mail: ranasikandar@mail.com";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(24, 52);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(217, 19);
            this.metroLabel10.TabIndex = 22;
            this.metroLabel10.Text = "Copyright - 2022 All Right reserved";
            this.metroLabel10.UseStyleColors = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Runing in background";
            this.notifyIcon1.BalloonTipTitle = "Email Printer";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Email Printer";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLastCheckTime
            // 
            this.lblLastCheckTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLastCheckTime.AutoSize = true;
            this.lblLastCheckTime.BackColor = System.Drawing.Color.Transparent;
            this.lblLastCheckTime.Location = new System.Drawing.Point(2, 356);
            this.lblLastCheckTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lblLastCheckTime.Name = "lblLastCheckTime";
            this.lblLastCheckTime.Size = new System.Drawing.Size(117, 19);
            this.lblLastCheckTime.TabIndex = 17;
            this.lblLastCheckTime.Text = "E-Mails Last Check";
            this.lblLastCheckTime.UseStyleColors = true;
            // 
            // btnRunnow
            // 
            this.btnRunnow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRunnow.Highlight = true;
            this.btnRunnow.Location = new System.Drawing.Point(564, 356);
            this.btnRunnow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRunnow.Name = "btnRunnow";
            this.btnRunnow.Size = new System.Drawing.Size(99, 19);
            this.btnRunnow.TabIndex = 22;
            this.btnRunnow.Text = "Retrieve E-Mails";
            this.btnRunnow.UseSelectable = true;
            this.btnRunnow.Click += new System.EventHandler(this.btnRunnow_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(0, 20, 20, 0);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.BackMaxSize = 70;
            this.ClientSize = new System.Drawing.Size(691, 377);
            this.Controls.Add(this.btnRunnow);
            this.Controls.Add(this.lblLastCheckTime);
            this.Controls.Add(this.tabCtrlAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Email Printer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.tabCtrlAbout.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmails)).EndInit();
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabAbout.ResumeLayout(false);
            this.tabAbout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabCtrlAbout;
        private MetroFramework.Controls.MetroTabPage tabMain;
        private MetroFramework.Controls.MetroTabPage tabSettings;
        private MetroFramework.Controls.MetroTextBox txtImapServer;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private MetroFramework.Controls.MetroButton btnSaveSettings;
        private MetroFramework.Controls.MetroTextBox txtInterval;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtTimeOut;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox cbxSSL;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPort;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvEmails;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroLabel lblLastCheckTime;
        private MetroFramework.Controls.MetroTabPage tabAbout;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroButton btnRunnow;
        private MetroFramework.Controls.MetroLabel metroLabel17;
        private MetroFramework.Controls.MetroTextBox txtLicence;
        private MetroFramework.Controls.MetroLabel metroLabel18;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn MessageDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn htmlBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmailDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Printed;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
    }
}