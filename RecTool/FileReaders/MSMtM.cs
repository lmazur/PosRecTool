using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using Utility;
using System.Data.OleDb;
using System.Data;

namespace RecTool
{
     
    class MSMtM
    {
        private string _SheetName = "Sheet1";
        public DataSet ds;
        private RECONDataSet.MSPosMVDataTable _msdt;
        private DataTable dt;

        #region
        public RECONDataSet.MSPosMVDataTable Table
        {
            get { return _msdt; }
        }
        public DataTable dtFileData
        {
            get { return this.ds.Tables[0]; }
        }
        #endregion

        public MSMtM(){ }

        //this is not used,since pulling from CSV file, 
        private string GetQueryString()
        {
            string sql = "SELECT [PORTFOLIO ID],[(L)ONG/(S)HORT/(n)ET], SYMBOL, CUSIP,SEDOL, [SECURITY DESCRIPTION], [QUANTITY], "
                + "[PRICE (ISSUE)],[MARKET VALUE - GROSS (ISSUE)],[MARKET VALUE - GROSS (BASE)],"
                + "[POSITION TYPE DESCRIPTION], [CURRENCY (ISSUE)]";                 
            sql += " FROM [" + this._SheetName + "$]";
            sql += " WHERE where [PORTFOLIO ID] in ('38141198', '38140190', '38140182') ";
            sql += " and [POSITION TYPE DESCRIPTION] in ('Option')";

            return sql;            
        }

        public void LoadFileFromDialog()
        {
            FileImporter fi = new FileImporter();
            //Get File Name
            fi.ChooseFileFromDialog();
            if (fi.FileName != "")
            {
                Load(fi.FileName);
            }

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
        private void LoadMSDataTable()
        {
            this._msdt = new RECONDataSet.MSPosMVDataTable();

            //string exp = "[POSITION TYPE DESCRIPTION] = 'Option'";
            //DataRow[] Rows = dt.Select(exp);
            foreach (DataRow dr in this.dt.Rows)
            {
                RECONDataSet.MSPosMVRow mr = _msdt.NewMSPosMVRow();
                mr.Dte = DateTime.Today;
                mr.AcctNo = dr["PORTFOLIO ID"].ToString().Trim();
                mr.Symbol = dr["SYMBOL"].ToString().Trim();
                mr.SecDes = dr["SECURITY DESCRIPTION"].ToString().Trim();
                mr.SEDOL = dr["SEDOL"].ToString().Trim();                                
                mr.CUSIP = dr["CUSIP"].ToString().Trim();
                mr.Side = dr["(L)ONG/(S)HORT/(n)ET"].ToString();                
                mr.Quantity = Utility.Common.SafeDouble(dr["QUANTITY"]);
                mr.Price = Utility.Common.SafeDouble(dr["PRICE (ISSUE)"]);
                mr.LocalMV = Utility.Common.SafeDouble(dr["MARKET VALUE - GROSS (ISSUE)"]);
                mr.BaseMV = Utility.Common.SafeDouble(dr["MARKET VALUE - GROSS (BASE)"]);               
                mr.AssetClass= dr["POSITION TYPE DESCRIPTION"].ToString().Trim();
                mr.Curr = dr["CURRENCY (ISSUE)"].ToString().Trim();

                if (mr.AssetClass == "Option")
                    mr.SEDOL = mr.Symbol;
                                
                //Data Row
                this._msdt.Rows.Add(mr);                
            }            
        }
        private void LoadCSVFile(string path)
        {
            FileImporter fi = new FileImporter();
            fi.ReadCsvFileIntoDT(path);

            this.dt = fi.dtBuffer.Copy();
            
        }
        public void Load(string path)
        {
            //this.LoadXLFile(path);
            this.LoadCSVFile(path);
            this.LoadMSDataTable();
        }
        
    }

    
    
}
