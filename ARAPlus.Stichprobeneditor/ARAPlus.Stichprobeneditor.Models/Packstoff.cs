using System;
using System.Collections.Generic;
using System.Text;

namespace ARAPlus.Stichprobeneditor.Models
{
    public class Packstoff
    {
        public int PackstoffId { get; set; }

        public string Bezeichnung { get; set; }
        public int Menge { get; set; }

        public int SortOrder { get; set; }
        public string PackstoffCode { get; set; }

        public virtual Artikel Artikel { get; set; }

    }
}
