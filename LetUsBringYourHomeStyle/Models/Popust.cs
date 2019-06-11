using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LetUsBringYourHomeStyle;
using static LetUsBringYourHomeStyle.Models.homeStyle;

namespace LetUsBringYourHomeStyle.Models
{
    public class Popust : IPopust
    {
        [ScaffoldColumn(false)]
        public int PopustID { get; set; }
        [Required]
        public string naziv;
        [Required]
        public double postotak;
        [Required]
        public DateTime pocetak;
        [Required]
        public DateTime kraj;
        [Required]
        public int RegistrovaniKorisnikID { get; set; }
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
        public double Postotak
        {
            get
            {
                return postotak;
            }
            set
            {
                postotak = value;
            }
        }
        public DateTime Pocetak
        {
            get
            {
                return pocetak;
            }
            set
            {
                pocetak = value;
            }
        }
        public DateTime Kraj
        {
            get
            {
                return kraj;
            }
            set
            {
                kraj = value;
            }
        }
        homeStyle h;
        public List<Namjestaj> pregledTrenutnihPopusta()
        {
            List<Namjestaj> l=new List<Namjestaj>();
            foreach (Firma firma in h.dajFirme())
            {
                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (DateTime.Now < Kraj) l.Add(n);
                }
            }
            return l;

        }

    }
}