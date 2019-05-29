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

        public List<Namjestaj> dimenzijaPretraga(Dimenzija d, Namjestaj n)
        {
            throw new NotImplementedException();
        }

        public List<Namjestaj> komadPretraga(Namjestaj n)
        {
            throw new NotImplementedException();
        }

        public List<Namjestaj> kategorijaPretraga(Kategorija k)
        {
            throw new NotImplementedException();
        }

        public List<Namjestaj> firmaPretraga(Firma f)
        {
            throw new NotImplementedException();
        }

        public List<Namjestaj> savNamjestajPretraga(Dimenzija d)
        {
            throw new NotImplementedException();
        }
    }
}
