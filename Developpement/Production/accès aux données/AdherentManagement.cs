using Maison_des_ligues.accès_aux_données;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maison_des_ligues.Classe
{
    public class AdherentManagement
    {
        public List<Adherent> ListAdhérent { get; set; }

        public AdherentManagement()
        {
            ListAdhérent = CreationAdherents.CreationList();
        }

        public void AjoutAdherent(Adherent adherent)
        {
            ListAdhérent.Add(adherent);
        }

        public void SupprimerAdherent(Adherent adherent)
        {
            foreach (var item in ListAdhérent)
            {
                if (adherent.Id == item.Id)
                {
                    ListAdhérent.Remove(item);
                }
            }
        }
    }
}
