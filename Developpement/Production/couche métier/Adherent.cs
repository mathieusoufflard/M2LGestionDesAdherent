using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_des_ligues.accès_aux_données
{
    public class Adherent
    {
        public DateTime DateAdhesion { get; set; }
        public int Id{ get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Adherent(DateTime date, int id, string nom, string prenom)
        {
            DateAdhesion = date;
            Id = id;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
