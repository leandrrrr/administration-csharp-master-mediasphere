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
    public partial class FormEmprunteurs : Form
    {
        public FormEmprunteurs()
        {
            InitializeComponent();
        }

        private void dgvEmprunteurs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bsEmprunteurs_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormEmprunteurs_Load(object sender, EventArgs e)
        {
            rendreExemplaireToolStripMenuItem.Enabled = true;
            rendreExemplaireToolStripMenuItem.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPopDGV formPopDGV = new FormPopDGV("Aucun Aide");
            formPopDGV.Show();
        }

        private void voirLesEmpruntsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bsExemplaires_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void dgvEmprunteurs_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgvEmprunts.Visible = true;
        }

        private void rendreExemplaireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
