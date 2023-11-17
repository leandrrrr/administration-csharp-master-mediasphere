namespace AP3_MEDIA
{
    partial class FormRessources
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voirLesExemplaireToolStripMenuItem = new ToolStripMenuItem();
            voirLesAuteursToolStripMenuItem = new ToolStripMenuItem();
            bsRessources = new BindingSource(components);
            bsExemplaires = new BindingSource(components);
            gbtHelp = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            dgvRessources = new DataGridView();
            ggbMenuStrip = new Guna.UI2.WinForms.Guna2GroupBox();
            ggbExemplaires = new Guna.UI2.WinForms.Guna2GroupBox();
            dgvExemplaires = new DataGridView();
            gbtRendre = new Guna.UI2.WinForms.Guna2Button();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRessources).BeginInit();
            ggbExemplaires.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirLesExemplaireToolStripMenuItem, voirLesAuteursToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(210, 52);
            // 
            // voirLesExemplaireToolStripMenuItem
            // 
            voirLesExemplaireToolStripMenuItem.Name = "voirLesExemplaireToolStripMenuItem";
            voirLesExemplaireToolStripMenuItem.Size = new Size(209, 24);
            voirLesExemplaireToolStripMenuItem.Text = "voir les exemplaires";
            voirLesExemplaireToolStripMenuItem.Click += voirLesExemplaireToolStripMenuItem_Click;
            // 
            // voirLesAuteursToolStripMenuItem
            // 
            voirLesAuteursToolStripMenuItem.Name = "voirLesAuteursToolStripMenuItem";
            voirLesAuteursToolStripMenuItem.Size = new Size(209, 24);
            voirLesAuteursToolStripMenuItem.Text = "Voir les Auteurs";
            voirLesAuteursToolStripMenuItem.Click += voirLesAuteursToolStripMenuItem_Click;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsRessources_CurrentChanged;
            // 
            // gbtHelp
            // 
            gbtHelp.DisabledState.BorderColor = Color.DarkGray;
            gbtHelp.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtHelp.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtHelp.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtHelp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbtHelp.ForeColor = Color.White;
            gbtHelp.Image = Properties.Resources.icons8_about_50;
            gbtHelp.ImageSize = new Size(27, 27);
            gbtHelp.Location = new Point(976, 12);
            gbtHelp.Name = "gbtHelp";
            gbtHelp.ShadowDecoration.CustomizableEdges = customizableEdges1;
            gbtHelp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gbtHelp.Size = new Size(40, 40);
            gbtHelp.TabIndex = 35;
            gbtHelp.Click += gbtHelp_Click;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.FromArgb(154, 206, 234);
            guna2Button1.BorderRadius = 6;
            guna2Button1.CustomizableEdges = customizableEdges2;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(881, 447);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges3;
            guna2Button1.Size = new Size(135, 58);
            guna2Button1.TabIndex = 34;
            guna2Button1.Text = "Fermer";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // dgvRessources
            // 
            dgvRessources.AllowUserToAddRows = false;
            dgvRessources.AllowUserToDeleteRows = false;
            dgvRessources.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRessources.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRessources.BackgroundColor = Color.White;
            dgvRessources.BorderStyle = BorderStyle.None;
            dgvRessources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRessources.ContextMenuStrip = contextMenuStrip1;
            dgvRessources.GridColor = Color.White;
            dgvRessources.Location = new Point(74, 75);
            dgvRessources.Margin = new Padding(3, 4, 3, 4);
            dgvRessources.Name = "dgvRessources";
            dgvRessources.ReadOnly = true;
            dgvRessources.RowHeadersWidth = 51;
            dgvRessources.RowTemplate.Height = 25;
            dgvRessources.Size = new Size(884, 334);
            dgvRessources.TabIndex = 39;
            dgvRessources.CellClick += dgvRessources_CellClick;
            dgvRessources.CellContentClick += dgvRessources_CellContentClick_1;
            dgvRessources.Click += dgvRessources_Click_1;
            // 
            // ggbMenuStrip
            // 
            ggbMenuStrip.BorderColor = Color.White;
            ggbMenuStrip.BorderRadius = 4;
            ggbMenuStrip.CustomBorderColor = Color.White;
            ggbMenuStrip.CustomizableEdges = customizableEdges4;
            ggbMenuStrip.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ggbMenuStrip.ForeColor = Color.FromArgb(125, 137, 149);
            ggbMenuStrip.Location = new Point(65, 63);
            ggbMenuStrip.Name = "ggbMenuStrip";
            ggbMenuStrip.ShadowDecoration.CustomizableEdges = customizableEdges5;
            ggbMenuStrip.Size = new Size(903, 350);
            ggbMenuStrip.TabIndex = 40;
            ggbMenuStrip.TextAlign = HorizontalAlignment.Center;
            // 
            // ggbExemplaires
            // 
            ggbExemplaires.BackColor = Color.FromArgb(154, 206, 234);
            ggbExemplaires.BorderColor = Color.White;
            ggbExemplaires.BorderRadius = 4;
            ggbExemplaires.Controls.Add(dgvExemplaires);
            ggbExemplaires.CustomBorderColor = Color.White;
            ggbExemplaires.CustomizableEdges = customizableEdges6;
            ggbExemplaires.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ggbExemplaires.ForeColor = Color.Black;
            ggbExemplaires.Location = new Point(496, 46);
            ggbExemplaires.Name = "ggbExemplaires";
            ggbExemplaires.ShadowDecoration.CustomizableEdges = customizableEdges7;
            ggbExemplaires.Size = new Size(462, 381);
            ggbExemplaires.TabIndex = 41;
            ggbExemplaires.TextAlign = HorizontalAlignment.Center;
            ggbExemplaires.Visible = false;
            ggbExemplaires.Click += guna2GroupBox1_Click;
            // 
            // dgvExemplaires
            // 
            dgvExemplaires.AllowUserToAddRows = false;
            dgvExemplaires.AllowUserToDeleteRows = false;
            dgvExemplaires.BackgroundColor = Color.White;
            dgvExemplaires.BorderStyle = BorderStyle.None;
            dgvExemplaires.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExemplaires.Location = new Point(3, 17);
            dgvExemplaires.Margin = new Padding(3, 4, 3, 4);
            dgvExemplaires.Name = "dgvExemplaires";
            dgvExemplaires.ReadOnly = true;
            dgvExemplaires.RowHeadersWidth = 51;
            dgvExemplaires.RowTemplate.Height = 25;
            dgvExemplaires.Size = new Size(455, 346);
            dgvExemplaires.TabIndex = 42;
            dgvExemplaires.Visible = false;
            dgvExemplaires.CellContentClick += dgvExemplaires_CellContentClick_1;
            // 
            // gbtRendre
            // 
            gbtRendre.BackColor = Color.FromArgb(154, 206, 234);
            gbtRendre.BorderRadius = 6;
            gbtRendre.CustomizableEdges = customizableEdges8;
            gbtRendre.DisabledState.BorderColor = Color.DarkGray;
            gbtRendre.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtRendre.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtRendre.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtRendre.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbtRendre.ForeColor = Color.White;
            gbtRendre.Location = new Point(12, 447);
            gbtRendre.Name = "gbtRendre";
            gbtRendre.ShadowDecoration.CustomizableEdges = customizableEdges9;
            gbtRendre.Size = new Size(135, 58);
            gbtRendre.TabIndex = 42;
            gbtRendre.Text = "Rendre un exemplaire ";
            gbtRendre.Click += gbtRendre_Click;
            // 
            // FormRessources
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 517);
            Controls.Add(gbtRendre);
            Controls.Add(ggbExemplaires);
            Controls.Add(gbtHelp);
            Controls.Add(guna2Button1);
            Controls.Add(dgvRessources);
            Controls.Add(ggbMenuStrip);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRessources";
            Text = "Liste des Ressources";
            Load += FormRessources_Load;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRessources).EndInit();
            ggbExemplaires.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource bsRessources;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem voirLesExemplaireToolStripMenuItem;
        private BindingSource bsExemplaires;
        private Guna.UI2.WinForms.Guna2CircleButton gbtHelp;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private DataGridView dgvRessources;
        private Guna.UI2.WinForms.Guna2GroupBox ggbMenuStrip;
        private Guna.UI2.WinForms.Guna2GroupBox ggbExemplaires;
        private DataGridView dgvExemplaires;
        private ToolStripMenuItem voirLesAuteursToolStripMenuItem;
        private Guna.UI2.WinForms.Guna2Button gbtRendre;
    }
}