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
    public partial class Authorized_Personnel_Log : Form
    {
        public Authorized_Personnel_Log()
        {
            InitializeComponent();
        }

        private void btnLog_in_Click(object sender, EventArgs e)
        {
            if (txtbxUsername.Text == "admin" && txtbxPassword.Text == "confidentialinfo")
            {
                MessageBox.Show("You can now view and monitor the contact tracing form.", "Welcome Ms. Sevi!");
                this.Close();
                
                Contact_Tracing_Monitory monitory = new Contact_Tracing_Monitory();
                monitory.Show();
            }
            else
            {
                MessageBox.Show("Wrong password." , "Error");
                this.Close();
            }
        }
    }
}
