using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class KhachHang
    {
        public string id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string mobilePhone { get; set; }
        public string email { get; set; }
        public List<AccountBanking> dsTaiKhoan { get; set; }
        public bool actived { get; set; }


/*
        public bool dangKyThanhVien(KhachHang kh)
        {
            // Các công việc khi đăng ký 1 tài khoản
            //1. Kiểm tra Khach Hang đã tồn tại chưa 
            //2. Generater 1 cái account 
            //4. Lưu xuống CSDL
            return false;
        }
        public bool kiemTraKhachHangTonTai(KhachHang kh)
        {
            return false;
        }
        public bool generatorTaiKhoanNganHang()
        {
            return false;
        }
        public bool luuThanhVienMoi()
        {
            return false;
        }*/

       /*

        public bool dangNhapThanhVien(string id, string pass)
        {
            
            return false;
        }
        */
        public bool themTaiKhoanNganHangMoi()
        {
            return false;
        }

        public bool deActiveTaiKhoan(AccountBanking account)
        {
            return false;
        }

        public bool doiMatKhau(String matKhauCu, String matKhauMoi)
        {
            return false;
        }

        public bool capNhapThongTinCaNhan(KhachHang kh)
        {
            return false;
        }

        public List<AccountBanking> layDanhSachAccount()
        {
            return null;
        }
    }
}