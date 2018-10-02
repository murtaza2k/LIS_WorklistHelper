using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS_WorklistHelper.BL
{
  
    public class WLWorklist
    {
        public string WLId { set; get; }
        public string WLName { set; get; }
        public string SourceCentreCode { set; get; }
        public string ProcessCentreCode { set; get; }
        public DateTime WLDate { set; get; }
        public DateTime WLTime { set; get; }
        public string Status { set; get; }
        public string Valid { set; get; }

    }
    public class WorklistPatient
    {
        public String WStatus { set; get; }
        public String VstNo { set; get; }
        public String Regno { set; get; }
        public String PatientName { set; get; }
        public String PatSex { set; get; }
        public String Age { set; get; }
        public String PCDescription { set; get; }
        public String DoctorName { set; get; }
        public String TotalTests { set; get; }
        public String Accepted { set; get; }
        public String SNR { set; get; }
        public String Rejected { set; get; }
        public String NotAccepted { set; get; }
        public String LabNo { set; get; }
    }

    public class WorkListPatientTest
    {
        public String DeptName { set; get; }
        public Int32 TestCode { set; get; }
        public String TestPrintAs { set; get; }
        public String SampleStatus { set; get; }      
        public String SampleType { set; get; }
    }       
}
