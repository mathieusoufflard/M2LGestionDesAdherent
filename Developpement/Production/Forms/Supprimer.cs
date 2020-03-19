using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Maison_des_ligues.accès_aux_données;
using Maison_des_ligues.Classe;

namespace Maison_des_ligues.Forms
{
    public partial class Supprimer : Form
    {
        private AdherentManagement Manager;
        public Supprimer(AdherentManagement manager)
        {
            InitializeComponent();
            Manager = manager;
            ListBoxInit();
        }

        private void ListBoxInit()
        {
            if (ltBoxAderents.Items != null)
                ltBoxAderents.Items.Clear();
            foreach (var item in Manager.ListAdhérent)
            {
                ltBoxAderents.Items.Add(item.Nom);
            }
        }

        private void BtnSupp_Click(object sender, EventArgs e)
        {
            if (ltBoxAderents.Items.Count == 1)
            {
                MessageBox.Show("Impossible de supprimer le dernier adhérent", "ACTION NON AUTORISER",
                    MessageBoxButtons.OK);
            }
            else if (ltBoxAderents.SelectedIndex != -1)
            {
                Manager.ListAdhérent.RemoveAt(ltBoxAderents.SelectedIndex);
                ListBoxInit();
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un adhérent pour continuer", "ERREUR SELECTION MANQUANT",
                    MessageBoxButtons.OK);
            }
            
        }
    }
}
