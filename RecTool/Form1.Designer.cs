namespace RecTool
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.txtFileLoc1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Side2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbcsv = new System.Windows.Forms.RadioButton();
            this.rbxls = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.lblFileLoc2 = new System.Windows.Forms.Label();
            this.txtFileLoc2 = new System.Windows.Forms.TextBox();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.Side1File = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(178, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtFileLoc1
            // 
            this.txtFileLoc1.Location = new System.Drawing.Point(25, 101);
            this.txtFileLoc1.Name = "txtFileLoc1";
            this.txtFileLoc1.Size = new System.Drawing.Size(100, 20);
            this.txtFileLoc1.TabIndex = 1;
            this.txtFileLoc1.Text = "c:\\tmp\\FA.csv";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tag,
            this.Side1,
            this.Side2});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 329);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowTemplate.Height = 15;
            this.dataGridView1.Size = new System.Drawing.Size(308, 72);
            this.dataGridView1.TabIndex = 2;
            // 
            // Tag
            // 
            this.Tag.HeaderText = "Tag";
            this.Tag.Name = "Tag";
            // 
            // Side1
            // 
            this.Side1.HeaderText = "Side 1";
            this.Side1.Name = "Side1";
            // 
            // Side2
            // 
            this.Side2.HeaderText = "Side2";
            this.Side2.Name = "Side2";
            this.Side2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rbcsv
            // 
            this.rbcsv.AutoSize = true;
            this.rbcsv.Location = new System.Drawing.Point(347, 25);
            this.rbcsv.Name = "rbcsv";
            this.rbcsv.Size = new System.Drawing.Size(42, 17);
            this.rbcsv.TabIndex = 3;
            this.rbcsv.TabStop = true;
            this.rbcsv.Text = "csv";
            this.rbcsv.UseVisualStyleBackColor = true;
            // 
            // rbxls
            // 
            this.rbxls.AutoSize = true;
            this.rbxls.Location = new System.Drawing.Point(347, 48);
            this.rbxls.Name = "rbxls";
            this.rbxls.Size = new System.Drawing.Size(37, 17);
            this.rbxls.TabIndex = 4;
            this.rbxls.TabStop = true;
            this.rbxls.Text = "xls";
            this.rbxls.UseVisualStyleBackColor = true;
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.button2);
            this.gb1.Controls.Add(this.label4);
            this.gb1.Controls.Add(this.btnBrowse2);
            this.gb1.Controls.Add(this.lblFileLoc2);
            this.gb1.Controls.Add(this.txtFileLoc2);
            this.gb1.Controls.Add(this.btnBrowse1);
            this.gb1.Controls.Add(this.Side1File);
            this.gb1.Controls.Add(this.label3);
            this.gb1.Controls.Add(this.label2);
            this.gb1.Controls.Add(this.label1);
            this.gb1.Controls.Add(this.txtFileLoc1);
            this.gb1.Controls.Add(this.dataGridView1);
            this.gb1.Location = new System.Drawing.Point(12, 90);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(510, 430);
            this.gb1.TabIndex = 5;
            this.gb1.TabStop = false;
            this.gb1.Text = "KeyMap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "What files will be compared.";
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(293, 102);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(21, 20);
            this.btnBrowse2.TabIndex = 7;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            // 
            // lblFileLoc2
            // 
            this.lblFileLoc2.AutoSize = true;
            this.lblFileLoc2.Location = new System.Drawing.Point(184, 85);
            this.lblFileLoc2.Name = "lblFileLoc2";
            this.lblFileLoc2.Size = new System.Drawing.Size(67, 13);
            this.lblFileLoc2.TabIndex = 6;
            this.lblFileLoc2.Text = "File Location";
            // 
            // txtFileLoc2
            // 
            this.txtFileLoc2.Location = new System.Drawing.Point(187, 102);
            this.txtFileLoc2.Name = "txtFileLoc2";
            this.txtFileLoc2.Size = new System.Drawing.Size(100, 20);
            this.txtFileLoc2.TabIndex = 5;
            this.txtFileLoc2.Text = "c:\\tmp\\MS.csv";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(131, 101);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(21, 20);
            this.btnBrowse1.TabIndex = 4;
            this.btnBrowse1.Text = "...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            // 
            // Side1File
            // 
            this.Side1File.AutoSize = true;
            this.Side1File.Location = new System.Drawing.Point(22, 85);
            this.Side1File.Name = "Side1File";
            this.Side1File.Size = new System.Drawing.Size(67, 13);
            this.Side1File.TabIndex = 3;
            this.Side1File.Text = "File Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Side 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "How will the files be matched..";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(335, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 708);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.rbxls);
            this.Controls.Add(this.rbcsv);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtFileLoc1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rbcsv;
        private System.Windows.Forms.RadioButton rbxls;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Side2;
        private System.Windows.Forms.Label Side1File;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.Label lblFileLoc2;
        private System.Windows.Forms.TextBox txtFileLoc2;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}