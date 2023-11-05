using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IGiayService
    {
        public List<Giay_ChatLieu_MauSac_KichCo> GetAll(string? txtTimKiem,string? searchType);
        public Giay_ChatLieu_MauSac_KichCo GetByID(int id);
        public bool Them(Giay_ChatLieu_MauSac_KichCo giay);
        public bool Sua(int id,Giay_ChatLieu_MauSac_KichCo giay);
        public bool Lock(int id);
    }
}
