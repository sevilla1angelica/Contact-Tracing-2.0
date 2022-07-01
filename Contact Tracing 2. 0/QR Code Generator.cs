using QRCoder;
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
    public partial class QR_Code_Generator : Form
    {
        public QR_Code_Generator()
        {
            InitializeComponent();
            string path = @"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\code.txt";
            StreamReader info = new StreamReader(path);
            string data = info.ReadToEnd();
            txtbxQRCodeGen.Text = data.ToString();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData info = qr.CreateQrCode(txtbxQRCodeGen.Text, QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(info);
            pctrbxCode.Image = code.GetGraphic(5);
        }
    }
}
