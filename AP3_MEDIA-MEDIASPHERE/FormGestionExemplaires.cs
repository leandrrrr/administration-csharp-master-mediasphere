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
using AP3_MEDIA.Libs;
using static System.Net.Mime.MediaTypeNames;

namespace AP3_MEDIA
{
    public partial class FormGestionExemplaires : Form
    {

        private Ressource R = new Ressource();
        private ToolsLeandre ToolsL = new ToolsLeandre();
        public FormGestionExemplaires()
        {
            InitializeComponent();
        }




        public void remplirListeExemples()
        {
            // remplir la comboBox des catégories
            gcbEtat.ValueMember = "idetat";    //permet de stocker l'identifiant
            gcbEtat.DisplayMember = "libelleetat";
            bsEtat.DataSource = Modele.getListEtats();
            gcbEtat.DataSource = bsEtat;
        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {
            if (lbRessources.SelectedIndex != -1)
            {
                // récupération de la catégorie sélectionnée
                R = (Ressource)bsRessources.Current;

                // mise à jour du libellé pour modifier ou supprimer
                gtbLibelle.Text = R.Titre;
            }
        }

        public void remplirListeCategories()
        {
            // remplir la comboBox des catégories
            lbRessources.ValueMember = "idressource";   //permet de stocker l'identifiant
            lbRessources.DisplayMember = "titre";
            bsRessources.DataSource = Modele.getListRessources();
            lbRessources.DataSource = bsRessources;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lbRessources_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormGestionExemplaires_Load(object sender, EventArgs e)
        {
            remplirListeCategories();
            remplirListeExemples();

            gdtpDate.Value = DateTime.Now;
            gtbDate.Text = ToolsL.dateFormatBDD(System.DateTime.Now);
        }

        #region useless

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bsExemples_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void gbtHelp_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Aucun Aide");
            formPopDGV.Show();
        }

        private void gdtpDate_ValueChanged(object sender, EventArgs e)
        {
            gtbDate.Text = ToolsL.dateFormatBDD(gdtpDate.Value);

        }

        private void gbtAjouter_Click(object sender, EventArgs e)
        {
            int idEtatAdd = Convert.ToInt32(gcbEtat.SelectedValue);
            int idRessourceAdd = lbRessources.SelectedIndex;
            DateTime dateRessourceAdd = gdtpDate.Value;


            if (gcbEtat.SelectedIndex != -1 && lbRessources.SelectedIndex != -1 && gdtpDate.Value != null)
            {
                try
                {
                    if (Modele.AjoutExemplaire(idRessourceAdd, idEtatAdd, dateRessourceAdd))
                    {
                        FormPopDGV formPopDGV = new FormPopDGV("AJOUT EFFECTUÉ !");
                        ToolsL.waitingForm(formPopDGV, 1000);

                    }
                }
                catch (Exception ex)
                {
                    FormPopDGV formPopDGV = new FormPopDGV("sa a merdé : " + Convert.ToString(ex));
                    formPopDGV.Show();
                }
            }
            else
            {
                FormPopDGV formPopDGV = new FormPopDGV("VEUILLEZ REMPLIR TOUT LES CHAMP !");
                formPopDGV.Show();
            }
        }
    }
}
