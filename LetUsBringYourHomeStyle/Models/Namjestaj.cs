using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class Namjestaj
    {
        private string naziv { get; set; }
        private double cijena { get; set; }
        private string dezen { get; set; }
        private Kategorija kategorija { get; set; }
        private Dimenzija dimenzija { get; set; }
        private string materijal { get; set; }
        private string stil { get; set; }
        

        public Namjestaj(string naziv, double cijena, string dezen, Kategorija kategorija, Dimenzija dimenzija, string materijal, string stil)
        {
            this.naziv = naziv;
            this.cijena = cijena;
            this.dezen = dezen;
            this.kategorija = kategorija;
            this.dimenzija = dimenzija;
            this.materijal = materijal;
            this.stil = stil;
        }
    }
}
