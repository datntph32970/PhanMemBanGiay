using DAL.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models.ModelRefer
{
    public class Giay_ChatLieu_MauSac_KichCo
    {
        public Giay giay { get; set; }
        public int maChatLieu { get; set; }
        public int maMauSac { get; set; }
        public int maKichCo { get; set; }
        public int soLuongCon { get; set; }
        public string tenChatLieu { get; set; }
        public string tenMauSac { get; set; }
        public string tenKichCo { get; set; }
        public string moTaChatLieu { get; set; }
        public string moTaMauSac { get; set; }
        public string moTaKichCo { get; set; }


    }
}
