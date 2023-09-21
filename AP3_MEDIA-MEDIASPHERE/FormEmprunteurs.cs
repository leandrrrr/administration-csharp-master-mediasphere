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
            bsEmprunteurs.DataSource = Modele.getListEmprunteur().Select(x => new
            {
                x.Idemprunteur,
                x.Nomemprunteur,
                x.Prenomemprunteur,
                x.Datenaissance,
                x.Emailemprunteur,
                x.Telportable
            }).OrderBy(x => x.Idemprunteur).ToList();

            dgvEmprunteurs.DataSource = bsEmprunteurs;

            dgvEmprunteurs.Columns["Idemprunteur"].Visible = false;

        }
    }
}
