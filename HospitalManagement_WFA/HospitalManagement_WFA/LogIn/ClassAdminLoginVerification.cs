using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using HospitalManagement_WFA.CommonUI;

namespace HospitalManagement_WFA.Admin
{
    static class ClassAdminLoginVerification
    {

        public static void Verification(string username, string password, FormHome home)
        {
            
            string trueFalseValue = firstStepOfVerification(username,password); 
         

            if (trueFalseValue == "1")
            {
                //--------------successfull Log In
                MessageBox.Show("Successfull Log In", "Message");

                //-----------------close Home Form and Open Admin Form
                home.Hide();

                FormAdminPanel fap = new FormAdminPanel(ref username);
                fap.ShowDialog();
            }
            else
            {
                //--------------Failed Log In
                MessageBox.Show("Log In Failed", "Message");
            }


        }

        public static void employeeVerification(string username, string password, FormHome home,FormPharmasy pharmasyForm)
        {
            
            string trueFalseValue = firstStepOfVerification(username,password);

            if (trueFalseValue == "1")
            {
                //--------------successfull Log In
                MessageBox.Show("Successfull Log In", "Message");

                //-----------------close pharmasy Form and Open Sell Form
                home.Hide();
                pharmasyForm.Hide();

                FormDrugSell ds = new FormDrugSell(username);
                ds.ShowDialog();
            }
            else
            {
                //--------------Failed Log In
                MessageBox.Show("Log In Failed", "Message");
            }


        }

        public static string firstStepOfVerification(string username,string password) 
        {
            string query = "SELECT COUNT (*) FROM AccountTable WHERE Username = '" + username + "' AND Password = '" + password + "' ";
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);

            string trueFalseValue = dt.Rows[0][0].ToString();
            return trueFalseValue;
        }
    }
}
