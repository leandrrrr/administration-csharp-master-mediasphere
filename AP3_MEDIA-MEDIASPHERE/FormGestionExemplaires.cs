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
            cbEtat.ValueMember = "idetat";    //permet de stocker l'identifiant
            cbEtat.DisplayMember = "libelleetat";
            bsEtat.DataSource = Modele.getListEtats();
            cbEtat.DataSource = bsEtat;
        }

        private void bsCategories_CurrentChanged(object sender, EventArgs e)
        {
            if (lbRessources.SelectedIndex != -1)
            {
                // récupération de la catégorie sélectionnée
                R = (Ressource)bsRessources.Current;

                // mise à jour du libellé pour modifier ou supprimer
                tbLibelle.Text = R.Titre;
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
            FormPopDGV formPopDGV = new FormPopDGV("Aucun Aide");
            formPopDGV.Show();
        }

        private void lbRessources_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormGestionExemplaires_Load(object sender, EventArgs e)
        {
            remplirListeCategories();
            remplirListeExemples();

            dateTimePicker1.Value = DateTime.Now;
            textBox1.Text = ToolsL.dateFormatBDD(System.DateTime.Now);
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bsExemples_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            textBox1.Text = ToolsL.dateFormatBDD(dateTimePicker1.Value);
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            int idEtatAdd = cbEtat.SelectedIndex;
            int idRessourceAdd = lbRessources.SelectedIndex;
            DateTime dateRessourceAdd = dateTimePicker1.Value;


            if (cbEtat.SelectedIndex != -1 && lbRessources.SelectedIndex != -1 && dateTimePicker1.Value != null)
            {
                if (Modele.AjoutExemplaire(idRessourceAdd, idEtatAdd, dateRessourceAdd))
                {
                    FormPopDGV formPopDGV = new FormPopDGV("AJOUT EFFECTUÉ !");
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
