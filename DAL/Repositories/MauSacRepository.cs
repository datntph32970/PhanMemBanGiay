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
    public class MauSacRepository : IMauSacRepository
    {
        public List<Mausac> GetAll(string? txtTimKiem, string? searchType)
        {
            throw new NotImplementedException();
        }

        public Mausac GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Lock(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sua(int id, Mausac mausac)
        {
            throw new NotImplementedException();
        }

        public bool Them(Mausac mausac)
        {
            throw new NotImplementedException();
        }
    }
}
