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
    public partial class FormAuteurAjout : Form
    {
        private Ressource C = new Ressource();

        public FormAuteurAjout()
        {
            InitializeComponent();
        }

        private void dgvAuteur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void remplirListeRessource()
        {
            // remplir la comboBox des catégories
            lbRessources.ValueMember = "idressource";    //permet de stocker l'identifiant
            lbRessources.DisplayMember = "titre";
            bsRessource.DataSource = Modele.getListRessources();
            lbRessources.DataSource = bsRessource;
        }
        public void remplirDgvAuteur()
        {
            bsAuteur.DataSource = Modele.getListAuteurs().Select(x => new
            {
                x.IdAuteur,
                x.NomAuteur,
                x.PrenomAuteur


            }).OrderBy(x => x.NomAuteur).ToList();

            gdgvAuteurs.DataSource = bsAuteur;

            gdgvAuteurs.Columns["IdAuteur"].Visible = false;
        }

        private void FormAuteurAjout_Load(object sender, EventArgs e)
        {
            remplirListeRessource();
            remplirDgvAuteur();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtHelp_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Aucun Aide");
            formPopDGV.Show();
        }

        private void gtbLibelle_TextChanged(object sender, EventArgs e)
        {

        }

        private void bsRessource_CurrentChanged(object sender, EventArgs e)
        {
            if (lbRessources.SelectedIndex != -1)
            {
                // récupération de la ressource sélectionnée
                C = (Ressource)bsRessource.Current;

                // mise à jour du libellé 
                gtbLibelle.Text = C.Titre;
            }
        }

        private void gbtAjouter_Click(object sender, EventArgs e)
        {
            Ressource R = (Ressource)bsRessource.Current;

            foreach (DataGridViewRow row in gdgvAuteurs.Rows)
            {
                if (Convert.ToBoolean(row.Cells["selectAuteurs"].Value)) // Vérifie si la case à cocher est cochée
                {



                    int id = Convert.ToInt32(row.Cells["IdAuteur"].Value); // Récupère l'identifiant unique de la ligne
                    MessageBox.Show(id + "/ " + R.Idressource);
                    Modele.AjoutAuteurs(R.Idressource, id);






                }
            }
        }

        private void lbRessources_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsRessource_CurrentChanged(sender, e);

        }
    }
}
