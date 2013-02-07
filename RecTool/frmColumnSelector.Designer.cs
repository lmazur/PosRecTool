namespace RecTool
{
    partial class frmColumnSelector
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
            this.clbColumns = new System.Windows.Forms.CheckedListBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.linkCheckAll = new System.Windows.Forms.LinkLabel();
            this.linkUncheckAll = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // clbColumns
            // 
            this.clbColumns.Dock = System.Windows.Forms.DockStyle.Top;
            this.clbColumns.FormattingEnabled = true;
            this.clbColumns.Location = new System.Drawing.Point(0, 0);
            this.clbColumns.Name = "clbColumns";
            this.clbColumns.Size = new System.Drawing.Size(292, 199);
            this.clbColumns.TabIndex = 0;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(100, 238);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // linkCheckAll
            // 
            this.linkCheckAll.AutoSize = true;
            this.linkCheckAll.Location = new System.Drawing.Point(-3, 202);
            this.linkCheckAll.Name = "linkCheckAll";
            this.linkCheckAll.Size = new System.Drawing.Size(52, 13);
            this.linkCheckAll.TabIndex = 2;
            this.linkCheckAll.TabStop = true;
            this.linkCheckAll.Text = "Check All";
            this.linkCheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCheckAll_LinkClicked);
            // 
            // linkUncheckAll
            // 
            this.linkUncheckAll.AutoSize = true;
            this.linkUncheckAll.Location = new System.Drawing.Point(55, 202);
            this.linkUncheckAll.Name = "linkUncheckAll";
            this.linkUncheckAll.Size = new System.Drawing.Size(65, 13);
            this.linkUncheckAll.TabIndex = 3;
            this.linkUncheckAll.TabStop = true;
            this.linkUncheckAll.Text = "Uncheck All";
            this.linkUncheckAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkUncheckAll_LinkClicked);
            // 
            // frmColumnSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.linkUncheckAll);
            this.Controls.Add(this.linkCheckAll);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.clbColumns);
            this.Name = "frmColumnSelector";
            this.Text = "Select Columns To View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbColumns;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.LinkLabel linkCheckAll;
        private System.Windows.Forms.LinkLabel linkUncheckAll;
    }
}