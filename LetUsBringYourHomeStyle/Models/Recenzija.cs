using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LetUsBringYourHomeStyle.Models
{
    public class Recenzija
    {
        [ScaffoldColumn(false)]
        public int RecenzijaID { get; set; }
        [Required]
        public RegistrovaniKorisnik korisnik;
        [Required]
        public int RegistrovaniKorisnikID;
        [Required]
        public string komentar;
        [Required]
        public int ocjena;

        public Recenzija(RegistrovaniKorisnik korisnik, string komentar, int ocjena)
        {
            this.korisnik = korisnik;
            this.komentar = komentar;
            this.ocjena = ocjena;
        }
        public RegistrovaniKorisnik Korisnik
        {
            get
            {
                return korisnik;
            }
            set
            {
                korisnik = value;
            }
        }
        public string Komentar
        {
            get
            {
                return komentar;
          
  }
            set
            {
                komentar = value;
            
}
        }
        public int Ocjena
        {
            get
            {
                return ocjena;
            }
            set
            {
                ocjena = value;

            }
        }

    }
}
