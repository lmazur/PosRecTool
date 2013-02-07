namespace RecTool
{
    partial class frmFAvsMS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpicker = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstatusLoaded = new System.Windows.Forms.ToolStripStatusLabel();
            this.tstatusMatched = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDelta = new System.Windows.Forms.TabPage();
            this.dgDiffs = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSymbol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEDOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtyDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnexplainedQtyDiff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mSMktValDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MSPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fAMktValDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FAPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mktValDiffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtMnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.qtyBreaksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.onlyUnexplainPL0ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toleranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxTolerance = new System.Windows.Forms.ToolStripTextBox();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcusPositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rMFPositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octavianMgdPositionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripCustomFilterInput = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSourceDiffs = new System.Windows.Forms.BindingSource(this.components);
            this.dsRECON = new RecTool.RECONDataSet();
            this.tabMS = new System.Windows.Forms.TabPage();
            this.dgSide1 = new System.Windows.Forms.DataGridView();
            this.tabFA = new System.Windows.Forms.TabPage();
            this.dgSide2 = new System.Windows.Forms.DataGridView();
            this.MsPosMVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FaPosMVBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mSvsFAMtMDiffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lnkCalculate = new System.Windows.Forms.LinkLabel();
            this.lblDate = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inputsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTxtFAFile = new System.Windows.Forms.ToolStripTextBox();
            this.mSFilePathToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTxtMSFile = new System.Windows.Forms.ToolStripTextBox();
            this.types = new RecTool.Types();
            this.explainTypeTableAdapter = new RecTool.TypesTableAdapters.ExplainTypeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlExplains = new System.Windows.Forms.TabControl();
            this.tabExplainAdj = new System.Windows.Forms.TabPage();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgExplain = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accountDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusipDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symbolDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dteDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoteDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExplainType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxtExplain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.saveExplainsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cboExplainFilter = new System.Windows.Forms.ComboBox();
            this.explainTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mSvsFAMtMDiffTableAdapter = new RecTool.RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter();
            this.mSPosMVTableAdapter = new RecTool.RECONDataSetTableAdapters.MSPosMVTableAdapter();
            this.fAPosMVTableAdapter = new RecTool.RECONDataSetTableAdapters.FAPosMVTableAdapter();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDelta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiffs)).BeginInit();
            this.ctxtMnu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiffs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRECON)).BeginInit();
            this.tabMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSide1)).BeginInit();
            this.tabFA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSide2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MsPosMVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaPosMVBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSvsFAMtMDiffBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.types)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabControlExplains.SuspendLayout();
            this.tabExplainAdj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExplain)).BeginInit();
            this.ctxtExplain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.explainTypeBindingSource)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpicker
            // 
            this.dtpicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicker.Location = new System.Drawing.Point(53, 8);
            this.dtpicker.Name = "dtpicker";
            this.dtpicker.Size = new System.Drawing.Size(104, 20);
            this.dtpicker.TabIndex = 1;
            this.dtpicker.ValueChanged += new System.EventHandler(this.DtpValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstatusLoaded,
            this.tstatusMatched});
            this.statusStrip1.Location = new System.Drawing.Point(0, 668);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1176, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstatusLoaded
            // 
            this.tstatusLoaded.Name = "tstatusLoaded";
            this.tstatusLoaded.Size = new System.Drawing.Size(0, 17);
            // 
            // tstatusMatched
            // 
            this.tstatusMatched.Name = "tstatusMatched";
            this.tstatusMatched.Size = new System.Drawing.Size(0, 17);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDelta);
            this.tabControl1.Controls.Add(this.tabMS);
            this.tabControl1.Controls.Add(this.tabFA);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1176, 386);
            this.tabControl1.TabIndex = 6;
            // 
            // tabDelta
            // 
            this.tabDelta.Controls.Add(this.dgDiffs);
            this.tabDelta.Location = new System.Drawing.Point(4, 22);
            this.tabDelta.Name = "tabDelta";
            this.tabDelta.Padding = new System.Windows.Forms.Padding(3);
            this.tabDelta.Size = new System.Drawing.Size(1168, 360);
            this.tabDelta.TabIndex = 2;
            this.tabDelta.Text = "Differences";
            this.tabDelta.UseVisualStyleBackColor = true;
            // 
            // dgDiffs
            // 
            this.dgDiffs.AllowUserToOrderColumns = true;
            this.dgDiffs.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgDiffs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDiffs.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDiffs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDiffs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiffs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.ridDataGridViewTextBoxColumn,
            this.ColDte,
            this.ColAccount,
            this.ColSymbol,
            this.SEDOL,
            this.mSQtyDataGridViewTextBoxColumn,
            this.fAQtyDataGridViewTextBoxColumn,
            this.qtyDiffDataGridViewTextBoxColumn,
            this.UnexplainedQtyDiff,
            this.mSMktValDataGridViewTextBoxColumn,
            this.MSPrice,
            this.fAMktValDataGridViewTextBoxColumn,
            this.FAPrice,
            this.mktValDiffDataGridViewTextBoxColumn});
            this.dgDiffs.ContextMenuStrip = this.ctxtMnu;
            this.dgDiffs.DataSource = this.bindingSourceDiffs;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDiffs.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgDiffs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgDiffs.Location = new System.Drawing.Point(3, 3);
            this.dgDiffs.MultiSelect = false;
            this.dgDiffs.Name = "dgDiffs";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDiffs.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgDiffs.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDiffs.RowTemplate.Height = 24;
            this.dgDiffs.Size = new System.Drawing.Size(1162, 354);
            this.dgDiffs.TabIndex = 0;
            this.dgDiffs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DiffCellClickEvent);
            this.dgDiffs.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.RowEnterEvent);
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "";
            this.Edit.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Adjust Explain";
            this.Edit.ToolTipText = "Allows you to add explain PL adjustment.";
            this.Edit.UseColumnTextForLinkValue = true;
            this.Edit.Width = 21;
            // 
            // ridDataGridViewTextBoxColumn
            // 
            this.ridDataGridViewTextBoxColumn.DataPropertyName = "rid";
            this.ridDataGridViewTextBoxColumn.Frozen = true;
            this.ridDataGridViewTextBoxColumn.HeaderText = "rid";
            this.ridDataGridViewTextBoxColumn.Name = "ridDataGridViewTextBoxColumn";
            this.ridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ridDataGridViewTextBoxColumn.Visible = false;
            // 
            // ColDte
            // 
            this.ColDte.DataPropertyName = "Dte";
            this.ColDte.Frozen = true;
            this.ColDte.HeaderText = "Dte";
            this.ColDte.Name = "ColDte";
            this.ColDte.Visible = false;
            // 
            // ColAccount
            // 
            this.ColAccount.DataPropertyName = "Account";
            this.ColAccount.Frozen = true;
            this.ColAccount.HeaderText = "Account";
            this.ColAccount.Name = "ColAccount";
            // 
            // ColSymbol
            // 
            this.ColSymbol.DataPropertyName = "Symbol";
            this.ColSymbol.Frozen = true;
            this.ColSymbol.HeaderText = "Symbol";
            this.ColSymbol.Name = "ColSymbol";
            // 
            // SEDOL
            // 
            this.SEDOL.DataPropertyName = "SEDOL";
            this.SEDOL.Frozen = true;
            this.SEDOL.HeaderText = "SEDOL";
            this.SEDOL.Name = "SEDOL";
            // 
            // mSQtyDataGridViewTextBoxColumn
            // 
            this.mSQtyDataGridViewTextBoxColumn.DataPropertyName = "MSQty";
            this.mSQtyDataGridViewTextBoxColumn.Frozen = true;
            this.mSQtyDataGridViewTextBoxColumn.HeaderText = "MSQty";
            this.mSQtyDataGridViewTextBoxColumn.Name = "mSQtyDataGridViewTextBoxColumn";
            // 
            // fAQtyDataGridViewTextBoxColumn
            // 
            this.fAQtyDataGridViewTextBoxColumn.DataPropertyName = "FAQty";
            this.fAQtyDataGridViewTextBoxColumn.Frozen = true;
            this.fAQtyDataGridViewTextBoxColumn.HeaderText = "FAQty";
            this.fAQtyDataGridViewTextBoxColumn.Name = "fAQtyDataGridViewTextBoxColumn";
            // 
            // qtyDiffDataGridViewTextBoxColumn
            // 
            this.qtyDiffDataGridViewTextBoxColumn.DataPropertyName = "QtyDiff";
            this.qtyDiffDataGridViewTextBoxColumn.HeaderText = "QtyDiff";
            this.qtyDiffDataGridViewTextBoxColumn.Name = "qtyDiffDataGridViewTextBoxColumn";
            // 
            // UnexplainedQtyDiff
            // 
            this.UnexplainedQtyDiff.DataPropertyName = "UnexplainedQtyDiff";
            this.UnexplainedQtyDiff.HeaderText = "UnexplainedQtyDiff";
            this.UnexplainedQtyDiff.Name = "UnexplainedQtyDiff";
            // 
            // mSMktValDataGridViewTextBoxColumn
            // 
            this.mSMktValDataGridViewTextBoxColumn.DataPropertyName = "MSMktVal";
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.mSMktValDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.mSMktValDataGridViewTextBoxColumn.HeaderText = "MSMktVal";
            this.mSMktValDataGridViewTextBoxColumn.Name = "mSMktValDataGridViewTextBoxColumn";
            // 
            // MSPrice
            // 
            this.MSPrice.DataPropertyName = "MSPrice";
            this.MSPrice.HeaderText = "MSPrice";
            this.MSPrice.Name = "MSPrice";
            // 
            // fAMktValDataGridViewTextBoxColumn
            // 
            this.fAMktValDataGridViewTextBoxColumn.DataPropertyName = "FAMktVal";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.fAMktValDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.fAMktValDataGridViewTextBoxColumn.HeaderText = "FAMktVal";
            this.fAMktValDataGridViewTextBoxColumn.Name = "fAMktValDataGridViewTextBoxColumn";
            // 
            // FAPrice
            // 
            this.FAPrice.DataPropertyName = "FAPrice";
            this.FAPrice.HeaderText = "FAPrice";
            this.FAPrice.Name = "FAPrice";
            // 
            // mktValDiffDataGridViewTextBoxColumn
            // 
            this.mktValDiffDataGridViewTextBoxColumn.DataPropertyName = "MktValDiff";
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            this.mktValDiffDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.mktValDiffDataGridViewTextBoxColumn.HeaderText = "MktValDiff";
            this.mktValDiffDataGridViewTextBoxColumn.Name = "mktValDiffDataGridViewTextBoxColumn";
            // 
            // ctxtMnu
            // 
            this.ctxtMnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.qtyBreaksToolStripMenuItem,
            this.onlyUnexplainPL0ToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.toolStripMenuItem3,
            this.showAllToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exportToExcelToolStripMenuItem});
            this.ctxtMnu.Name = "ctxtMnu";
            this.ctxtMnu.Size = new System.Drawing.Size(214, 126);
            this.ctxtMnu.Text = "Data Options";
            // 
            // qtyBreaksToolStripMenuItem
            // 
            this.qtyBreaksToolStripMenuItem.Name = "qtyBreaksToolStripMenuItem";
            this.qtyBreaksToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.qtyBreaksToolStripMenuItem.Text = "Qty Breaks";
            this.qtyBreaksToolStripMenuItem.Click += new System.EventHandler(this.qtyBreaksToolStripMenuItem_Click);
            // 
            // onlyUnexplainPL0ToolStripMenuItem
            // 
            this.onlyUnexplainPL0ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toleranceToolStripMenuItem,
            this.toolStripTextBoxTolerance});
            this.onlyUnexplainPL0ToolStripMenuItem.Name = "onlyUnexplainPL0ToolStripMenuItem";
            this.onlyUnexplainPL0ToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.onlyUnexplainPL0ToolStripMenuItem.Text = "Only Unexplained PL Items";
            this.onlyUnexplainPL0ToolStripMenuItem.Click += new System.EventHandler(this.onlyUnexplainPL0ToolStripMenuItem_Click);
            // 
            // toleranceToolStripMenuItem
            // 
            this.toleranceToolStripMenuItem.Name = "toleranceToolStripMenuItem";
            this.toleranceToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.toleranceToolStripMenuItem.Text = "Tolerance";
            // 
            // toolStripTextBoxTolerance
            // 
            this.toolStripTextBoxTolerance.Name = "toolStripTextBoxTolerance";
            this.toolStripTextBoxTolerance.Size = new System.Drawing.Size(100, 21);
            this.toolStripTextBoxTolerance.Text = "0";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.marcusPositionsToolStripMenuItem,
            this.rMFPositionsToolStripMenuItem,
            this.octavianMgdPositionsToolStripMenuItem,
            this.enterFilterToolStripMenuItem,
            this.toolStripCustomFilterInput});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.filterToolStripMenuItem.Text = "Other Filter";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // marcusPositionsToolStripMenuItem
            // 
            this.marcusPositionsToolStripMenuItem.Name = "marcusPositionsToolStripMenuItem";
            this.marcusPositionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.marcusPositionsToolStripMenuItem.Text = "Marcus Positions";
            this.marcusPositionsToolStripMenuItem.Click += new System.EventHandler(this.marcusPositionsToolStripMenuItem_Click);
            // 
            // rMFPositionsToolStripMenuItem
            // 
            this.rMFPositionsToolStripMenuItem.Name = "rMFPositionsToolStripMenuItem";
            this.rMFPositionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.rMFPositionsToolStripMenuItem.Text = "RMF Positions";
            this.rMFPositionsToolStripMenuItem.Click += new System.EventHandler(this.rMFPositionsToolStripMenuItem_Click);
            // 
            // octavianMgdPositionsToolStripMenuItem
            // 
            this.octavianMgdPositionsToolStripMenuItem.Name = "octavianMgdPositionsToolStripMenuItem";
            this.octavianMgdPositionsToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.octavianMgdPositionsToolStripMenuItem.Text = "Octavian Mgd Positions";
            this.octavianMgdPositionsToolStripMenuItem.Click += new System.EventHandler(this.octavianMgdPositionsToolStripMenuItem_Click);
            // 
            // enterFilterToolStripMenuItem
            // 
            this.enterFilterToolStripMenuItem.Name = "enterFilterToolStripMenuItem";
            this.enterFilterToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.enterFilterToolStripMenuItem.Text = "Custom Filter";
            // 
            // toolStripCustomFilterInput
            // 
            this.toolStripCustomFilterInput.Name = "toolStripCustomFilterInput";
            this.toolStripCustomFilterInput.Size = new System.Drawing.Size(100, 21);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 6);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.showAllToolStripMenuItem.Text = "Clear Filter";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.showAllToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(210, 6);
            // 
            // exportToExcelToolStripMenuItem
            // 
            this.exportToExcelToolStripMenuItem.Name = "exportToExcelToolStripMenuItem";
            this.exportToExcelToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.exportToExcelToolStripMenuItem.Text = "Export To Excel";
            this.exportToExcelToolStripMenuItem.Click += new System.EventHandler(this.exportToExcelToolStripMenuItem_Click);
            // 
            // bindingSourceDiffs
            // 
            this.bindingSourceDiffs.DataMember = "MSvsFAMtMDiff";
            this.bindingSourceDiffs.DataSource = this.dsRECON;
            this.bindingSourceDiffs.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.BindingSourceDiffListChanged);
            // 
            // dsRECON
            // 
            this.dsRECON.DataSetName = "dsRECON";
            this.dsRECON.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabMS
            // 
            this.tabMS.Controls.Add(this.dgSide1);
            this.tabMS.Location = new System.Drawing.Point(4, 22);
            this.tabMS.Name = "tabMS";
            this.tabMS.Padding = new System.Windows.Forms.Padding(3);
            this.tabMS.Size = new System.Drawing.Size(1168, 360);
            this.tabMS.TabIndex = 3;
            this.tabMS.Text = "MS Data";
            this.tabMS.UseVisualStyleBackColor = true;
            // 
            // dgSide1
            // 
            this.dgSide1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSide1.Location = new System.Drawing.Point(3, 3);
            this.dgSide1.Name = "dgSide1";
            this.dgSide1.Size = new System.Drawing.Size(1162, 354);
            this.dgSide1.TabIndex = 0;
            // 
            // tabFA
            // 
            this.tabFA.Controls.Add(this.dgSide2);
            this.tabFA.Location = new System.Drawing.Point(4, 22);
            this.tabFA.Name = "tabFA";
            this.tabFA.Size = new System.Drawing.Size(1168, 360);
            this.tabFA.TabIndex = 4;
            this.tabFA.Text = "FA Data";
            this.tabFA.UseVisualStyleBackColor = true;
            // 
            // dgSide2
            // 
            this.dgSide2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSide2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgSide2.Location = new System.Drawing.Point(0, 0);
            this.dgSide2.Name = "dgSide2";
            this.dgSide2.Size = new System.Drawing.Size(1168, 360);
            this.dgSide2.TabIndex = 0;
            // 
            // MsPosMVBindingSource
            // 
            this.MsPosMVBindingSource.DataMember = "MSPosMV";
            this.MsPosMVBindingSource.DataSource = this.dsRECON;
            // 
            // FaPosMVBindingSource
            // 
            this.FaPosMVBindingSource.DataMember = "FAPosMV";
            this.FaPosMVBindingSource.DataSource = this.dsRECON;
            // 
            // mSvsFAMtMDiffBindingSource
            // 
            this.mSvsFAMtMDiffBindingSource.DataMember = "MSvsFAMtMDiff";
            this.mSvsFAMtMDiffBindingSource.DataSource = this.dsRECON;
            // 
            // lnkCalculate
            // 
            this.lnkCalculate.AutoSize = true;
            this.lnkCalculate.Location = new System.Drawing.Point(163, 8);
            this.lnkCalculate.Name = "lnkCalculate";
            this.lnkCalculate.Size = new System.Drawing.Size(75, 13);
            this.lnkCalculate.TabIndex = 1;
            this.lnkCalculate.TabStop = true;
            this.lnkCalculate.Text = "Calculate Diffs";
            this.lnkCalculate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCalculate_LinkClicked);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(17, 8);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.runToolStripMenuItem1,
            this.loadToolStripMenuItem1,
            this.inputsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1176, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.testToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(35, 20);
            this.mnuFile.Text = "&File";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.runToolStripMenuItem.Text = "Run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.testToolStripMenuItem.Text = "Save";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem1
            // 
            this.runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            this.runToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.runToolStripMenuItem1.Text = "Run";
            this.runToolStripMenuItem1.Click += new System.EventHandler(this.runToolStripMenuItem1_Click);
            // 
            // loadToolStripMenuItem1
            // 
            this.loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            this.loadToolStripMenuItem1.Size = new System.Drawing.Size(42, 20);
            this.loadToolStripMenuItem1.Text = "Load";
            this.loadToolStripMenuItem1.Click += new System.EventHandler(this.loadToolStripMenuItem1_Click);
            // 
            // inputsToolStripMenuItem
            // 
            this.inputsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.mSFilePathToolStripMenuItem});
            this.inputsToolStripMenuItem.Name = "inputsToolStripMenuItem";
            this.inputsToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inputsToolStripMenuItem.Text = "Inputs";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTxtFAFile});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(143, 22);
            this.toolStripMenuItem2.Text = "FA File Path";
            // 
            // mnuTxtFAFile
            // 
            this.mnuTxtFAFile.Name = "mnuTxtFAFile";
            this.mnuTxtFAFile.Size = new System.Drawing.Size(500, 21);
            this.mnuTxtFAFile.Text = "c:\\tmp\\FA.csv";
            this.mnuTxtFAFile.TextChanged += new System.EventHandler(this.FAFileMnuChangedEvent);
            // 
            // mSFilePathToolStripMenuItem
            // 
            this.mSFilePathToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTxtMSFile});
            this.mSFilePathToolStripMenuItem.Name = "mSFilePathToolStripMenuItem";
            this.mSFilePathToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.mSFilePathToolStripMenuItem.Text = "MS File Path";
            // 
            // mnuTxtMSFile
            // 
            this.mnuTxtMSFile.Name = "mnuTxtMSFile";
            this.mnuTxtMSFile.Size = new System.Drawing.Size(400, 21);
            this.mnuTxtMSFile.Text = "c:\\tmp\\MS.csv";
            this.mnuTxtMSFile.TextChanged += new System.EventHandler(this.MSFileMnuChangedEvent);
            // 
            // types
            // 
            this.types.DataSetName = "Types";
            this.types.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // explainTypeTableAdapter
            // 
            this.explainTypeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lnkCalculate);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.dtpicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1176, 60);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControlExplains
            // 
            this.tabControlExplains.Controls.Add(this.tabExplainAdj);
            this.tabControlExplains.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlExplains.Location = new System.Drawing.Point(0, 0);
            this.tabControlExplains.Name = "tabControlExplains";
            this.tabControlExplains.SelectedIndex = 0;
            this.tabControlExplains.Size = new System.Drawing.Size(1176, 194);
            this.tabControlExplains.TabIndex = 3;
            // 
            // tabExplainAdj
            // 
            this.tabExplainAdj.Controls.Add(this.lblTotal);
            this.tabExplainAdj.Controls.Add(this.label1);
            this.tabExplainAdj.Controls.Add(this.dgExplain);
            this.tabExplainAdj.Controls.Add(this.cboExplainFilter);
            this.tabExplainAdj.Location = new System.Drawing.Point(4, 22);
            this.tabExplainAdj.Name = "tabExplainAdj";
            this.tabExplainAdj.Padding = new System.Windows.Forms.Padding(3);
            this.tabExplainAdj.Size = new System.Drawing.Size(1168, 168);
            this.tabExplainAdj.TabIndex = 0;
            this.tabExplainAdj.Text = "Explain Adjustments";
            this.tabExplainAdj.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(205, 3);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filter";
            // 
            // dgExplain
            // 
            this.dgExplain.AllowUserToOrderColumns = true;
            this.dgExplain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgExplain.AutoGenerateColumns = false;
            this.dgExplain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExplain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Amt,
            this.accountDataGridViewTextBoxColumn2,
            this.cusipDataGridViewTextBoxColumn4,
            this.symbolDataGridViewTextBoxColumn3,
            this.dteDataGridViewTextBoxColumn4,
            this.NoteDataGridViewTextBoxColumn3,
            this.UserId,
            this.ExplainType});
            this.dgExplain.ContextMenuStrip = this.ctxtExplain;
            this.dgExplain.DataMember = "ExplainPL";
            this.dgExplain.DataSource = this.dsRECON;
            this.dgExplain.Location = new System.Drawing.Point(3, 27);
            this.dgExplain.Name = "dgExplain";
            this.dgExplain.RowTemplate.Height = 24;
            this.dgExplain.Size = new System.Drawing.Size(996, 138);
            this.dgExplain.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ExplainId";
            this.dataGridViewTextBoxColumn1.HeaderText = "ExplainId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Amt
            // 
            this.Amt.DataPropertyName = "Amt";
            this.Amt.HeaderText = "Amt";
            this.Amt.Name = "Amt";
            // 
            // accountDataGridViewTextBoxColumn2
            // 
            this.accountDataGridViewTextBoxColumn2.DataPropertyName = "Account";
            this.accountDataGridViewTextBoxColumn2.HeaderText = "Account";
            this.accountDataGridViewTextBoxColumn2.Name = "accountDataGridViewTextBoxColumn2";
            this.accountDataGridViewTextBoxColumn2.Visible = false;
            // 
            // cusipDataGridViewTextBoxColumn4
            // 
            this.cusipDataGridViewTextBoxColumn4.DataPropertyName = "Cusip";
            this.cusipDataGridViewTextBoxColumn4.HeaderText = "Cusip";
            this.cusipDataGridViewTextBoxColumn4.Name = "cusipDataGridViewTextBoxColumn4";
            this.cusipDataGridViewTextBoxColumn4.Visible = false;
            // 
            // symbolDataGridViewTextBoxColumn3
            // 
            this.symbolDataGridViewTextBoxColumn3.DataPropertyName = "Symbol";
            this.symbolDataGridViewTextBoxColumn3.HeaderText = "Symbol";
            this.symbolDataGridViewTextBoxColumn3.Name = "symbolDataGridViewTextBoxColumn3";
            this.symbolDataGridViewTextBoxColumn3.Visible = false;
            // 
            // dteDataGridViewTextBoxColumn4
            // 
            this.dteDataGridViewTextBoxColumn4.DataPropertyName = "Dte";
            this.dteDataGridViewTextBoxColumn4.HeaderText = "Dte";
            this.dteDataGridViewTextBoxColumn4.Name = "dteDataGridViewTextBoxColumn4";
            // 
            // NoteDataGridViewTextBoxColumn3
            // 
            this.NoteDataGridViewTextBoxColumn3.DataPropertyName = "Note";
            this.NoteDataGridViewTextBoxColumn3.HeaderText = "Note";
            this.NoteDataGridViewTextBoxColumn3.Name = "NoteDataGridViewTextBoxColumn3";
            // 
            // UserId
            // 
            this.UserId.DataPropertyName = "UserId";
            this.UserId.HeaderText = "UserId";
            this.UserId.Name = "UserId";
            // 
            // ExplainType
            // 
            this.ExplainType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ExplainType.DataPropertyName = "ExplainType";
            this.ExplainType.HeaderText = "ExplainType";
            this.ExplainType.Name = "ExplainType";
            this.ExplainType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExplainType.Width = 90;
            // 
            // ctxtExplain
            // 
            this.ctxtExplain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveExplainsToolStripMenuItem});
            this.ctxtExplain.Name = "ctxtExplain";
            this.ctxtExplain.Size = new System.Drawing.Size(152, 26);
            // 
            // saveExplainsToolStripMenuItem
            // 
            this.saveExplainsToolStripMenuItem.Name = "saveExplainsToolStripMenuItem";
            this.saveExplainsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveExplainsToolStripMenuItem.Text = "Save Explains";
            this.saveExplainsToolStripMenuItem.Click += new System.EventHandler(this.saveExplainsToolStripMenuItem_Click);
            // 
            // cboExplainFilter
            // 
            this.cboExplainFilter.DataSource = this.explainTypeBindingSource;
            this.cboExplainFilter.DisplayMember = "Type";
            this.cboExplainFilter.FormattingEnabled = true;
            this.cboExplainFilter.Location = new System.Drawing.Point(32, 0);
            this.cboExplainFilter.Name = "cboExplainFilter";
            this.cboExplainFilter.Size = new System.Drawing.Size(121, 21);
            this.cboExplainFilter.TabIndex = 4;
            this.cboExplainFilter.ValueMember = "ExplainTypeId";
            this.cboExplainFilter.SelectionChangeCommitted += new System.EventHandler(this.CBOExplainSelectionChangeEvent);
            // 
            // explainTypeBindingSource
            // 
            this.explainTypeBindingSource.DataMember = "ExplainType";
            this.explainTypeBindingSource.DataSource = this.types;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 84);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControlExplains);
            this.splitContainer1.Size = new System.Drawing.Size(1176, 584);
            this.splitContainer1.SplitterDistance = 386;
            this.splitContainer1.TabIndex = 4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dsRECON;
            this.bindingSource1.Position = 0;
            // 
            // mSvsFAMtMDiffTableAdapter
            // 
            this.mSvsFAMtMDiffTableAdapter.ClearBeforeFill = true;
            // 
            // mSPosMVTableAdapter
            // 
            this.mSPosMVTableAdapter.ClearBeforeFill = true;
            // 
            // fAPosMVTableAdapter
            // 
            this.fAPosMVTableAdapter.ClearBeforeFill = true;
            // 
            // frmFAvsMS
            // 
            this.ClientSize = new System.Drawing.Size(1176, 690);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFAvsMS";
            this.Load += new System.EventHandler(this.frmFAvsMS_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabDelta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDiffs)).EndInit();
            this.ctxtMnu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDiffs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsRECON)).EndInit();
            this.tabMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSide1)).EndInit();
            this.tabFA.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgSide2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MsPosMVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaPosMVBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mSvsFAMtMDiffBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.types)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlExplains.ResumeLayout(false);
            this.tabExplainAdj.ResumeLayout(false);
            this.tabExplainAdj.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgExplain)).EndInit();
            this.ctxtExplain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.explainTypeBindingSource)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSourceDiffs;
        private RECONDataSet dsRECON;
        private System.Windows.Forms.DateTimePicker dtpicker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDelta;
        private System.Windows.Forms.DataGridView dgDiffs;
        private System.Windows.Forms.LinkLabel lnkCalculate;
        private System.Windows.Forms.Label lblDate;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgExplain;
        private Types types;
        private RecTool.TypesTableAdapters.ExplainTypeTableAdapter explainTypeTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip ctxtMnu;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inputsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox mnuTxtFAFile;
        private System.Windows.Forms.ToolStripMenuItem mSFilePathToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox mnuTxtMSFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tstatusLoaded;
        private System.Windows.Forms.ToolStripStatusLabel tstatusMatched;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem qtyBreaksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem onlyUnexplainPL0ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toleranceToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxTolerance;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlExplains;
        private System.Windows.Forms.TabPage tabExplainAdj;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cboExplainFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource explainTypeBindingSource;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ContextMenuStrip ctxtExplain;
        private System.Windows.Forms.ToolStripMenuItem saveExplainsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amt;
        private System.Windows.Forms.DataGridViewTextBoxColumn accountDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusipDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn symbolDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dteDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoteDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExplainType;
        private System.Windows.Forms.TabPage tabMS;
        private System.Windows.Forms.DataGridView dgSide1;
        private System.Windows.Forms.BindingSource mSvsFAMtMDiffBindingSource;
        private RecTool.RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter mSvsFAMtMDiffTableAdapter;
        private System.Windows.Forms.TabPage tabFA;
        private System.Windows.Forms.DataGridView dgSide2;
        private System.Windows.Forms.BindingSource FaPosMVBindingSource;

        private System.Windows.Forms.BindingSource MsPosMVBindingSource;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripCustomFilterInput;
        private System.Windows.Forms.ToolStripMenuItem enterFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcusPositionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rMFPositionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octavianMgdPositionsToolStripMenuItem;
        private RecTool.RECONDataSetTableAdapters.MSPosMVTableAdapter mSPosMVTableAdapter;
        private RecTool.RECONDataSetTableAdapters.FAPosMVTableAdapter fAPosMVTableAdapter;
        private System.Windows.Forms.DataGridViewLinkColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDte;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSymbol;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEDOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtyDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnexplainedQtyDiff;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSMktValDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MSPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn fAMktValDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FAPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn mktValDiffDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

