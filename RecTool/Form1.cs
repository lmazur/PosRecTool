using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utility;
using System.Data.OleDb;
using System.IO;


namespace RecTool
{
    public partial class Form1 : Form
    {
        private DataTable _dt;
        private DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this._dt != null) this._dt.Clear();
            if( this.ds != null) this.ds.Clear();
            try
            {
                if (this.rbcsv.Checked)
                    this.ReadCsvFileIntoDT(this.txtFileLoc1.Text);
                if (this.rbxls.Checked)
                    this.LoadXLFile(this.txtFileLoc1.Text);

                this.dataGridView1.DataSource = this._dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetQueryString()
        {
            string sql = "SELECT *";
            sql += " FROM [MS$]";
            //sql += " WHERE where [PORTFOLIO ID] in ('38141198', '38140190', '38140182') ";
            //sql += " and [POSITION TYPE DESCRIPTION] in ('Option')";

            return sql;
        }
        private void LoadXLFile(string path)
        {

            string strConn;
            strConn = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=" + path;
            
            //Open Connection
            OleDbConnection oConn = new OleDbConnection();
            oConn.ConnectionString = strConn;
            oConn.Open();

            //
            

            //Create DataAdapter
            OleDbDataAdapter oCmd = new OleDbDataAdapter(this.GetQueryString(), oConn);
            /*
            OleDbDataReader reader = oCmd.SelectCommand.ExecuteReader(CommandBehavior.Default);
            if (reader.HasRows)
            {                
                while (reader.Read())
                {
                    //Console.WriteLine("\t{0}\t{1}", reader.GetInt32(0), reader.GetString(1));
                    string s = "hello";
                }
            }
            else
            {
                //Console.WriteLine("No rows returned.");
            }

            reader.Close();
            */
            

            try
            {
                //Load the DataSet
                this.ds = new DataSet();
                oCmd.Fill(this.ds);
                this._dt = ds.Tables[0];
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

        public void ReadCsvFileIntoDT(string filename)
        {

            FileImporter fi = new FileImporter();
            fi.ReadCsvFileIntoDT(filename);

            this._dt = fi.dtBuffer;


        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this._dt.ExtendedProperties.Add("Hello", "ValueOfHello");
            
            
            _dt.WriteXmlSchema(@"c:\tmp\schema.xml");
            _dt.WriteXml(@"c:\tmp\data.xml");


            //this._dt.WriteXmlSchema(@"c:\tmp\schema.xml");
            //this._dt.WriteXml(@"c:\tmp\data.xml");
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Tester t = new Tester();
            t.Show();
            /*
            KeyMap km = new KeyMap();
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to serialize.
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(KeyMap));
            TextWriter writer = new StreamWriter(@"c:\tmp\km.xml");
            serializer.Serialize(writer, km);
            writer.Close();
            */

        }
    }
}