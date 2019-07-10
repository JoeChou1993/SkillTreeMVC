using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCHomeWork.Models.ViewModels
{
    public class TransactionViewModels
    {
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Remark { get; set; }
    }
}