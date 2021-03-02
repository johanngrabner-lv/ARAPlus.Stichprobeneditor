using ARAPlus.Stichprobeneditor.Models;
using System;
using System.Collections.Generic;

namespace ARAPlus.Stichprobeneditor.Repository.Contract.Mock
{
    public class MyMockRepos : IRepo
    {
        public void AddArtikel(Artikel artikel)
        {
            throw new NotImplementedException();
        }

        public Artikel GetArtikel(int id)
        {
            return new Artikel() { ArtikelId = 1, Absatzmenge = 10 };

        }

        public List<Artikel> GetArtikel()
        {
            throw new NotImplementedException();
        }

    }
}
