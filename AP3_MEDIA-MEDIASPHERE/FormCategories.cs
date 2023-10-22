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
using static System.Net.Mime.MediaTypeNames;

namespace AP3_MEDIA
{
    //test
    public partial class FormCategories : Form
    {
        private Categorie C = new Categorie();
        public FormCategories()
        {
            InitializeComponent();
        }

        public void remplirListeCategories()
        {
            // remplir la comboBox des catégories
            lbCategories.ValueMember = "idcategorie";    //permet de stocker l'identifiant
            lbCategories.DisplayMember = "libellecategorie";
            bsCategories.DataSource = Modele.getListCategories();
            lbCategories.DataSource = bsCategories;
        }
        private void FormCategories_Load(object sender, EventArgs e)
        {
            remplirListeCategories();
            gbtModifier.Enabled = false;
            gbtSupprimer.Enabled = false;

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {


        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedIndex != -1)
            {
                // récupération de la catégorie sélectionnée
                C = (Categorie)bsCategories.Current;

                // mise à jour du libellé pour modifier ou supprimer
                gtbLibelle.Text = C.Libellecategorie;
            }
        }
        #region useless
        private void btnModifier_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }



        private void tbLibelle_TextChanged(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void gbCategorie_Enter(object sender, EventArgs e)
        {

        }

        private void lbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbCategories.SelectedIndex == -1)
            {
                gbtModifier.Enabled = false;
                gbtSupprimer.Enabled = false;
            }
            gbtAjouter.Enabled = false;
            gbtModifier.Enabled = true;
            gbtSupprimer.Enabled = true;
        }

        private void gbtHelp_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Sélectionner une catégorie pour la modifier ou la supprimer");
            formPopDGV.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtAjouter_Click(object sender, EventArgs e)
        {
            string libelle = gtbLibelle.Text;
            if (libelle != "")
            {

                if (Modele.AjoutCategorie(libelle))
                {
                    MessageBox.Show("Catégorie ajoutée ");
                    gtbLibelle.Clear();
                    remplirListeCategories();
                }
                else
                {
                    MessageBox.Show("Ajout impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("ERREUR : Libellé ne doit pas être vide", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbtModifier_Click(object sender, EventArgs e)
        {
            string libelle = gtbLibelle.Text;
            if (libelle != "")
            {
                if (Modele.ModifierCategorie(C.Idcategorie, libelle))
                {
                    MessageBox.Show("Catégorie modifiée ");
                    remplirListeCategories();
                    lbCategories.SelectedIndex = -1;
                    gtbLibelle.Clear();
                }
                else
                {
                    MessageBox.Show("Modification impossible", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la catégorie à modifier", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gtbLibelle_TextChanged(object sender, EventArgs e)
        {
            if (gtbLibelle.Text == "" || gtbLibelle.Text == " ")
            {
                gbtAjouter.Enabled = false;
                gbtModifier.Enabled = false;
                gbtSupprimer.Enabled = false;
            }
            else
            {

                gbtAjouter.Enabled = true;
            }
        }

        private void gbtSupprimer_Click(object sender, EventArgs e)
        {
            string libelle = gtbLibelle.Text;
            if (libelle != "")
            {
                if (Modele.SupprimerCategorie(C.Idcategorie))
                {
                    MessageBox.Show("Catégorie supprimée ");
                    remplirListeCategories();
                    lbCategories.SelectedIndex = -1;
                    gtbLibelle.Clear();
                }
            }
            else
            {
                MessageBox.Show("ERREUR : Sélectionner la catégorie à supprimer", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
