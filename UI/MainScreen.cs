using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFConfigApp
{
    public partial class MainScreen : Form
    {

        ConfigForm configForm;
        public MainScreen()
        {
            InitializeComponent();
        }

        private void CreateNewConfigurationBtn_Click(object sender, EventArgs e)
        {
            if ((configForm == null) || (configForm.IsDisposed))
            {
                configForm = new ConfigForm(this);
            }
            this.Hide();
            configForm.Show();
        }
    }
}
