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

        // Any of the case text box changes
        private void CaseTextBox_TextChanged(object sender, EventArgs e)
        {
            int sum = -1;
            bool caseAllValid = uint.TryParse(smallSilverTB.Text, out _) &&
                            uint.TryParse(smallRainbowTB.Text, out _) &&
                            uint.TryParse(mediumPebbleTB.Text, out _) &&
                            uint.TryParse(mediumTB.Text, out _) &&
                            uint.TryParse(largeTB.Text, out _);
            try
            {
                sum = int.Parse(smallSilverTB.Text) +
                                int.Parse(smallRainbowTB.Text) +
                                int.Parse(mediumPebbleTB.Text) +
                                int.Parse(mediumTB.Text) +
                                int.Parse(largeTB.Text);
            }
            catch (FormatException err)
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please enter number.";
                Console.WriteLine($"Error: {err}");
            }

            if ((caseAllValid) && (sum > 0) && (!tableTopFairCheckBox.Checked))
            {
                //errorLbl.ForeColor = Color.Green;
                //errorLbl.Text = "All valid.";
                errorLbl.Text = "";
            }
            else if ((sum == 0) && (!tableTopFairCheckBox.Checked))
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please check table top fair or enter amounts.";
            }
            else if ((sum > 0) && (tableTopFairCheckBox.Checked))
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please uncheck table top fair or change amounts to zero.";
            }
            else if((sum == 0) && (tableTopFairCheckBox.Checked))
            {
                errorLbl.Text = "";
            }
            else
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please enter number.";

            }
        }

        // The table top check box changes
        private void tableTopFairCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            uint sum = 1;
            try
            {
                sum = uint.Parse(smallSilverTB.Text) +
                                uint.Parse(smallRainbowTB.Text) +
                                uint.Parse(mediumPebbleTB.Text) +
                                uint.Parse(mediumTB.Text) +
                                uint.Parse(largeTB.Text);
            }
            catch (FormatException err)
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please enter number.";
                Console.WriteLine($"Error: {err}");
            }
            if ((sum == 0) && (tableTopFairCheckBox.Checked))
            {
                //errorLbl.ForeColor = Color.Green;
                //errorLbl.Text = "All valid.";
                errorLbl.Text = "";
            }else if ((sum != 0) && (tableTopFairCheckBox.Checked))
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "All case amounts should be zero if table top fair is checked.";
            }
            else if ((sum == 0) && (!tableTopFairCheckBox.Checked))
            {
                errorLbl.ForeColor = Color.Red;
                errorLbl.Text = "Please check table top fair or enter amounts.";
            }
            else
            {
                errorLbl.Text = "";
            }
        }
    }
}
