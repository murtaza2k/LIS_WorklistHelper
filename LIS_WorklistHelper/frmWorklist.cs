using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LIS_WorklistHelper.BL;

namespace LIS_WorklistHelper
{
    public partial class frmWorklist : Form
    {
        public frmWorklist()
        {
            InitializeComponent();
        }
        private List<LISClient> Registrationlist = null;
        private List<LISClient> Processinglist = null;
        private void btnShowWorklist_Click(object sender, EventArgs e)
        {
            LISClient processClient = (LISClient)cboLocations.SelectedItem;
            LISClient registrationClient = (LISClient)cboRegistrationCentre.SelectedItem;
            string sMRN;
            string sStatus = "O";
            WorklistManager wkList = new WorklistManager();
            if (txtMRN.Text==string.Empty)
                sMRN ="%";
            else
                sMRN =txtMRN.Text.ToString();
            if (rdbAll.Checked)
                sStatus = "%";
            else
                sStatus = "O";



            List<WLWorklist> list = wkList.getWorklistForSourceCenterDateWise(processClient.vCenCode, registrationClient.vCenCode, dtpWorkList.Value, sStatus, processClient.Server, processClient.Login, processClient.Password, sMRN);
            gridWorkHeader.DataSource = list;
            
        }

        private void frmWorklist_Load(object sender, EventArgs e)
        {
            Processinglist = MyUtility.getSQLConnectionString();
            Registrationlist = MyUtility.getSQLConnectionString();

            ///  MessageBox.Show(list.Count.ToString());
            cboLocations.DataSource = Processinglist;
            cboLocations.ValueMember = "vCenCode";
            cboLocations.DisplayMember = "Location";

            cboRegistrationCentre.DataSource = Registrationlist;
            cboRegistrationCentre.ValueMember = "vCenCode";
            cboRegistrationCentre.DisplayMember = "Location";
            gridPatientList.FocusedRowObjectChanged += gridPatientList_FocusedRowObjectChanged;

        }

        void gridPatientList_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            ///throw new NotImplementedException();
            ///
            try
            {
                LISClient processClient = (LISClient)cboLocations.SelectedItem;
                LISClient registrationClient = (LISClient)cboRegistrationCentre.SelectedItem;

                object selected = grdHeader.GetFocusedRow();
                string sWlId = grdHeader.GetFocusedRowCellValue("WLId").ToString();
                string sVstNo = gridPatientList.GetFocusedRowCellValue("VstNo").ToString();


                WorklistManager wkList = new WorklistManager();
                List<WorkListPatientTest> list = wkList.getPatientTestList(sVstNo, processClient.vCenCode, sWlId, "%", processClient.Server, processClient.Login, processClient.Password);
                gridTestList.DataSource = list;
            }
            catch (Exception ex)
            {
            }
        }

        //void grdHeader_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        //{
        //    //throw new System.NotImplementedException();
        //    LISClient processClient = (LISClient)cboLocations.SelectedItem;
        //    LISClient registrationClient = (LISClient)cboRegistrationCentre.SelectedItem;

        //    string sWlId = grdHeader.GetFocusedRowCellValue("WLId").ToString();






        //    WorklistManager wkList = new WorklistManager();
        //    List<WorklistPatient> list = wkList.getWorklistPatientList(processClient.vCenCode, registrationClient.vCenCode, sWlId, "%", processClient.Server, processClient.Login, processClient.Password);
        //    gridWorklistPatient.DataSource = list;         
        //}

        void grdHeader_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //throw new System.NotImplementedException();
            //throw new System.NotImplementedException();
            LISClient processClient = (LISClient)cboLocations.SelectedItem;
            LISClient registrationClient = (LISClient)cboRegistrationCentre.SelectedItem;
            if (grdHeader.GetFocusedRowCellValue("WLId") != null)
            {
                string sWlId = grdHeader.GetFocusedRowCellValue("WLId").ToString();






                WorklistManager wkList = new WorklistManager();
                List<WorklistPatient> list = wkList.getWorklistPatientList(processClient.vCenCode, registrationClient.vCenCode, sWlId, "%", processClient.Server, processClient.Login, processClient.Password);
                gridWorklistPatient.DataSource = list;
            }
        }


        private void gridWorkHeader_Click(object sender, EventArgs e)
        {
            LISClient processClient = (LISClient)cboLocations.SelectedItem;
            LISClient registrationClient = (LISClient)cboRegistrationCentre.SelectedItem;

            string sWlId = grdHeader.GetFocusedRowCellValue("WLId").ToString();






            WorklistManager wkList = new WorklistManager();
            List<WorklistPatient> list = wkList.getWorklistPatientList(processClient.vCenCode, registrationClient.vCenCode, sWlId, "%", processClient.Server, processClient.Login, processClient.Password);
            gridWorklistPatient.DataSource = list;           
        }

        private void gridWorklistPatient_Click(object sender, EventArgs e)
        {
            try
            {
                LISClient processClient = (LISClient)cboLocations.SelectedItem;
                LISClient registrationClient = (LISClient)cboRegistrationCentre.SelectedItem;

                object selected = grdHeader.GetFocusedRow();
                string sWlId = grdHeader.GetFocusedRowCellValue("WLId").ToString();
                string sVstNo = gridPatientList.GetFocusedRowCellValue("VstNo").ToString();


                WorklistManager wkList = new WorklistManager();
                List<WorkListPatientTest> list = wkList.getPatientTestList(sVstNo, processClient.vCenCode, sWlId, "%", processClient.Server, processClient.Login, processClient.Password);
                gridTestList.DataSource = list;
            }
            catch (Exception ex)
            {
            }

        }

    }

   
    
 
    public static class MyUtility
    {
       

        public static List<LISClient> getSQLConnectionString()
        {
           
            DataSet XMLDs = new DataSet();
            XMLDs.ReadXml(Application.StartupPath.ToString() + "\\XML\\servers.xml");
            List<LISClient> list = new List<LISClient>();
            foreach (DataRow dRow in XMLDs.Tables[0].Rows)
            {
                LIS_WorklistHelper.BL.LISClient client = new BL.LISClient();
                client.Location = dRow[0].ToString();
                client.Server = dRow[1].ToString();
                client.Login = dRow[2].ToString();
                client.Password = dRow[3].ToString();
                client.vCenCode = dRow[4].ToString();
                list.Add(client);
            }

            return list;
            
        }
    }
    

}
