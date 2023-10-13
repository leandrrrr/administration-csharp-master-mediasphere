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


    public enum EtatGestion
    {
        Create,
        Update,
        Delete
    }
    public partial class FormGestionRessources : Form
    {
        private EtatGestion etat;
        public FormGestionRessources(EtatGestion etat)
        {
            InitializeComponent();
            this.etat = etat; // pour savoir si on est en create ou update ou delete

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {


        }

        private void tbAnnee_TextChanged(object sender, EventArgs e)
        {

        }
        private void remplirListeRessources()
        {
            // remplir la comboBox des ressources (si modification)
            cbRessources.ValueMember = "idressource";    //permet de stocker l'identifiant
            cbRessources.DisplayMember = "titre";
            bsRessources.DataSource = Modele.getListRessources();
            cbRessources.DataSource = bsRessources;
        }
        private void remplirListeEtat()
        {
            // remplir la comboBox des etats
            cbEtats.ValueMember = "idetat";    //permet de stocker l'identifiant
            cbEtats.DisplayMember = "libelleetat";
            bsEtats.DataSource = Modele.getListEtats();
            cbEtats.DataSource = bsEtats;
        }
        public void remplirListeCategories()
        {
            // remplir la comboBox des catégories
            cbCategories.ValueMember = "idcategorie";    //permet de stocker l'identifiant
            cbCategories.DisplayMember = "libellecategorie";
            bsCategories.DataSource = Modele.getListCategories();
            cbCategories.DataSource = bsCategories;
        }
        private void FormGestionRessources_Load(object sender, EventArgs e)
        {

            remplirListeCategories();
            remplirListeEtat();




            if (etat == EtatGestion.Create) // cas etat create
            {
                label1.Text = "Ajout d'une ressource";
                btnAjouter.Text = "AJOUTER";
                gbInfo.Visible = true;
                cbRessources.Visible = false;
                tbAnnee.Text = Convert.ToString(System.DateTime.Now.Year);

            }
            else if (etat == EtatGestion.Update) // cas etat update
            {
                label1.Text = "Modification d'une ressource";
                btnAjouter.Text = "MODIFIER";
                btnAjouter.Visible = false;
                gbInfo.Visible = false;
                cbRessources.Visible = true;
                remplirListeRessources();
            }
            else if (etat == EtatGestion.Delete) // cas etat update
            {
                label1.Text = "Supression d'une ressource";
                btnAjouter.Text = "Supprimer";
                btnAjouter.Visible = false;
                gbInfo.Visible = false;
                cbRessources.Visible = true;

                tbAnnee.ReadOnly = true;
                tbLangue.ReadOnly = true;
                tbImage.ReadOnly = true;
                tbIsbn.ReadOnly = true;
                tbDescription.ReadOnly = true;
                tbTitre.ReadOnly = true;


                remplirListeRessources();
                
            }
        }

        private void tbAnnee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                string errorText = "Erreur dans le format de saisie de l'année (que des chiffres)" + "Erreur" + MessageBoxButtons.OK +
                         MessageBoxIcon.Error;
                FormPopDGV formPopDGV = new FormPopDGV(errorText);
                formPopDGV.Show();
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbIsbn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != Convert.ToChar(Keys.Back))
            {

                string errorText = "Erreur dans le format de saisie de l'ISBN (que des chiffres)" + "Erreur" + MessageBoxButtons.OK +
                        MessageBoxIcon.Error;
                FormPopDGV formPopDGV = new FormPopDGV(errorText);
                formPopDGV.Show();
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void tbLangue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'a' || e.KeyChar > 'z') && (e.KeyChar < 'A' || e.KeyChar > 'Z') && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                string errorText = "Erreur dans le format de saisie de la langue (2 caractères)" + "Erreur" + MessageBoxButtons.OK +
                        MessageBoxIcon.Error;
                FormPopDGV formPopDGV = new FormPopDGV(errorText);
                formPopDGV.Show();
                e.Handled = true; // efface le dernier caractère saisi
            }
        }

        private void Annuler()
        {
            tbTitre.Clear();
            tbDescription.Clear();
            tbLangue.Clear();
            tbImage.Clear();
            tbAnnee.Clear();
            tbIsbn.Clear();
            cbCategories.SelectedIndex = -1;
            tbTitre.Focus();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int idCat = -1, annee;
            string titre, description, image, langue, isbn;

            if (tbTitre.Text != "" && cbCategories.SelectedIndex != -1 && tbAnnee.Text != "")
            {
                // ajout possible si les champs titre et catégorie sont remplis au moins
                if (Convert.ToInt32(tbAnnee.Text) >= 1000 && Convert.ToInt32(tbAnnee.Text) <= 2100)
                {
                    // ajout possible si l'année est correcte
                    titre = tbTitre.Text;
                    description = tbDescription.Text;
                    image = tbImage.Text;
                    langue = tbLangue.Text;
                    isbn = tbIsbn.Text;
                    annee = Convert.ToInt32(tbAnnee.Text);
                    idCat = Convert.ToInt32(cbCategories.SelectedValue.ToString());


                    if (etat == EtatGestion.Create) // cas de l'ajout
                    {
                        //verification de la completion de tout les champs
                        if (tbAnnee.Text != "" && tbImage.Text != "" && tbIsbn.Text != "" && tbLangue.Text != "" && cbCategories.SelectedIndex != -1 && tbDescription.Text != "" && tbTitre.Text != "" && tbAnnee.Text != " " && tbImage.Text != " " && tbIsbn.Text != " " && tbLangue.Text != " " && tbDescription.Text != " " && tbTitre.Text != " ")
                        {
                            if (Modele.AjoutRessource(titre, description, image, annee, langue, isbn, idCat))
                            {
                                FormPopDGV formPopDGV = new FormPopDGV("AJOUT EFFECTUÉ !");
                                formPopDGV.Show();
                                Annuler();
                            }
                        }
                        else
                        {
                            FormPopDGV formPopDGV = new FormPopDGV("VEUILLEZ REMPLIR TOUT LES CHAMP !");
                            formPopDGV.Show();
                        }
                    }
                    if (etat == EtatGestion.Update) // cas de la mise à jour
                    {
                        Ressource R = (Ressource)bsRessources.Current;
                        if (Modele.ModificationRessource(R.Idressource, titre, description, image, annee, langue, isbn, idCat))
                        {
                            MessageBox.Show("Ressource modifiée");
                            gbInfo.Visible = false;
                            btnAjouter.Visible = false;
                            cbRessources.SelectedIndex = -1;
                            // Annuler();
                        }
                    }
                    if (etat == EtatGestion.Delete) // cas de la mise à jour
                    {
                        Ressource R = (Ressource)bsRessources.Current;
                        if (Modele.SupprimerRessource(R.Idressource))
                        {
                            MessageBox.Show("Ressource DELETE !");
                            gbInfo.Visible = false;
                            btnAjouter.Visible = false;
                            cbRessources.SelectedIndex = -1;
                            // Annuler();
                        }
                    }
                }
                else
                {
                    FormPopDGV formPopDGV = new FormPopDGV("ERREUR AVEC L'ANNÉE !");
                    formPopDGV.Show();
                }

            }
            else
            {
                FormPopDGV formPopDGV = new FormPopDGV("VEUILLEZ REMPLIR TOUS LES CHAMPS !");
                formPopDGV.Show();
            }
        }

        private void bsRessources_CurrentChanged(object sender, EventArgs e)
        {
            // si une ressource est sélectionnée dans la liste
            if (cbRessources.SelectedIndex != -1)
            {
                // récupération de la ressource sélectionnée
                Ressource R = (Ressource)bsRessources.Current;

                // mise à jour des champs de la ressource sélectionnée
                tbTitre.Text = R.Titre;
                tbDescription.Text = R.Description;
                tbAnnee.Text = R.Anneesortie.ToString();
                tbIsbn.Text = R.Isbn;
                tbLangue.Text = R.Langue;
                tbImage.Text = R.Image;
                cbCategories.Text = R.IdcategorieNavigation.Libellecategorie;

                gbInfo.Visible = true;
                btnAjouter.Visible = true;
            }
            else
                gbInfo.Visible = false;
        }

        private void cbRessources_SelectedIndexChanged(object sender, EventArgs e)
        {
            bsRessources_CurrentChanged(sender, e);
        }

        private void gbInfo_Enter(object sender, EventArgs e)
        {

        }
        public async Task rgbb()
        {
            while (true)
            {
                await Task.Delay(20);
                this.BackColor = Color.Blue;
                await Task.Delay(20);
                this.BackColor = Color.Red;
                await Task.Delay(20);
                this.BackColor = Color.LightGreen;
                await Task.Delay(20);
                this.BackColor = Color.Yellow;
            }
        }

        private void FormGestionRessources_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void FormGestionRessources_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            rgbb();
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
