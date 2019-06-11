using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class RegistrovaniKorisnik:IObserver
    {
        private string ime;
        private string prezime;
        private string idPopust;
        private Date datumRodjenja;
        private string adresa;
        private string grad;
        private homeStyle homes;
        private string stanje;



        public RegistrovaniKorisnik(string ime, string prezime, string idPopust, Date datumRodjenja, string adresa, string grad, homeStyle homes)
        {
            this.ime = ime;
            this.prezime = prezime;
            this.idPopust = idPopust;
            this.datumRodjenja = datumRodjenja;
            this.adresa = adresa;
            this.grad = grad;

            this.homes = homes;
        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;

            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;

            }
        }
        public string IdPopust
        {
            get
            {
                return idPopust;
            }
            set
            {
                idPopust
 = value;

            }
        }
        public Date DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                datumRodjenja = value;

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
                adresa
 = value;

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
                grad
 = value;

            }
        }
        public homeStyle Homes
        {
            get
            {
                return homes;
            }
            set
            {
                homes = value;

            }
        }

        public RegistrovaniKorisnik(homeStyle subjekt, string ime, string prezime, string idPopust, Date datum, string adresa, string grad)
        {
            this.home = subjekt;
            this.ime = ime;
            this.prezime = prezime;
            this.idPopust = idPopust;
            this.datumRodjenja = datum;
            this.adresa = adresa;
            this.grad = grad;
            subjekt.Obavijesti += Azuriraj; 
            
 }
        public void Azuriraj(string subjektStanje)
        {
            stanje = subjektStanje;
            Console.WriteLine(ime + "-" + stanje);
        }



    }
}
