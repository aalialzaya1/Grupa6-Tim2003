using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class Savjet
    {
        private string naziv { get; set; }
        private string autor { get; set; }
        private string sadrzaj { get; set; }
        private Kategorija kategorija { get; set; }

        public Savjet(string naziv, string autor, string sadrzaj, Kategorija kategorija)
        {
            this.naziv = naziv;
            this.autor = autor;
            this.sadrzaj = sadrzaj;
            this.kategorija = kategorija;
        }

    }
}
