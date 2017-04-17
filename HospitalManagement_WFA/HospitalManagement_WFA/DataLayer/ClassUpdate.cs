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
    static class ClassUpdate
    {
        static string connectionString = "Data Source=SHOVON-PC\\SQLEXPRESS;Initial Catalog=HospitalMSdatabase;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connectionString);

        public static void UpdateAdminsAnyInfo(string ColumnName, int ColmnMaxValue, string adminUsername, string GivenChange)
        {
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "UPDATE AccountTable SET " + ColumnName + "= @" + ColumnName + "  WHERE Username =  @Username";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter UNParameter = new SqlParameter("@Username", SqlDbType.NChar, 10);
            UNParameter.Value = adminUsername;


            SqlParameter changeParaMeter = new SqlParameter("@" + ColumnName, SqlDbType.NChar, ColmnMaxValue);
            changeParaMeter.Value = GivenChange;

            cmnd.Parameters.Add(UNParameter);
            cmnd.Parameters.Add(changeParaMeter);

            ClassCommon.ExecuteOpenCose(cmnd);

            //-----------------Show Success Message in MessageBox
           

        }

        public static void UpdateAnyForPharmasy(string ColumnName, string givenId, int GivenChange)
        {
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "UPDATE PharmasyTable SET " + ColumnName + "= @" + ColumnName + "  WHERE Id =  @Id";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter IdParameter = new SqlParameter("@Id", SqlDbType.NChar, 10);
            IdParameter.Value = givenId;


            SqlParameter changeParaMeter = new SqlParameter("@" + ColumnName, SqlDbType.Int);
            changeParaMeter.Value = GivenChange;

            cmnd.Parameters.Add(IdParameter);
            cmnd.Parameters.Add(changeParaMeter);

            ClassCommon.ExecuteOpenCose(cmnd);

            

        }

        public static void UpdatePharmasySoldStatus(string drugId)
        {
            
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "UPDATE PharmasyTable SET TodayStatus = @TodayStatus  WHERE Id =  @Id ";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter MoParameter = new SqlParameter("@Id", SqlDbType.NChar, 10);
            MoParameter.Value = drugId;

            SqlParameter CommentParameter = new SqlParameter("@TodayStatus", SqlDbType.NChar, 10);
            CommentParameter.Value = "Sold";

            cmnd.Parameters.Add(MoParameter);
            cmnd.Parameters.Add(CommentParameter);

            ClassCommon.ExecuteOpenCose(cmnd);


        }

        public static void UpdateDonorComment(string DonorMobile, string comment)
        {
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "UPDATE DonorTable SET Comment = @Comment  WHERE Mobile =  @Mobile ";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter MoParameter = new SqlParameter("@Mobile", SqlDbType.NChar, 14);
            MoParameter.Value = DonorMobile;

            SqlParameter CommentParameter = new SqlParameter("@Comment", SqlDbType.NChar, 30);
            CommentParameter.Value = comment;

            cmnd.Parameters.Add(MoParameter);
            cmnd.Parameters.Add(CommentParameter);

            ClassCommon.ExecuteOpenCose(cmnd);

        }

       
    }
}
