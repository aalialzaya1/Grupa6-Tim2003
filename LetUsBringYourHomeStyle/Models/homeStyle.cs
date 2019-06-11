using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    
    public class homeStyle: IPretraga
    {
        public enum Kategorija {DnevnaSoba, Kuhinja, SpavacaSoba, Kupatilo, DjecijaSOba, Ured, Dekoracija }
        private List<Savjet> savjeti;
        private List<Firma> firme;

        public homeStyle()
        {
            savjeti = new List<Savjet>();
            firme = new List<Firma>();
        }
        public void dodajSavjet(Savjet s)
        {
            savjeti.Add(s);
        }
        public void dodajFirmu(Firma f)
        {
            firme.Add(f);
        }

        public delegate void Callback(string s);
        public event Callback Obavijesti;
        Simulator simulator = new Simulator();
        public string subjektStanje { get; set; }
        public void Run()
        {
            new Thread(new ThreadStart(Run)).Start();

        }
        void RadnaOperacija()
        {
            foreach (string s in simulator)
            {
                Console.WriteLine("Subjekt: " + s);
                SubjektStanje = s;
                Obavijesti(s); // pošalji notifikaciju o promijeni stanja
                Thread.Sleep(10);
            }
        }



            public List<Namjestaj> dimenzijaPretraga(string nazivNamjestaja, double duzina, double sirina, double visina)
        {
            List<Namjestaj> l;
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in namjestaj)
                {
                    if (n.Naziv.ToLower() == nazivNamjestaja.ToLower() && n.Dimenzija.duzina == duzina && n.Dimenzija.sirina == sirina && n.Dimenzija.visina == visina)
                        l.add(n);
                }
                
            }
            return l;
        }
        public List<Namjestaj> nazivPretraga(string nazivNamjestaja)
        {
            List<Namjestaj> l;
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.namjestaj)
                {
                    if (n.Naziv.ToLower() == nazivNamjestaja.ToLower()) l.add(n);
                }

            }
            return l;
        }
        public List<Namjestaj> kategorijaPretraga(Kategorija k)
        {
            List<Namjestaj> l;
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.namjestaj)
                {
                    if (n.Kategorija==k) l.add(n);
                }
            }
            return l;
        }
        public List<Namjestaj> firmaPretraga(string nazivFirme)
        {
            List<Namjestaj> l;
            foreach(Firma firma in firme)
            {
                if (firma.Naziv.ToLower() == nazivFirme.ToLower())
                    return firma.Namjestaj;
            }
            return l;
            
        }
        public List<Namjestaj> cijenaPretraga(double cijena)
  
      {
            List<Namjestaj> l;
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.namjestaj)
                {
                    if (n.Cijena == cijena) l.add(n);
                }

            }
            return l;
        }
        public List<Namjestaj> stilPretraga(string stil)

        {
            List<Namjestaj> l;
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.namjestaj)
                {
                    if (n.Stil.ToLower()=stil.ToLower()) l.add(n);
                }

            }
            return l;
        }
        public List<Namjestaj> materijalPretraga(string materijal)

        {
            List<Namjestaj> l;
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.namjestaj)
                {
                    if (n.Materijal.ToLower() = materijal.ToLower()) l.add(n);
                }

            }
            return l;
        }
        public List<Namjestaj> dezenPretraga(string dezen)

        {
            List<Namjestaj> l;
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.namjestaj)
                {
                    if (n.Dezen.ToLower() = dezen.ToLower()) l.add(n);
                }

            }
            return l;
        }





    }
}
