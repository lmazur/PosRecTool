using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Data;
using Utility;
using System.Windows.Forms;



namespace RecTool
{
    public class ExplainParamater
    {
        public DateTime Date;
        public string Account;
        public string Cusip;
        public string Symbol;

        public ExplainParamater() { }
        public ExplainParamater(DateTime dt, string acct, string cusip, string symbol)
        {
            this.Date = dt;
            this.Account = acct;
            this.Cusip = cusip;
            this.Symbol = symbol;
        }
    }

    public class ExplainPL
    {
        private RECONDataSet.ExplainPLDataTable _dt;
        private RECONDataSetTableAdapters.ExplainPLTableAdapter _tableadapter = new RECONDataSetTableAdapters.ExplainPLTableAdapter();
        
        #region Properties
        public RECONDataSetTableAdapters.ExplainPLTableAdapter ExplainTableAdapter
        {
            get { return this._tableadapter; } 
        }
        public RECONDataSet.ExplainPLDataTable ExplainTable
        {
            get { return _dt; }
            set { _dt = value; }
        }
        public double TotalExplainAmt
        {
            get { 
                double amt = 0.0;
                foreach (RECONDataSet.ExplainPLRow dr in this._dt.Rows)
                {
                    amt += dr.Amt;
                }
                return amt;
            }
        }
        #endregion

        public ExplainPL(RECONDataSet.ExplainPLDataTable dtExplain)
        {
            this._dt = dtExplain;
        }

        public static double GetITDExplain(DateTime dte, string acct, string cusip, string symbol)
        {
            RECONDataSetTableAdapters.ExplainPLTableAdapter ta = new RECONDataSetTableAdapters.ExplainPLTableAdapter();
            return Common.SafeDouble(ta.TotalITDExplainAdj(dte, cusip, symbol, acct));
        }
        public static double GetQtyDailyExplain(ExplainParamater ExpParam)
        {
            RECONDataSetTableAdapters.ExplainPLTableAdapter ta = new RECONDataSetTableAdapters.ExplainPLTableAdapter();
            return Common.SafeDouble(ta.TotalQtyDailyExplain(ExpParam.Date, ExpParam.Cusip, ExpParam.Symbol, ExpParam.Account));
        }
        public static double GetQtyITDExplain(ExplainParamater ExpParam)
        {
            RECONDataSetTableAdapters.ExplainPLTableAdapter ta = new RECONDataSetTableAdapters.ExplainPLTableAdapter();
            return Common.SafeDouble(ta.TotalQtyITDExplain(ExpParam.Date, ExpParam.Cusip, ExpParam.Symbol, ExpParam.Account));
        }
        public static double GetDailyExplain(DateTime dte, string acct, string cusip, string symbol)
        {
            RECONDataSetTableAdapters.ExplainPLTableAdapter ta = new RECONDataSetTableAdapters.ExplainPLTableAdapter();
            double dailyexp = Common.SafeDouble(ta.TotalDailyExplainAdj(dte, cusip, symbol, acct));
            return dailyexp;
        }

        public void Save()
        {
            this._tableadapter.Update(this._dt);
        }
        public void LoadQtyDailyExplain(ExplainParamater ExpParam)
        {
            this._tableadapter.QtyDailyFillByParams(this._dt, ExpParam.Date, ExpParam.Account, ExpParam.Cusip, ExpParam.Symbol);
        }
        public void LoadQtyITDExplain(ExplainParamater ExpParam)
        {
            this._tableadapter.QtyITDFillByParams(this._dt, ExpParam.Date, ExpParam.Account, ExpParam.Cusip, ExpParam.Symbol);
        }
        public void LoadITDExplain(ExplainParamater ExpParam)
        {
            this._tableadapter.FillByITDExplainByParams(this._dt, ExpParam.Date, ExpParam.Account, ExpParam.Cusip, ExpParam.Symbol);
        }
        public void LoadITDExplain(DateTime dte, string acct, string cusip, string symbol)
        {
            this._tableadapter.FillByITDExplainByParams(this._dt, dte, acct, cusip, symbol);
        }
        public void LoadDailyExplain(ExplainParamater ExpParam)
        {
            LoadDailyExplain(ExpParam.Date, ExpParam.Account, ExpParam.Cusip, ExpParam.Symbol);
        }
        public void LoadDailyExplain(DateTime dte, string acct, string cusip, string symbol)
        {            
            this._tableadapter.FillDailyByParams(this._dt, dte, acct, cusip, symbol);
        }
        public void LoadAllExplain(ExplainParamater ExpParam)
        {
            _tableadapter.ClearBeforeFill = true;
            _tableadapter.FillByDte(this._dt, ExpParam.Date, ExpParam.Account, ExpParam.Cusip, ExpParam.Symbol);
        }

