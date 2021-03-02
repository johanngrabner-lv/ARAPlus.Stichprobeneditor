using System;
using System.Collections.Generic;

namespace ARAPlus.Stichprobeneditor.Models
{
    public class Artikel
    {
        public int ArtikelId { get; set; }

        public string Bezeichnung { get; set; }
        public double Absatzmenge { get; set; }

        public string ArtikelNummer { get; set; }

        public virtual List<Packstoff> Packstoffe { get; set; }
    }
}
