using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Utility;
using System.Data.OleDb;
using System.Data;

namespace RecTool
{

    class Loader
    {
        public Loader() { }
    }
    /// <summary>
    /// Purpose of this class is to read in the specific file, and map the fields into the datatable in reconobject.
    /// Don't need this.. I can just make a Side Object, and load the datatable from a file.
    /// </summary>
    class FAMtM
    {
        private string _SheetName = "Sheet1";
        private DataSet ds;        
        private RECONDataSet.FAPosMVDataTable _dt;
        private DataTable dt;

        #region Properties
        public RECONDataSet.FAPosMVDataTable Table
        {
            set { _dt = value; }
            get { return _dt; }
        }
        public DataTable dtFileData
        {
            get { return this.ds.Tables[0]; }
            //set { this.ds.Tables[0] = value; }
        }
        #endregion

        public FAMtM() 
        {      
        }

        //Not used for load CSV part
        private string GetQueryString()
        {
            string sql = "SELECT [Portfolio Name],Id2, Id1, PLPosEnd, [Used Price End], [Val End], [Trading TPL], Type, Curr ";
            sql += " FROM [" + this._SheetName + "$] ";
            return sql;            
        }
        public void LoadFileFromDialog()
        {
            FileImporter fi = new FileImporter();
            //Get File Name
            fi.ChooseFileFromDialog();
            if( fi.FileName != "")
                Load(fi.FileName);

        }
        private void LoadCSVFile(string path)
        {
            FileImporter fi = new FileImporter();
            fi.ReadCsvFileIntoDT(path);

            this.dt = fi.dtBuffer.Copy();

            //this.dtFileData.Load(fi.dtBuffer.CreateDataReader());
        }

        private void LoadXLFile(string path)
        {            
            string strConn;            
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + path;                             

            //Open Connection
            OleDbConnection oConn = new OleDbConnection();
            oConn.ConnectionString = strConn;
            oConn.Open();

            //Create DataAdapter
            OleDbDataAdapter oCmd = new OleDbDataAdapter(this.GetQueryString(), oConn);

            try
            {
                //Load the DataSet
                this.ds = new DataSet();
                oCmd.Fill(this.ds);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            finally
            {
                if (oConn.State == ConnectionState.Open) { oConn.Close(); }
            }
        }
        private void LoadFADataTable()
        {
            this.Table = new RECONDataSet.FAPosMVDataTable();
            foreach (DataRow dr in this.dt.Rows)
            {
                RECONDataSet.FAPosMVRow fa = this._dt.NewFAPosMVRow();
                
                fa.Dte = DateTime.Today;
                fa.AcctNo= dr["TF Acct Number"].ToString().Trim();
                fa.Symbol = dr["Insid"].ToString().Trim();
                fa.SEDOL = dr["Id2"].ToString().Trim();
                fa.Cusip = dr["Id1"].ToString().Trim();
                fa.Quantity = Utility.Common.SafeDouble(dr["PLPosEnd"]);
                fa.Price = Utility.Common.SafeDouble(dr["Used Price End"]);
                fa.LocalMarketValue = Utility.Common.SafeDouble(dr["Val End"]);
                fa.BaseMarketValue = Utility.Common.SafeDouble(dr["Portfolio Value End"]);
                fa.Curr = dr["Curr"].ToString().Trim();
                fa.InstType= dr["Type"].ToString().Trim();

                if (fa.InstType == "Option")
                    fa.SEDOL = fa.Cusip;

                //Data Row
                this._dt.Rows.Add(fa);                
            }            
        }

        public void Load(string path)
        {
            this.LoadCSVFile(path);
            this.LoadFADataTable();
        }
    }

    
}
