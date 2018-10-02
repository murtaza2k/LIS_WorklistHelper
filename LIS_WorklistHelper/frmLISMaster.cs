using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIS_WorklistHelper.BL;

namespace LIS_WorklistHelper
{
    public partial class frmLISMaster : Form
    {
        private List<LISClient> Registrationlist = null;
        private List<LISClient> Processinglist = null;

        public frmLISMaster()
        {
            InitializeComponent();
        }

        private void frmLISMaster_Load(object sender, EventArgs e)
        {
            Processinglist = MyUtility.getSQLConnectionString();
           

            ///  MessageBox.Show(list.Count.ToString());
            cboLocations.DataSource = Processinglist;
            cboLocations.ValueMember = "vCenCode";
            cboLocations.DisplayMember = "Location";

            gridMachineMasterView.FocusedRowChanged += gridMachineMasterView_FocusedRowChanged;
        }

        void gridMachineMasterView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            ///throw new NotImplementedException();
            ///
            string sMachineId = gridMachineMasterView.GetFocusedRowCellValue("MachineId").ToString();
            //loadMachineParam(sMachineId);
        }
        void loadMachineParam(string sMachineId)
        {
            if (gridMachineMasterView.GetFocusedRowCellValue("MachineId") != null)
            {
                LISClient processClient = (LISClient)cboLocations.SelectedItem;


                MachineParamManager mManager = new MachineParamManager();

               

                List<MachineParamMaster> list = mManager.getMachineParamList(sMachineId, processClient.vCenCode, processClient.Server, processClient.Login, processClient.Password);
                gridMachineParamMaster.DataSource = list;
                gridMachineParamMasterView.Columns[4].Width = 350;
                gridMachineParamMasterView.Columns[2].Width = 100;
                gridMachineParamMasterView.Columns[1].Width = 100;
                gridMachineParamMasterView.Columns[4].Width = 200;
                //gridProcessingCentre.Columns[2].Width = 50;
                //gridProcessingCentre.Columns[3].Width = 50;
                //gridProcessingCentre.Columns[4].Width = 50;
            }


        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LISClient processClient = (LISClient)cboLocations.SelectedItem;

            TestBL wkList = new TestBL();
            
            List<CentreTest> list = wkList.getTestList(processClient.vCenCode, processClient.Server, processClient.Login, processClient.Password);
            gridTestMaster.DataSource = list;
            gridTest.Columns[2].BestFit();
            gridTest.Columns[3].BestFit();

            MachineMasterManager mManager = new MachineMasterManager();

            List<MachineMaster> listMachine = mManager.getMachineMaster(processClient.vCenCode, processClient.Server, processClient.Login, processClient.Password);

            gridMachineMaster.DataSource = listMachine;
            loadMachineParam("%");


        }

        private void gridTestMaster_Click(object sender, EventArgs e)
        {

            if (gridTest.GetFocusedRowCellValue("TestCode") != null)
            {
                LISClient processClient = (LISClient)cboLocations.SelectedItem;

                TestBL wkList = new TestBL();
                Int32 sWlId = Convert.ToInt32(gridTest.GetFocusedRowCellValue("TestCode").ToString());

                List<CentreParam> list = wkList.getParamList(processClient.vCenCode, sWlId, processClient.Server, processClient.Login, processClient.Password);
                gridParameters.DataSource = list;
                gridProcessingCentre.Columns[1].BestFit();
                gridProcessingCentre.Columns[6].BestFit();
                gridProcessingCentre.Columns[0].Width = 50;
                gridProcessingCentre.Columns[2].Width = 50;
                gridProcessingCentre.Columns[3].Width = 50;
                gridProcessingCentre.Columns[4].Width = 50;
            }
        }

        private void gridMachineMaster_Click(object sender, EventArgs e)
        {
            string sMachineId = gridMachineMasterView.GetFocusedRowCellValue("MachineId").ToString();
            //loadMachineParam(sMachineId);

        }
    }
}
