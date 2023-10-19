using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using BCrypt.Net;
using AP3_MEDIA.Libs;


namespace AP3_MEDIA
{
    public partial class FormConnexion : Form
    {
        private ToolsLeandre ToolsL = new ToolsLeandre();
        private FormMenu parentForm;
        public FormConnexion(FormMenu parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            var connexionAvecID1 = Modele.getListUsers().Where(x => x.MailUser == tbId.Text);
            try
            {
                string mdpBcrypt = connexionAvecID1.Select(x => x.MdpUser).FirstOrDefault();
                bool motDePasseCorrect = BCrypt.Net.BCrypt.Verify(tbMdp.Text, mdpBcrypt);
                if (motDePasseCorrect)
                {
                    parentForm.menuStrip1.Visible = true;

                    this.Close();
                }
                else
                {
                    FormPopDGV formPopDGV = new FormPopDGV("Mot de Passe ou Email faux");
                    ToolsL.waitingForm(formPopDGV, 1000);
                }
            }
            catch (Exception xeu)
            {
                FormPopDGV formPopDGV = new FormPopDGV("Mot de Passe ou Email faux");
                ToolsL.waitingForm(formPopDGV, 1000);
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
