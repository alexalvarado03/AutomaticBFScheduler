using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*******************************
 Code written by: Alex Alvarado
 This code is for Phoenix Book Company LLC.
 Last Edited: 5/20/2025
 ******************************/

namespace BFConfigApp
{


    public partial class CaseFairConfig : Form
    {
        private UserSession session; //session will hold the fair object

        private ConfigForm configFormRef;

        private bool ConfigNameIsValid = false;
        public CaseFairConfig(ConfigForm form, UserSession session)
        {
            InitializeComponent();
            configFormRef = form;
            this.session = session;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateCaseConfigPage(); //generates config page on load
        }

        //This is the function for the back button
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            configFormRef.Show();
        }

        //this function dynamically generates labels depending on the number of cases selected on ConfigForm
        private void GenerateCaseConfigPage()
        {
            flowLayoutPanelHolder.Controls.Clear(); //clears old labels if any
            foreach (KeyValuePair<string, int> entry in session.AllCaseNum) //goes through all the values in session to generate all the cases
            {
                string name = entry.Key;
                int numCases = entry.Value;


                for (int i = 1; i <= numCases; i++) //for each cases type a label is generated for the number of cases selected in ConfigForm
                {
                    Label CaseLabel = new Label();
                    ComboBox CaseNameComboBox = new ComboBox();
                    CaseNameComboBox.DataSource = Enum.GetValues(typeof(TypeOfCase));
                    CaseNameComboBox.Name = $"CaseNameComboBox{i}";
                    CaseLabel.Text = $"{name}{i}";
                    CaseLabel.Name = $"{name}{i}Lbl";
                    CaseLabel.AutoSize = true;
                    CaseLabel.Margin = new Padding(5);
                    flowLayoutPanelHolder.Controls.Add(CaseLabel); //Adds label to flow panel
                    flowLayoutPanelHolder.Controls.Add(CaseNameComboBox); //Adds combo box to flow panel
                }
            }
        }

        //This function checks that the configuration name is valid
        private void ConfigurationNameTB_TextChanged(object sender, EventArgs e)
        {
            string ConfigName = ConfigurationNameTB.Text;
            if (ConfigName == null || ConfigName == "") 
            {
                ErrorLabel.ForeColor = Color.Red;
                ErrorLabel.Text = "Please enter name.";
                ConfigNameIsValid = false;
            }
            else
            {
                ErrorLabel.Text = "";
                ConfigNameIsValid = true;
            }

        }

        //This function saves the new data from this form
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (ConfigNameIsValid)
            {
                session.ConfigurationName = ConfigurationNameTB.Text.Trim(); //saves config name
                foreach (KeyValuePair<string, int> entry in session.AllCaseNum) //saves the selected items from the drop downs for each case
                {
                    string name = entry.Key;
                    int numCases = entry.Value;
                    for (int i = 1; i <= numCases; i++)
                    {
                        ComboBox? comboBox = flowLayoutPanelHolder.Controls.Find($"CaseNameComboBox{i}", true).FirstOrDefault() as ComboBox;
                        if (comboBox != null)
                        {
                            string key = $"{name}{i}";
                            if (!session.CasesDataHolder.ContainsKey(key))
                            {
                                session.CasesDataHolder[key] = new CaseTypeObject();
                            }
                            session.CasesDataHolder[key].CaseType = (TypeOfCase)comboBox.SelectedIndex;
                            session.CasesDataHolder[key].CaseName = key;
                        }
                        else
                        {
                            Console.WriteLine("Something is amiss with the combo boxes when saving.");
                        }
                    }
                }
            }
        }
    }
}
