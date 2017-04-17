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
    public partial class FormPharmasy : Form
    {
        FormHome home;
        public FormPharmasy(FormHome h)
        {
            home = h;
            InitializeComponent();
        }

        private void buttonShowDrugList_Click(object sender, EventArgs e)
        {

            home.Hide();
            this.Hide();

            string query = "SELECT * FROM PharmasyTable";
          
            FormShowDrugList sdl = new FormShowDrugList(query);
            sdl.ShowDialog();
        }

        private void buttonEmployeeLogIn_Click(object sender, EventArgs e)
        {
            //--------------------------Employee Log In Verification
            string username = textBoxEmployeeUN.Text;
            string password = textBoxEmployeePW.Text;
            if (username.StartsWith("e"))
            {
                ClassAdminLoginVerification.employeeVerification(username,password,home,this);
                FormDrugSell fds = new FormDrugSell(username);
                //ClassAdminLoginVerification.Verification(username, password, this);
            }
            else
            {
                MessageBox.Show("Log In Failed", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
