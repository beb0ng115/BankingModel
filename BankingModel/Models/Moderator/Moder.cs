using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class Moder
    {
        public string id { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public bool capNhapThongTinKhachHang(KhachHang kh)
        {
            return false;
        }
    }
}