        public void SaveChanges()
        {
            this._tableadapter.Update(this._dt);
        }
    }

    #region - Weakness --
    /*  For each new rec, i will need to create a datatable in the RECONDataset.xsd schema, and calculate a new diffs.
     * The user should be able to do it, or at least through some xml.
     */ 

    #endregion
    /// <summary>
    /// Takes in a typed dataset & loads the MtmDiff Table with the results
    /// </summary>
    public class ReconMgr:Reconciler
    {
        private RECONDataSet _dsRec;
        private dsError.ErrorDataTable _dtError = new dsError.ErrorDataTable();
        private DateTime _date;
        private RecType rectype = RecType.MSvsFA;  //Default Value        
        private RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter _taDiffs;

        #region Properties
        public RecType RecType
        {
            get { return this.rectype; }
            set { this.rectype = value; }
        }
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        public RECONDataSet dsRecon
        {
            get { return this._dsRec; }
        }
        public RECONDataSet.MSPosMVDataTable dtMS
        {
            get { return this._dsRec.MSPosMV; }
        }
        public RECONDataSet.FAPosMVDataTable dtFA
        {
            get { return this._dsRec.FAPosMV; }
        }
        public RECONDataSet.MSvsFAMtMDiffDataTable dtDiff
        {
            get { return this._dsRec.MSvsFAMtMDiff; }
        }
        #endregion

        /// <summary>
        /// Constructor methond
        /// </summary>
        /// <param name="dsRec">Recon DataSet Object.  Assumes it already has the data loaded into it.</param>
        public ReconMgr(RECONDataSet dsRec, DateTime date)
        {
            _dsRec = dsRec;
            _date = DateTime.Parse(date.ToShortDateString());            
            this.CompareTables2();            
        }
                      
        /// <summary>
        /// Adds rows of both FA and MS to the diff table.
        /// </summary>
        /// <param name="RowSide1">Must Have id as the prim key id name</param>
        /// <param name="RowSide2">Must Have id as the prim key id name</param>
        public override void AddToDiffTable(DataRow row1, DataRow row2)
        {
            //I have to know the type of the object to do the qty diffs
            // of i can set the same Diff Columns in both tables...
            RECONDataSet.FAPosMVRow farow;
            RECONDataSet.MSPosMVRow msrow;
            if (row1 is RECONDataSet.FAPosMVRow)
            {
                farow = row1 as RECONDataSet.FAPosMVRow;
                msrow = row2 as RECONDataSet.MSPosMVRow;
            }
            else
            {
                farow = row2 as RECONDataSet.FAPosMVRow;
                msrow = row1 as RECONDataSet.MSPosMVRow;
            }

            RECONDataSet.MSvsFAMtMDiffRow drow = dtDiff.NewMSvsFAMtMDiffRow();
            drow.Dte = DateTime.Parse(this.Date.ToShortDateString());
            drow.RecType = (int) this.RecType;            
            
            //Only MS Data Is Available
            if (msrow != null)
            {
                drow.Symbol = msrow.Symbol;
                drow.SEDOL = msrow.SEDOL;
                drow.Account = msrow.AcctNo;
                drow.MSQty= msrow.Quantity;
                drow.MSMktVal = msrow.LocalMV;
                drow.MSPrice = msrow.Price;
            }
            
            if (farow != null)
            {
                drow.Account = farow.AcctNo;
                drow.Symbol = farow.Symbol;
                drow.SEDOL = farow.SEDOL;
                drow.FAQty = farow.Quantity;
                drow.FAMktVal = farow.LocalMarketValue;
                drow.FAPrice = farow.Price;
            }

            if (farow != null && msrow != null)
            {
                farow.MatchFound = "Y";
                msrow.MatchFound = "Y";
            }
            this.dtDiff.Rows.Add(drow);
        }

