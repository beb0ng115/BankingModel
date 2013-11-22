using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class AccountBanking
    {
        public String maTaiKhoan { get; set; }
        public String ngayLamThe { get; set; }
        public String ngayHetHan { get; set; }
        public float soDu { get; set; }
        public List<CardBanking> dsThe { get; set; }
        public List<HistoryTransaction> lichSuGiaoDich { get; set; }

        public Boolean kiemTraHetHan()
        {
            return false;
        }

        public bool dangKyTaiKhoanNganHang()
        {
            return false;
        }
        public bool kiemTraKhachHangTonTai(KhachHang kh)
        {
            return false;
        }
        public AccountBanking generatorAccount()
        {
            return null;
        }
        public bool savingAccount()
        {
            return false;
        }


        public bool rutTien()
        {
            // Người dùng muốn rút tiền từ tài khoản nào
            return false;
        }

        public bool napTien()
        {
            return false;
        }

        public bool chuyenKhoan(AccountBanking AccountTo)
        {
            return false;
        }

        public List<CardBanking> layDanhSachThe()
        {
            return null;
        }

        public List<HistoryTransaction> layDanhSachGiaoDich()
        {
            return null;
        }

        public bool kiemTraSoDuHopLe(float sotien)
        {
            if (this.soDu - sotien > 50000)
                return true;
            return false;
        }

        public bool taoThe()
        {
            return false;
        }



    }
}