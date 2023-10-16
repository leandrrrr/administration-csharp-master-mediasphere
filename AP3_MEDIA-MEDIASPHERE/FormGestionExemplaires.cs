using AP3_MEDIA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP3_MEDIA
{
    public partial class FormGestionExemplaires : Form
    {

        private Ressource R = new Ressource();
        public FormGestionExemplaires()
        {
            InitializeComponent();
        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {
            if (lbRessources.SelectedIndex != -1)
            {
                // récupération de la catégorie sélectionnée
                R = (Ressource)bsRessources.Current;

                // mise à jour du libellé pour modifier ou supprimer
                //tbLibelle.Text = C.Libellecategorie;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Aucun Aide");
            formPopDGV.Show();
        }
    }
}
