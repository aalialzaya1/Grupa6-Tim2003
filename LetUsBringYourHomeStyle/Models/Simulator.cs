using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;


namespace LetUsBringYourHomeStyle.Models
{
    public class Simulator:IEnumerable
    {
        string[] pomjeranja = { "1", "3", "5" };
        public IEnumerator GetEnumerator()
        {
            foreach (string element in pomjeranja)
                return element;
        }
    }
}
