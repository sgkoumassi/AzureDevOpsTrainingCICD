using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebServicesAJAX
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Titre { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int HomeTelephone { get; set; }
        public string Sexe { get; set; }
        public int Telephone { get; set; }
    }
}