using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Controls;
using System.Data.SqlClient;

namespace LIS_WorklistHelper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            gridControl1.DataSource = new DoctorMaster().getAllDoctors();
            
        }

        
    }

    public class DoctorMaster
    {
        //select HIMSCode , DoctorName  FROM DoctorMaster Where HIMSCode is not null 

        public string HIMSCode { get; set; }
        public string DoctorName { get; set; }
        public string DHANo { get; set; }
        public string DHCCNo { get; set; }

        public List<DoctorMaster> getAllDoctors()
        {
            List<DoctorMaster> listDoctor=null;
            SqlConnection con=null;
            SqlCommand com = null;
            SqlDataReader reader = null;
            DoctorMaster doc;

            try
            {
                con = new SqlConnection("SERVER=172.20.32.40\\SQLEXPRESS;uid=sa;pwd=mchins@123;Database=Insurance_MCH");
                con.Open();

                com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = "select HIMSCode , DoctorName,IsNull(DHANo,'NA'),Isnull(DHCCNo ,'NA') FROM DoctorMaster Where HIMSCode is not null ";
                com.Connection = con;
                reader = com.ExecuteReader();

                listDoctor = new List<DoctorMaster>();
                listDoctor.Clear();

                while (reader.Read())
                {
                    doc = new DoctorMaster();

                    doc.HIMSCode = reader.GetString(0); //(reader.GetSqlInt64(0));
                    doc.DoctorName = reader.GetString(1).ToString();
                    doc.DHANo = reader.GetString(2).ToString();
                    doc.DHCCNo = reader.GetString(3).ToString();

                    listDoctor.Add(doc);
                    doc = null;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                listDoctor=null;                
                throw ex;
            }
            finally
            {
                if (com != null)
                    com.Dispose();

                if (con != null)
                    con.Dispose();

                com = null;
                con = null;
            }
            


            return listDoctor;
        }

    }
}
