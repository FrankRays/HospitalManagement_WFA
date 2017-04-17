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
using System.IO;

namespace HospitalManagement_WFA
{
    public partial class FormAdminPanel : Form
    {
        string adminUsername;

        public FormAdminPanel(ref string UN)
        {
            adminUsername = UN;
            InitializeComponent();
        }

        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            label21.Text = adminUsername;
        }

        private void FormAdminPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageHome);
        }

        private void pharmasyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adminAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageAdminAccount);
        }

        private void bloodBonationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonChangePW_Click(object sender, EventArgs e)
        {
            //-------------------Change Admin Password
            string GivenChange = textBoxPassword.Text;
            string ColmnName = "Password";
            int ColmnMaxValue = 10;
            ClassUpdate.UpdateAdminsAnyInfo(ColmnName, ColmnMaxValue, adminUsername, GivenChange);
            MessageBox.Show("Success");
            buttonShowAdminDGV_Click(sender, e);

        }

        private void buttonChangeMobile_Click(object sender, EventArgs e)
        {
            //-------------------Change Admin Mobile
            string GivenChange = textBoxMobile.Text;
            string ColmnName = "Mobile";
            int ColmnMaxValue = 14;
            ClassUpdate.UpdateAdminsAnyInfo(ColmnName, ColmnMaxValue, adminUsername, GivenChange);
            MessageBox.Show("Success");
            buttonShowAdminDGV_Click(sender, e);
        }

        private void buttonShowAdminDGV_Click(object sender, EventArgs e)
        {
            //---------------------showing Admin Information in DataGridView
            string query = "SELECT * FROM AccountTable WHERE Username = '" + adminUsername + "'";
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);
            dataGridViewAdmin.DataSource = dt;
            buttonShowAdminDGV.Text = "Refresh";
        }

        private void buttonChangeAddress_Click(object sender, EventArgs e)
        {
            //-------------------Change Admin Address
            string GivenChange = textBoxAddress.Text;
            string ColmnName = "Address";
            int ColmnMaxValue = 50;

            ClassUpdate.UpdateAdminsAnyInfo(ColmnName, ColmnMaxValue, adminUsername, GivenChange);
            MessageBox.Show("Success");
            buttonShowAdminDGV_Click(sender, e);
        }

        private void buttonDeleteAccountPermamently_Click(object sender, EventArgs e)
        {
            //---------------Confirmation for Delete Account Permanently
            string message = "Sure To Delete Account??";
            string title = "Admin Account Delete Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                ClassDelete.DeleteAdminAccount(adminUsername);
                MessageBox.Show("Success");
                Application.Exit();
            }
        }

        private void logOuttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            //---------------Confirmation for Log Out
            string message = "Sure To Do Log Out??";
            string title = "Log Out and Application Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void goToTabToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteDonorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //------------------------------Delete Donor Panal On
            tabControl1.SelectTab(tabPageBloodDonation);
            panelDonorComent.Visible = false;
            panelDonorDelete.Visible = true;

        }

        private void tabPageBloodDonation_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowDonorList_Click(object sender, EventArgs e)
        {

            //-----------Show Table in DataGridView for Blood Donor
            string query = "SELECT * FROM DonorTable";
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);
            dataGridViewDonorList.DataSource = dt;
            buttonShowDonorList.Text = "Refresh";
        }

        private void buttonDeleteDonorInfo_Click(object sender, EventArgs e)
        {
            //----------------------Delete Donor from Donor Table
            string DonorMobile = textBoxDonorIDtoDelete.Text;

            if (DonorMobile != "")
            {
                //---------------------------------------Query For found Id Exist in database
                string query = "Select COUNT (*)  FROM DonorTable WHERE Mobile= '" + DonorMobile + "'";
                DataTable dt = new DataTable();
                ClassCommon.SqlC_DAOpenFillCose(query, dt);
                string truevalue = dt.Rows[0][0].ToString();

                if (truevalue == "1")
                {
                    //Database
                    ClassDelete.DeleteDonor(DonorMobile);
                    MessageBox.Show("Success");
                    buttonShowDonorList_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("ID " + DonorMobile + " Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Fill Field");
            }
        }

        private void addCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //----------------------------------Add Comment Pannel On
            tabControl1.SelectTab(tabPageBloodDonation);
            panelDonorDelete.Visible = false;
            panelDonorComent.Visible = true;
        }

        private void buttonAddDonorComment_Click(object sender, EventArgs e)
        {
            //--------------------Adding Donor Comment
            string DonorMobile = textBoxDonorIdToAddComment.Text;
            if (DonorMobile != "")
            {
                //---------------------------------------Query For found Id Exist in database
                string query = "Select COUNT (*)  FROM DonorTable WHERE Mobile= '" + DonorMobile + "'";
                DataTable dt = new DataTable();
                ClassCommon.SqlC_DAOpenFillCose(query, dt);
                string truevalue = dt.Rows[0][0].ToString();

                if (truevalue == "1")
                {
                    if (radioButtonActive.Checked)
                    {
                        string comment = "Active " + DateTime.Now.ToString();
                        ClassUpdate.UpdateDonorComment(DonorMobile, comment);
                        MessageBox.Show("Success");
                        buttonShowDonorList_Click(sender, e);
                    }
                    else if (radioButtonNoComment.Checked)
                    {
                        string comment = "";
                        ClassUpdate.UpdateDonorComment(DonorMobile, comment);
                        MessageBox.Show("Success");
                        buttonShowDonorList_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Please Check A RadioButton");
                    }
                }
                else
                {
                    MessageBox.Show("This Mobile No Foun in Database");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Mobile No");
            }
           
        }

        private void dataGridViewDonorList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewDonorList.CurrentCell.RowIndex;
            string selectedMobile = dataGridViewDonorList.Rows[rowindex].Cells[1].Value.ToString();
            if (panelDonorDelete.Visible == true)
            {
                textBoxDonorIDtoDelete.Text = selectedMobile;
            }
            else if (panelDonorComent.Visible == true)
            {
                textBoxDonorIdToAddComment.Text = selectedMobile;
            }

        }

        private void deleteCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteDonorToolStripMenuItem_Click(sender, e);
        }

        private void goToTabToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void addCommentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            addCommentToolStripMenuItem_Click(sender, e);
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            logOuttoolStripMenuItem_Click(sender, e);
        }

        private void adminAccountToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            adminAccountToolStripMenuItem_Click(sender, e);
        }

        private void goToTabToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void insertNewDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPagePharmasyControl);
            panelInsertDrug.Visible = true;
            panelUpdateCopies.Visible = false;
            panelUpdatePrice.Visible = false;
            panelDeleteDrugs.Visible = false;
        }

        private void updatePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPagePharmasyControl);
            panelInsertDrug.Visible = false;
            panelUpdateCopies.Visible = false;
            panelUpdatePrice.Visible = true;
            panelDeleteDrugs.Visible = false;
        }

        private void updateCopiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPagePharmasyControl);
            panelInsertDrug.Visible = false;
            panelUpdateCopies.Visible = true;
            panelUpdatePrice.Visible = false;
            panelDeleteDrugs.Visible = false;
        }

        private void deleteDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPagePharmasyControl);
            panelInsertDrug.Visible = false;
            panelUpdateCopies.Visible = false;
            panelUpdatePrice.Visible = false;
            panelDeleteDrugs.Visible = true;
        }

        private void bloodDonationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageBloodDonation);
        }

        private void buttonShowPharmasyList_Click(object sender, EventArgs e)
        {
            //-----------Show Table in DataGridView for Pharmasy 

            string query = "SELECT * FROM PharmasyTable";
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);
            dataGridViewPharmasyTable.DataSource = dt;
            buttonShowPharmasyList.Text = "Refresh";
        }

        private void buttonUpdatePrice_Click(object sender, EventArgs e)
        {
            //-----------------------Update Price of Drugs
            string givenID = textBoxDrugIdUpdatePrice.Text;
            string givenPrice = textBoxUpdatePrice.Text;
            

            if (givenID != "" && givenPrice != "")
            {
                //---------------------------------------Query For found Id Exist in database
                string query = "Select COUNT (*)  FROM PharmasyTable WHERE Id= '" + givenID + "'";
                DataTable dt = new DataTable();
                ClassCommon.SqlC_DAOpenFillCose(query, dt);
                string truevalue = dt.Rows[0][0].ToString();

                if (truevalue == "1")
                {
                    //Database
                    int price = Convert.ToInt16(givenPrice);
                    string colmnName = "Price";
                    ClassUpdate.UpdateAnyForPharmasy(colmnName, givenID, price);
                    MessageBox.Show("Success");
                    buttonShowPharmasyList_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("ID " + givenID + " Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Field");
            }
        }

        private void buttonUpdateCopies_Click(object sender, EventArgs e)
        {
            //----------------------Update Copies of Drugs
            string givenID = textBoxDrugIdUpdateCopies.Text;
            string givenCopies = textBoxUpdateCopies.Text;

            if (givenID != "" && givenCopies !="")
            {
                //---------------------------------------Query For found Id Exist in database
                string query = "Select COUNT (*)  FROM PharmasyTable WHERE Id= '" + givenID + "'";
                DataTable dt = new DataTable();
                ClassCommon.SqlC_DAOpenFillCose(query, dt);
                string truevalue = dt.Rows[0][0].ToString();

                if (truevalue == "1")
                {
                    //Database
                    int Copies = Convert.ToInt16(givenCopies);
                    string colmnName = "Copies";
                    ClassUpdate.UpdateAnyForPharmasy(colmnName, givenID, Copies);
                    MessageBox.Show("Success");
                    buttonShowPharmasyList_Click(sender, e);
                    
                }
                else
                {
                    MessageBox.Show("ID " + givenID + " Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Field");
            }

            

        }

        private void buttonDrugInsert_Click(object sender, EventArgs e)
        {
            //-----------------------Insert New Drugs
            string id = textBoxDrugIdInsert.Text;
            string name = textBoxDrugName.Text;
            string givenprice = textBoxDrugPriceInsert.Text;
            string givencopies = textBoxDrugCopiesInsert.Text;

            if (id != "" && name != "" && givenprice != "" && givencopies != "")
            {
                //---------------------------------------Query For found Id Exist in database
                string query = "Select COUNT (*)  FROM PharmasyTable WHERE Id= '" + id + "'";
                DataTable dt = new DataTable();
                ClassCommon.SqlC_DAOpenFillCose(query, dt);
                string truevalue = dt.Rows[0][0].ToString();
                if (truevalue == "0")
                {
                    //Database
                    int Price = Convert.ToInt16(givenprice);
                    int Copies = Convert.ToInt16(givencopies);
                    ClassInsert.InsertInPharmasyTable(id, name, Price, Copies);
                    MessageBox.Show("Success");
                    buttonShowPharmasyList_Click(sender, e);

                }
                else
                {
                    MessageBox.Show("Given Id already In Database");
                }

            }
            else
            {
                MessageBox.Show("Please Fill All Field");
            }


            
        }

        private void buttonDrugDelete_Click(object sender, EventArgs e)
        {
            //----------------------Delete Drug Form PharmasyTable
            string drugId = textBoxDrugIdDelete.Text;
            

            if (drugId != "")
            {
                //---------------------------------------Query For found Id Exist in database
                string query = "Select COUNT (*)  FROM PharmasyTable WHERE Id= '" + drugId + "'";
                DataTable dt = new DataTable();
                ClassCommon.SqlC_DAOpenFillCose(query, dt);
                string truevalue = dt.Rows[0][0].ToString();

                if (truevalue == "1")
                {
                    //Database
                    ClassDelete.DeleteDrugItem(drugId);
                    MessageBox.Show("Success");
                    buttonShowPharmasyList_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("ID " + drugId + " Not Found");
                }
            }
            else
            {
                MessageBox.Show("Please Fill All Field");
            }
        }

        private void buttonShowSoldList_Click(object sender, EventArgs e)
        {
            //-----------Show Table in DataGridView for Sold List

            string query = "SELECT * FROM PharmasyTable WHERE TodayStatus= 'Sold' ";
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);
            dataGridViewShowSoldList.DataSource = dt;
            buttonShowSoldList.Text = "Refresh";
        }

        private void pharmasyControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pharmasyToolStripMenuItem_Click(sender, e);
        }

        private void insertNewDrugToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            insertNewDrugToolStripMenuItem_Click(sender, e);
        }

        private void updatePriceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updatePriceToolStripMenuItem_Click(sender, e);
        }

        private void updateCopiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            updateCopiesToolStripMenuItem_Click(sender, e);
        }

        private void deleteDrugsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteDrugToolStripMenuItem_Click(sender, e);
        }

        private void insertNewDrugToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            insertNewDrugToolStripMenuItem_Click(sender, e);
        }

        private void updatePriceToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updatePriceToolStripMenuItem_Click(sender, e);
        }

        private void updateCopiesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            updateCopiesToolStripMenuItem_Click(sender, e);
        }

        private void deleteDrugsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteDrugToolStripMenuItem_Click(sender, e);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can Insert, Update Price Copies,Delete Drug Form Here", "Help Message");
        }

        private void deleteDonorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            deleteDonorToolStripMenuItem_Click(sender, e);
        }

        private void addCommentToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            addCommentToolStripMenuItem_Click(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can Delete Donor and Add Comment Form Here", "Help Message");
        }

        private void logOutToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            logOuttoolStripMenuItem_Click(sender, e);
        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You Can Update Your Information", "Help Message");
        }

        private void dataGridViewPharmasyTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //--------------------Auto Fill Textbox by clickin CellContent
            int rowindex = dataGridViewPharmasyTable.CurrentCell.RowIndex;
            string selectedid = dataGridViewPharmasyTable.Rows[rowindex].Cells[0].Value.ToString();

            if (panelUpdatePrice.Visible == true)
            {
                textBoxDrugIdUpdatePrice.Text = selectedid;
            }
            else if (panelUpdateCopies.Visible == true)
            {
                textBoxDrugIdUpdateCopies.Text = selectedid;
            }
            else if (panelDeleteDrugs.Visible == true)
            {
                textBoxDrugIdDelete.Text = selectedid;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonNewRegistration_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------New Account Registration
            if (radioButtonAdmin.Checked == false && radioButtonEmployee.Checked == false)
            {
                MessageBox.Show("Please Check Admin or Employee", "Check Radio Button", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //----------------Complete Registration
                string name = textBoxRegName.Text;
                string username = textBoxRegUN.Text;
                string password = textBoxRegPW.Text;
                string mobile = textBoxRegMobile.Text;
                string address = textBoxRegAddress.Text;
                if ((radioButtonAdmin.Checked == true && username.StartsWith("a")) || (radioButtonEmployee.Checked == true && username.StartsWith("e")))
                {
                    string query = "Select COUNT (*)  FROM AccountTable WHERE Username= '" + username + "'";
                    DataTable dt = new DataTable();
                    ClassCommon.SqlC_DAOpenFillCose(query, dt);
                    string truevalue = dt.Rows[0][0].ToString();

                    if (truevalue == "0")
                    {
                        ClassInsert.InsertAdminEmployeeRegistration(name, username, password, mobile, address);
                        MessageBox.Show("Success");
                    }
                    else
                    {
                        MessageBox.Show(username+" Username Already Exist");
                    }
                
                    
                }
                else
                {
                    MessageBox.Show("Admin Username must start with (a) and\nEmployee Username must start with (e)", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageNewRegistration);
        }

        private void buttonDeleteSoldList_Click(object sender, EventArgs e)
        {
            //---------------------------------------------Delete Sold Item
            DialogResult res = MessageBox.Show("Are You Sure To Delete Sold Data ", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string query = "UPDATE PharmasyTable SET TodayStatus=' ' ,SoldCopies = '0' WHERE TodayStatus = 'Sold' ";
                DataTable dt = new DataTable();
                ClassCommon.SqlC_DAOpenFillCose(query, dt);
                buttonShowSoldList_Click(sender, e);
            }


        }

        private void buttonGetPrintedReceipt_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.Filter = "Text Files (.txt)|*.txt";
            DialogResult res = openFileDialog1.ShowDialog();

            //-------------------------------If File Selected Show File in Messagebox
            if (res == DialogResult.OK)
            {
                System.IO.StreamReader myStream = new System.IO.StreamReader(openFileDialog1.FileName);
                MessageBox.Show(myStream.ReadToEnd());
                myStream.Close();
            }


        }

        private void buttonTotalSoldAmount_Click(object sender, EventArgs e)
        {
            //-------------------------------------Get Total Sold Ammount
            string query = "SELECT SUM(SoldCopies*Price) FROM PharmasyTable WHERE TodayStatus = 'Sold'";
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);
            string getSum = dt.Rows[0][0].ToString();

            if (getSum == "")
            {
                MessageBox.Show("Total Sold Amount ::" + 0);
            }
            else
            {
                int amount = Convert.ToInt16(getSum);
                MessageBox.Show("Total Sold Amount ::" + amount);

            }

        }

        private void tabPageHome_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeleteDr_Click(object sender, EventArgs e)
        {
           
        }
    }
}
