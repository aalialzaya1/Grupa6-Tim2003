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
        public IEnumerator Enumerator
        {
            get
            {
                foreach (string element in pomjeranja)
                    yield return element;
            }
        }

        public IEnumerator GetEnumerator()
        {
            return pomjeranja.GetEnumerator();
        }
    }
}
