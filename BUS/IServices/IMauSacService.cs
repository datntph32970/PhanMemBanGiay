﻿using DAL.Models.DomainClass;
using DAL.Models.ModelRefer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepositories
{
    public interface IMauSacService
    {
        public List<Mausac> GetAll(string? txtTimKiem, string? searchType);
        public Mausac GetByID(int id);
        public bool Them(Mausac mausac);
        public bool Sua(int id, Mausac mausac);
        public bool Lock(int id);
    }
}
