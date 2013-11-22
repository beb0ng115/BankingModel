using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models.Bills
{
    public class BillChuyenKhoan : Bill
    {
        public CardBanking theChuyenDen { get; set; }

        public AccountBanking taiKhoanChuyenDen { get; set; }

        
    }
}