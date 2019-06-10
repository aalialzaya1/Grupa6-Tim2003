using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public interface IPopust
    {
        List<Namjestaj> pregledTrenutnihPopusta();
        List<Namjestaj> pregledSvihPopusta();

    }
}
