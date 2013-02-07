using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using Microsoft.Office.Interop;

namespace RecTool
{
    public partial class frmFAvsMS : Form
    {        
        private ReconMgr reconObj;
        private ExplainPL explainObj;
        private AccountMapping AcctMapObj;       
        public string FAFilePath;
        public string MSFilePath;
        private ExplainParamater explainParamater;
                
        public frmFAvsMS()
        {
            InitializeComponent();
            Init();
           
        }

        private void Init()
        {
            // TODO: This line of code loads data into the 'types.ExplainType' table. You can move, or remove it, as needed.
            this.explainTypeTableAdapter.Fill(this.types.ExplainType);  

            //Load Account Mapping Table
            this.AcctMapObj = AccountMapping.GetInstance();
                        
            // Declare A New Explain Object
            this.explainObj = new ExplainPL(this.dsRECON.ExplainPL);
            
            // Declare the Recon Manager
            reconObj = new ReconMgr(this.dsRECON, dtpicker.Value);

            //Loads Paths From Menu
            this.LoadFilePaths();

            this.explainObj.ExplainTable.ExplainPLRowChanged += new RECONDataSet.ExplainPLRowChangeEventHandler(ExplainTable_ExplainPLRowChanged);
            this.reconObj.FoundMatch += new RecEventDelegate(reconObj_FoundMatch);
            
        }

        void reconObj_FoundMatch(object sender, EventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        void reconObj_TestEvent(object sender, EventArgs e)
        {
            //throw new Exception("The method or operation is not implemented.");
        }

        void ExplainTable_ExplainPLRowChanged(object sender, RECONDataSet.ExplainPLRowChangeEvent e)
        {
            this.lblTotal.Text = "Total Amount: " + this.explainObj.TotalExplainAmt.ToString();
        }

        public void LoadFilePaths()
        {
            this.FAFilePath = this.mnuTxtFAFile.Text;
            this.MSFilePath = this.mnuTxtMSFile.Text;
        }

        public void RunRec()
        {
            RunRec(this.FAFilePath, this.MSFilePath);
        }
        public void RunRec(string FAFilePath, string MSFilePath)
        {
            try           
            {
                this.FAFilePath = FAFilePath;
                this.MSFilePath = MSFilePath;

                //Clear DataSet
                this.dsRECON.Clear();

                //MSMtM msObj = new MSMtM();
                //msObj.Load(MSFilePath);                
                //dsRECON.MSPosMV.Load(msObj.Table.CreateDataReader());

                //FAMtM faObj = new FAMtM();
                //faObj.Load(FAFilePath);                
                //DataTableReader dtrdr = faObj.Table.CreateDataReader();                
                //this.dsRECON.FAPosMV.Load(dtrdr, LoadOption.OverwriteChanges);
                Side side1 = new Side(SideEnum.Side1, "FA Position File");
                side1.LoadCSVFile(FAFilePath);
                
                
                Side side2 = new Side(SideEnum.Side2, "MS Pos. File");
                side2.LoadCSVFile(MSFilePath);
                                
                //Run The Recon Object
                // Declare the Recon Manager                
                reconObj.Date = GetDate();
                //reconObj.DeletePrevious(reconObj.Date);
                
                /***** 
                 * Need to load the sides with file names.
                 * Need to grab pull a key map, from either a database or a file, and load it into a file.  The reconobject should
                 * store the details of the particular reconciliation, ReconLabel, and pull its reconciliation.
                 */
                reconObj.CompareTables(side1, side2, new KeyMap());
                this.dgSide1.DataSource = side1.Table;
                this.dgSide2.DataSource = side2.Table;

                //Load the Status Bar with Data
                this.LoadToolStrip();                                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }        
        }

        private void LoadToolStrip()
        {
            this.tstatusLoaded.Text = "Total Records Compared = " + reconObj.TotalRecordsCompared.ToString();
            this.tstatusMatched.Text = "Matched(" + reconObj.TotalMatched.ToString()+") / Unmatched("+reconObj.TotalUnmatched.ToString()+")";
        }
       
        private void lnkCalculate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.reconObj.CalcDiffs();
            Cursor.Current = Cursors.Default;
        }

        public void Save()
        {
            this.reconObj.SaveAll();
            this.explainObj.ExplainTableAdapter.Update(this.dsRECON.ExplainPL);  
        }
        
        public void LoadDiffs()
        {
            Cursor.Current = Cursors.WaitCursor;            
            DateTime dt = this.GetDate();
            this.reconObj.LoadByDate(dt);
            
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Captures The Edit Link that the user clicked to make an adjustment.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiffCellClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            //Grab the data contents of the selected cell
            if (e.ColumnIndex == 0 && e.RowIndex != -1 )
            {
                this.explainParamater = GetExplainParamater(this.dgDiffs, e);

                // Opens the Explain Window
                this.AddExplain(this.explainParamater);
            }
        }

        public ExplainParamater GetExplainParamater(DataGridView dg, DataGridViewCellEventArgs e)
        {
            
            ExplainParamater ep = new ExplainParamater();
            try
            {
                ep.Account = dg.Rows[e.RowIndex].Cells["ColAccount"].Value.ToString();
                ep.Cusip = dg.Rows[e.RowIndex].Cells["SEDOL"].Value.ToString();
                ep.Date = DateTime.Parse(dg.Rows[e.RowIndex].Cells["ColDte"].Value.ToString());
                ep.Symbol = dg.Rows[e.RowIndex].Cells["ColSymbol"].Value.ToString();
                
            }
            catch (Exception ex)
            {
                Utility.Error.ErrMsgBox(ex.Message);
            }
            
            return ep;

        }
       
