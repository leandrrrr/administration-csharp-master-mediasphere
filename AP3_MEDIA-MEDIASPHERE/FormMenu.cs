using AP3_MEDIA.Libs;
using Guna.UI2.WinForms;
using System.Diagnostics;
using System.Windows.Forms;

namespace AP3_MEDIA
{
    public partial class FormMenu : Form
    {
        private ToolsLeandre ToolsL = new ToolsLeandre();

        public int droitAcces = 0;
        public string phraseInfo = "vous etes en mode developeur";

        bool DevMode = true;
        string menuOption = "";
        bool homeButtonActive = true;
        public FormMenu()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ggbHomeOption.Visible = false;
            ggbMenuOption.Visible = false;
            if (!DevMode)
            {
                ggbMenuStrip.Visible = false;
                openChildForm(new FormConnexion(this));
            }

        }

        public void resetMenuColor()
        {
            int colorHold1 = 94;
            int colorHold2 = 148;
            int colorHold3 = 255;
            guna2Button1.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            gbtCategories.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            gbtEmprunteurs.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            gbtRess.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            gbtExemplaires.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            gbtExtension.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);

        }

        public void resetMenuOptionColor()
        {
            int colorHold1 = 94;
            int colorHold2 = 148;
            int colorHold3 = 255;
            guna2Button2.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            guna2Button3.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            guna2Button4.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            guna2Button5.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
            guna2Button6.FillColor = Color.FromArgb(colorHold1, colorHold2, colorHold3);
        }


        public void fullAcces()
        {
            gbtRess.Enabled = true;
            gbtEmprunteurs.Enabled = true;
            gbtCategories.Enabled = true;
            gbtExemplaires.Enabled = true;
            guna2Button1.Enabled = true;
            gbtExtension.Enabled = true;

        }
        public void initAcces(int acces)
        {
            switch (acces)
            {
                //!!DEV MODE!!
                case 0:
                    fullAcces();
                    break;
                //FULL acces
                case 1:
                    fullAcces();
                    phraseInfo = "vous avez acces a tout les onglets de l'app";
                    break;
                //ressource
                case 2:
                    fullAcces();
                    gbtEmprunteurs.Enabled = false;
                    gbtExtension.Enabled = false;
                    phraseInfo = "vous ne pouvez gestionner que les entites referente au ressources";

                    break;
                //emprunts
                case 3:
                    fullAcces();
                    gbtRess.Enabled = false;
                    gbtEmprunteurs.Enabled = false;
                    gbtCategories.Enabled = false;
                    gbtExemplaires.Enabled = false;
                    guna2Button1.Enabled = false;
                    phraseInfo = "vous ne pouvez gestionner que les entites referente au prets";
                    break;
                //emprunteur
                case 4:
                    fullAcces();
                    gbtRess.Enabled = false;
                    gbtCategories.Enabled = false;
                    gbtExemplaires.Enabled = false;
                    guna2Button1.Enabled = false;
                    gbtExtension.Enabled = false;
                    phraseInfo = "vous ne pouvez gestionner que les entites referente au emprunteurs";
                    break;
                //noacces
                case 5:
                //no acces
                default:
                    gbtRess.Enabled = false;
                    gbtEmprunteurs.Enabled = false;
                    gbtCategories.Enabled = false;
                    gbtExemplaires.Enabled = false;
                    guna2Button1.Enabled = false;
                    gbtExtension.Enabled = false;
                    phraseInfo = "vous n'avez aucun droit, veillez contacter votre sup�rieure";
                    break;
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
            resetMenuColor();
            resetMenuOptionColor();
            gbtRess.FillColor = Color.FromArgb(64, 108, 235);

            ggbMenuOption.Visible = true;
            menuOption = "ressource";

            //options utuliser :
            guna2Button2.Enabled = true;//list
            guna2Button3.Enabled = true;//add
            guna2Button4.Enabled = true;//edit
            guna2Button5.Enabled = true;//delete
            guna2Button6.Visible = true;//auteur ressource add




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            resetMenuColor();
            resetMenuOptionColor();
            guna2Button1.FillColor = Color.FromArgb(64, 108, 235);

            ggbMenuOption.Visible = true;
            menuOption = "auteur";
            guna2Button2.Enabled = true;//list
            guna2Button3.Enabled = false;//add
            guna2Button4.Enabled = false;//edit
            guna2Button5.Enabled = false;//delete
            guna2Button6.Visible = false;//auteur ressource add
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            resetMenuOptionColor();
            guna2Button2.FillColor = Color.FromArgb(64, 108, 235);

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
            resetMenuColor();
            resetMenuOptionColor();
            gbtCategories.FillColor = Color.FromArgb(64, 108, 235);

            ggbMenuOption.Visible = false;

            openChildForm(new FormCategories());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            resetMenuOptionColor();
            guna2Button3.FillColor = Color.FromArgb(64, 108, 235);
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
            resetMenuOptionColor();
            guna2Button4.FillColor = Color.FromArgb(64, 108, 235);
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
            resetMenuOptionColor();
            guna2Button5.FillColor = Color.FromArgb(64, 108, 235);
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
            resetMenuColor();
            resetMenuOptionColor();
            gbtEmprunteurs.FillColor = Color.FromArgb(64, 108, 235);

            ggbMenuOption.Visible = false;
            openChildForm(new FormRessources("emprunteurs"));

        }

        private void gbtExemplaires_Click(object sender, EventArgs e)
        {
            resetMenuColor();
            resetMenuOptionColor();
            gbtExemplaires.FillColor = Color.FromArgb(64, 108, 235);

            ggbMenuOption.Visible = false;
            openChildForm(new FormGestionExemplaires());
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gcbHome_Click(object sender, EventArgs e)
        {


            if (homeButtonActive)
            {
                ggbHomeOption.Visible = true;
                homeButtonActive = false;
                gcbHome.FillColor = Color.FromArgb(64, 108, 235);
                //gcbHome.BackColor = Color.White;
            }
            else
            {
                ggbHomeOption.Visible = false;
                homeButtonActive = true;
                gcbHome.FillColor = Color.FromArgb(94, 148, 255);
                //gcbHome.BackColor = Color.FromArgb(154, 206, 234);

            }
        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            ggbMenuPlus.Visible = false;
            ggbMenuStrip.Visible = false;
            ggbHomeOption.Visible = false;
            ggbMenuOption.Visible = false;
            gbtClose.Visible = false;
            gcbHome.Visible = false;
            openChildForm(new FormConnexion(this));
        }

        private void ggbMenuOption_Click(object sender, EventArgs e)
        {

        }

        private void gbtExtension_Click(object sender, EventArgs e)
        {
            resetMenuColor();
            resetMenuOptionColor();
            gbtExtension.FillColor = Color.FromArgb(64, 108, 235);

            ggbMenuOption.Visible = false;
            openChildForm(new FormExtension());
        }

        private void ggbMenuStrip_VisibleChanged(object sender, EventArgs e)
        {
            initAcces(droitAcces);
        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV(phraseInfo);
            ToolsL.waitingForm(formPopDGV, 1000);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            resetMenuOptionColor();
            guna2Button6.FillColor = Color.FromArgb(64, 108, 235);
            //auteursRessource add
            switch (menuOption)
            {
                case ("ressource"):
                    openChildForm(new FormAuteurAjout());

                    break;
                case ("auteur"):
                    openChildForm(new FormAuteurAjout());
                    break;
                default:

                    break;
            }
        }
    }
}