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
    public partial class FormRessources : Form
    {
        private string etatForm;
        public FormRessources(string etatForm)
        {
            this.etatForm = etatForm;
            InitializeComponent();


        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRessources_Load(object sender, EventArgs e)
        {

            if (etatForm == "ressources")
            {

                bsRessources.DataSource = Modele.getListRessources().Select(x => new
                {
                    x.Idressource,
                    x.Titre,
                    x.Description,
                    x.Isbn,
                    x.Idcategorie,
                    x.IdcategorieNavigation.Libellecategorie
                }).OrderBy(x => x.Idressource).ToList();


                dgvRessources.DataSource = bsRessources;
                dgvRessources.Columns["Idressource"].Visible = false;
                dgvRessources.Columns["Idcategorie"].Visible = false;
            }
            else if (etatForm == "emprunteurs")
            {
                voirLesExemplaireToolStripMenuItem.Text = "voir les emprunts";
                bsRessources.DataSource = Modele.getListEmprunteur().Select(x => new
                {
                    x.Idemprunteur,
                    x.Nomemprunteur,
                    x.Prenomemprunteur,
                    x.Datenaissance,
                    x.Emailemprunteur,
                    x.Telportable
                }).OrderBy(x => x.Idemprunteur).ToList();

                dgvRessources.DataSource = bsRessources;

                dgvRessources.Columns["Idemprunteur"].Visible = false;
            }

            else if (etatForm == "auteurs")
            {

                voirLesExemplaireToolStripMenuItem.Text = "il fait beau aujourd'hui";
                bsRessources.DataSource = Modele.getListAuteurs().Select(x => new
                {
                    x.IdAuteur,
                    x.PrenomAuteur
                    ,
                    x.NomAuteur
                }).OrderBy(x => x.IdAuteur).ToList();

                dgvRessources.DataSource = bsRessources;

                dgvRessources.Columns["IdAuteur"].Visible = false;
                dgvRessources.Columns["PrenomAuteur"].HeaderText = "Prenom";
                dgvRessources.Columns["NomAuteur"].HeaderText = "Nom";

            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void voirLesExemplaireToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (etatForm == "ressources")
            {
                System.Type type = bsRessources.Current.GetType();
                int idR = (int)type.GetProperty("Idressource").GetValue(bsRessources.Current, null);
                List<Exemplaire> lesExemplaires = Modele.listeExemplairesParRessource(idR);
                if (lesExemplaires.Count != 0)
                {
                    bsExemplaires.DataSource = (lesExemplaires).Select(x => new
                    {
                        x.Idexemplaire,
                        x.Dateentree,
                        x.IdetatNavigation.Libelleetat
                    });

                    dgvExemplaires.DataSource = bsExemplaires;
                    dgvExemplaires.Visible = true;
                    dgvExemplaires.Columns["Idexemplaire"].Visible = false;
                    dgvExemplaires.Columns["Dateentree"].Width = 95;
                    dgvExemplaires.Columns["Libelleetat"].Width = 105;



                }
                else
                {
                    dgvExemplaires.Visible = false;
                    MessageBox.Show("Pas d'exemplaire pour cette ressource");
                }
            }
            else if (etatForm == "emprunteurs")
            {
                System.Type type = bsRessources.Current.GetType();
                int idR = (int)type.GetProperty("Idemprunteur").GetValue(bsRessources.Current, null);
                List<Emprunter> lesExemplaires = Modele.listeEmpruntsParEmpruteurs(idR);
                if (lesExemplaires.Count != 0)
                {
                    bsExemplaires.DataSource = (lesExemplaires).Select(x => new
                    {
                        x.IdRessourceNavigation.Titre,
                        x.Dureeemprunt,
                        Dateretour = (DateTime.Now < x.Dateretour) ? "En Cours" : "Archiver"
                    });

                    dgvExemplaires.DataSource = bsExemplaires;
                    dgvExemplaires.Visible = true;





                }
                else
                {
                    dgvExemplaires.Visible = false;
                    FormPopDGV formPopDGV = new FormPopDGV("Pas d'Emprunts pour cette Emprunteur");
                    formPopDGV.Show();

                }
            }

        }

        private void dgvRessources_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        private void dgvRessources_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        private void dgvRessources_Click(object sender, EventArgs e)
        {
            dgvExemplaires.Visible = false;
        }

        private void dgvExemplaires_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsRessources_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Aucun Aide");
            formPopDGV.Show();
        }
    }
}
