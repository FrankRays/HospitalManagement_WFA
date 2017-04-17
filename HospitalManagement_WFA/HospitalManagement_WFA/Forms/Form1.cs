using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement_WFA.Admin;

namespace HospitalManagement_WFA
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            if (username.StartsWith("a"))
            {
                   ClassAdminLoginVerification.Verification(username, password,this);
            }
            else {
                MessageBox.Show("Log In Failed","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void buttonBloodDonation_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBloodDonation bd = new FormBloodDonation(this);
            bd.ShowDialog();
            
        }

        private void FormHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormPharmasy fp = new FormPharmasy(this);
            fp.ShowDialog();
        }

        private void buttonBooking_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonBDSopitals_Click(object sender, EventArgs e)
        {
            FormHMSwebBrowser web = new FormHMSwebBrowser();
            web.Show();
        }
    }
}
