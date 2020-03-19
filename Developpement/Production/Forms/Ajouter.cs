using Maison_des_ligues.accès_aux_données;
using Maison_des_ligues.Classe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maison_des_ligues.Forms
{
    public partial class Ajouter : Form
    {
        private AdherentManagement Manager;
        public Ajouter(AdherentManagement manager)
        {
            InitializeComponent();
            Manager = manager;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            if (txbNom.Text != "" && txbPrenom.Text != "")
            {
                Manager.AjoutAdherent(new Adherent(DateTime.Now, 1, $"{txbNom.Text}", $"{txbPrenom.Text}"));
                txbNom.Text = "";
                txbPrenom.Text = "";
            }
            else
            {
                MessageBox.Show("Vous devez renseignez les deux champs pour continuer", "ERREUR CHAP(S) MANQUANT",
                    MessageBoxButtons.OK);
            }
        }
    }
}
