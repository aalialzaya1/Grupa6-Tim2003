using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class PredstavnikFirme : SistemskiKorisnik
    {
        [ScaffoldColumn(false)]
        public int PredstavnikFirmeID { get; set; }
        [Required]
        public int FirmaID { get; set; }
        public Firma firma;

        public PredstavnikFirme(Firma firma)
        {
            this.firma = firma;
        }
        public Firma Firma
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
