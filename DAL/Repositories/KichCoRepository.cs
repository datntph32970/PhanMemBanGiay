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
    public class KichCoRepository : IKichCoRepository
    {
        public List<Kichco> GetAll(string? txtTimKiem, string? searchType)
        {
            throw new NotImplementedException();
        }

        public Kichco GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public bool Lock(int id)
        {
            throw new NotImplementedException();
        }

        public bool Sua(int id, Kichco kichco)
        {
            throw new NotImplementedException();
        }

        public bool Them(Kichco kichco)
        {
            throw new NotImplementedException();
        }
    }
}
