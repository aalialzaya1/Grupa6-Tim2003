using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static LetUsBringYourHomeStyle.Models.homeStyle;

namespace LetUsBringYourHomeStyle.Models
{
    public class Savjet
    {
        [ScaffoldColumn(false)]
        private int SavjetID { get; set; }
        [Required]
        public string naziv;
        [Required]
        public string autor;
        [Required]
        public string sadrzaj;
        public Kategorija kategorija { get; set; }
        [Required]
        public int KategorijaID { get; set; }
        public string Naziv
        {
            get
            {
                return naziv;
            }
            set
            {
                naziv = value;
            }
        }
        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public string Sadrzaj
        {
            get
            {
                return sadrzaj;
            }
            set
            {
                sadrzaj = value;
            }
        }
        public Kategorija Kategorija
        {
            get
            {
                return kategorija;
            }
            set
            {
                kategorija = value;
            }
        }
        public Savjet(string naziv, string autor, string sadrzaj, Kategorija kategorija)
        {
            this.naziv = naziv;
            this.autor = autor;
            this.sadrzaj = sadrzaj;
            this.kategorija = kategorija;
        }
    }
}
