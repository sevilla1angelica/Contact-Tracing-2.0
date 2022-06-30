using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_2._0
{
    public partial class Contact_Tracing_Monitory : Form
    {
        public Contact_Tracing_Monitory()
        {
            InitializeComponent();

        }

        private void dateoffillingup_ValueChanged(object sender, EventArgs e)
        {
            txtbxsearch.Text = dateoffillingup.Value.ToShortDateString();
        }

        private void btnAllrecords_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\test.txt");
            MessageBox.Show(reader.ReadToEnd().ToString(), "Records");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\test.txt");
            List<string> all = new List<string>();

            string Find = txtbxsearch.Text;
            string AllInfoDate = dateoffillingup.Value.ToShortDateString();
            int results = 0;
            while (!reader.EndOfStream)
            {
                string record = reader.ReadLine();
                if (record.Contains(AllInfoDate))
                {
                    if (record.Contains(Find))
                    {
                        results++;
                        all.Add(record);
                    }
                }
            }
            if (results == 0)
            {
                MessageBox.Show("No results found");
                reader.Close();
            }
            else
            {
                reader.Close();
                StreamWriter filedate = new StreamWriter(@"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\date.txt", true);
                foreach (var record in all)
                {
                    filedate.WriteLine(record);
                }
                MessageBox.Show("Found: " + results.ToString() + " records on the said date");
                filedate.Close();

                string path = @"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\date.txt";
                StreamReader read = new StreamReader(path);
                string filedata = read.ReadToEnd();
                rchtxtbxRecord.Text = filedata.ToString();
                read.Close();
            }
        }
    }
}






