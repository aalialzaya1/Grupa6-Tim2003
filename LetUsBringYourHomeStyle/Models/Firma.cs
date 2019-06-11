using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class Firma

    {
        [ScaffoldColumn(false)]
        int FirmaID;
        [Required]
        private string naziv;
        [Required]
        private string adresa;
        [Required]
        private string grad;
        private List<Namjestaj> namjestaj;
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
        public string Adresa
        {
            get
            {
                return adresa;
            }
            set
            {
                adresa = value;
            }
        }
        public string Grad
        {
            get
            {
                return grad;
            }
            set
            {
                grad = value;
            }
        }

        public Firma(string naziv, string adresa, string grad)
        {
            this.naziv = naziv;
            this.adresa = adresa;
            this.grad = grad;
            namjestaj = new List<Namjestaj>();
        }
        public void dodajNamjestaj(Namjestaj n)
        {
            namjestaj.Add(n);
        }
        public List<Namjestaj> dajNamjestaj()
        {
            return namjestaj;
        }

    }
}
