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
            label1 = new Label();
            gbInfo = new GroupBox();
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
            gbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(59, 12);
            label1.Name = "label1";
            label1.Size = new Size(266, 32);
            label1.TabIndex = 2;
            label1.Text = "Ajout d'une ressource";
            // 
            // gbInfo
            // 
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
            gbInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            gbInfo.Location = new Point(59, 65);
            gbInfo.Margin = new Padding(3, 4, 3, 4);
            gbInfo.Name = "gbInfo";
            gbInfo.Padding = new Padding(3, 4, 3, 4);
            gbInfo.Size = new Size(781, 303);
            gbInfo.TabIndex = 3;
            gbInfo.TabStop = false;
            gbInfo.Text = "Informations de la ressource";
            // 
            // cbCategories
            // 
            cbCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(495, 212);
            cbCategories.Margin = new Padding(3, 4, 3, 4);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(188, 29);
            cbCategories.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(495, 181);
            label8.Name = "label8";
            label8.Size = new Size(96, 23);
            label8.TabIndex = 11;
            label8.Text = "Catégorie *";
            // 
            // tbLangue
            // 
            tbLangue.Location = new Point(495, 131);
            tbLangue.Margin = new Padding(3, 4, 3, 4);
            tbLangue.MaxLength = 2;
            tbLangue.Name = "tbLangue";
            tbLangue.Size = new Size(74, 29);
            tbLangue.TabIndex = 5;
            tbLangue.KeyPress += tbLangue_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(495, 104);
            label7.Name = "label7";
            label7.Size = new Size(66, 23);
            label7.TabIndex = 9;
            label7.Text = "Langue";
            // 
            // tbIsbn
            // 
            tbIsbn.Location = new Point(495, 55);
            tbIsbn.Margin = new Padding(3, 4, 3, 4);
            tbIsbn.MaxLength = 13;
            tbIsbn.Name = "tbIsbn";
            tbIsbn.Size = new Size(188, 29);
            tbIsbn.TabIndex = 4;
            tbIsbn.KeyPress += tbIsbn_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(495, 28);
            label6.Name = "label6";
            label6.Size = new Size(47, 23);
            label6.TabIndex = 8;
            label6.Text = "ISBN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 181);
            label5.Name = "label5";
            label5.Size = new Size(130, 23);
            label5.TabIndex = 7;
            label5.Text = "Année de sortie";
            label5.Click += label5_Click;
            // 
            // tbAnnee
            // 
            tbAnnee.Location = new Point(257, 212);
            tbAnnee.Margin = new Padding(3, 4, 3, 4);
            tbAnnee.MaxLength = 4;
            tbAnnee.Name = "tbAnnee";
            tbAnnee.Size = new Size(114, 29);
            tbAnnee.TabIndex = 3;
            tbAnnee.TextChanged += tbAnnee_TextChanged;
            tbAnnee.KeyPress += tbAnnee_KeyPress;
            // 
            // tbImage
            // 
            tbImage.ForeColor = SystemColors.WindowText;
            tbImage.Location = new Point(257, 51);
            tbImage.Margin = new Padding(3, 4, 3, 4);
            tbImage.Multiline = true;
            tbImage.Name = "tbImage";
            tbImage.Size = new Size(212, 75);
            tbImage.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(257, 24);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 4;
            label4.Text = "Image";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 88);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 24);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 2;
            label2.Text = "Titre *";
            // 
            // tbDescription
            // 
            tbDescription.ForeColor = SystemColors.WindowText;
            tbDescription.Location = new Point(25, 115);
            tbDescription.Margin = new Padding(3, 4, 3, 4);
            tbDescription.Multiline = true;
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(212, 129);
            tbDescription.TabIndex = 1;
            // 
            // tbTitre
            // 
            tbTitre.ForeColor = SystemColors.WindowText;
            tbTitre.Location = new Point(25, 51);
            tbTitre.Margin = new Padding(3, 4, 3, 4);
            tbTitre.Name = "tbTitre";
            tbTitre.Size = new Size(212, 29);
            tbTitre.TabIndex = 0;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.Black;
            btnAjouter.FlatStyle = FlatStyle.Popup;
            btnAjouter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(581, 376);
            btnAjouter.Margin = new Padding(3, 4, 3, 4);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(114, 57);
            btnAjouter.TabIndex = 12;
            btnAjouter.Text = "AJOUTER";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(720, 376);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(120, 57);
            btnFermer.TabIndex = 4;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // cbRessources
            // 
            cbRessources.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRessources.FormattingEnabled = true;
            cbRessources.Location = new Point(417, 25);
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
            // FormGestionRessources
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(914, 449);
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
            gbInfo.ResumeLayout(false);
            gbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsCategories).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
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
    }
}