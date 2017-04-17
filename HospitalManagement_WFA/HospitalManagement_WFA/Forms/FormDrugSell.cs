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
using System.Diagnostics;


namespace HospitalManagement_WFA
{
    public partial class FormDrugSell : Form
    {
        string username;
        public FormDrugSell(string UN)
        {
            username=UN;
           
            InitializeComponent();
        }

        private void FormDrugSell_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormHome home = new FormHome();
            home.Show();
        }

        private void buttonShowDrugList_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowDrugList_Click_1(object sender, EventArgs e)
        {
            //-----------Show Table in DataGridView for Pharmasy Donor

            string query = "SELECT * FROM PharmasyTable";
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);
            dataGridViewShowDList.DataSource = dt;
            buttonShowDrugList.Text = "Refresh";
        }

        private void buttonSellDrug_Click(object sender, EventArgs e)
        {

            string drugSellId = textBoxDrugId.Text;
            string col = textBoxCollected.Text;
            string ret = textBoxReturned.Text;

            string query2 = "Select COUNT (*)  FROM PharmasyTable WHERE Id= '" + drugSellId + "'";
            DataTable dt2 = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query2, dt2);
            string truevalue = dt2.Rows[0][0].ToString();

            if (truevalue == "1")
            {
                if (drugSellId != "" && col != "" && ret != "")     //------------- For Exception Handel (Sell Button Click Without Input)
                {
                    string query = "SELECT Price , Name ,Copies, SoldCopies FROM PharmasyTable WHERE Id= '" + drugSellId + "' ";
                    DataTable dt = new DataTable();
                    ClassCommon.SqlC_DAOpenFillCose(query, dt);
                    int orginalPrice = Convert.ToInt16(dt.Rows[0][0].ToString());
                    string drugName = dt.Rows[0][1].ToString();
                    int RemainCopies = Convert.ToInt16(dt.Rows[0][2].ToString());
                    int SoldCopies = Convert.ToInt16(dt.Rows[0][3].ToString());

                    int collected = Convert.ToInt16(col);
                    int returned = Convert.ToInt16(ret);
                    
               
                    if (((collected - returned) == orginalPrice) && RemainCopies > 0)
                    {
                        string colmnName = "Copies";
                        ClassUpdate.UpdateAnyForPharmasy(colmnName, drugSellId, RemainCopies - 1);
                        
                        string colmnName2 = "SoldCopies";
                        ClassUpdate.UpdateAnyForPharmasy(colmnName2, drugSellId, SoldCopies + 1);
                        ClassUpdate.UpdatePharmasySoldStatus(drugSellId);
                        
                        MessageBox.Show("This Producted is sold, Now Print Recipt", "Success");
                        printReceipt(drugSellId, drugName, collected, returned, orginalPrice);

                       
                    }
                    else
                    {
                        MessageBox.Show("Sell Not Possible ", "Price Not Matched", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Fill All Box ", "Enter All Textbox", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            else
            {
                MessageBox.Show("This Id Is not Exist In Database");
            }
            
        }

        private void buttonPrintRecipt_Click(object sender, EventArgs e)
        {
            


        }
        private void printReceipt(string drugSellId, string drugName, int collectedAmmount, int returnedAmmount, int orginalPrice) 
        {
            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            int second = DateTime.Now.Second;
            string timeInString = DateTime.Now.ToString();

            string nameString =username+" "+year + "y" + month + "m" + day + "d" + hour + "h" + minute + "m" + second + "s";

            string filename = "D:\\" + nameString + ".txt";

            //--------------------------------To Create a Txt file
            ProcessStartInfo myProcess = new ProcessStartInfo();
            myProcess.FileName = "notepad.exe";
            myProcess.Arguments = filename;
            Process.Start(myProcess);

            //--------------------------------To Write a Txt file
            System.IO.StreamWriter obj = new System.IO.StreamWriter(filename);
            obj.WriteLine("-------------------------------------------------");
            obj.WriteLine("File Name       :" + nameString);
            obj.WriteLine("File Created on :" + timeInString);
            obj.WriteLine("-------------------------------------------------");
            obj.WriteLine("Resposible           :"+username);
            obj.WriteLine("-------------------------------------------------");
            obj.WriteLine("Drug Id              :" + drugSellId);
            obj.WriteLine("Drug Name            :" + drugName);
            obj.WriteLine("Orginal Price        :" + orginalPrice);
            obj.WriteLine("Collected Ammount    :" + collectedAmmount);
            obj.WriteLine("Returned Ammount     :" + returnedAmmount);
            obj.WriteLine("-------------------------------------------------");
            obj.WriteLine("Thank You To Buy Drugs From Us");
            obj.Close();
        
        }

        private void FormDrugSell_Load(object sender, EventArgs e)
        {
            labelEmployee.Text = username;
        }

        private void dataGridViewShowDList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dataGridViewShowDList.CurrentCell.RowIndex;
            string selectedId = dataGridViewShowDList.Rows[rowindex].Cells[0].Value.ToString();
            textBoxDrugId.Text = selectedId;
            

        }

        private void buttonEmpLogOut_Click(object sender, EventArgs e)
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
    }
}
