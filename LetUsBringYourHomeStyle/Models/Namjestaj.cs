using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LetUsBringYourHomeStyle.Models.homeStyle;

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
        public Kategorija Kategorija
        {
            get
            {
                return kategorija;
            }
            set
            {
                kategorija = value;
            }
        }
        public double Cijena
        {
            get
            {
                return cijena;
            }
            set
            {
                cijena = value;
            }
        }
        public string Stil
        {
            get
            {
                return stil;
            }
            set
            {
                stil = value;
            }
        }
        public string Materijal
        {
            get
            {
                return materijal;
            }
            set
            {
                materijal = value;
            }
        }
        public string Dezen
        {
            get
            {
                return dezen;
            }
            set
            {
                dezen = value;
            }
        }
        public Dimenzija Dimenzija
        {
            get
            {
                return dimenzija;
            }
            set
            {
                dimenzija = value;
            }
        }
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
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
