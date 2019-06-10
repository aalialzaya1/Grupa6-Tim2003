using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class Namjestaj
    {
        private string naziv;
        private double cijena;
        private string dezen;
        private Kategorija kategorija;
        private Dimenzija dimenzija;
        private string materijal;
        private string stil;
        private Popust popust;

        public Popust Popust
        {
            get
            {
                return popust;
            }
            set
            {
                popust = value;
            }
        }

        public Namjestaj(global::System.String naziv, global::System.Double cijena, global::System.String dezen, Kategorija kategorija, Dimenzija dimenzija, global::System.String materijal, global::System.String stil, Boolean naPopustu)
        {
            this.naziv = naziv;
            this.cijena = cijena;
            this.dezen = dezen;
            this.kategorija = kategorija;
            this.dimenzija = dimenzija;
            this.materijal = materijal;
            this.stil = stil;
            this.naPopustu = naPopustu;
        }
       

    }
}
