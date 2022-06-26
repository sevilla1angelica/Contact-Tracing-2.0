using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_2._0
{
    public partial class Contact_Tracing_Monitory : Form
    {
        public Contact_Tracing_Monitory()
        {
            InitializeComponent();
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader (@"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\test.txt");
            MessageBox.Show(reader.ReadToEnd() ,"Records");
        }
    }
}
