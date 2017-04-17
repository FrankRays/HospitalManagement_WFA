using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalManagement_WFA.CommonUI;

namespace HospitalManagement_WFA
{
    public partial class FormBloodDonation : Form
    {
        FormHome home;
        public FormBloodDonation(FormHome h)
        {
            home = h;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void FormBloodDonation_FormClosed(object sender, FormClosedEventArgs e)
        {
            home.Show();
        }

        private void buttonCompleteRegistration_Click(object sender, EventArgs e)
        {
            if(checkBoxDonorAgree.Checked)
            {
                //-------------------------------------taking data for Donor Registration
                string name=textBoxDonorName.Text;
                string mobile=textBoxDonorMobile.Text;
                int age=Convert.ToInt16(numericUpDownDonorAge.Value);
                string sex=comboBoxDonorSex.Text;
                string address=textBoxDonorAddress.Text;
                string bloodGroup="";

                if (radioButtonAp.Checked) { bloodGroup = "A+"; }
                if (radioButtonAm.Checked) { bloodGroup = "A-"; }
                if (radioButtonABp.Checked) { bloodGroup = "AB+"; }
                if (radioButtonABm.Checked) { bloodGroup = "AB-"; }
                if (radioButtonBp.Checked) { bloodGroup = "B+"; }
                if (radioButtonBm.Checked) { bloodGroup = "B-"; }
                if (radioButtonOp.Checked) { bloodGroup = "O+"; }
                if (radioButtonOm.Checked) { bloodGroup = "O-"; }

                if (mobile.Length == 14 && bloodGroup != "")
                {
                    //---------------------------------Check for mobile existance
                    string query = "Select COUNT (*)  FROM DonorTable WHERE Mobile= '" + mobile + "'";
                    DataTable dt = new DataTable();
                    ClassCommon.SqlC_DAOpenFillCose(query, dt);
                    string truevalue = dt.Rows[0][0].ToString();

                    if(truevalue=="0")
                    {
                        //-----------------------------------All Data Get Successfully,Insert in Database
                        ClassInsert.InsertRegistrationDonorTable(mobile, bloodGroup, name, address,sex,age);
                    }
                    else
                    {
                        MessageBox.Show("This number is Already registered Before");
                    }
                    
                    
                }
                else {
                    string message = "Mobile Number Must Be valied(14 Number with +880) \nMust Check Your Blood GrouP";
                    MessageBox.Show(message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }

                
            }
            else
            {
                MessageBox.Show("You Must Need To Agree","Message");
            }
        }

        private void aToolStripMenuItemAp_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor A+
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'A+' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();
        }

        private void aToolStripMenuItemAm_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor A-
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'A-' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();
        }

        private void aBToolStripMenuItemABp_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor AB+
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'AB+' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();
        }

        private void aBToolStripMenuItemABm_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor AB-
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'AB-' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();
        }

        private void bToolStripMenuItemBp_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor B+
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'B+' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();
        }

        private void bToolStripMenuItemBm_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor B-
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'B-' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();
        }

        private void oToolStripMenuItemBp_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor O-
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'O+' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();

        }

        private void oToolStripMenuItemBm_Click(object sender, EventArgs e)
        {
            //---------------------------------Show List Of Donor O-
            this.Hide();
            string query = "SELECT * FROM DonorTable WHERE BloodGroup = 'O-' ";
            FormShowDrugList flist = new FormShowDrugList(query);
            flist.ShowDialog();
        }

        private void FormBloodDonation_Load(object sender, EventArgs e)
        {

        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("If You Register You will be Donor Listed \nWe will Call You when your blood is needed"
                                + "\nIf You Want To Delete Your Registration Please Inform To System Admin","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
