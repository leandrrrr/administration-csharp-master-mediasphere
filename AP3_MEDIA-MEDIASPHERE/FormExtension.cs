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
    public partial class FormExtension : Form
    {

        private void remplirListeEmprunteurs()
        {
            // remplir la comboBox des ressources (si modification)
            gcbEmprunteurs.ValueMember = "idemprunteur";    //permet de stocker l'identifiant
            gcbEmprunteurs.DisplayMember = "nomemprunteur";
            bsEmprunteur.DataSource = Modele.getListEmprunteur();
            gcbEmprunteurs.DataSource = bsEmprunteur;
        }

        public void lbListeEmpruntsEmprunteur()
        {
            
            int id = Convert.ToInt32(gcbEmprunteurs.SelectedValue);
            List<Emprunter> lesEmprunt = Modele.listeEmpruntsParEmpruteurs(id);
            if (lesEmprunt.Count != 0)
            {
                gdgvEmprunt.Visible=true;
                bsEmprunt.DataSource = (lesEmprunt).Select(x => new
                {
                    x.IdRessourceNavigation.Image,
                    x.Id,
                    x.IdRessourceNavigation.Titre,
                    x.Dureeemprunt,
                });


                gdgvEmprunt.DataSource = bsEmprunt;
            }
            else
            {
                gdgvEmprunt.Visible = false;

            }



        }
        public FormExtension()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void gbtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtHelp_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Ajouter du temps d'emprunt d'un exemplaire 10 /20 /30 jours a un utilisateur selectionner dans la liste deroulante, un exemplaire ne peut voir son emprunt augmenter qu'une seule fois !");
            formPopDGV.Show();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormExtension_Load(object sender, EventArgs e)
        {
            gdgvEmprunt.Visible = false;

            remplirListeEmprunteurs();

            string imageUrl = "http://mediatout.florianjaunet.fr/public/assets/tof.png";

            try
            {
                Image image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
                pictureBox1.Image = image;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
            }
        }

        private void gcbEmprunteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbListeEmpruntsEmprunteur();
        }

        private void gdgvEmprunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gdgvEmprunt.CurrentCell.Value != null)
            {
                try
                {
                    string cellValue = gdgvEmprunt.CurrentCell.Value.ToString();



                    string imageUrl = "http://mediatout.florianjaunet.fr/public/assets/" + cellValue;

                    try
                    {
                        Image image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
                        pictureBox1.Image = image;
                    }
                    catch (Exception ex)
                    {
                        
                    }
                }
                catch (Exception exx) { }
            }
        }
    }
}
