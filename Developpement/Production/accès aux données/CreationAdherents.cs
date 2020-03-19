using Maison_des_ligues.accès_aux_données;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_des_ligues.Classe
{
    public class CreationAdherents
    {
        public static List<Adherent> CreationList()
        {
            List<Adherent> list = new List<Adherent>();

            list.Add(new Adherent(DateTime.Now, 1, "Paul", "didi"));
            list.Add(new Adherent(DateTime.Now, 2, "martin", "dodo"));
            list.Add(new Adherent(DateTime.Now, 3, "toto", "titi"));
            list.Add(new Adherent(DateTime.Now, 4, "felix", "LeChat"));
            list.Add(new Adherent(DateTime.Now, 5, "jack", "morey"));

            return list;
        }
    }
}
