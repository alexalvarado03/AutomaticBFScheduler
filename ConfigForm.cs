namespace BFConfigApp
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void CaseTextBox_TextChanged(object sender, EventArgs e)
        {
            bool caseAllValid = int.TryParse(smallSilverTB.Text, out _) &&
                            int.TryParse(smallRainbowTB.Text, out _) &&
                            int.TryParse(mediumPebbleTB.Text, out _) &&
                            int.TryParse(mediumTB.Text, out _) &&
                            int.TryParse(largeTB.Text, out _);
            if(caseAllValid)
            {
                errorLbl.ForeColor = Color.Green;
                errorLbl.Text = "All valid.";
            }
            else
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please enter number.";
                
            }
        }
    }
}
