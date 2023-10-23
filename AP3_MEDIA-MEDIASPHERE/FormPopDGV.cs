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
    public partial class FormPopDGV : Form
    {
        public FormPopDGV(string Text)
        {
            InitializeComponent();
            richTextBox1.Text = Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPopDGV_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbtExemplaires_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
