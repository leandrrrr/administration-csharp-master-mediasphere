using System.Diagnostics;
using System.Windows.Forms;

namespace AP3_MEDIA
{
    public partial class FormMenu : Form
    {

        bool DevMode = true;
        string menuOption = "";
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ggbMenuOption.Visible = false;
            if (!DevMode)
            {
                ggbMenuStrip.Visible = false;
                openChildForm(new FormConnexion(this));
            }

        }

        private void qUITTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }





        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(formEnfant);
            panelPrincipal.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }


        #region useless

        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k
            openChildForm(new FormCategories());

        }
        private async void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k
            openChildForm(new FormRessources("ressources"));

        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k
            openChildForm(new FormGestionRessources(EtatGestion.Create));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k
            openChildForm(new FormGestionRessources(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eMPRUNTEURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k
            openChildForm(new FormRessources("emprunteurs"));
        }

        private void supressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k
            openChildForm(new FormGestionRessources(EtatGestion.Delete));
        }

        private void rESSOURCESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete
            FormPopDGV formPopDGV = new FormPopDGV("uwu");
            formPopDGV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //obsolete
            FormPopDGV formPopDGV = new FormPopDGV("                                               uwu");
            formPopDGV.Show();
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void exemplairesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k

            openChildForm(new FormGestionExemplaires());


        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //obsolete k
            ggbMenuStrip.Visible = false;
            openChildForm(new FormConnexion(this));
        }

        private void eMPRUNTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eMPRUNTEURSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lISTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //obsolete k
            openChildForm(new FormRessources("auteurs"));

        }
        #endregion

        private void gbtRess_Click(object sender, EventArgs e)
        {
            ggbMenuOption.Visible = true;
            menuOption = "ressource";

            //options utuliser :
            guna2Button2.Enabled = true;//list
            guna2Button3.Enabled = true;//add
            guna2Button4.Enabled = true;//edit
            guna2Button5.Enabled = true;//delete



        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            ggbMenuOption.Visible = true;
            menuOption = "auteur";
            guna2Button2.Enabled = true;//list
            guna2Button3.Enabled = true;//add
            guna2Button4.Enabled = false;//edit
            guna2Button5.Enabled = false;//delete
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //liste
            switch (menuOption)
            {
                case ("ressource"):
                    openChildForm(new FormRessources("ressources"));
                    break;
                case ("auteur"):
                    openChildForm(new FormRessources("auteurs"));
                    break;
                default:

                    break;
            }
        }

        private void gbtCategories_Click(object sender, EventArgs e)
        {
            ggbMenuOption.Visible = false;

            openChildForm(new FormCategories());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //ajout
            switch (menuOption)
            {
                case ("ressource"):
                    openChildForm(new FormGestionRessources(EtatGestion.Create));
                    break;
                case ("auteur"):
                    openChildForm(new FormAuteurAjout());
                    break;
                default:

                    break;
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            //edit
            switch (menuOption)
            {
                case ("ressource"):
                    openChildForm(new FormGestionRessources(EtatGestion.Update));
                    break;
                case ("auteur"):
                    break;
                default:

                    break;
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //delete
            switch (menuOption)
            {
                case ("ressource"):
                    openChildForm(new FormGestionRessources(EtatGestion.Delete));

                    break;
                case ("auteur"):
                    break;
                default:

                    break;
            }
        }

        private void gbtEmprunteurs_Click(object sender, EventArgs e)
        {
            ggbMenuOption.Visible = false;
            openChildForm(new FormRessources("emprunteurs"));

        }

        private void gbtExemplaires_Click(object sender, EventArgs e)
        {
            ggbMenuOption.Visible = false;
            //openChildForm(new FormGestionExemplaires());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gcbHome_Click(object sender, EventArgs e)
        {
            ggbMenuStrip.Visible = false;
            ggbMenuOption.Visible = false;
            gbtClose.Visible = false;
            gcbHome.Visible = false;
            openChildForm(new FormConnexion(this));
        }
    }
}