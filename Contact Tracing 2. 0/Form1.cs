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
        }

        private void btn2Yes_Click(object sender, EventArgs e)
        {
            txtboxDryCough.Text = " Yes :< ";
        }

        private void btn3Yes_Click(object sender, EventArgs e)
        {
            txtbxFatigue.Text = " Yes :< ";
        }

        private void btn4Yes_Click(object sender, EventArgs e)
        {
            txtbxAchesandPains.Text = " Yes :< ";
        }

        private void btn5Yes_Click(object sender, EventArgs e)
        {
            txtbx5RunnyRose.Text = " Yes :< ";
        }

        private void btn6Yes_Click(object sender, EventArgs e)
        {
            txtbxSoreThroat.Text = " Yes :< ";
        }

        private void btn7Yes_Click(object sender, EventArgs e)
        {
            txtbxShortnessofBreathe.Text = " Yes :< ";
        }

        private void btn8Yes_Click(object sender, EventArgs e)
        {
            txtbx8Diarrhea.Text = " Yes :< ";
        }
    }
}