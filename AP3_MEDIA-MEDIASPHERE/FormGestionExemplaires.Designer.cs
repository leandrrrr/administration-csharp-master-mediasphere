namespace AP3_MEDIA
{
    partial class FormGestionExemplaires
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbRessources = new ListBox();
            bsRessources = new BindingSource(components);
            pictureBox1 = new PictureBox();
            btnFermer = new Button();
            tbLibelle = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbRessources
            // 
            lbRessources.Anchor = AnchorStyles.Top;
            lbRessources.BorderStyle = BorderStyle.None;
            lbRessources.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbRessources.FormattingEnabled = true;
            lbRessources.ItemHeight = 21;
            lbRessources.Location = new Point(49, 69);
            lbRessources.Margin = new Padding(3, 4, 3, 4);
            lbRessources.Name = "lbRessources";
            lbRessources.Size = new Size(280, 273);
            lbRessources.TabIndex = 9;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsCategories_CurrentChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.border_style___Copie;
            pictureBox1.Location = new Point(381, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnFermer
            // 
            btnFermer.Anchor = AnchorStyles.Top;
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Oxanium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(614, 271);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(114, 59);
            btnFermer.TabIndex = 11;
            btnFermer.Text = "AJOUTER";
            btnFermer.UseVisualStyleBackColor = false;
            // 
            // tbLibelle
            // 
            tbLibelle.Anchor = AnchorStyles.Top;
            tbLibelle.Location = new Point(392, 92);
            tbLibelle.Margin = new Padding(3, 4, 3, 4);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(559, 26);
            tbLibelle.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.Location = new Point(392, 126);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(559, 26);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Oxanium ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(981, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 14;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormGestionExemplaires
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 428);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tbLibelle);
            Controls.Add(btnFermer);
            Controls.Add(pictureBox1);
            Controls.Add(lbRessources);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionExemplaires";
            Text = "FormGestionExemplaires";
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbRessources;
        private BindingSource bsRessources;
        private PictureBox pictureBox1;
        private Button btnFermer;
        private TextBox tbLibelle;
        private TextBox textBox1;
        private Button button1;
    }
}