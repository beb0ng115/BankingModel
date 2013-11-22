using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models.Bill
{
    public class BillNapTienDienThoai : Bill
    {
        public float menhGiaThe { get; set; }
        public string loaiThe { get; set; }
        public string nhaCungCapthe { get; set; }
        public string soDienThoai { get; set; }
    }
}