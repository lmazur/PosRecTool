using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecTool
{
    public partial class frmColumnSelector : Form
    {
        private DataGridView _dgv;
        public frmColumnSelector(DataGridView dgv)
        {
            InitializeComponent();

            //Initialize The List box with what items are selected
            //How will this memorize what the user had checked or unchecked.
            this._dgv = dgv;
            this.CheckSelectedColumns();            

        }

        public void CheckSelectedColumns()
        {
            foreach (DataGridViewColumn col in this._dgv.Columns)
            {
                if (col.Visible)
                {
                    this.clbColumns.Items.Add(col.Name, true);
                }
                else
                {
                    this.clbColumns.Items.Add(col.Name, false);
                }
            }
        }

        #region
        public CheckedListBox ListBox
        {
            get { return this.clbColumns; }
        }
        #endregion

        private void btnApply_Click(object sender, EventArgs e)
        {
            // Traverse Unchecked Items and make the datagridview items not visible
            foreach (object item in this.clbColumns.Items)
            {
                CheckState state =  clbColumns.GetItemCheckState(clbColumns.Items.IndexOf(item));
                string colname = item.ToString();

                //Set the DataGrid Columns as Not
                if (state == CheckState.Unchecked)
                    this._dgv.Columns[colname].Visible = false;
                if (state == CheckState.Checked)
                    this._dgv.Columns[colname].Visible = true;
                                
            }
        }        

        private void linkCheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Traverse Unchecked Items and make the datagridview items not visible
            for (int i = 0; i < this.clbColumns.Items.Count; i++)
            {
                this.clbColumns.SetItemChecked(i, true);
            }            
        }

        private void linkUncheckAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Traverse Unchecked Items and make the datagridview items not visible
            for (int i = 0; i < this.clbColumns.Items.Count; i++)
            {
                this.clbColumns.SetItemChecked(i, false);
            } 
        }
    }
}