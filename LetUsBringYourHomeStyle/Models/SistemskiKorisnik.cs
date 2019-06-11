using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LetUsBringYourHomeStyle.Models
{
    public class SistemskiKorisnik
    {
        [ScaffoldColumn(false)]
        public int SistemskiKorisnikID { get; set; }
        [Required]
        private string username;
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        [Required]
        public string password;
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        [Required]
        public string email;
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
        [Required]
        public string telefon;
        public string Telefon
        {
            get
            {
                return telefon;
            }
            set
            {
                telefon = value;
            }
        }


    }
}
