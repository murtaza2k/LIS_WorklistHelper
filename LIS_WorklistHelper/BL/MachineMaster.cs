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
   public class MachineMaster
    {

       public string MachineId {get;set;}
       public string MachineName {get;set;}
       public Int32 Commport { get; set; }
       public string Settings  { get; set; }
       public string Category  { get; set; }
       public string PcName { get; set; }

    }

   public class MachineMasterManager
   {
       SqlConnection cSQLCon = null;
       SqlCommand sqlCmd = null;

       public List<MachineMaster> getMachineMaster(string sProcessingCentre, string sServer, string sUserLogin, string sPassword)
       {
           //ProcSCGetRecvWL '2018-07-15 00:00:00:000','AB00','O','2018-07-16 00:00:00:000'
           string sSQLString = " select MachineId , MachineName , Commport , Settings , Category , PcName  From MachineMaster Order By MachineName  ";
           
           string sSQLConnectionString = "SERVER=" + sServer + ";uid=" + sUserLogin + ";pwd=" + sPassword + ";Database=Apex";
           List<MachineMaster> list = null;
           try
           {
               Mapper.CreateMap<IDataReader, MachineMaster>();

               using (cSQLCon = new SqlConnection(sSQLConnectionString))
               {
                   cSQLCon.Open();
                   using (sqlCmd = new SqlCommand(sSQLString, cSQLCon))
                   {
           //            sqlCmd.Parameters.Add("@TCode", SqlDbType.Int).Value = @TestCode;
             //          sqlCmd.Parameters.Add("@vCenCode", SqlDbType.VarChar, 4).Value = sProcessingCentre;

                       SqlDataReader reader = sqlCmd.ExecuteReader();

                       list = Mapper.Map<List<MachineMaster>>(reader);


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


   public class MachineParamMaster
   {
       //SELECT MP.MachineParamId ,  MA.Description , MP.ParamCode  , CP.ParamPrintAs , CP.ParamAlias , MP.AssayNo , MP.Valid
       //     FROM MACHINEPARAM MP 
       //         INNER JOIN MACID MA ON MP.MachineParamId = MA.MachineParamID AND MP.MachineId = MA.MachineID
       //         INNER JOIN CENTREPARAM CP ON MP.ParamCode = CP.ParamCode and MP.vCenCode = CP.vCenCode 
       public string MachineID { get; set; }
       public string MachineParamId { get; set; }
       public string Description { get; set; }
       public Int32 ParamCode { get; set; }
       public string ParamPrintAs { get; set; }
       public string ParamAlias { get; set; }
       public Int32 AssayNo { get; set; }
       public string Valid { get; set; }


   }

   public class MachineParamManager
   {

       SqlConnection cSQLCon = null;
       SqlCommand sqlCmd = null;

       public List<MachineParamMaster> getMachineParamList(string sMachineId, string sProcessingCentre, string sServer, string sUserLogin, string sPassword)
       {
           //ProcSCGetRecvWL '2018-07-15 00:00:00:000','AB00','O','2018-07-16 00:00:00:000'
           //string sSQLString = " select MachineId , MachineName , Commport , Settings , Category , PcName  From MachineMaster Order By MachineName  ";
           string sSQLString = " SELECT MA.MachineID ,MP.MachineParamId ,  MA.Description , MP.ParamCode  , CP.ParamPrintAs , CP.ParamAlias , MP.AssayNo , MP.Valid " +
                              " FROM MACHINEPARAM MP  " +
                              " INNER JOIN MACID MA ON MP.MachineParamId = MA.MachineParamID AND MP.MachineId = MA.MachineID " +
                              " INNER JOIN CENTREPARAM CP ON MP.ParamCode = CP.ParamCode and MP.vCenCode = CP.vCenCode  WHERE MP.MachineId LIKE @MachineId";


           string sSQLConnectionString = "SERVER=" + sServer + ";uid=" + sUserLogin + ";pwd=" + sPassword + ";Database=Apex";
           List<MachineParamMaster> list = null;
           try
           {
               Mapper.CreateMap<IDataReader, MachineParamMaster>();

               using (cSQLCon = new SqlConnection(sSQLConnectionString))
               {
                   cSQLCon.Open();
                   using (sqlCmd = new SqlCommand(sSQLString, cSQLCon))
                   {
                       sqlCmd.Parameters.Add("@MachineId", SqlDbType.VarChar).Value = @sMachineId;
                       //          sqlCmd.Parameters.Add("@vCenCode", SqlDbType.VarChar, 4).Value = sProcessingCentre;

                       SqlDataReader reader = sqlCmd.ExecuteReader();

                       list = Mapper.Map<List<MachineParamMaster>>(reader);


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
