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
    public class TestBL 

        
    {

        /*
         * SELECT dbo.[fnGetProcCentre](vCenCode,TestCode) As ProcessCentreCode , TestCode , TestCategory , TestPrintAs , TestAlias , DrTestCode 
           FROM CentreTest
           Order By TestCategory

         * 
         */

        SqlConnection cSQLCon = null;
        SqlCommand sqlCmd = null;
        public List<CentreTest> getTestList(string sProcessingCentre, string sServer, string sUserLogin, string sPassword)
        {
            //ProcSCGetRecvWL '2018-07-15 00:00:00:000','AB00','O','2018-07-16 00:00:00:000'
            string sSQLString = "SELECT dbo.[fnGetProcCentre](vCenCode,TestCode) As ProcessCentreCode , TestCode , UPPER(TestCategory) AS TestCategory , UPPER(TestPrintAs) AS TestPrintAs  , TestAlias , DrTestCode " + 
                                "FROM CentreTest Order By TestCategory"; 
           
            string sSQLConnectionString = "SERVER=" + sServer + ";uid=" + sUserLogin + ";pwd=" + sPassword + ";Database=Apex";
            List<CentreTest> list = null;
            try
            {
                Mapper.CreateMap<IDataReader, CentreTest>();

                using (cSQLCon = new SqlConnection(sSQLConnectionString))
                {
                    cSQLCon.Open();
                    using (sqlCmd = new SqlCommand(sSQLString, cSQLCon))
                    {
                        //sqlCmd.Parameters.Add("@VstNo", SqlDbType.VarChar, 15).Value = sVstNo;
                        //sqlCmd.Parameters.Add("@Status", SqlDbType.VarChar, 12).Value = sStatus;
                        //sqlCmd.Parameters.Add("@WLID", SqlDbType.VarChar, 12).Value = WorkListId;
                        //sqlCmd.Parameters.Add("@vCenCode", SqlDbType.VarChar, 10).Value = sProcessingCentre.ToString();


                        SqlDataReader reader = sqlCmd.ExecuteReader();

                        list = Mapper.Map<List<CentreTest>>(reader);


                    }

                }
            }
            catch (Exception ex)
            {
                // list = null;
            }
            return list;
        }

        public List<CentreParam> getParamList(string sProcessingCentre,Int32 @TestCode ,string sServer, string sUserLogin, string sPassword)
        {
            //ProcSCGetRecvWL '2018-07-15 00:00:00:000','AB00','O','2018-07-16 00:00:00:000'
            string sSQLString = "select Param.ParamCode ,  "+ 
                                " ISNULL(cp.ParamPrintAs,param.ParamPrintAs)  ParamPrintAs,  "+ 
                                " ISNULL(cp.PAramAlias, Param.PAramAlias ) ParamAlias,  "+ 
                                " ISNULL(cp.prece, Param.prece) prece ,  "+ 
                                " ISNULL(cp.Formula, Param.Formula ) Formula,  "+  
                                " ISNULL(cp.ParamConvUnit, Param.PAramConvUnit) ParamConvUnit,   "+ 
                                " ISNULL(cp.VISIBLE,param.VISIBLE) VISIBLE ,   "+ 
                                " Param.ParamName , "+ 
                                "  test.barcodesuffix     "+                                                                
                                " ,PrintOrder   "+ 
                                " from Test    "+ 
                                " join testparam on testparam.vcencode like @vCenCode and test.testcode = testparam.testcode   "+ 
                                " join param on testparam.paramcode = param.paramcode   "+ 
                                " LEFT JOIN centreparam cp on param.paramcode = cp.paramcode and testparam.vcencode = cp.vcencode "+
                                " where test.testcode = @TCode " + 
                                " order by testparam.vcencode , testalias ,printorder  ";

            string sSQLConnectionString = "SERVER=" + sServer + ";uid=" + sUserLogin + ";pwd=" + sPassword + ";Database=Apex";
            List<CentreParam> list = null;
            try
            {
                Mapper.CreateMap<IDataReader, CentreParam>();

                using (cSQLCon = new SqlConnection(sSQLConnectionString))
                {
                    cSQLCon.Open();
                    using (sqlCmd = new SqlCommand(sSQLString, cSQLCon))
                    {
                        sqlCmd.Parameters.Add("@TCode", SqlDbType.Int).Value = @TestCode;
                        sqlCmd.Parameters.Add("@vCenCode", SqlDbType.VarChar,4).Value = sProcessingCentre;
                      
                        SqlDataReader reader = sqlCmd.ExecuteReader();

                        list = Mapper.Map<List<CentreParam>>(reader);


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
