using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LetUsBringYourHomeStyle.Models.homeStyle;

namespace LetUsBringYourHomeStyle.Models
{
    interface IPopust
    {
        List<Namjestaj> pregledTrenutnihPopusta();
    }
}