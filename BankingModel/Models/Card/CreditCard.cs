using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class CreditCard : CardBanking
    {
        public float thunhap { get; set; }
        public float tienMuonToiDa { get; set; }
        public float soTienDaMuon { get; set; }
        public DateTime ngayPhaiTra { get; set; }

        public bool capNhapThuNhap()
        {
            return false;
        }

        public bool capNhapSoTienToiDa()
        { 
            return false; 
        }

        public bool capNhapSoTienDaMuon()
        {
            return false;
        }

        public bool capNhapNgayPhaiTra()
        {
            return false;
        }
    }
}