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
    }
}
