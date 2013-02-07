namespace RecTool
{
    partial class frmExplainAdjustment
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
            this.lblCusip = new System.Windows.Forms.Label();
            this.txtCusip = new System.Windows.Forms.TextBox();
            this.lblAccount = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.cboExplainType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmt = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.reconDataSet1 = new RecTool.RECONDataSet();
            this.explainPLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.explainPLTableAdapter = new RecTool.RECONDataSetTableAdapters.ExplainPLTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.reconDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explainPLBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCusip
            // 
            this.lblCusip.AutoSize = true;
            this.lblCusip.Location = new System.Drawing.Point(190, 24);
            this.lblCusip.Name = "lblCusip";
            this.lblCusip.Size = new System.Drawing.Size(33, 13);
            this.lblCusip.TabIndex = 12;
            this.lblCusip.Text = "Cusip";
            // 
            // txtCusip
            // 
            this.txtCusip.Location = new System.Drawing.Point(254, 22);
            this.txtCusip.Name = "txtCusip";
            this.txtCusip.ReadOnly = true;
            this.txtCusip.Size = new System.Drawing.Size(97, 20);
            this.txtCusip.TabIndex = 11;
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(9, 51);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(64, 13);
            this.lblAccount.TabIndex = 10;
            this.lblAccount.Text = "PB Account";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(73, 49);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.ReadOnly = true;
            this.txtAccount.Size = new System.Drawing.Size(105, 20);
            this.txtAccount.TabIndex = 9;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(24, 88);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // dtpicker
            // 
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.Location = new System.Drawing.Point(74, 84);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(104, 20);
            this.dtpicker.TabIndex = 7;
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Location = new System.Drawing.Point(190, 50);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(41, 13);
            this.lblSymbol.TabIndex = 14;
            this.lblSymbol.Text = "Symbol";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(254, 48);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.ReadOnly = true;
            this.txtSymbol.Size = new System.Drawing.Size(97, 20);
            this.txtSymbol.TabIndex = 13;
            // 
            // cboExplainType
            // 
            this.cboExplainType.FormattingEnabled = true;
            this.cboExplainType.Location = new System.Drawing.Point(74, 110);
            this.cboExplainType.Name = "cboExplainType";
            this.cboExplainType.Size = new System.Drawing.Size(104, 21);
            this.cboExplainType.TabIndex = 15;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(9, 113);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(65, 13);
            this.lblType.TabIndex = 16;
            this.lblType.Text = "ExplainType";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(73, 164);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(278, 189);
            this.txtMemo.TabIndex = 17;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(73, 138);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(105, 20);
            this.txtAmount.TabIndex = 18;
            // 
            // lblAmt
            // 
            this.lblAmt.AutoSize = true;
            this.lblAmt.Location = new System.Drawing.Point(24, 141);
            this.lblAmt.Name = "lblAmt";
            this.lblAmt.Size = new System.Drawing.Size(43, 13);
            this.lblAmt.TabIndex = 19;
            this.lblAmt.Text = "Amount";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(37, 167);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(30, 13);
            this.lblNote.TabIndex = 20;
            this.lblNote.Text = "Note";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(21, 26);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 13);
            this.lblUser.TabIndex = 21;
            this.lblUser.Text = "User";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(73, 23);
            this.txtUser.Name = "txtUser";
            this.txtUser.ReadOnly = true;
            this.txtUser.Size = new System.Drawing.Size(105, 20);
            this.txtUser.TabIndex = 22;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(74, 359);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(221, 23);
            this.btnSave.TabIndex = 23;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // reconDataSet1
            // 
            this.reconDataSet1.DataSetName = "RECONDataSet";
            this.reconDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // explainPLBindingSource
            // 
            this.explainPLBindingSource.DataMember = "ExplainPL";
            this.explainPLBindingSource.DataSource = this.reconDataSet1;
            // 
            // explainPLTableAdapter
            // 
            this.explainPLTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.dtpicker);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.lblAmt);
            this.groupBox1.Controls.Add(this.lblSymbol);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtSymbol);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.lblCusip);
            this.groupBox1.Controls.Add(this.cboExplainType);
            this.groupBox1.Controls.Add(this.txtCusip);
            this.groupBox1.Controls.Add(this.txtMemo);
            this.groupBox1.Controls.Add(this.lblAccount);
            this.groupBox1.Controls.Add(this.lblType);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 453);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inputs";
            // 
            // frmExplainAdjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 484);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmExplainAdjustment";
            this.Text = "ExplainAdjustment";
            ((System.ComponentModel.ISupportInitialize)(this.reconDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explainPLBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCusip;
        private System.Windows.Forms.TextBox txtCusip;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.Label lblSymbol;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.ComboBox cboExplainType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmt;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnSave;
        private RECONDataSet reconDataSet1;
        private System.Windows.Forms.BindingSource explainPLBindingSource;
        private RecTool.RECONDataSetTableAdapters.ExplainPLTableAdapter explainPLTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;

    }
}