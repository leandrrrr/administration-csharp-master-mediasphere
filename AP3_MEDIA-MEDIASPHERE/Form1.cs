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
    public partial class FormRetourExemplaire : Form
    {
        public FormRetourExemplaire()
        {
            InitializeComponent();
        }


        private void gbtHelp_Click(object sender, EventArgs e)
        {

        }

        private void FormRetourExemplaire_Load(object sender, EventArgs e)
        {
            remplirListeEmprunteurs();
            gdgvEmprunt.Visible = false;
        }
        private void remplirListeEmprunteurs()
        {
            // remplir la comboBox des ressources (si modification)
            gcbEmprunteurs.ValueMember = "idemprunteur";    //permet de stocker l'identifiant
            gcbEmprunteurs.DisplayMember = "nomemprunteur";
            bsEmprunteur.DataSource = Modele.getListEmprunteur();
            gcbEmprunteurs.DataSource = bsEmprunteur;
        }

        public void lbListeEmpruntsEmprunteur()
        {

            int id = Convert.ToInt32(gcbEmprunteurs.SelectedValue);
            List<Emprunter> lesEmprunt = Modele.listeEmpruntsParEmpruteursWhere(id);
            if (lesEmprunt.Count != 0)
            {
                gdgvEmprunt.Visible = true;
                bsEmprunt.DataSource = (lesEmprunt).Select(x => new
                {
                    x.IdRessourceNavigation.Image,
                    x.Idressource,
                    x.Idexemplaire,
                    x.Idemprunteur,
                    x.Datedebutemprunt,
                    x.IdRessourceNavigation.Titre,
                    x.Dateretour

                });


                gdgvEmprunt.DataSource = bsEmprunt;
                gdgvEmprunt.Columns["Idressource"].Visible = false;
                gdgvEmprunt.Columns["Idexemplaire"].Visible = false;
                gdgvEmprunt.Columns["Idemprunteur"].Visible = false;
                gdgvEmprunt.Columns["Image"].Visible = false;
                gdgvEmprunt.Columns["selectAuteurs"].Width = 50;
                gdgvEmprunt.Columns["Dateretour"].Visible = false;






            }
            else
            {
                gdgvEmprunt.Visible = false;

            }



        }
        int ExtractRowIndexFromCellName(string cellName)
        {
            string searchStr = "RowIndex=";
            int index = cellName.IndexOf(searchStr);

            if (index != -1)
            {
                string numberPart = cellName.Substring(index + searchStr.Length);
                int endIndex = numberPart.IndexOf('}');

                if (endIndex != -1)
                {
                    numberPart = numberPart.Substring(0, endIndex); // Exclure la parenthèse
                    if (int.TryParse(numberPart, out int rowIndex))
                    {
                        return rowIndex;
                    }
                }
            }

            return -1; // Si aucun chiffre n'est trouvé dans le nom de la cellule
        }

        private void gbtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcbEmprunteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbListeEmpruntsEmprunteur();

        }

        private void gbtRendre_Click(object sender, EventArgs e)
        {

        }

        private void gdgvEmprunt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            object uwu = gdgvEmprunt.CurrentCell.Value;
            if (gdgvEmprunt.CurrentCell.Value != null)
            {

                // Obtenez l'index de la ligne sélectionnée
                object rowIndex = gdgvEmprunt.CurrentCell;
                // Récupérez l'indice de la ligne sélectionnée
                string indexFn = rowIndex.ToString();

                int superRow = ExtractRowIndexFromCellName(indexFn)

;

                // Récupérez la valeur de la colonne "Image" pour la ligne sélectionnée
                string imageText = gdgvEmprunt.Rows[superRow].Cells["Image"].Value.ToString();




                string imageUrl = "http://mediatout.florianjaunet.fr/public/assets/" + imageText;

                try
                {
                    Image image = Image.FromStream(new System.Net.WebClient().OpenRead(imageUrl));
                    pictureBox1.Image = image;
                }
                catch (Exception ex)
                {

                }

            }
        }
    }
}
