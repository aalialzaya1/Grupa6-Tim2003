using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LetUsBringYourHomeStyle;


namespace LetUsBringYourHomeStyle.Models
{
    public class Popust : IPopust
    {
        private string naziv;
        private double postotak;
        private DateTime pocetak;
        private DateTime kraj;
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

        public List<Namjestaj> pregledTrenutnihPopusta()
        {
            List<Namjestaj> l=new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in namjestaj)
                {
                    if (DateTime.Now < Kraj) l.Add(n);
                }
            }
            return l;

        }

    }
}