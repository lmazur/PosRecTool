namespace RecTool
{
    partial class Tester
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
            this.button1 = new System.Windows.Forms.Button();
            this.mSvsFAMtMDiffDataGridView = new System.Windows.Forms.DataGridView();
            this.mSvsFAMtMDiffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rECONDataSet = new RecTool.RECONDataSet();
            this.rECONDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSvsFAMtMDiffTableAdapter1 = new RecTool.RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mSvsFAMtMDiffDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSvsFAMtMDiffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECONDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mSvsFAMtMDiffDataGridView
            // 
            this.mSvsFAMtMDiffDataGridView.AutoGenerateColumns = false;
            this.mSvsFAMtMDiffDataGridView.DataSource = this.rECONDataSet;
            this.mSvsFAMtMDiffDataGridView.Location = new System.Drawing.Point(22, 77);
            this.mSvsFAMtMDiffDataGridView.Name = "mSvsFAMtMDiffDataGridView";
            this.mSvsFAMtMDiffDataGridView.Size = new System.Drawing.Size(759, 220);
            this.mSvsFAMtMDiffDataGridView.TabIndex = 2;
            // 
            // mSvsFAMtMDiffBindingSource
            // 
            this.mSvsFAMtMDiffBindingSource.DataMember = "MSvsFAMtMDiff";
            this.mSvsFAMtMDiffBindingSource.DataSource = this.rECONDataSet;
            // 
            // rECONDataSet
            // 
            this.rECONDataSet.DataSetName = "RECONDataSet";
            this.rECONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rECONDataSetBindingSource
            // 
            this.rECONDataSetBindingSource.DataSource = this.rECONDataSet;
            this.rECONDataSetBindingSource.Position = 0;
            // 
            // mSvsFAMtMDiffTableAdapter1
            // 
            this.mSvsFAMtMDiffTableAdapter1.ClearBeforeFill = true;
            // 
            // Tester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 385);
            this.Controls.Add(this.mSvsFAMtMDiffDataGridView);
            this.Controls.Add(this.button1);
            this.Name = "Tester";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Tester_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mSvsFAMtMDiffDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSvsFAMtMDiffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rECONDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource rECONDataSetBindingSource;
        private RECONDataSet rECONDataSet;
        private RecTool.RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter mSvsFAMtMDiffTableAdapter1;
        private System.Windows.Forms.BindingSource mSvsFAMtMDiffBindingSource;
        private System.Windows.Forms.DataGridView mSvsFAMtMDiffDataGridView;
    }
}