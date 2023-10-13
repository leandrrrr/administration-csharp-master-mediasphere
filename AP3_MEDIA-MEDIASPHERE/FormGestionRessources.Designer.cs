namespace AP3_MEDIA
{
    partial class FormGestionRessources
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGestionRessources));
            label1 = new Label();
            gbInfo = new GroupBox();
            cbEtats = new ComboBox();
            cbEtat = new Label();
            cbCategories = new ComboBox();
            label8 = new Label();
            tbLangue = new TextBox();
            label7 = new Label();
            tbIsbn = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbAnnee = new TextBox();
            tbImage = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            tbDescription = new TextBox();
            tbTitre = new TextBox();
            btnAjouter = new Button();
            btnFermer = new Button();
            bsCategories = new BindingSource(components);
            cbRessources = new ComboBox();
            bsRessources = new BindingSource(components);
            button1 = new Button();
            bsEtats = new BindingSource(components);
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtats).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oxanium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 12);
            label1.Name = "label1";
            label1.Size = new Size(253, 29);
            label1.TabIndex = 2;
            label1.Text = "Ajout d'une ressource";
            // 
            // gbInfo
            // 
            gbInfo.BackgroundImage = (Image)resources.GetObject("gbInfo.BackgroundImage");
            gbInfo.BackgroundImageLayout = ImageLayout.Stretch;
            gbInfo.Controls.Add(cbEtats);
            gbInfo.Controls.Add(cbEtat);
            gbInfo.Controls.Add(cbCategories);
            gbInfo.Controls.Add(label8);
            gbInfo.Controls.Add(tbLangue);
            gbInfo.Controls.Add(label7);
            gbInfo.Controls.Add(tbIsbn);
            gbInfo.Controls.Add(label6);
            gbInfo.Controls.Add(label5);
            gbInfo.Controls.Add(tbAnnee);
            gbInfo.Controls.Add(tbImage);
            gbInfo.Controls.Add(label4);
            gbInfo.Controls.Add(label3);
            gbInfo.Controls.Add(label2);
            gbInfo.Controls.Add(tbDescription);
            gbInfo.Controls.Add(tbTitre);
            gbInfo.FlatStyle = FlatStyle.Flat;
            gbInfo.Font = new Font("Oxanium", 18.2F, FontStyle.Underline, GraphicsUnit.Point);
            gbInfo.Location = new Point(59, 61);
            gbInfo.Margin = new Padding(3, 4, 3, 4);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(2, 4, 3, 4);
            gbInfo.Size = new Size(781, 307);
            gbInfo.TabIndex = 3;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informations de la ressource";
            gbInfo.Enter += gbInfo_Enter;
            // 
            // cbEtats
            // 
            cbEtats.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEtats.FlatStyle = FlatStyle.Flat;
            cbEtats.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbEtats.FormattingEnabled = true;
            cbEtats.Location = new Point(252, 246);
            cbEtats.Margin = new Padding(3, 4, 3, 4);
            cbEtats.Name = "cbEtats";
            cbEtats.Size = new Size(212, 29);
            cbEtats.TabIndex = 12;
            // 
            // cbEtat
            // 
            cbEtat.AutoSize = true;
            cbEtat.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbEtat.Location = new Point(251, 215);
            cbEtat.Name = "cbEtat";
            cbEtat.Size = new Size(43, 21);
            cbEtat.TabIndex = 13;
            cbEtat.Text = "Etat";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FlatStyle = FlatStyle.Flat;
            cbCategories.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(490, 246);
            cbCategories.Margin = new Padding(3, 4, 3, 4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(188, 29);
            cbCategories.TabIndex = 6;
            cbCategories.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(489, 215);
            label8.Name = "label8";
            label8.Size = new Size(98, 21);
            label8.TabIndex = 11;
            label8.Text = "Catégorie *";
            // 
            // tbLangue
            // 
            tbLangue.BorderStyle = BorderStyle.None;
            tbLangue.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbLangue.Location = new Point(490, 162);
            tbLangue.Margin = new Padding(3, 4, 3, 4);
            tbLangue.MaxLength = 2;
            tbLangue.Name = "tbLangue";
            tbLangue.Size = new Size(74, 22);
            tbLangue.TabIndex = 5;
            tbLangue.KeyPress += tbLangue_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(489, 135);
            label7.Name = "label7";
            label7.Size = new Size(68, 21);
            label7.TabIndex = 9;
            label7.Text = "Langue";
            // 
            // tbIsbn
            // 
            tbIsbn.BorderStyle = BorderStyle.None;
            tbIsbn.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbIsbn.Location = new Point(490, 82);
            tbIsbn.Margin = new Padding(3, 4, 3, 4);
            tbIsbn.MaxLength = 13;
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(188, 22);
            tbIsbn.TabIndex = 4;
            tbIsbn.KeyPress += tbIsbn_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Image = Properties.Resources.border_style___Copie;
            label6.Location = new Point(489, 55);
            label6.Name = "label6";
            label6.Size = new Size(47, 21);
            label6.TabIndex = 8;
            label6.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(251, 131);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 7;
            label5.Text = "Année de sortie";
            label5.Click += label5_Click;
            // 
            // tbAnnee
            // 
            tbAnnee.BorderStyle = BorderStyle.None;
            tbAnnee.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbAnnee.Location = new Point(252, 162);
            tbAnnee.Margin = new Padding(3, 4, 3, 4);
            tbAnnee.MaxLength = 4;
            tbAnnee.Name = "tbAnnee";
            tbAnnee.Size = new Size(212, 22);
            tbAnnee.TabIndex = 3;
            tbAnnee.TextChanged += tbAnnee_TextChanged;
            tbAnnee.KeyPress += tbAnnee_KeyPress;
            // 
            // tbImage
            // 
            tbImage.BorderStyle = BorderStyle.None;
            tbImage.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbImage.ForeColor = SystemColors.WindowText;
            tbImage.Location = new Point(252, 82);
            tbImage.Margin = new Padding(3, 4, 3, 4);
            tbImage.Multiline = true;
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(212, 22);
            tbImage.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(251, 55);
            label4.Name = "label4";
            label4.Size = new Size(58, 21);
            label4.TabIndex = 4;
            label4.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(19, 119);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(19, 55);
            label2.Name = "label2";
            label2.Size = new Size(59, 21);
            label2.TabIndex = 2;
            label2.Text = "Titre *";
            // 
            // tbDescription
            // 
            tbDescription.BorderStyle = BorderStyle.None;
            tbDescription.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbDescription.ForeColor = SystemColors.WindowText;
            tbDescription.Location = new Point(20, 146);
            tbDescription.Margin = new Padding(3, 4, 3, 4);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(212, 129);
            tbDescription.TabIndex = 1;
            // 
            // tbTitre
            // 
            tbTitre.BorderStyle = BorderStyle.None;
            tbTitre.Font = new Font("Oxanium", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitre.ForeColor = SystemColors.WindowText;
            tbTitre.Location = new Point(20, 82);
            tbTitre.Margin = new Padding(3, 4, 3, 4);
            tbTitre.Name = "tbTitre";
            tbTitre.Size = new Size(212, 22);
            tbTitre.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Black;
            btnAjouter.FlatStyle = FlatStyle.Popup;
            btnAjouter.Font = new Font("Oxanium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(581, 376);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(114, 46);
            btnAjouter.TabIndex = 12;
            btnAjouter.Text = "AJOUTER";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Oxanium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(720, 376);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(120, 46);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // cbRessources
            // 
            cbRessources.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRessources.FormattingEnabled = true;
            cbRessources.Location = new Point(418, 16);
            cbRessources.Margin = new Padding(3, 4, 3, 4);
            cbRessources.Name = "cbRessources";
            cbRessources.Size = new Size(422, 28);
            cbRessources.TabIndex = 13;
            cbRessources.SelectedIndexChanged += cbRessources_SelectedIndexChanged;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsRessources_CurrentChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(154, 206, 234);
            button1.FlatAppearance.BorderColor = Color.FromArgb(154, 206, 234);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Oxanium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 418);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(36, 30);
            button1.TabIndex = 14;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormGestionRessources
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(914, 449);
            Controls.Add(button1);
            Controls.Add(cbRessources);
            Controls.Add(btnAjouter);
            Controls.Add(btnFermer);
            Controls.Add(gbInfo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormGestionRessources";
            Text = "Gestion des Ressources";
            Load += FormGestionRessources_Load;
            KeyDown += FormGestionRessources_KeyDown;
            KeyPress += FormGestionRessources_KeyPress;
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtats).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbInfo;
        private Button btnFermer;
        private TextBox tbAnnee;
        private TextBox tbImage;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox tbDescription;
        private TextBox tbTitre;
        private Label label5;
        private Label label6;
        private ComboBox cbCategories;
        private Label label8;
        private TextBox tbLangue;
        private Label label7;
        private TextBox tbIsbn;
        private BindingSource bsCategories;
        private Button btnAjouter;
        private ComboBox cbRessources;
        private BindingSource bsRessources;
        private Button button1;
        private ComboBox cbEtats;
        private Label label9;
        private Label cbEtat;
        private BindingSource bsEtats;
    }
}