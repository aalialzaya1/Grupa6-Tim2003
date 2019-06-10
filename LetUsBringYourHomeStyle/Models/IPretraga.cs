using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LetUsBringYourHomeStyle.Models.homeStyle;

namespace LetUsBringYourHomeStyle.Models
{
    interface IPretraga
    {
        //pretrage namjestaja
        
        List<Namjestaj> nazivPretraga(string nazivNamjestaja);
        List<Namjestaj> kategorijaPretraga(Kategorija k);
        List<Namjestaj> firmaPretraga(string nazivFirme);
        List<Namjestaj> cijenaPretraga(double cijena);
        List<Namjestaj> stilPretraga(string stil);
        List<Namjestaj> dezenPretraga(string dezen);
        List<Namjestaj> materijalPretraga(string materijal);
        List<Namjestaj> dimenzijaPretraga(string nazivNamjestaja, double duzina, double sirina, double visina);
    }
}
