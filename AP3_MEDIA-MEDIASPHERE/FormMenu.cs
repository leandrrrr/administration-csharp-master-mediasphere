using System.Windows.Forms;

namespace AP3_MEDIA
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            openChildForm(new FormConnexion(this));

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


        private void cATEGORIESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormCategories());

        }
        private async void listeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openChildForm(new FormRessources("ressources"));

        }

        private void ajoutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openChildForm(new FormGestionRessources(EtatGestion.Create));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void modificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormGestionRessources(EtatGestion.Update)); // Form de Gestion en modification (update)
        }

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void eMPRUNTEURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRessources("emprunteurs"));
        }

        private void supressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
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

            FormPopDGV formPopDGV = new FormPopDGV("uwu");
            formPopDGV.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("                                               uwu");
            formPopDGV.Show();
        }

        private void FormMenu_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void exemplairesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openChildForm(new FormGestionExemplaires());


        }

        private void deconnexionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            openChildForm(new FormConnexion(this));
        }

        private void eMPRUNTSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eMPRUNTEURSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new FormEmprunteurs());
        }
    }
}