        public void LoadByDate(DateTime date)
        {
            this._taDiffs = new RecTool.RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter();
            this._taDiffs.FillByDate(dtDiff, date);
            this.CalcDiffs();
        }

        public void Clear()
        {
            this._dsRec.Clear();
        }
        public void SaveAll()
        {
            //Save Diff            
            RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter ta = new RecTool.RECONDataSetTableAdapters.MSvsFAMtMDiffTableAdapter();
            int records = Common.SafeInt(ta.TotalRecordsByDate(this._date));
            if (records > 0)
            {
                if (MessageBox.Show("There are FA vs. MS Reconciliation records in the database for " + this._date.ToShortDateString() + "Are you sure you want to overwrite current schedule?", "Overwrite Schedule Warning",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    ta.DeleteDte(this.Date);                            
                    ta.Update(this.dtDiff);
                }
            }
            else
            {
                ta.Update(this.dtDiff);
            }            
        }

        public void DeletePrevious(DateTime dte)
        {
            this.LoadByDate(dte);
            if (this.dtDiff.Rows.Count > 0)
            {
                foreach (RECONDataSet.MSvsFAMtMDiffRow dr in dtDiff.Rows)
                    dr.Delete();
            }            
        }

        public void CompareTablesMine(Side side1, Side side2, KeyMap km)
        {
            //Run Compare Tables twice, to go both ways of finding the matches.
            //base.CompareTables(side1.Table, side2.Table, new KeyMap());
            //base.CompareTables(side2.Table, side1.Table, new KeyMap());

            //Need to come up with Diffs algorithm
            this.CalcDiffs();
        }

        public void CompareTables2()
        {
            //Run Compare Tables twice, to go both ways of finding the matches.
            //base.CompareTables(this.dtFA, this.dtMS, new KeyMap());
            //base.CompareTables(this.dtMS, this.dtFA, new KeyMap());
            //this.CalcDiffs();
        }

        public void CalcDiffs()
        {
            foreach (RECONDataSet.MSvsFAMtMDiffRow dr in this.dtDiff.Rows)
            {
                try
                {
                    //Need to use the row objects because using the properties will throw exceptions for 
                    //null datatypes
                    dr.QtyDiff = Common.SafeDouble(dr["MSQty"]) - Common.SafeDouble(dr["FAQty"]);
                    dr.MktValDiff = Common.SafeDouble(dr["MSMktVal"]) - Common.SafeDouble(dr["FAMktVal"]);                    
                                                            
                    double DailyExplain = ExplainPL.GetDailyExplain(dr.Dte, dr.Account, dr.SEDOL, dr.Symbol);
                    double ITDExplain = ExplainPL.GetITDExplain(dr.Dte, dr.Account, dr.SEDOL, dr.Symbol);                                                            

                    //Unexplained Qty
                    double QtyITDExplained = ExplainPL.GetQtyITDExplain(new ExplainParamater(dr.Dte, dr.Account, dr.SEDOL, dr.Symbol));
                    double QtyDailyExplain = ExplainPL.GetQtyDailyExplain(new ExplainParamater(dr.Dte, dr.Account, dr.SEDOL, dr.Symbol));
                    double QtyExplained = QtyITDExplained + QtyDailyExplain;
                    dr.UnexplainedQtyDiff = dr.QtyDiff + QtyExplained;

                    
                }
                catch (Exception ex)
                {                                        
                    throw ex;
                }
            }
        }

        public string NonZeroQtyDiffsExpression
        {
            get
            {
                string exp;
                exp = "UnexplainedQtyDiff <> 0";
                return exp;
            }
        }

        public string UnexplainedExpression(object tolerance)
        {
            string exp = "";
            //exp = this.dtDiff.UnexplainedPLDiffColumn.ColumnName + " > " + tolerance.ToString();
            //exp += " OR " + dtDiff.UnexplainedPLDiffColumn.ColumnName + " < -" + tolerance.ToString();
            return exp;
        }

        public ExplainParamater GetExplainParam(RECONDataSet.ExplainPLRow dr)
        {
            return new ExplainParamater(dr.Dte, dr.Account, dr.Cusip, dr.Symbol);
        }
        
    }
}
