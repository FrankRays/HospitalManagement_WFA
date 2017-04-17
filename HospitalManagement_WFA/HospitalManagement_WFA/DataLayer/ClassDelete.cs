using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HospitalManagement_WFA.CommonUI
{
    static class ClassDelete
    {
        

        public static void DeleteAdminAccount(string AdminUsername)
        {
            string myCmnd = "DELETE AccountTable WHERE Username = @Username";
            SqlParameter changeParaMeter = new SqlParameter("@Username", SqlDbType.NChar, 10);
            
            //-----------------Pass To Method
            ClassCommon.CommonPeocessOfDelete(myCmnd, changeParaMeter, AdminUsername);


        }
        public static void DeleteDrugItem(string drugId)
        {
            string myCmnd = "DELETE PharmasyTable WHERE Id = @Id";
            SqlParameter changeParaMeter = new SqlParameter("@Id", SqlDbType.NChar, 10);

            //-----------------Pass To Method
            ClassCommon.CommonPeocessOfDelete(myCmnd, changeParaMeter, drugId);

            


        }
        public static void DeleteDonor(string mobileNo)
        {
            string myCmnd = "DELETE DonorTable WHERE Mobile = @Mobile";
            SqlParameter changeParaMeter = new SqlParameter("@Mobile", SqlDbType.NChar, 14);

            //-----------------Pass To Method
            ClassCommon.CommonPeocessOfDelete(myCmnd, changeParaMeter, mobileNo);

        }

    }
}
