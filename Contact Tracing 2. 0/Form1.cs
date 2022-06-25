namespace Contact_Tracing_2._0
{
    public partial class CntctTrcngform : Form
    {
        public CntctTrcngform()
        {
            InitializeComponent();
        }


        private void btnInformation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a health contact tracing form in relation to the COVID 19 virus. We hope for a truthful answers and cooperation from you. This would track down people who are in danger of being exposed to the virus.", "Information");
            MessageBox.Show("We will not, in any circumstances, share your personal information with other individuals or organizations without your permission, including public organizations, corporations or individuals, except when applicable by law.", "Attention");
        }

        private void dateoffillingout_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dynamicDTP = new DateTimePicker();
            dynamicDTP.Name = "DyanmicDateTimePicker";

            dynamicDTP.MinDate = new DateTime(2000, 1, 1);
            dynamicDTP.MaxDate = DateTime.Today;
        }

        private void dateoffillingup_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dynamicDTP = new DateTimePicker();
            dynamicDTP.Name = "DyanmicDateoffillingup";

            dynamicDTP.MinDate = new DateTime(2019, 1, 1);
            dynamicDTP.MaxDate = new DateTime(2025, 12, 31);
        }

        private void btn1Yes_Click(object sender, EventArgs e)
        {
            txtbxfever.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn2Yes_Click(object sender, EventArgs e)
        {
            txtbxDryCough.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn3Yes_Click(object sender, EventArgs e)
        {
            txtbxFatigue.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn4Yes_Click(object sender, EventArgs e)
        {
            txtbxAchesandPains.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn5Yes_Click(object sender, EventArgs e)
        {
            txtbxRunnyRose.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn6Yes_Click(object sender, EventArgs e)
        {
            txtbxSoreThroat.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn7Yes_Click(object sender, EventArgs e)
        {
            txtbxShortnessofBreathe.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn8Yes_Click(object sender, EventArgs e)
        {
            txtbxDiarrhea.Text = " Yes :< ";
            txtbxSummarization.Text = "With Covid Symptoms";
        }

        private void btn1No_Click(object sender, EventArgs e)
        {
            txtbxfever.Text = " No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn2No_Click(object sender, EventArgs e)
        {
            txtbxDryCough.Text = " No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn3No_Click(object sender, EventArgs e)
        {
            txtbxFatigue.Text = "No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn4No_Click(object sender, EventArgs e)
        {
            txtbxAchesandPains.Text = " No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn5No_Click(object sender, EventArgs e)
        {
            txtbxRunnyRose.Text = " No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn6No_Click(object sender, EventArgs e)
        {
            txtbxSoreThroat.Text = " No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn7No_Click(object sender, EventArgs e)
        {
            txtbxShortnessofBreathe.Text = " No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn8No_Click(object sender, EventArgs e)
        {
            txtbxDiarrhea.Text = " No :> ";
            txtbxSummarization.Text = "Without Covid Symptoms";
        }

        private void btn17Yes_Click(object sender, EventArgs e)
        {
            txtbxDiagnosedCovid.Text = " Yes :< ";
        }

        private void btn18Yes_Click(object sender, EventArgs e)
        {
            txtbxCovidSymptoms.Text = "Yes :<";
        }

        private void btn17No_Click(object sender, EventArgs e)
        {
            txtbxDiagnosedCovid.Text = " No :> ";
        }

        private void btn18No_Click(object sender, EventArgs e)
        {
            txtbxCovidSymptoms.Text = " No :> ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dateoffillingup.Text == "" || txtbxFirstName.Text == "" || txtbxLastName.Text == "" || txtbxBirthdate.Text == "" || txtbxGender.Text == "" || txtbxContactNo.Text == "" || txtbxEmailaddress.Text == "" ||
               txtbxBarangay.Text == "" || txtbxMunicipality.Text == "" || txtbxProvince.Text == "" || txtbxRegion.Text == "")
            {
                MessageBox.Show("Please fill up the form completely, thank you", "Error", MessageBoxButtons.OK);
            }
            else
            {
                StreamWriter file = new StreamWriter(@"C:\Users\HP\OneDrive\Desktop\Contact Tracing 2.0\test.txt", true);
                file.WriteLine("Date: " + dateoffillingup.Text + ", " + "Name: " + txtbxFirstName.Text + txtbxLastName.Text + ", " + "Birthdate: " + txtbxBirthdate.Text + ", " + txtbxGender.Text + "Contact no.: " + txtbxContactNo.Text
                    + ", " + "Email address of " + txtbxEmailaddress.Text + ", " + "residing at Barangay " + txtbxBarangay.Text + ", " + txtbxMunicipality.Text + ", " + txtbxProvince.Text + ", " + txtbxRegion.Text + ", Temperature of " + txtbxTemp.Text
                    + ", " + txtbxSummarization.Text + ", Contact with Diagnosed Covid person = " + txtbxDiagnosedCovid.Text + ", Contact with person who has covid symptoms = " + txtbxCovidSymptoms.Text);

                MessageBox.Show("Keep safe at all times, especially at this time of pandemic." , "Thank you for filling up the form!", MessageBoxButtons.OK);
                file.Close();
            }
        }

        private void btnContactMonitoring_Click(object sender, EventArgs e)
        {
            Authorized_Personnel_Log authorized_Personnel = new Authorized_Personnel_Log();
            authorized_Personnel.Show();
        }
    }
}