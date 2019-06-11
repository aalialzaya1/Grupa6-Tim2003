using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{

    public class homeStyle : IPretraga
    {
        public enum Kategorija { DnevnaSoba, Kuhinja, SpavacaSoba, Kupatilo, DjecijaSOba, Ured, Dekoracija }
        public List<Savjet> savjeti;
        public List<Firma> firme;
        public List<Firma> Firme
        {
            get
            {
                return firme;
            }
            set
            {
                firme = value;
            }
        }
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
        public List<Firma> dajFirme()
        {
            return firme;
        }

        public delegate void Callback(string s);
        public event Callback Obavijesti;
        Simulator simulator = new Simulator();
        public string subjektStanje;
        public string SubjektStanje
        {
            get
            {
                return subjektStanje;
            }
            set
            {
                subjektStanje = value;
            }
        }

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
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (n.Naziv.ToLower() == nazivNamjestaja.ToLower() && n.Dimenzija.Duzina == duzina && n.Dimenzija.Sirina == sirina && n.Dimenzija.Visina == visina)
                        l.Add(n);
                }

            }
            return l;
        }
        public List<Namjestaj> nazivPretraga(string nazivNamjestaja)
        {
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {

                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (n.Naziv.ToLower() == nazivNamjestaja.ToLower())
                    {
                        l.Add(n);
                    }

                }

            }
            return l;
        }
        public List<Namjestaj> kategorijaPretraga(Kategorija k)
        {
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (n.Kategorija == k) l.Add(n);
                }
            }
            return l;
        }
        public List<Namjestaj> firmaPretraga(string nazivFirme)
        {
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                if (firma.Naziv.ToLower() == nazivFirme.ToLower())
                    return firma.dajNamjestaj();
            }
            return l;

        }
        public List<Namjestaj> cijenaPretraga(double cijena)

        {
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (n.Cijena == cijena) l.Add(n);
                }

            }
            return l;
        }
        public List<Namjestaj> stilPretraga(string stil)

        {
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (n.Stil.ToLower().Equals(stil.ToLower())) l.Add(n);

                }


            }
            return l;
        }
        public List<Namjestaj> materijalPretraga(string materijal)

        {
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (n.Materijal.ToLower().Equals(materijal.ToLower())) l.Add(n);
                }

            }
            return l;
        }
        public List<Namjestaj> dezenPretraga(string dezen)

        {
            List<Namjestaj> l = new List<Namjestaj>();
            foreach (Firma firma in firme)
            {
                foreach (Namjestaj n in firma.dajNamjestaj())
                {
                    if (n.Dezen.ToLower().Equals(dezen.ToLower())) l.Add(n);
                }

            }
            return l;
        }





    }
}
