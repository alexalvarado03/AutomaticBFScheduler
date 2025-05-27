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

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            configFormRef.Show();
        }
    }
}
