using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class Bill
    {
        public string maSoBill { get; set; }
        public string soTien { get; set; }
        public DateTime thoiGian { get; set; }
        public string noiDung { get; set; }
    }
}