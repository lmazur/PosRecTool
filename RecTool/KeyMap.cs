using System;
using System.Collections;
using System.Text;
using System.Data;
using Library.SqlFilter;

namespace RecTool
{
    /// <summary>
    /// Class to determine the mappings between both data sets to compare.
    /// </summary>
    [Serializable()]
    public class KeyMap
    {
        private string _valuesuffix = ".value";
        private kmds.KeyMapDataTable _dt;
        private ArrayList _keys = new ArrayList();  //Array of Filter Objects
        private ArrayList _expression_nodes = new ArrayList();
        private string _filterstr;


        public KeyMap()
        {
            // Establishes the data column key map.
            init();
            // Builds the where expression
            BuildExpression();
        }

        /// <summary>
        /// Initialize the KeyMap.  Must make sure side1 and side2 match the table values.
        /// </summary>
        private void init()
        {
            // Initialize keys in Map
            _dt = new kmds.KeyMapDataTable();            
            _dt.LoadDataRow(new object[] { "acct", "TF Acct Number", "PORTFOLIO ID" }, true);
            _dt.LoadDataRow(new object[] { "symbol", "Id1", "SYMBOL" }, true);
            _dt.LoadDataRow(new object[] { "sedol", "Id2", "SEDOL" }, true);

            //Populates keys list which is a list of Filter objects
            foreach (kmds.KeyMapRow kr in _dt.Rows)
            {
                _keys.Add(new Filter(kr.Tag, SqlOperators.Equal, kr.Tag + this._valuesuffix));
            }
        }

        /// <summary>
        /// Builds the filter expression based on the Filter objects.
        /// </summary>
        public void BuildExpression()
        {
            // Constructs the final filters.
            //ANDFilter and1 = new ANDFilter(this["date"], this["acct"]);
            ORFilter or1 = new ORFilter(this["symbol"], this["sedol"]);
            ANDFilter exp = new ANDFilter(this["acct"], or1);
            this._filterstr = exp.FilterString;
            
        }

        /// <summary>
        /// Takes two data rows, and changes the name value pairs of the where expression to have the column of side 1 = value of side 2
        /// Side1.ColumnName = Side2[ColumnName] 
        /// </summary>
        /// <param name="side">Determines the value</param>
        /// <returns></returns>
        public string getExpression(Side side)
        {
            string exp = _filterstr;
            //Traverse Each Key and Replace the sides with the Columns of the Sides
            foreach (Filter f in _keys)
            {
                string s1 = this.getSide1(f.FilterID);
                string s2 = this.getSide2(f.FilterID);

                //Replace expression with side statements
                // FilterName = FilerValue
                //makes sedol = sedol.value ==> sedol1 = dr[sedol2.ColumnName.value]                
                if (side.SideEnum == SideEnum.Side1)
                {
                    f.FilterName = "["+s2+"]";
                    f.FilterValue = side.Row[s1].ToString();
                }
                else //Side2's value should be shown
                {
                    f.FilterName = "["+s1+"]";;
                    f.FilterValue = side.Row[s2].ToString();
                }
            }
            //Reapplies the And | Or conditions to the statement
            this.BuildExpression();
            return _filterstr;
        }
        public string WhereKeysNotNullExpression(Side side)
        {
            foreach (Filter f in _keys)
            {
                string SideColName = "";
                //Get Column Mapping Names of Both Sides
                if (side.SideEnum == SideEnum.Side1)
                    SideColName = this.getSide1(f.FilterID);
                else if (side.SideEnum == SideEnum.Side2)
                    SideColName = this.getSide2(f.FilterID);

                //Replace expression with side statements
                //makes sedol = sedol.value ==> sedol1 = sedol.value
                f.FilterName = SideColName;
                f.SqlOperator = SqlOperators.NotEqual;
                f.FilterValue = "";
            }
            this.BuildExpression();
            return this._filterstr;
        }
        /// <summary>
        /// Given a tag (common name of two mapped ids), it returns the Side1 column.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public string getSide1(string tag)
        {
            string where = "Tag = '" + tag + "'";
            DataRow[] rows = _dt.Select(where);
            if (rows.Length > 0)
                return rows[0]["Side1"].ToString();
            else
            {
                throw new Exception("Side1 of tag " + tag + " cannot be found.");
            }
        }
        /// <summary>
        /// Given a tag (common name of two mapped ids), it returns the Side2 column.
        /// </summary>
        /// <param name="tag"></param>
        /// <returns></returns>
        public string getSide2(string tag)
        {
            string where = "Tag = '" + tag + "'";
            DataRow[] rows = _dt.Select(where);
            if (rows.Length > 0)
                return rows[0]["Side2"].ToString();
            else
            {
                throw new Exception("Side2 of tag " + tag + " cannot be found.");
            }
        }

        #region Properties
        public ArrayList ExpressionNodes
        {
            get { return _expression_nodes; }
        }
        public string FilterString
        {
            set
            {
                this._filterstr = value;
            }
            get
            {
                return this._filterstr;
            }
        }

        public DataTable KeyMapdt
        {
            get { return this._dt; }
        }
        /// <summary>
        /// Gets the Filter Object given the tag id.
        /// </summary>
        /// <param name="tag">Common tag id between both sides.</param>
        /// <returns></returns>
        public Filter this[string tag]
        {
            get
            {
                bool found = false;
                int i;
                for (i = 0; i < _keys.Count; i++)
                {
                    if (((Filter)_keys[i]).FilterID == tag)
                    {
                        found = true;
                        break;
                    }
                }
                if (found)
                    return (Filter)_keys[i];
                else
                    throw new Exception("Tag " + tag + " cannot be found.");
            }
        }
        #endregion

    }

    [Serializable()]
    public class Key
    {
        public string _tag = "";
        public string _side1 = "";
        public string _side2 = "";
        public Key(string tag, string side1, string side2)
        {
            _tag = tag;
            _side1 = side1;
            _side2 = side2;
        }
    }
}
