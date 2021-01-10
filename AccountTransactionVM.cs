using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PEGASE.Domain.ViewModels
{
    public class AccountTransactionVM  
    { 
        public long ID { get; set; } 
        public DateTime TransDate { get; set; } 
        public DateTime ValueDate { get; set; } 
        public long AccountID { get; set; }
        public string TransDesc { get; set; } 
        public decimal AccountBalance { get; set; } 
    }
}