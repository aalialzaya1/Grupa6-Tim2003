using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class Firma
    {
        private string naziv { get; set; }
        private string adresa { get; set; }
        private string grad { get; set; }
        private List<Namjestaj> namjestaj;

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
    }
}
