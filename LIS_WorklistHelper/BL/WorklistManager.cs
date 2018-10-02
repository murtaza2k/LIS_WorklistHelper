using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using AutoMapper;


namespace LIS_WorklistHelper.BL
{
    public class WorklistManager
    {
            SqlConnection cSQLCon = null;
            SqlCommand sqlCmd =null;


        public List<WLWorklist> getWorklistForSourceCenterDateWise(string sSourceCentreCode,string sRegistrationCentre ,DateTime dWorklistDate,string sStatus,string sServer,string sUserLogin , string sPassword , string sMRN="%")
        {
            //ProcSCGetRecvWL '2018-07-15 00:00:00:000','AB00','O','2018-07-16 00:00:00:000'
            string sSQLString = "EXEC ProcSCGetRecvWL_MALI @Dt,@SCenCode,@Status,@Dt1,@MRN";
            string sSQLConnectionString = "SERVER=" +  sServer+ ";uid=" + sUserLogin + ";pwd=" + sPassword + ";Database=Apex";
            List<WLWorklist> list = null ;
            try
            {
                using (cSQLCon = new SqlConnection(sSQLConnectionString))
                {
                    cSQLCon.Open();
                    using (sqlCmd = new SqlCommand(sSQLString,cSQLCon))
                    {
                        DateTime fromDate = dWorklistDate.Date.Subtract(new TimeSpan(8,0,0,0));
                        sqlCmd.Parameters.Add("@Dt", SqlDbType.DateTime).Value = fromDate;
                        sqlCmd.Parameters.Add("@SCenCode", SqlDbType.VarChar, 10).Value = sRegistrationCentre.ToString();
                        sqlCmd.Parameters.Add("@Status", SqlDbType.VarChar, 12).Value = sStatus;;
                        sqlCmd.Parameters.Add("@Dt1", SqlDbType.DateTime).Value = dWorklistDate;
                        sqlCmd.Parameters.Add("@MRN", SqlDbType.VarChar,15).Value = sMRN;

                       SqlDataReader reader =   sqlCmd.ExecuteReader();
                       list = new List<WLWorklist>();
                       
                           while (reader.Read())
                           {
                               WLWorklist cls = new WLWorklist();
                               cls.WLId = reader[0].ToString();
                               cls.WLDate = reader.GetDateTime(4);
                               cls.WLName = reader[3].ToString();
                               cls.WLTime = reader.GetDateTime(5);
                               cls.Status = reader[6].ToString();
                               cls.Valid = reader[7].ToString();
                               cls.SourceCentreCode = reader[1].ToString();
                               cls.ProcessCentreCode  = reader[2].ToString();
                               list.Add(cls);
                               cls = null;
                           }
                    }
                    
                }              
            }
            catch (Exception ex)
            {
               // list = null;
            }
            return  list;
        }


        public List<WorklistPatient> getWorklistPatientList(string sProcessingCentre, string sRegistrationCentre, string WorkListId, string sStatus, string sServer, string sUserLogin, string sPassword)
        {
            //ProcSCGetRecvWL '2018-07-15 00:00:00:000','AB00','O','2018-07-16 00:00:00:000'
            string sSQLString = "EXEC ProcSCListRecvWLPatients_MALI @SCenCode,@WLID,@Status,@vCenCode";
            string sSQLConnectionString = "SERVER=" + sServer + ";uid=" + sUserLogin + ";pwd=" + sPassword + ";Database=Apex";
            List<WorklistPatient> list = null;
            try
            {
                using (cSQLCon = new SqlConnection(sSQLConnectionString))
                {
                    cSQLCon.Open();
                    using (sqlCmd = new SqlCommand(sSQLString, cSQLCon))
                    {
                        

                        sqlCmd.Parameters.Add("@SCenCode", SqlDbType.VarChar, 10).Value = sRegistrationCentre.ToString();
                        sqlCmd.Parameters.Add("@Status", SqlDbType.VarChar, 12).Value = sStatus;
                        sqlCmd.Parameters.Add("@WLID", SqlDbType.VarChar, 12).Value = WorkListId;
                        sqlCmd.Parameters.Add("@vCenCode", SqlDbType.VarChar, 10).Value = sProcessingCentre.ToString();


                        SqlDataReader reader = sqlCmd.ExecuteReader();
                        list = new List<WorklistPatient>();

                        while (reader.Read())
                        {
                            WorklistPatient cls = new WorklistPatient();
                            cls.WStatus = reader[0].ToString();
                            cls.VstNo = reader[1].ToString();
                            cls.Regno = reader[2].ToString();
                            cls.PatientName  = reader[3].ToString();
                            cls.PatSex = reader[4].ToString();
                            cls.Age = reader[5].ToString();
                            cls.PCDescription= reader[6].ToString();
                            cls.DoctorName = reader[7].ToString();
                            cls.TotalTests = reader[8].ToString();
                            cls.Accepted = reader[9].ToString();
                            cls.SNR = reader[10].ToString();
                            cls.Rejected = reader[11].ToString();
                            cls.NotAccepted = reader[12].ToString();
                            cls.LabNo = reader[13].ToString();                           
                            list.Add(cls);
                            cls = null;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // list = null;
            }
            return list;
        }

        public List<WorkListPatientTest> getPatientTestList(string sVstNo,string sProcessingCentre, string WorkListId, string sStatus, string sServer, string sUserLogin, string sPassword)
        {
            //ProcSCGetRecvWL '2018-07-15 00:00:00:000','AB00','O','2018-07-16 00:00:00:000'
            string sSQLString = "EXEC ProcSCListRecvWLPatTests_Edit_ALI @WLID,@VstNo,@vCenCode,@Status";
            string sSQLConnectionString = "SERVER=" + sServer + ";uid=" + sUserLogin + ";pwd=" + sPassword + ";Database=Apex";
            List<WorkListPatientTest> list = null;
            try

            {
                Mapper.CreateMap<IDataReader, WorkListPatientTest>();

                using (cSQLCon = new SqlConnection(sSQLConnectionString))
                {
                    cSQLCon.Open();
                    using (sqlCmd = new SqlCommand(sSQLString, cSQLCon))
                    {
                        sqlCmd.Parameters.Add("@VstNo", SqlDbType.VarChar, 15).Value = sVstNo;
                        sqlCmd.Parameters.Add("@Status", SqlDbType.VarChar, 12).Value = sStatus;
                        sqlCmd.Parameters.Add("@WLID", SqlDbType.VarChar, 12).Value = WorkListId;
                        sqlCmd.Parameters.Add("@vCenCode", SqlDbType.VarChar, 10).Value = sProcessingCentre.ToString();


                        SqlDataReader reader = sqlCmd.ExecuteReader();

                          list =   Mapper.Map<List<WorkListPatientTest>>(reader);
                        
            
                    }

                }
            }
            catch (Exception ex)
            {
                // list = null;
            }
            return list;
        }

    }
}
