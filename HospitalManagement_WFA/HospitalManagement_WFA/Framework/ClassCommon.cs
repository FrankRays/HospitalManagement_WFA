using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace HospitalManagement_WFA.CommonUI
{
    static class ClassCommon
    {
        static string connectionString = "Data Source=SHOVON-PC\\SQLEXPRESS;Initial Catalog=HospitalMSdatabase;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connectionString);

        public static void SqlC_DAOpenFillCose(string query, DataTable dt)
        {
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            connection.Open();
            da.Fill(dt);
            connection.Close();

            
        }

        public static void CommonPeocessOfDelete(string myCmnd, SqlParameter changeParaMeter, string DeletedID)
        {
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);
            changeParaMeter.Value = DeletedID;
            cmnd.Parameters.Add(changeParaMeter);

            connection.Open();
            cmnd.ExecuteNonQuery();
            connection.Close();
        }
        
        

        public static void ExecuteOpenCose(SqlCommand command)
        {
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }

    }
}
