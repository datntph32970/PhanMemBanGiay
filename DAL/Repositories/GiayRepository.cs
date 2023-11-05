using DAL.IRepositories;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GiayRepository : IGiayRepository
    {
        public List<Giay_ChatLieu_MauSac_KichCo> GetAll(string? txtTimKiem, string? searchType)
        {
            throw new NotImplementedException();
        }

        public Giay_ChatLieu_MauSac_KichCo GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Lock(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sua(int id, Giay_ChatLieu_MauSac_KichCo giay)
        {
            throw new NotImplementedException();
        }

        public bool Them(Giay_ChatLieu_MauSac_KichCo giay)
        {
            throw new NotImplementedException();
        }
    }
}