        /// <summary>
        /// Opens an explain PL adjustment window.
        /// </summary>
        /// <param name="ep"></param>
        private void AddExplain(ExplainParamater ep)
        {
            frmExplainAdjustment frmexpl = new frmExplainAdjustment(this.explainObj);
            frmexpl.PopulateFormFields(ep);
            frmexpl.ShowDialog();
        }
               
        private DateTime GetDate()
        {
            return DateTime.Parse(this.dtpicker.Value.ToShortDateString());
        }
       
        /// <summary>
        /// Should pull the datarow values and pass them to the Explain PL object to show the explains.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RowEnterEvent(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex != -1)
            {
                this.explainParamater = GetExplainParamater(this.dgDiffs, e);
                this.LoadExplain();                                
                Debug.WriteLine(this.explainParamater.Symbol);                
            }           
        }

        public void LoadExplain()
        {
            int selection = int.Parse(this.cboExplainFilter.SelectedValue.ToString());
            switch (selection)
            {
                case 1:
                    this.explainObj.LoadDailyExplain(this.explainParamater);
                    break;
                case 2:
                    this.explainObj.LoadITDExplain(this.explainParamater);
                    break;
                case 3:
                    this.explainObj.LoadQtyDailyExplain(this.explainParamater);
                    break;
                case 4:
                    this.explainObj.LoadQtyITDExplain(this.explainParamater);
                    break;
                case 5:
                    this.explainObj.LoadAllExplain(this.explainParamater);
                    break;
            }

            this.lblTotal.Text = "Total Amount: " + this.explainObj.TotalExplainAmt.ToString();
        }
        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.RunRec();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tstatusLoaded.Text = "";
            this.tstatusMatched.Text = "";
            this.dsRECON.Clear();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LoadDiffs();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Save();
        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LoadDiffs();
        }
       
        private void FAFileMnuChangedEvent(object sender, EventArgs e)
        {
            this.LoadFilePaths();
        }

        private void MSFileMnuChangedEvent(object sender, EventArgs e)
        {
            this.LoadFilePaths();
        }
       
        private void runToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.RunRec();
        }

        private void qtyBreaksToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            this.bindingSourceDiffs.Filter = reconObj.NonZeroQtyDiffsExpression;                       
        }

        private void showAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bindingSourceDiffs.RemoveFilter();
            this.toolStripCustomFilterInput.Text = "";
        }

        private void onlyUnexplainPL0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.bindingSourceDiffs.Filter = reconObj.UnexplainedExpression(this.toolStripTextBoxTolerance.Text);
            }
            catch (Exception ex)
            {
                Utility.Error.ErrMsgBox(ex.Message);
            }
        }

        private void BindingSourceDiffListChanged(object sender, ListChangedEventArgs e)
        {
            this.tstatusLoaded.Text = "Loaded " + this.bindingSourceDiffs.List.Count.ToString();
        }

        private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog Fd = new SaveFileDialog();
            if (Fd.ShowDialog() == DialogResult.OK)
            {
                
                ExcelHelper.exportToExcel(this.dsRECON.MSvsFAMtMDiff,Fd.FileName);
                
            }            
            
        }

        private void CBOExplainSelectionChangeEvent(object sender, EventArgs e)
        {
            try
            {
                this.LoadExplain();
                reconObj.CalcDiffs();
            }
            catch { }
        }

        private void saveExplainsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.explainObj.Save();
        }
       

        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            if (this.toolStripCustomFilterInput.Text != "")
            {
                try
                {
                    this.bindingSourceDiffs.Filter = this.toolStripCustomFilterInput.Text;
                }
                catch (Exception ex)
                {
                    Utility.Error.ErrMsgBox(ex.Message);
                }
            }
        }

        private void marcusPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bindingSourceDiffs.Filter = "Account = '38140190'";
        }

        private void rMFPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bindingSourceDiffs.Filter = "Account = '38140182'";
        }

        private void octavianMgdPositionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.bindingSourceDiffs.Filter = "Account = '38141198'";
        }

        private void DtpValueChanged(object sender, EventArgs e)
        {
            reconObj.LoadByDate(this.GetDate());
        }

        private void frmFAvsMS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsRECON.FAPosMV' table. You can move, or remove it, as needed.
            //this.fAPosMVTableAdapter.Fill(this.dsRECON.FAPosMV);
            // TODO: This line of code loads data into the 'dsRECON.MSPosMV' table. You can move, or remove it, as needed.
            //this.mSPosMVTableAdapter.Fill(this.dsRECON.MSPosMV);
            try
            {
                reconObj.LoadByDate(this.GetDate());
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Col Selector
            frmColumnSelector fcs = new frmColumnSelector(this.dgDiffs);
            fcs.ShowDialog(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();

            this.dsRECON.WriteXmlSchema(@"c:\tmp\dschema.xml");
            this.dsRECON.WriteXml(@"c:\tmp\rschema.xml");
        }

     
    }
}