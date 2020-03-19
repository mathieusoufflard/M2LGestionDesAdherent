
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
    public partial class FormPrincipal : Form
    {
        AdherentManagement adherentManagement = new AdherentManagement();
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void listerToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Adherents listeDesAdherents = new Adherents(adherentManagement.ListAdhérent);
            listeDesAdherents.ShowDialog();
            listeDesAdherents.Dispose();
        }

        private void AjouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajouter AjouterAdherents = new Ajouter(adherentManagement);
            AjouterAdherents.ShowDialog();
            AjouterAdherents.Dispose();
        }

        private void SupprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supprimer SupprimerAdherents = new Supprimer(adherentManagement);
            SupprimerAdherents.ShowDialog();
            SupprimerAdherents.Dispose();
        }
    }
}
