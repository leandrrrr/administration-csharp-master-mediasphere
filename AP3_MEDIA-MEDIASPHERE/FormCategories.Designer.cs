namespace AP3_MEDIA
{
    partial class FormCategories
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
            bsCategories = new BindingSource(components);
            tbLibelle = new TextBox();
            lbCategories = new ListBox();
            btnFermer = new Button();
            gbCategorie = new GroupBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnValider = new Button();
            label4 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            gbCategorie.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oxanium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(55, 19);
            label1.Name = "label1";
            label1.Size = new Size(264, 29);
            label1.TabIndex = 3;
            label1.Text = "Gestion des catégories";
            // 
            // bsCategories
            // 
            bsCategories.CurrentChanged += bsCategories_CurrentChanged;
            // 
            // tbLibelle
            // 
            tbLibelle.Font = new Font("Oxanium", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            tbLibelle.ImeMode = ImeMode.NoControl;
            tbLibelle.Location = new Point(6, 27);
            tbLibelle.Margin = new Padding(3, 4, 3, 4);
            tbLibelle.Multiline = true;
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(402, 60);
            tbLibelle.TabIndex = 6;
            tbLibelle.TextChanged += tbLibelle_TextChanged;
            // 
            // lbCategories
            // 
            lbCategories.BorderStyle = BorderStyle.None;
            lbCategories.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 21;
            lbCategories.Location = new Point(514, 58);
            lbCategories.Margin = new Padding(3, 4, 3, 4);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(343, 315);
            lbCategories.TabIndex = 8;
            lbCategories.SelectedIndexChanged += lbCategories_SelectedIndexChanged;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.FromArgb(254, 254, 254);
            btnFermer.FlatStyle = FlatStyle.Flat;
            btnFermer.Font = new Font("Oxanium Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.FromArgb(10, 10, 64);
            btnFermer.Location = new Point(881, 301);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(135, 72);
            btnFermer.TabIndex = 9;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // gbCategorie
            // 
            gbCategorie.BackgroundImage = Properties.Resources.border_style___Copie;
            gbCategorie.BackgroundImageLayout = ImageLayout.Stretch;
            gbCategorie.Controls.Add(btnSupprimer);
            gbCategorie.Controls.Add(btnModifier);
            gbCategorie.Controls.Add(btnValider);
            gbCategorie.Controls.Add(tbLibelle);
            gbCategorie.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbCategorie.Location = new Point(55, 58);
            gbCategorie.Margin = new Padding(3, 4, 3, 4);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Padding = new Padding(3, 4, 3, 4);
            gbCategorie.Size = new Size(414, 315);
            gbCategorie.TabIndex = 11;
            gbCategorie.TabStop = false;
            gbCategorie.Text = "A ajouter";
            gbCategorie.Enter += gbCategorie_Enter;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.FromArgb(254, 254, 254);
            btnSupprimer.Enabled = false;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.Font = new Font("Oxanium Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSupprimer.ForeColor = Color.FromArgb(10, 10, 64);
            btnSupprimer.Location = new Point(6, 231);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(402, 60);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(254, 254, 254);
            btnModifier.Enabled = false;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Oxanium Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModifier.ForeColor = Color.FromArgb(10, 10, 64);
            btnModifier.Location = new Point(6, 163);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(402, 60);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnValider
            // 
            btnValider.BackColor = Color.FromArgb(254, 254, 254);
            btnValider.FlatStyle = FlatStyle.Flat;
            btnValider.Font = new Font("Oxanium Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnValider.ForeColor = Color.FromArgb(10, 10, 64);
            btnValider.Location = new Point(6, 95);
            btnValider.Margin = new Padding(3, 4, 3, 4);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(402, 60);
            btnValider.TabIndex = 8;
            btnValider.Text = "Ajouter";
            btnValider.UseVisualStyleBackColor = false;
            btnValider.Click += btnValider_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oxanium", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(117, 345);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 12;
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
            button1.TabIndex = 13;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 427);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(gbCategorie);
            Controls.Add(btnFermer);
            Controls.Add(lbCategories);
            Controls.Add(label1);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCategories";
            Text = "Gestion des catégories";
            Load += FormCategories_Load;
            ((System.ComponentModel.ISupportInitialize)bsCategories).EndInit();
            gbCategorie.ResumeLayout(false);
            gbCategorie.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private BindingSource bsCategories;
        private TextBox tbLibelle;
        private ListBox lbCategories;
        private Button btnFermer;
        private GroupBox gbCategorie;
        private Label label4;
        private Button btnValider;
        private Button btnSupprimer;
        private Button btnModifier;
        private Button button1;
    }
}