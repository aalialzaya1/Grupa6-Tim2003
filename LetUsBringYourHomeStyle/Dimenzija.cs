using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle
{
    public class Dimenzija
    {
        private double visina { get; set; }
        private double duzina { get; set; }
        private double sirina { get; set; }

        public Dimenzija(double visina, double duzina, double sirina)
        {
            this.visina = visina;
            this.duzina = duzina;
            this.sirina = sirina;
        }
    }
}
