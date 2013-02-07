using System;
using System.Collections;
using System.Data.OleDb;
using System.Text;
using System.Data;
using Utility;

namespace RecTool
{
    public enum SideEnum { Side1, Side2 }

    public class Side : RecTool.ISide
    {
        private DataRow _dr;
        private DataTable _dt;
        private DataSet _ds;
        private SideEnum _side;
        private string _filepath;
        private string _querystring = "";
        private string _label;

        public Side(DataRow dr, SideEnum side)
        {
            _dr = dr;
            _side = side;

        }
        public Side(DataTable dt, SideEnum side)
        {
            _dt = dt;
            _side = side;            
        }

        public Side(SideEnum side, string label)
        {
            _side = side;
            _label = label;
            
        }

        private void AddExtendedProperties()
        {
            //Used to identify which side the datatable belongs to
            this._dt.ExtendedProperties.Add("Side", this._side.ToString());                         
        }

        private void InitializeTable(DataTable dt)
        {
            this._dt = new DataTable(this.SideEnum.ToString());
            
            //Add RowId PK Column of table
            DataColumn rowid = new DataColumn("RowId");
            rowid.DataType = typeof(System.Int32);
            rowid.ColumnMapping = MappingType.Element;
            rowid.AutoIncrement = true;
            rowid.AutoIncrementSeed = 100;
            rowid.AutoIncrementStep = 1;
            rowid.Unique = true;
            this._dt.Columns.Add(rowid);
            
            DataColumn fk = new DataColumn("FK");
            fk.DataType = typeof(System.Int32);
            fk.ColumnMapping = MappingType.Element;
            this._dt.Columns.Add(fk);

            DataColumn MatchCount = new DataColumn("MatchCount");
            MatchCount.DataType = typeof(System.Int32);
            MatchCount.ColumnMapping = MappingType.Element;
            this._dt.Columns.Add(MatchCount);
            
            //Merge Into current datatable            
            _dt.Merge(dt, false, MissingSchemaAction.AddWithKey);
            _dt.AcceptChanges();
        }

        public void LoadCSVFile(string path)
        {
            FileImporter fi = new FileImporter();
            fi.ReadCsvFileIntoDT(path);
            
            this.InitializeTable(fi.dtBuffer);
            this._filepath = path;
            this.AddExtendedProperties();

        }
        public void LoadXLFile(string path)
        {
            FileImporter fi = new FileImporter();
            fi.ReadXLFile(path, "something");
            this._filepath = path;
            this.AddExtendedProperties();
        }
        
        #region Properties
        public string Label
        {
            get { return _label; }
            set { _label = value; }
        }

        public DataRow Row
        {
            get { return this._dr; }
        }
        public DataTable Table
        {
            get { return this._dt; }
        }
        public SideEnum SideEnum
        {
            get { return _side; }
        }
        #endregion
    }

}
