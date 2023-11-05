using DAL.IRepositories;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class ThuongHieuRepository : IThuongHieuRepository
    {
        public List<Thuonghieu> GetAll(string? txtTimKiem, string? searchType)
        {
            throw new NotImplementedException();
        }

        public Thuonghieu GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Lock(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sua(int id, Thuonghieu thuonghieu)
        {
            throw new NotImplementedException();
        }

        public bool Them(Thuonghieu thuonghieu)
        {
            throw new NotImplementedException();
        }
    }
}
