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
            label3 = new Label();
            bsCategories = new BindingSource(components);
            tbLibelle = new TextBox();
            label2 = new Label();
            lbCategories = new ListBox();
            btnFermer = new Button();
            gbCategorie = new GroupBox();
            btnSupprimer = new Button();
            btnModifier = new Button();
            btnValider = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)bsCategories).BeginInit();
            gbCategorie.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 27);
            label1.Name = "label1";
            label1.Size = new Size(272, 32);
            label1.TabIndex = 3;
            label1.Text = "Gestion des catégories";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(457, 35);
            label3.Name = "label3";
            label3.Size = new Size(117, 23);
            label3.TabIndex = 5;
            label3.Text = "Liste existante";
            // 
            // bsCategories
            // 
            bsCategories.CurrentChanged += bsCategories_CurrentChanged;
            // 
            // tbLibelle
            // 
            tbLibelle.Location = new Point(23, 65);
            tbLibelle.Margin = new Padding(3, 4, 3, 4);
            tbLibelle.Name = "tbLibelle";
            tbLibelle.Size = new Size(269, 27);
            tbLibelle.TabIndex = 6;
            tbLibelle.TextChanged += tbLibelle_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 39);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 7;
            label2.Text = "Libellé ";
            // 
            // lbCategories
            // 
            lbCategories.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbCategories.FormattingEnabled = true;
            lbCategories.ItemHeight = 21;
            lbCategories.Location = new Point(457, 61);
            lbCategories.Margin = new Padding(3, 4, 3, 4);
            lbCategories.Name = "lbCategories";
            lbCategories.Size = new Size(162, 298);
            lbCategories.TabIndex = 8;
            lbCategories.SelectedIndexChanged += lbCategories_SelectedIndexChanged;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(674, 312);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(120, 76);
            btnFermer.TabIndex = 9;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // gbCategorie
            // 
            gbCategorie.Controls.Add(btnSupprimer);
            gbCategorie.Controls.Add(btnModifier);
            gbCategorie.Controls.Add(btnValider);
            gbCategorie.Controls.Add(label2);
            gbCategorie.Controls.Add(tbLibelle);
            gbCategorie.Location = new Point(49, 133);
            gbCategorie.Margin = new Padding(3, 4, 3, 4);
            gbCategorie.Name = "gbCategorie";
            gbCategorie.Padding = new Padding(3, 4, 3, 4);
            gbCategorie.Size = new Size(318, 172);
            gbCategorie.TabIndex = 11;
            gbCategorie.TabStop = false;
            gbCategorie.Text = "A ajouter";
            // 
            // btnSupprimer
            // 
            btnSupprimer.Enabled = false;
            btnSupprimer.Location = new Point(207, 120);
            btnSupprimer.Margin = new Padding(3, 4, 3, 4);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(86, 31);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = true;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnModifier
            // 
            btnModifier.Enabled = false;
            btnModifier.Location = new Point(115, 120);
            btnModifier.Margin = new Padding(3, 4, 3, 4);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(86, 31);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = true;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnValider
            // 
            btnValider.Location = new Point(23, 120);
            btnValider.Margin = new Padding(3, 4, 3, 4);
            btnValider.Name = "btnValider";
            btnValider.Size = new Size(86, 31);
            btnValider.TabIndex = 8;
            btnValider.Text = "Ajouter";
            btnValider.UseVisualStyleBackColor = true;
            btnValider.Click += btnValider_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(104, 363);
            label4.Name = "label4";
            label4.Size = new Size(515, 25);
            label4.TabIndex = 12;
            label4.Text = "sélectionner une catégorie pour la modifier ou la supprimer";
            // 
            // FormCategories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(914, 449);
            Controls.Add(label4);
            Controls.Add(gbCategorie);
            Controls.Add(btnFermer);
            Controls.Add(lbCategories);
            Controls.Add(label3);
            Controls.Add(label1);
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
        private Label label3;
        private BindingSource bsCategories;
        private TextBox tbLibelle;
        private Label label2;
        private ListBox lbCategories;
        private Button btnFermer;
        private GroupBox gbCategorie;
        private Label label4;
        private Button btnValider;
        private Button btnSupprimer;
        private Button btnModifier;
    }
}