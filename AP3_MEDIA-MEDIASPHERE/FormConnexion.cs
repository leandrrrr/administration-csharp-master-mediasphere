﻿using System;
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
        #region useless
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            //old




        }

        private void button1_Click(object sender, EventArgs e)
        {
            //old
        }
        #endregion

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }

        private void gbtExemplaires_Click(object sender, EventArgs e)
        {
            var connexionAvecID1 = Modele.getListUsers().Where(x => x.MailUser == gbtId.Text);
            try
            {
                string mdpBcrypt = connexionAvecID1.Select(x => x.MdpUser).FirstOrDefault();
                bool motDePasseCorrect = BCrypt.Net.BCrypt.Verify(gtbMdp.Text, mdpBcrypt);
                if (motDePasseCorrect)
                {
                    parentForm.ggbMenuStrip.Visible = true;
                    parentForm.ggbMenuPlus.Visible = true;
                    parentForm.gbtClose.Visible = true;
                    parentForm.gcbHome.Visible = true;




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

        private void gbtClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
