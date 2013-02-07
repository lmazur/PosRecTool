using System;
using System.Collections.Generic;
using System.Text;

namespace RecTool
{
    public class AccountMapping
    {
        private static AccountMapping _instance;
        private static int _NumOfRef;
        private Types.AccountMappingDataTable _dtAccountMapping;
        private TypesTableAdapters.AccountMappingTableAdapter _ta;


        #region Properties
        public Types.AccountMappingDataTable Table
        {
            get { return this._dtAccountMapping; }
        }
        #endregion
        /// <summary>
        /// Initializes class and loads from Database.
        /// </summary>
        private AccountMapping()
        {
            _NumOfRef = 0;

            _ta = new RecTool.TypesTableAdapters.AccountMappingTableAdapter();

            this._dtAccountMapping = new Types.AccountMappingDataTable();
            _ta.Fill(this._dtAccountMapping);
        }
        public static AccountMapping GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AccountMapping();
            }
            _NumOfRef++;
            return _instance;
        }

        public string GetAccountName(string FAPortfolio)
        {
            try
            {

                string exp = "FAName = '" + FAPortfolio + "'";
                foreach (Types.AccountMappingRow row in this._dtAccountMapping.Select(exp) as Types.AccountMappingRow[])
                {
                    return row.OtherName;
                }
                return "";
            }
            catch
            {
                return "";
            }
        }
        
    }
}
