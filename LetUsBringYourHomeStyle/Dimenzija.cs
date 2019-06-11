using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LetUsBringYourHomeStyle
{
    public class Dimenzija
    {
        [ScaffoldColumn(false)]
        public int DimenzijaID { get; set; }
        [Required]
        public Double visina;
        [Required]
        public Double duzina;
        [Required]
        public Double sirina;


        public Double Visina
        {
            get
            {
                return visina;
            }
            set
            {
                visina = value;
            }
        }
        public Double Duzina
        {
            get
            {
                return duzina;
            }
            set
            {
                duzina = value;
            }
        }
        public Double Sirina
        {
            get
            {
                return sirina;
            }
            set
            {
                sirina = value;
            }
        }
        public Dimenzija() { }
        public Dimenzija(Double visina, Double duzina, Double sirina)
        {
            this.visina = visina;
            this.duzina = duzina;
            this.sirina = sirina;
        }
    }
}
