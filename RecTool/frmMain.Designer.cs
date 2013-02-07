namespace RecTool
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconciliationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frontArenaVsMorganStanleyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbFAvsMS = new System.Windows.Forms.GroupBox();
            this.lnkMSFile = new System.Windows.Forms.LinkLabel();
            this.lnkFAFile = new System.Windows.Forms.LinkLabel();
            this.btnRunRec = new System.Windows.Forms.Button();
            this.txtMSFilePath = new System.Windows.Forms.TextBox();
            this.txtFAFilePath = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.gbFAvsMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reconciliationsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // reconciliationsToolStripMenuItem
            // 
            this.reconciliationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frontArenaVsMorganStanleyToolStripMenuItem});
            this.reconciliationsToolStripMenuItem.Name = "reconciliationsToolStripMenuItem";
            this.reconciliationsToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.reconciliationsToolStripMenuItem.Text = "&Reconciliations";
            // 
            // frontArenaVsMorganStanleyToolStripMenuItem
            // 
            this.frontArenaVsMorganStanleyToolStripMenuItem.Name = "frontArenaVsMorganStanleyToolStripMenuItem";
            this.frontArenaVsMorganStanleyToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.frontArenaVsMorganStanleyToolStripMenuItem.Text = "Front Arena vs. Morgan Stanley";
            this.frontArenaVsMorganStanleyToolStripMenuItem.Click += new System.EventHandler(this.frontArenaVsMorganStanleyToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // gbFAvsMS
            // 
            this.gbFAvsMS.Controls.Add(this.lnkMSFile);
            this.gbFAvsMS.Controls.Add(this.lnkFAFile);
            this.gbFAvsMS.Controls.Add(this.btnRunRec);
            this.gbFAvsMS.Controls.Add(this.txtMSFilePath);
            this.gbFAvsMS.Controls.Add(this.txtFAFilePath);
            this.gbFAvsMS.Controls.Add(this.lblDate);
            this.gbFAvsMS.Controls.Add(this.dtpicker);
            this.gbFAvsMS.Location = new System.Drawing.Point(12, 39);
            this.gbFAvsMS.Name = "gbFAvsMS";
            this.gbFAvsMS.Size = new System.Drawing.Size(268, 191);
            this.gbFAvsMS.TabIndex = 1;
            this.gbFAvsMS.TabStop = false;
            this.gbFAvsMS.Text = "Run Inputs";
            // 
            // lnkMSFile
            // 
            this.lnkMSFile.AutoSize = true;
            this.lnkMSFile.Location = new System.Drawing.Point(13, 106);
            this.lnkMSFile.Name = "lnkMSFile";
            this.lnkMSFile.Size = new System.Drawing.Size(86, 13);
            this.lnkMSFile.TabIndex = 15;
            this.lnkMSFile.TabStop = true;
            this.lnkMSFile.Text = "MS File Location";
            // 
            // lnkFAFile
            // 
            this.lnkFAFile.AutoSize = true;
            this.lnkFAFile.Location = new System.Drawing.Point(13, 67);
            this.lnkFAFile.Name = "lnkFAFile";
            this.lnkFAFile.Size = new System.Drawing.Size(83, 13);
            this.lnkFAFile.TabIndex = 14;
            this.lnkFAFile.TabStop = true;
            this.lnkFAFile.Text = "FA File Location";
            // 
            // btnRunRec
            // 
            this.btnRunRec.Location = new System.Drawing.Point(16, 146);
            this.btnRunRec.Name = "btnRunRec";
            this.btnRunRec.Size = new System.Drawing.Size(113, 23);
            this.btnRunRec.TabIndex = 13;
            this.btnRunRec.Text = "Run Rec";
            this.btnRunRec.UseVisualStyleBackColor = true;
            this.btnRunRec.Click += new System.EventHandler(this.btnRunRec_Click);
            // 
            // txtMSFilePath
            // 
            this.txtMSFilePath.Location = new System.Drawing.Point(102, 103);
            this.txtMSFilePath.Name = "txtMSFilePath";
            this.txtMSFilePath.Size = new System.Drawing.Size(144, 20);
            this.txtMSFilePath.TabIndex = 11;
            this.txtMSFilePath.Text = "c:\\tmp\\MS.xls";
            // 
            // txtFAFilePath
            // 
            this.txtFAFilePath.Location = new System.Drawing.Point(102, 67);
            this.txtFAFilePath.Name = "txtFAFilePath";
            this.txtFAFilePath.Size = new System.Drawing.Size(146, 20);
            this.txtFAFilePath.TabIndex = 9;
            this.txtFAFilePath.Text = "c:\\tmp\\FA.xls";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(29, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date Of Rec";
            // 
            // dtpicker
            // 
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.Location = new System.Drawing.Point(102, 31);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(96, 20);
            this.dtpicker.TabIndex = 7;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 244);
            this.Controls.Add(this.gbFAvsMS);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbFAvsMS.ResumeLayout(false);
            this.gbFAvsMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconciliationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frontArenaVsMorganStanleyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbFAvsMS;
        private System.Windows.Forms.TextBox txtMSFilePath;
        private System.Windows.Forms.TextBox txtFAFilePath;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.LinkLabel lnkMSFile;
        private System.Windows.Forms.LinkLabel lnkFAFile;
        private System.Windows.Forms.Button btnRunRec;
    }
}