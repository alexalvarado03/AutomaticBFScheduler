
/*******************************
 Code written by: Alex Alvarado
 This code is for Phoenix Book Company LLC.
 Last Edited: 5/20/2025
 ******************************/
namespace BFConfigApp
{
    public partial class ConfigForm : Form
    {
        Form1 form1;
        // These bool values are responsible for moving forward to second page
        bool CaseCompleteValid = false;
        bool CashRangeCompleteValid = false;
        bool LinenComboBoxValid = false;
        public ConfigForm()
        {
            InitializeComponent();
            numLinenComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {

        }

        // Any of the case text box changes
        private void CaseTextBox_TextChanged(object sender, EventArgs e)
        {
            int sum = -1;
            //Try to parse and return true if all the numbers are unsigned ints
            bool caseAllValid = uint.TryParse(smallSilverTB.Text, out _) &&
                            uint.TryParse(smallRainbowTB.Text, out _) &&
                            uint.TryParse(mediumPebbleTB.Text, out _) &&
                            uint.TryParse(mediumTB.Text, out _) &&
                            uint.TryParse(largeTB.Text, out _);
            try
            { //find the sum to determine if all the values are 0 or greater than 0
                sum = int.Parse(smallSilverTB.Text) +
                                int.Parse(smallRainbowTB.Text) +
                                int.Parse(mediumPebbleTB.Text) +
                                int.Parse(mediumTB.Text) +
                                int.Parse(largeTB.Text);
            }
            catch (Exception err) //if the values are not all ints then an error will be thrown
            {
                caseErrorLbl.ForeColor = Color.Red;
                caseErrorLbl.Text = "Please enter integer.";
                Console.WriteLine($"Error: {err}");
                CaseCompleteValid = false;
            }

            if ((caseAllValid) && (sum > 0) && (!tableTopFairCheckBox.Checked)) //Everything is valid 
            {
                //errorLbl.ForeColor = Color.Green;
                //errorLbl.Text = "All valid.";
                caseErrorLbl.Text = "";
                CaseCompleteValid = true;
            }
            else if ((sum == 0) && (!tableTopFairCheckBox.Checked)) //Sum is 0 but Table Top Fair is unchecked; this is invalid
            {
                caseErrorLbl.ForeColor = Color.Red;
                caseErrorLbl.Text = "Please check table top fair or enter amounts.";
                CaseCompleteValid = false;
            }
            else if ((sum > 0) && (tableTopFairCheckBox.Checked)) //Sum is greater than 0 but table top fair is checked; this is invalid
            {
                caseErrorLbl.ForeColor = Color.Red;
                caseErrorLbl.Text = "Please uncheck table top fair or change amounts to zero.";
                CaseCompleteValid = false;
            }
            else if ((sum == 0) && (tableTopFairCheckBox.Checked)) //Sum is 0 and table top fair is checked; this is valid
            {
                caseErrorLbl.Text = "";
                CaseCompleteValid = true;
            }
            else //Number not entered; Catches rest of cases could potentially need a fix if another combination is found
            {
                caseErrorLbl.ForeColor = Color.Red;
                caseErrorLbl.Text = "Please enter integer.";
                CaseCompleteValid = false;
            }
        }

        // The table top check box changes
        private void TableTopFairCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            uint sum = 1;
            try
            { //find the sum to determine if all the values are 0 or greater than 0
                sum = uint.Parse(smallSilverTB.Text) +
                                uint.Parse(smallRainbowTB.Text) +
                                uint.Parse(mediumPebbleTB.Text) +
                                uint.Parse(mediumTB.Text) +
                                uint.Parse(largeTB.Text);
            }
            catch (Exception err) //if the values are not all ints then an error will be thrown
            {
                caseErrorLbl.ForeColor = Color.Red;
                caseErrorLbl.Text = "Please enter integer.";
                Console.WriteLine($"Error: {err}");
                CaseCompleteValid = false;
            }
            if ((sum == 0) && (tableTopFairCheckBox.Checked)) //All valid
            {
                //errorLbl.ForeColor = Color.Green;
                //errorLbl.Text = "All valid.";
                caseErrorLbl.Text = "";
                CaseCompleteValid = true;
            }
            else if ((sum != 0) && (tableTopFairCheckBox.Checked)) //Sum is not 0 and the table top fair is checked; This is invalid
            {
                caseErrorLbl.ForeColor = Color.Red;
                caseErrorLbl.Text = "All case amounts should be zero if table top fair is checked.";
                CaseCompleteValid = false;
            }
            else if ((sum == 0) && (!tableTopFairCheckBox.Checked)) //Sum is 0 but table top fair is not checked; This is invalid
            {
                caseErrorLbl.ForeColor = Color.Red;
                caseErrorLbl.Text = "Please check table top fair or enter amounts.";
                CaseCompleteValid = false;
            }
            else //Number not entered; Catches rest of cases could potentially need a fix if another combination is found; This is valid
            {
                caseErrorLbl.Text = "";
                CaseCompleteValid = true;
            }
        }

        //Cash Range text boxes change
        private void CashRange_TextChanged(object sender, EventArgs e)
        {
            //Min and Max values to be stored
            uint min = 1;
            uint max = 1;
            //Return true if valid
            bool cashRangeValid = uint.TryParse(minRangeTB.Text, out _) &&
                                    uint.TryParse(maxRangeTB.Text, out _);
            try
            {
                min = uint.Parse(minRangeTB.Text);
                max = uint.Parse(maxRangeTB.Text);
            }
            catch (Exception err)
            {
                cashRangeErrorLbl.ForeColor = Color.Red;
                cashRangeErrorLbl.Text = "Please positive enter integer.";
                Console.WriteLine($"Error: {err}");
                CashRangeCompleteValid = false;
            }
            if (cashRangeValid && (min < max)) //All valid
            {
                cashRangeErrorLbl.Text = "";
                CashRangeCompleteValid = true;
            }
            else if ((cashRangeValid) && (min >= max)) //Min is greater than max; this is invalid
            {
                cashRangeErrorLbl.ForeColor = Color.Red;
                cashRangeErrorLbl.Text = "Min must be strictly less than max.";
                CashRangeCompleteValid = false;
            }
            else //Number not entered; Catches rest of cases could potentially need a fix if another combination is found
            {
                cashRangeErrorLbl.ForeColor = Color.Red;
                cashRangeErrorLbl.Text = "Please enter integer.";
                CashRangeCompleteValid = false;
            }
        }

        // Combo Box changes
        private void numLinenComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LinenComboBoxValid = true; //value just needs to change once to be valid
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (form1 == null)
            {
                form1 = new Form1(this);
            }
            if(CaseCompleteValid && CashRangeCompleteValid && LinenComboBoxValid)
            {
                completeFormLbl.Text = "";
                this.Hide();
                form1.Show();
            }
            else
            {
                completeFormLbl.ForeColor = Color.Red;
                completeFormLbl.Text = "Please complete form.";
            }

        }
    }
}
