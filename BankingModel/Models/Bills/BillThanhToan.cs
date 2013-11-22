using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models.Bill
{
    public class BillThanhToan : Bill
    {
        public int loaiThanhToan { get; set; }
        public string tenThanhToan { get; set; }
        public AccountBanking taiKhoanDichVu { get; set; }  
    }
}