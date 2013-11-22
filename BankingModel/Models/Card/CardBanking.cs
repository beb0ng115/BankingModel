using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class CardBanking
    {
        public String maTaiKhoan { get; set; }
        public String ngayDangKy { get; set; }
        public float soDu { get; set; }

        public List<Bill> dsBill { get; set; }
        public List<HistoryTransaction> danhSachGiaoDich { get; set; }

        
        public List<HistoryTransaction> layDanhSachGiaoDich() 
        { 
            return null; 
        }

        public void capNhapSoDu()
        { 

        }

        public Boolean kiemTraSoDuHopLe(float tien) 
        {
            return false;
        }

        public bool kiemTraDangNhap()
        {
            return false;
        }

        public bool rutTien()
        {
            return false;
        }

        public bool chuyenKhoan(CardBanking cardTo)
        {
            return false;
        }

        public bool layTaiKhoanTuThe(CardBanking card)
        {
            return false;
        }

    }
}