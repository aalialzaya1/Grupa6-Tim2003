using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LetUsBringYourHomeStyle;


namespace LetUsBringYourHomeStyle.Models
{
    public class Popust: IPopust
    {
        [ScaffoldColumn(false)]
        int PopustID;
        [Required]
        private String naziv;
        [Required]
        private Double postotak;
        [Required]
        private DateTime pocetak;
        [Required]
        private DateTime kraj;
        public String Naziv
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
        public Double Postotak
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

        public List<Namjestaj> pregledSvihPopusta()
        {
            throw new NotImplementedException();
        }

        /*List<Namjestaj> pregledTrenutnihPopusta()
        {
            List<Namjestaj> l;
            foreach(Firma firma in firme)
            {
               foreach(Namjestaj n in namjestaj)
                {
                    if (DateTime.Now<Kraj) l.add(n);
                }
            }
            return l;

        }*/

        List<Namjestaj> IPopust.pregledTrenutnihPopusta()
        {
            throw new NotImplementedException();
        }
    }
}
