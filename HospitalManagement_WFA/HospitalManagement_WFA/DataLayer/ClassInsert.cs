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
    static class ClassInsert
    {
        static string connectionString = "Data Source=SHOVON-PC\\SQLEXPRESS;Initial Catalog=HospitalMSdatabase;Integrated Security=True";
        static SqlConnection connection = new SqlConnection(connectionString);

        public static void InsertInPharmasyTable(string id,string name,int price,int copies)
        {
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "INSERT INTO PharmasyTable (Id, Name, Price, Copies , SoldCopies) VALUES(@Id, @Name, @Price, @Copies, @SoldCopies)";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter IdParameter = new SqlParameter("@Id", SqlDbType.NChar, 10);
            IdParameter.Value = id;
            SqlParameter NameParameter = new SqlParameter("@Name", SqlDbType.NChar, 20);
            NameParameter.Value = name;
            SqlParameter PriceParameter = new SqlParameter("@Price", SqlDbType.Int);
            PriceParameter.Value = price;
            SqlParameter CopiesParameter = new SqlParameter("@Copies", SqlDbType.Int);
            CopiesParameter.Value = copies;
            SqlParameter SoldCopiesParameter = new SqlParameter("@SoldCopies", SqlDbType.Int);
            SoldCopiesParameter.Value = 0;

            cmnd.Parameters.Add(IdParameter);
            cmnd.Parameters.Add(NameParameter);
            cmnd.Parameters.Add(PriceParameter);
            cmnd.Parameters.Add(CopiesParameter);
            cmnd.Parameters.Add(SoldCopiesParameter);

            ClassCommon.ExecuteOpenCose(cmnd);


        }


        public static void InsertRegistrationDonorTable(string mobile,string bloodGroup,string name,string address,string sex,int age)
        {
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "INSERT INTO DonorTable (Mobile, BloodGroup, Name, Address, Sex, Age) VALUES(@Mobile, @BloodGroup, @Name, @Address, @Sex, @Age)";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter MobileParameter = new SqlParameter("@Mobile", SqlDbType.NChar, 14);
            MobileParameter.Value = mobile;
            SqlParameter bloodGroupParameter = new SqlParameter("@BloodGroup", SqlDbType.NChar, 5);
            bloodGroupParameter.Value = bloodGroup;
            SqlParameter NameParameter = new SqlParameter("@Name", SqlDbType.NChar,20);
            NameParameter.Value = name;

            SqlParameter addressParameter = new SqlParameter("@Address", SqlDbType.NChar,50);
            addressParameter.Value = address;
            SqlParameter sexParameter = new SqlParameter("@Sex", SqlDbType.NChar,6);
            sexParameter.Value = sex;
            SqlParameter ageParameter = new SqlParameter("@Age", SqlDbType.Int);
            ageParameter.Value = age;

            cmnd.Parameters.Add(MobileParameter);
            cmnd.Parameters.Add(bloodGroupParameter);
            cmnd.Parameters.Add(NameParameter);
            cmnd.Parameters.Add(addressParameter);
            cmnd.Parameters.Add(sexParameter);
            cmnd.Parameters.Add(ageParameter);

            ClassCommon.ExecuteOpenCose(cmnd);

            //-----------------Show Success Message in MessageBox
            string message="Name:: "+name + "\nMobile:: " + mobile + "\nAge:: " + age + "\nSex:: " + sex + "\nAddress:: " + address + "\nBloodGroup:: " + bloodGroup;
            MessageBox.Show(message, "Registration Completed");

        }

        public static void InsertAdminEmployeeRegistration(string name, string username, string password, string mobile, string address)
        {
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "INSERT INTO AccountTable (Name, Username, Password, Mobile, Address) VALUES(@Name, @Username, @Password, @Mobile, @Address)";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter NameParameter = new SqlParameter("@Name", SqlDbType.NChar, 20);
            NameParameter.Value = name;

            SqlParameter UsernameParameter = new SqlParameter("@Username", SqlDbType.NChar, 10);
            UsernameParameter.Value = username;

            SqlParameter PWParameter = new SqlParameter("@Password", SqlDbType.NChar, 10);
            PWParameter.Value = password;

            SqlParameter MobileParameter = new SqlParameter("@mobile", SqlDbType.NChar, 14);
            MobileParameter.Value = mobile;

            SqlParameter addressParameter = new SqlParameter("@Address", SqlDbType.NChar, 50);
            addressParameter.Value = address;

            cmnd.Parameters.Add(NameParameter);
            cmnd.Parameters.Add(UsernameParameter);
            cmnd.Parameters.Add(PWParameter);
            cmnd.Parameters.Add(addressParameter);
            cmnd.Parameters.Add(MobileParameter);

            ClassCommon.ExecuteOpenCose(cmnd);

            //-----------------Show Success Message in MessageBox
            string message = "Success";
            MessageBox.Show(message, "Registration Completed");

        }

        public static void InsertIntoDoctorTable(string mobile, string drName)
        {
            //---------------------------Common Change For Admin Password, Mobile, Adderess
            string myCmnd = "INSERT INTO DoctorTable (PatientMobile, DoctorName) VALUES(@PatientMobile, @DoctorName)";
            SqlCommand cmnd = new SqlCommand(myCmnd, connection);

            SqlParameter PatientMobileParameter = new SqlParameter("@PatientMobile", SqlDbType.NChar, 14);
            PatientMobileParameter.Value = mobile;

            SqlParameter DoctorNameParameter = new SqlParameter("@DoctorName", SqlDbType.NChar, 20);
            DoctorNameParameter.Value = drName;


            cmnd.Parameters.Add(PatientMobileParameter);
            cmnd.Parameters.Add(DoctorNameParameter);

            ClassCommon.ExecuteOpenCose(cmnd);

            //-----------------Show Success Message in MessageBox
            string message = "Success";
            MessageBox.Show(message, "Booking Done");

        }
    }
}
