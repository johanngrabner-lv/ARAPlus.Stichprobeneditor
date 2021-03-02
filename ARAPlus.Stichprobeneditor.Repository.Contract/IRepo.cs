using ARAPlus.Stichprobeneditor.Models;
using System;
using System.Collections.Generic;

namespace ARAPlus.Stichprobeneditor.Repository.Contract
{
    public interface  IRepo
    {
        void AddArtikel(Artikel artikel);
        List<Artikel> GetArtikel();
        Artikel GetArtikel(int artikelId);
    }
}
