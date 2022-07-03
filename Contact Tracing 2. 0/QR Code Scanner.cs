using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;
using System.IO;
using ZXing.Aztec.Internal;
using ZXing.Windows.Compatibility;

namespace Contact_Tracing_2._0
{
    public partial class QR_Code_Scanner : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;

        public QR_Code_Scanner()
        {
            InitializeComponent();
        }

        private void QR_Code_Scanner_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                cmbxCam.Items.Add(Device.Name);

            cmbxCam.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmbxCam.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pctrbxscan.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private VideoCaptureDevice GetFinalFrame()
        {
            return FinalFrame;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader reader = new BarcodeReader();
            Result result = reader.Decode((Bitmap)pctrbxscan.Image);
            try
            {
                string decoded = result.ToString().Trim();
                if (decoded != "")
                {
                    txtbxQRCodeScan.Text = decoded;
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            ScanTimer.Start();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string data = txtbxQRCodeScan.Text;
            if (data != "")
            {
                MessageBox.Show("Can't be read.", "Try Again");
            }
            else
            {
                StreamWriter dataFromQRCode = new StreamWriter(@"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\scanned code.txt", true);
                dataFromQRCode.WriteLine(data);
                dataFromQRCode.Close();

                CntctTrcngform form1 = new CntctTrcngform();
                form1.Show();
                
                string path = @"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\scanned code.txt";
                StreamReader read = new StreamReader(path);
                string fileName = read.ReadToEnd();
            }
        }

        private void QR_Code_Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning == true)
                FinalFrame.SignalToStop();
        }
    }
}
