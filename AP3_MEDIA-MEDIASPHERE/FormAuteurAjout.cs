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

        private void FormAuteurAjout_Load(object sender, EventArgs e)
        {
            remplirListeRessource();
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
    }
}
