using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.IO;
using System.Data.OleDb;
using RecTool;

namespace Utility
{
    public enum RecType { MSvsFA, AWvsFA };
    public enum ExplainType { DailyExplain, ITDExplain }
    public enum FileImporterOptionEnum { IgnoreFirstLine, ReadFirstLine, CSVFile, FirstRowHasColumnDefs }
    public class FileImporter
    {
        private string m_FileName = "";
        //private  int m_FileLineCount = 0;	
        private DataTable m_dtbuffer;
        private FileImporterOptionEnum LineReadOpt = FileImporterOptionEnum.FirstRowHasColumnDefs;        
        private char m_delimeter = ',';
        private string m_InitialDir = @"c:\temp"; //ConfigurationSettings.AppSettings.Get("StartDirectory");

        public FileImporter()
        {
            this.m_dtbuffer = new DataTable();
        }
        public FileImporter(char FileDelimeter)
        {
            this.m_delimeter = FileDelimeter;
        }

        public bool ChooseFileFromDialogAndLoad()
        {
            if (ChooseFileFromDialog())
            {
                ReadCsvFileIntoDT(this.m_FileName);
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Opens File Dialog Box to select file.
        /// </summary>
        /// <returns></returns>				
        public bool ChooseFileFromDialog()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = this.m_InitialDir;
            openFileDialog1.Filter = "txt files (*.csv)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.m_FileName = openFileDialog1.FileName;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ReadCsvFileIntoDT(string filename)
        {
            int i = 0;
            string line = "";
            string input_append = "_input";
            string newfilename = filename + input_append;
            string[] cols;

            this.m_FileName = filename;

            //Create a copy of the file.  Workaround so that input files can be saved.
            if (File.Exists(newfilename))
                File.Delete(newfilename);
            File.Copy(filename, newfilename);

            try
            {
                System.IO.StreamReader sr = new System.IO.StreamReader(newfilename);
                sr.BaseStream.Seek(0, SeekOrigin.Begin);
                while (sr.Peek() > -1)
                {
                    line = sr.ReadLine();
                    if (line != "")
                    {
                        //Split the Coma Delimited into array cols.							
                        char[] sep = { m_delimeter };
                        cols = line.Split(sep);

                        if (i == 0) //setup datacolumns - First Row
                        {                            
                            if (LineReadOpt == FileImporterOptionEnum.FirstRowHasColumnDefs)
                            {                                
                                for (int c = 0; c < cols.Length; c++)
                                {
                                    string col = cols[c].ToString().Trim();
                                    DataColumn dc = new DataColumn();
                                    dc.ColumnName = col;
                                    this.m_dtbuffer.Columns.Add(dc);
                                }
                            }
                            else
                            {
                                for (int c = 0; c < cols.Length; c++)
                                {
                                    DataColumn dc = new DataColumn();
                                    dc.ColumnName = c.ToString();
                                    this.m_dtbuffer.Columns.Add(dc);
                                }
                            }
                        }
                        else
                        {                           
                            //populate datatable with speadsheet data
                            DataRow dr = this.m_dtbuffer.NewRow();
                            for (int c = 0 ; c < cols.Length; c++)
                            {
                                dr[c] = cols[c].ToString().Trim();
                            }
                            this.m_dtbuffer.Rows.Add(dr);
                        }
                        i++;
                    }
                }
                sr.Close();
                if (i < 1) throw new ApplicationException("No data contained in " + m_FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Row " + i + " " + ex.Message);
            }

            //Delete
            File.Delete(newfilename);
        }

        public void ReadXLFile(string path, string query_string)
        {
            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + path;

            //Open Connection
            OleDbConnection oConn = new OleDbConnection();
            oConn.ConnectionString = strConn;
            oConn.Open();

            //Create DataAdapter
            OleDbDataAdapter oCmd = new OleDbDataAdapter(query_string, oConn);

            try
            {
                //Load the DataSet
                DataSet ds = new DataSet();
                oCmd.Fill(ds);
                this.dtBuffer.Merge(ds.Tables[0]);
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

        #region Properties
        public DataTable dtBuffer
        {
            get { return m_dtbuffer; }
        }
        public char ColumnDelimeter
        {
            get { return this.m_delimeter; }
            set { this.m_delimeter = value; }
        }
        public string FileName
        {
            get { return this.m_FileName; }
        }
        public FileImporterOptionEnum LineReadOption
        {
            get { return LineReadOpt; }
            set { LineReadOpt = value; }
        }
        public string DialogDirectory
        {
            get { return this.m_InitialDir; }
            set { this.m_InitialDir = value; }
        }
        #endregion
    }

    public class Common
    {
        
        public static double SafeDouble(object obj)
        {
            if (obj == null || obj.ToString() == ""  ) return 0.0;
            else
            {
                try
                {
                    string s = obj.ToString();
                    return double.Parse(s.Trim());
                }
                catch (Exception ex)
                {
                    throw ex;
                }                    
            }            
        }
        public static int SafeInt(object obj)
        {            
            if (obj == null || obj.ToString() == "") return 0;
            else
            {   string s = obj.ToString();
                return int.Parse(s);
            }
        }
    }

    public class Lookup
    {
        public static string LookupMSAccount(string faportfolio)
        {
            RecTool.AccountMapping AcctMapObj = RecTool.AccountMapping.GetInstance();
            return AcctMapObj.GetAccountName(faportfolio);
        }

        public static RecTool.SideEnum LookupSideEnum(string side)
        {
            SideEnum retval;
            if (side == SideEnum.Side1.ToString())
                retval = SideEnum.Side1;
            else if (side == SideEnum.Side2.ToString())
                retval = SideEnum.Side2;
            else
                throw new Exception("No Enum Value for " + side);

            return retval;            
        }

    }

    public struct ComboBoxItem
    {
        private object id;
        private string name;

        public ComboBoxItem(object id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public object Id
        {
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }

    public class Error
    {
        public static void ErrMsgBox(string msg)
        {
            ErrMsgBox(msg, "Error");
        }
        public static void ErrMsgBox(string msg, string caption)
        {
            MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

    

