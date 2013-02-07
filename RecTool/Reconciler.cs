using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Data;
using Utility;

namespace RecTool
{
    //public Re
    public delegate void RecEventDelegate(object sender, System.EventArgs e);

    public class UnMatchEventArg : System.EventArgs
    {
        private DataRow _drside1;
        public UnMatchEventArg(DataRow Side)
        {
            this._drside1 = Side;
        }

        public DataRow RowSide1
        {
            get { return _drside1; }
        }
    }


    public class MatchEventArg : System.EventArgs
    {
        private DataRow _drside1;
        private DataRow[] _drside2;
        /// <summary>
        /// Other side can be 1 to many.
        /// </summary>
        /// <param name="Side1"></param>
        /// <param name="Side2">Array of rows</param>
        public MatchEventArg(DataRow Side1, DataRow[] Side2) 
        {
            this._drside1 = Side1;
            this._drside2 = Side2;
        }

        public DataRow RowSide1
        {
            get { return _drside1; }
        }
        public DataRow[] RowSide2
        {
            get { return _drside2; }
        }
    }

    public class Reconciler
    {
        private int _TotalOuterRecords = -1;
        private int _TotalUnmatched = -1;
        public event RecEventDelegate FoundMatch;
        public event RecEventDelegate NoMatch;
        

        #region Properties
        public int TotalRecordsCompared
        {
            get { return this._TotalOuterRecords; }
        }
        public int TotalUnmatched
        {
            get { return this._TotalUnmatched; }
        }
        public int TotalMatched
        {
            get { return this.TotalRecordsCompared - this.TotalUnmatched; }
        }
        #endregion

        public Reconciler() { }


        // Need to tell which sides are being passed.
        public void CompareTables(Side side1, Side side2, KeyMap km)
        {
            this._TotalOuterRecords = 0;
            this._TotalUnmatched = 0;
           
            //Should grab empty select
            DataRow[] OuterRows = side1.Table.Select();
            this._TotalOuterRecords = OuterRows.Length;

            //Traverse Outer Table And Compare rows by the keys
            foreach (DataRow OuterRow in OuterRows)
            {              
                //Check for items in InnerRow.col = OuterRow.value

                //Figure out if OuterRow is Side1 or Side2
                //SideEnum whichSide = Utility.Lookup.LookupSideEnum(OuterRow.Table.ExtendedProperties["Side"].ToString());

                //Declare a side object with rows to build the expression.
                Side side = new Side(OuterRow, side1.SideEnum);
                string exp = km.getExpression(side);
                DataRow[] InnerRows = side2.Table.Select(exp);

                //Found Match On Key
                if (InnerRows.Length > 0)
                {
                    //One to one Match
                    if (InnerRows.Length == 1)
                    {                        
                        InnerRows[0]["FK"] = OuterRow["RowId"];
                        OuterRow["MatchCount"] = 1;
                        RaiseMatchEvent(OuterRow, InnerRows);
                    }
                    else  //Many to One
                    {
                        if (Config.AllowOneToMany)
                        {
                            RaiseMatchEvent(OuterRow, InnerRows);
                            OuterRow["MatchCount"] = InnerRows.Length;

                            foreach (DataRow InnerRow in InnerRows)
                            {
                                //AddToDiffTable(OuterRow, InnerRow);
                                //Points each Inner Row Foreign Key to the Outer Row ID
                                //Need a way to flag the rows that have one to many..
                                InnerRow["FK"] = OuterRow["RowId"];                                
                            }
                        }
                        else
                        {
                            //Process Unmatched.. Flag as Many to One 
                        }
                    }
                    System.Diagnostics.Debug.WriteLine("Found Item" + OuterRow[0].ToString());
                }
                
                //Not Found
                else
                {
                    //Process Unmatched OuterRow
                    this._TotalUnmatched++;
                }                
            }                
        }

        private void RaiseMatchEvent(DataRow side1, DataRow[] side2)
        {
            // Safely invoke an event:
            RecEventDelegate temp = FoundMatch;

            if (temp != null)
            {
                temp(this, new MatchEventArg(side1, side2));
            }
        }

        public virtual void AddToDiffTable(DataRow dr1, DataRow dr2){}


    
       

    }
}
