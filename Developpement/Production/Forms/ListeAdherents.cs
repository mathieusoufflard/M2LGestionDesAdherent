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
    public partial class Adherents : Form
    {
        public Adherents(List<Adherent> list)
        {
            InitializeComponent();
            ManageDataGridView(list);
        }

        private void ManageDataGridView(List<Adherent> list)
        {
            foreach (var item in list)
            {
                dataGridView.Rows.Add($"{item.Nom}", $"{item.Prenom}", $"{item.DateAdhesion}");
            }
        }
    }
}
