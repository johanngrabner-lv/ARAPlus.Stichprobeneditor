using ARAPlus.Stichprobeneditor.Models;
using ARAPlus.Stichprobeneditor.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ARAPlus.Stichprobeneditor.Repository.Impl.MSSQLServer
{
    public class RepoMSSQL : IRepo
    {
        private StichprobenContext _ctx;
        public RepoMSSQL()
        {
            _ctx = new StichprobenContext();
        }
        public void AddArtikel(Artikel artikel)
        {
            _ctx.Artikel.Add(artikel);
            _ctx.SaveChanges();
        }

        public List<Artikel> GetArtikel()
        {
            return _ctx.Artikel.ToList();
        }

        public Artikel GetArtikel(int artikelId)
        {
            return _ctx.Artikel.Find(artikelId);
        }
    }
}
