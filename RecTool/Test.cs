using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Library.SqlFilter;


namespace RecTool
{
    public partial class Tester : Form
    {
        

        public Tester()
        {
            InitializeComponent();
            //Test t = new Test();
            KeyMap km = new KeyMap();            
            
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"c:\tmp\MyFile.bin",
                                     FileMode.Create,
                                     FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, km);
            stream.Close();
        }


        public void Deserialize()
        {
            KeyMap km;

            // Open the file containing the data that you want to deserialize.
            FileStream fs = new FileStream(@"c:\tmp\MyFile.bin", FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();

                // Deserialize the hashtable from the file and 
                // assign the reference to the local variable.
                //addresses = (Hashtable)formatter.Deserialize(fs);
                km = (KeyMap)formatter.Deserialize(fs);

            }
            catch (SerializationException e)
            {
                Console.WriteLine("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }

            // To prove that the table deserialized correctly, 
            // display the key/value pairs.
            Console.WriteLine("exp = {0}.", km.FilterString);
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deserialize();
        }

        private void Tester_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rECONDataSet.MSvsFAMtMDiff' table. You can move, or remove it, as needed.
            this.mSvsFAMtMDiffTableAdapter1.Fill(this.rECONDataSet.MSvsFAMtMDiff);

            this.mSvsFAMtMDiffTableAdapter1.Fill(this.rECONDataSet.MSvsFAMtMDiff);
        }

    }



  
}