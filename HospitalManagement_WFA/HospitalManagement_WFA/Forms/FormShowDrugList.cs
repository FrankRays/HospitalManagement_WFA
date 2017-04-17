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
    public partial class FormShowDrugList : Form
    {
        
        public FormShowDrugList(string query)
        {
           
            InitializeComponent();

            //-----------Show Table in DataGridView for Blood Donor
            
            DataTable dt = new DataTable();
            ClassCommon.SqlC_DAOpenFillCose(query, dt);
            dataGridViewShowDrugListnForm.DataSource = dt;

        }

        private void FormShowDrugList_FormClosed(object sender, FormClosedEventArgs e)
        {
           FormHome h = new FormHome();
           h.Show();
   
        }
    }
}
