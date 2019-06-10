using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class PredstavnikFirme
    {
        private Firma firma;

        public PredstavnikFirme(Firma firma)
        {
            this.firma = firma;
        }
        public int Firma
        {
            get
            {
                return firma;
            }
            set
            {
                firma = value;

            }
        }


    }
}
