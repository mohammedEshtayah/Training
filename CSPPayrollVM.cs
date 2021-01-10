using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PEGASE.Domain.ViewModels
{
    public class CSPPayrollVM  
    {
         
        public long ID { get; set; } 
        public long DatasetRequestID { get; set; } 
        public long EmpNo { get; set; } 
        public string FirstNameAr { get; set; } 
        public string FatherNameAr { get; set; } 
        public string GranFatherNameAr { get; set; } 
        
    }
}