using DAL.IRepositories;
using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class ChatLieuService : IChatLieuService
    {
        ChatLieuRepository _Res;
        public ChatLieuService()
        {
            _Res = new ChatLieuRepository();
        }
        public List<Chatlieu> GetAll(string? txtSearch, string? searchType)
        {
            return _Res.GetAll(txtSearch, searchType);
        }

        public Chatlieu GetByID(int id)
        {
            return _Res.GetByID(id);
        }

        public bool Lock(int id)
        {
            return _Res.Lock(id);
        }

        public bool Sua(int id, Chatlieu chatlieu)
        {
            return _Res.Sua(id, chatlieu);
        }

        public bool Them(Chatlieu chatlieu)
        {
            return _Res.Them(chatlieu);
        }
    }
}
