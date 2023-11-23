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
            Ressource R = (Ressource)bsRessource.Current;

            bsAuteur.DataSource = Modele.getListAuteurs().Select(x => new
            {
                x.IdAuteur,
                x.NomAuteur,
                x.PrenomAuteur


            }).OrderBy(x => x.NomAuteur).ToList();

            gdgvAuteurs.DataSource = bsAuteur;

            gdgvAuteurs.Columns["IdAuteur"].Visible = false;
            gdgvAuteurs.Columns["PrenomAuteur"].HeaderText = "Prenom";
            gdgvAuteurs.Columns["Nom"].HeaderText = "Prenom";
        }
        public void remplirDgvAuteurDeRessource()
        {
            Ressource R = (Ressource)bsRessource.Current;

            bsAuteurRessource.DataSource = Modele.listeAuteursParRessource(R.Idressource).Select(x => new
            {

                x.IdAuteurNavigation.PrenomAuteur,
                x.IdAuteurNavigation.NomAuteur


            }).OrderBy(x => x.NomAuteur).ToList();

            gdgvAuteurRessources.DataSource = bsAuteurRessource;

        }

        private void FormAuteurAjout_Load(object sender, EventArgs e)
        {
            remplirListeRessource();
            remplirDgvAuteurDeRessource();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtHelp_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Cette page ne sert pas a cree un auteur mais a referancer les auteurs pour une ressource");
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

                remplirDgvAuteur();
                remplirDgvAuteurDeRessource();
            }
        }

        private void gbtAjouter_Click(object sender, EventArgs e)
        {
            bool testR = true;
            Ressource R = (Ressource)bsRessource.Current;

            foreach (DataGridViewRow row in gdgvAuteurs.Rows)
            {
                if (Convert.ToBoolean(row.Cells["selectAuteurs"].Value)) // Vérifie si la case à cocher est cochée
                {

                    try
                    {

                        int id = Convert.ToInt32(row.Cells["IdAuteur"].Value); // Récupère l'identifiant unique de la ligne
                        // MessageBox.Show(id + "/ " + R.Idressource);
                        Modele.AjoutAuteurs(R.Idressource, id);
                    }
                    catch
                    {
                        FormPopDGV formPopDGV = new FormPopDGV("Un auteur ne peut pas etre ajouter deux fois a une ressource ! (" + row.Cells["PrenomAuteur"].Value + ")");
                        formPopDGV.Show();
                        testR = false;
                    }





                }
            }
            if (testR)
            {
                FormPopDGV formPopDGV = new FormPopDGV("auteur ajouté");
                formPopDGV.Show();
            }
            else
            {
                FormPopDGV formPopDGV = new FormPopDGV("erreur");
                formPopDGV.Show();
            }
        }

        private void lbRessources_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsRessource_CurrentChanged(sender, e);

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
