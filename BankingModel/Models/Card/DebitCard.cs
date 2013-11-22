using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BankingModel.Models
{
    public class DebitCard
    {
        public string pinCode { get; set; }
        public float soTienNganHangMuon { get; set; }

        public bool thayDoiPinCode()
        {
            return false;
        }

        public bool capNhapSoTien()
        {
            return false;
        }
    }
}