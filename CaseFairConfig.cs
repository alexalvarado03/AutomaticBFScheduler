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
        public CaseFairConfig(ConfigForm form, UserSession session)
        {
            InitializeComponent();
            configFormRef = form;
            this.session = session;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateCaseConfigPage();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            configFormRef.Show();
        }

        private void GenerateCaseConfigPage()
        {
            flowLayoutPanelHolder.Controls.Clear();
            foreach (KeyValuePair<string, int> entry in session.AllCaseNum)
            {
                string name = entry.Key;
                int numCases = entry.Value;
                

                for (int i = 0; i < numCases; i++)
                {
                    Label CaseLabel = new Label();
                    ComboBox CaseNameComboBox = new ComboBox();
                    CaseNameComboBox.DataSource = Enum.GetValues(typeof(TypeOfCase));
                    CaseNameComboBox.Name = $"CaseNameComboBox{i}";
                    if(i == 0)
                    {
                        CaseLabel.Text = $"{name}";
                        CaseLabel.Name = $"{name}Lbl";
                    }
                    else
                    {
                        CaseLabel.Text = $"{name} {i}";
                        CaseLabel.Name = $"{name}{i}Lbl";
                    }
                    CaseLabel.AutoSize = true;
                    CaseLabel.Margin = new Padding(5);
                    flowLayoutPanelHolder.Controls.Add(CaseLabel);
                    flowLayoutPanelHolder.Controls.Add(CaseNameComboBox);
                }
            }
        }

        private void GenerateHeader() //TODO: finish this method and create the data collection rows dynamically methods
        {
            string[] Headers = { "Initial Case Label", "Case Name", "Number Paperbacks per Title", "Number Paperback Titles", "Number Hardbacks per Title", "Number Hardcover Titles", "Total Number Titles",
                                "Total Number Books", "Titles per Case"};
            tableLayoutPanel.RowCount = Headers.Length;

        }
    }
}
