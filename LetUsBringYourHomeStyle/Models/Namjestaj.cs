using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using static LetUsBringYourHomeStyle.Models.homeStyle;

namespace LetUsBringYourHomeStyle.Models
{
    public class Namjestaj
    {
        [ScaffoldColumn(false)]
        public int NamjestajID { get; set; }
        [Required]
        public string naziv;
        [Required]
        public double cijena;
        [Required]
        public string dezen;
        [Required]
        public Kategorija kategorija;
        [Required]
        public Dimenzija dimenzija;
        [Required]
        public int DimenzijaID;
        [Required]
        public string materijal;
        [Required]
        public string stil;
        [Required]
        public Popust popust;
        [Required]
        public int PopustID;

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




        /*public Namjestaj(string naziv, double cijena, string dezen, Kategorija kategorija, Dimenzija dimenzija, string materijal, string stil, Popust popust)
        {
            this.naziv = naziv;
            this.cijena = cijena;
            this.dezen = dezen;
            this.kategorija = kategorija;
            this.dimenzija = dimenzija;
            this.materijal = materijal;
            this.stil = stil;
            this.popust = popust;
            
        }*/


    }
}
