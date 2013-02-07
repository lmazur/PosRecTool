using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility;
using System.Collections;

namespace RecTool
{
    public partial class frmExplainAdjustment : Form
    {
        private ExplainPL _ExplainPLObj;
        private ExplainParamater _ExplainParamObj;

        #region Properties
        public ExplainPL ExplainPLObj
        {
            get { return this._ExplainPLObj; }
            set { this._ExplainPLObj = value; }
        }
        #endregion


        public frmExplainAdjustment(ExplainPL explObj)
        {
            this._ExplainPLObj = explObj;
            InitializeComponent();
        }
        
        public frmExplainAdjustment()
        {            
            InitializeComponent();
            
        }


        public void PopulateFormFields(ExplainParamater ep)
        {
            this._ExplainParamObj = ep;

            #region Add To Combo Box
            ArrayList al = new ArrayList();
            al.Add(new ComboBoxItem(1, "Qty Daily Explain Adjustments"));
            al.Add(new ComboBoxItem(2, "Qty ITD Explain Adjustments"));
            al.Add(new ComboBoxItem(3, "MV Daily Explain Adjustments"));
            al.Add(new ComboBoxItem(4, "MV ITD Explain Adjustments"));            
            
            this.cboExplainType.DataSource = al;
            this.cboExplainType.DisplayMember = "Name";
            this.cboExplainType.ValueMember = "Id";
            #endregion

            // Load Set Parameters
            this.txtUser.Text = System.Windows.Forms.SystemInformation.UserName;
            this.dtpicker.Value = ep.Date;
            this.txtAccount.Text = ep.Account;
            this.txtCusip.Text = ep.Cusip;
            this.txtSymbol.Text = ep.Symbol;
                        
            //this._ExplainPLObj.LoadDailyExplain();
            
        }

        /// <summary>
        /// Adds the items that the user entered in the screen to the Explain DataTable
        /// Saves the Information
        /// </summary>
        public bool AddExplainDataToTable()
        {
            RECONDataSet.ExplainPLRow er = _ExplainPLObj.ExplainTable.NewExplainPLRow();
            er.Account = _ExplainParamObj.Account;
            er.Cusip = _ExplainParamObj.Cusip;
            er.Dte = _ExplainParamObj.Date;
            er.Symbol = _ExplainParamObj.Symbol;
            er.ExplainType = int.Parse(this.cboExplainType.SelectedValue.ToString());
            er.Amt = Common.SafeDouble(this.txtAmount.Text);
            er.Note = this.txtMemo.Text;
            er.UserId = this.txtUser.Text;

            if (er.Note == "")
            {
                Error.ErrMsgBox("A Note is Mandatory", "No Notation On Explain");
                return false;
            }
            else
            {
                try
                {
                    _ExplainPLObj.ExplainTable.AddExplainPLRow(er);
                    _ExplainPLObj.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    Error.ErrMsgBox(ex.Message);
                    return false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( this.AddExplainDataToTable() )
                this.Close();
        }       
       
    }
}