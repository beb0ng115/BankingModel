using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class HistoryTransaction
    {
        public String maLichSu { get; set; }
        public AccountBanking taiKhoanGiaoDich { get; set; }
        public String thoiGianGiaoDich { get; set; }
        public String theGiaoDich { get; set; }
        public float soTienGiaoDich { get; set; }
        public String lyDoGiaoDich { get; set; }
    }
}