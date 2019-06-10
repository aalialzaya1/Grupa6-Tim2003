using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class Proxy : IPopust
    {
        // Popust popusti = new IPopust();
        int nivoPristupa = 0;



        public void pristup(string username, string password)
        {
            if (password == "Home1234")

            {
                nivoPristupa = 1;
            }
            else nivoPristupa = 0;
        }

        public List<Namjestaj> pregledTrenutnihPopusta()
        {
            List<Namjestaj> l = new List<Namjestaj>();
            if (nivoPristupa == 1) return pregledTrenutnihPopusta();
            else return l;
        }

        public List<Namjestaj> pregledSvihPopusta()
        {
            return null;
        }
    }
}
