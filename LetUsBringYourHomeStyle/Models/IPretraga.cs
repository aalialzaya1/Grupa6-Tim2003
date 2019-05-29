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
        List<Namjestaj> dimenzijaPretraga(Dimenzija d, Namjestaj n);
        List<Namjestaj> komadPretraga(Namjestaj n);
        List<Namjestaj> kategorijaPretraga(Kategorija k);
        List<Namjestaj> firmaPretraga(Firma f);
        List<Namjestaj> savNamjestajPretraga(Dimenzija d);
    }
}
