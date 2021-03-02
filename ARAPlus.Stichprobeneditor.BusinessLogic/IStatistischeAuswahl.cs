using ARAPlus.Stichprobeneditor.Models;
using System;
using System.Collections.Generic;

namespace ARAPlus.Stichprobeneditor.BusinessLogic
{
    public interface IStatistischeAuswahl
    {
        List<Artikel> GetAuswahl();
    }

    public class AuswahlVariante : IStatistischeAuswahl
    {
        public List<Artikel> GetAuswahl()
        {
            var list = new List<Artikel>();
            list.Add(new Artikel() { Absatzmenge = 20, Bezeichnung = "abc" });

            return list;
        }
    }
}
