using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Turizam
{
    public class Turiz
    {
       

        public int broj { get; set; }
        public string naslov { get; set; }
        public DateTime datum { get; set; }
        public ImageSource slika { get; set; }
        public string autor { get; set; }
        public string tekst { get; set; }
        public string kategorije { get; set; }

        public Turiz(int broj, string naslov, DateTime datum, ImageSource slika, string autor, string tekst, string kategorije)
        {
            this.broj = broj;
            this.naslov = naslov;
            this.datum = datum;
            this.slika = slika;
            this.autor = autor;
            this.tekst = tekst;
            this.kategorije = kategorije;
        }
        public static string path_for_update;
    }
}
