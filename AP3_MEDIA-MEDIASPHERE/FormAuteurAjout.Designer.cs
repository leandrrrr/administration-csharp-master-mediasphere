namespace AP3_MEDIA
{
    partial class FormAuteurAjout
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbRessources = new ListBox();
            gdgvAuteurs = new Guna.UI2.WinForms.Guna2DataGridView();
            selectAuteurs = new DataGridViewCheckBoxColumn();
            ggbMenuStrip = new Guna.UI2.WinForms.Guna2GroupBox();
            label3 = new Label();
            gbtAjouter = new Guna.UI2.WinForms.Guna2Button();
            gtbLibelle = new Guna.UI2.WinForms.Guna2TextBox();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            gbtHelp = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            bsRessource = new BindingSource(components);
            bsAuteur = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gdgvAuteurs).BeginInit();
            ggbMenuStrip.SuspendLayout();
            guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRessource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsAuteur).BeginInit();
            SuspendLayout();
            // 
            // lbRessources
            // 
            lbRessources.Anchor = AnchorStyles.Top;
            lbRessources.BorderStyle = BorderStyle.None;
            lbRessources.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbRessources.FormattingEnabled = true;
            lbRessources.ItemHeight = 21;
            lbRessources.Location = new Point(47, 69);
            lbRessources.Margin = new Padding(3, 4, 3, 4);
            lbRessources.Name = "lbRessources";
            lbRessources.Size = new Size(274, 336);
            lbRessources.TabIndex = 17;
            lbRessources.SelectedIndexChanged += lbRessources_SelectedIndexChanged;
            // 
            // gdgvAuteurs
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            gdgvAuteurs.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gdgvAuteurs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gdgvAuteurs.ColumnHeadersHeight = 4;
            gdgvAuteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gdgvAuteurs.Columns.AddRange(new DataGridViewColumn[] { selectAuteurs });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gdgvAuteurs.DefaultCellStyle = dataGridViewCellStyle3;
            gdgvAuteurs.GridColor = Color.FromArgb(231, 229, 255);
            gdgvAuteurs.Location = new Point(687, 99);
            gdgvAuteurs.Name = "gdgvAuteurs";
            gdgvAuteurs.RowHeadersVisible = false;
            gdgvAuteurs.RowHeadersWidth = 51;
            gdgvAuteurs.RowTemplate.Height = 29;
            gdgvAuteurs.Size = new Size(326, 308);
            gdgvAuteurs.TabIndex = 20;
            gdgvAuteurs.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gdgvAuteurs.ThemeStyle.AlternatingRowsStyle.Font = null;
            gdgvAuteurs.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gdgvAuteurs.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gdgvAuteurs.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gdgvAuteurs.ThemeStyle.BackColor = Color.White;
            gdgvAuteurs.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gdgvAuteurs.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gdgvAuteurs.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gdgvAuteurs.ThemeStyle.HeaderStyle.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gdgvAuteurs.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gdgvAuteurs.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gdgvAuteurs.ThemeStyle.HeaderStyle.Height = 4;
            gdgvAuteurs.ThemeStyle.ReadOnly = false;
            gdgvAuteurs.ThemeStyle.RowsStyle.BackColor = Color.White;
            gdgvAuteurs.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gdgvAuteurs.ThemeStyle.RowsStyle.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gdgvAuteurs.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gdgvAuteurs.ThemeStyle.RowsStyle.Height = 29;
            gdgvAuteurs.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gdgvAuteurs.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // selectAuteurs
            // 
            selectAuteurs.HeaderText = "X";
            selectAuteurs.MinimumWidth = 6;
            selectAuteurs.Name = "selectAuteurs";
            // 
            // ggbMenuStrip
            // 
            ggbMenuStrip.Anchor = AnchorStyles.Top;
            ggbMenuStrip.BorderColor = Color.White;
            ggbMenuStrip.BorderRadius = 6;
            ggbMenuStrip.Controls.Add(label3);
            ggbMenuStrip.Controls.Add(gbtAjouter);
            ggbMenuStrip.Controls.Add(gtbLibelle);
            ggbMenuStrip.CustomBorderColor = Color.FromArgb(94, 148, 255);
            ggbMenuStrip.CustomizableEdges = customizableEdges5;
            ggbMenuStrip.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ggbMenuStrip.ForeColor = Color.White;
            ggbMenuStrip.Location = new Point(330, 45);
            ggbMenuStrip.Name = "ggbMenuStrip";
            ggbMenuStrip.ShadowDecoration.CustomizableEdges = customizableEdges6;
            ggbMenuStrip.Size = new Size(348, 370);
            ggbMenuStrip.TabIndex = 30;
            ggbMenuStrip.Text = "Ajout de un ou plusieurs utilisateurs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(193, 200, 207);
            label3.Location = new Point(122, 86);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 5;
            label3.Text = "Ressource";
            // 
            // gbtAjouter
            // 
            gbtAjouter.BackColor = Color.White;
            gbtAjouter.BorderRadius = 6;
            gbtAjouter.CustomizableEdges = customizableEdges1;
            gbtAjouter.DisabledState.BorderColor = Color.DarkGray;
            gbtAjouter.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtAjouter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtAjouter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtAjouter.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbtAjouter.ForeColor = Color.White;
            gbtAjouter.Location = new Point(20, 216);
            gbtAjouter.Name = "gbtAjouter";
            gbtAjouter.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbtAjouter.Size = new Size(310, 59);
            gbtAjouter.TabIndex = 4;
            gbtAjouter.Text = "Ajouter";
            gbtAjouter.Click += gbtAjouter_Click;
            // 
            // gtbLibelle
            // 
            gtbLibelle.BackColor = Color.White;
            gtbLibelle.BorderRadius = 6;
            gtbLibelle.CustomizableEdges = customizableEdges3;
            gtbLibelle.DefaultText = "";
            gtbLibelle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtbLibelle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtbLibelle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtbLibelle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtbLibelle.Enabled = false;
            gtbLibelle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbLibelle.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gtbLibelle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbLibelle.Location = new Point(20, 111);
            gtbLibelle.Margin = new Padding(3, 4, 3, 4);
            gtbLibelle.Name = "gtbLibelle";
            gtbLibelle.PasswordChar = '\0';
            gtbLibelle.PlaceholderText = "";
            gtbLibelle.SelectedText = "";
            gtbLibelle.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gtbLibelle.Size = new Size(310, 46);
            gtbLibelle.TabIndex = 1;
            gtbLibelle.TextAlign = HorizontalAlignment.Center;
            gtbLibelle.TextChanged += gtbLibelle_TextChanged;
            // 
            // guna2Button1
            // 
            guna2Button1.BackColor = Color.FromArgb(154, 206, 234);
            guna2Button1.BorderRadius = 6;
            guna2Button1.CustomizableEdges = customizableEdges7;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(881, 447);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button1.Size = new Size(135, 58);
            guna2Button1.TabIndex = 5;
            guna2Button1.Text = "Fermer";
            guna2Button1.Click += guna2Button1_Click;
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
            gbtHelp.ShadowDecoration.CustomizableEdges = customizableEdges9;
            gbtHelp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gbtHelp.Size = new Size(40, 40);
            gbtHelp.TabIndex = 31;
            gbtHelp.Click += gbtHelp_Click;
            // 
            // guna2GroupBox1
            // 
            guna2GroupBox1.Anchor = AnchorStyles.Top;
            guna2GroupBox1.BorderColor = Color.White;
            guna2GroupBox1.BorderRadius = 4;
            guna2GroupBox1.Controls.Add(label2);
            guna2GroupBox1.Controls.Add(label1);
            guna2GroupBox1.CustomBorderColor = Color.White;
            guna2GroupBox1.CustomizableEdges = customizableEdges10;
            guna2GroupBox1.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GroupBox1.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox1.Location = new Point(684, 69);
            guna2GroupBox1.Name = "guna2GroupBox1";
            guna2GroupBox1.ShadowDecoration.CustomizableEdges = customizableEdges11;
            guna2GroupBox1.Size = new Size(332, 338);
            guna2GroupBox1.TabIndex = 32;
            guna2GroupBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // guna2GroupBox2
            // 
            guna2GroupBox2.Anchor = AnchorStyles.Top;
            guna2GroupBox2.BorderColor = Color.White;
            guna2GroupBox2.BorderRadius = 4;
            guna2GroupBox2.CustomBorderColor = Color.White;
            guna2GroupBox2.CustomizableEdges = customizableEdges12;
            guna2GroupBox2.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox2.Location = new Point(44, 69);
            guna2GroupBox2.Name = "guna2GroupBox2";
            guna2GroupBox2.ShadowDecoration.CustomizableEdges = customizableEdges13;
            guna2GroupBox2.Size = new Size(280, 336);
            guna2GroupBox2.TabIndex = 33;
            guna2GroupBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // bsRessource
            // 
            bsRessource.CurrentChanged += bsRessource_CurrentChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(193, 200, 207);
            label1.Location = new Point(79, 6);
            label1.Name = "label1";
            label1.Size = new Size(50, 21);
            label1.TabIndex = 6;
            label1.Text = "Nom";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(193, 200, 207);
            label2.Location = new Point(197, 6);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 34;
            label2.Text = "Prenom";
            // 
            // FormAuteurAjout
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 517);
            Controls.Add(gbtHelp);
            Controls.Add(guna2Button1);
            Controls.Add(ggbMenuStrip);
            Controls.Add(lbRessources);
            Controls.Add(guna2GroupBox2);
            Controls.Add(gdgvAuteurs);
            Controls.Add(guna2GroupBox1);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuteurAjout";
            Text = "FormAuteurAjout";
            Load += FormAuteurAjout_Load;
            ((System.ComponentModel.ISupportInitialize)gdgvAuteurs).EndInit();
            ggbMenuStrip.ResumeLayout(false);
            ggbMenuStrip.PerformLayout();
            guna2GroupBox1.ResumeLayout(false);
            guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bsRessource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsAuteur).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ListBox lbRessources;
        private Guna.UI2.WinForms.Guna2DataGridView gdgvAuteurs;
        private Guna.UI2.WinForms.Guna2GroupBox ggbMenuStrip;
        private Guna.UI2.WinForms.Guna2Button gbtAjouter;
        private Guna.UI2.WinForms.Guna2TextBox gtbLibelle;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2CircleButton gbtHelp;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Label label3;
        private BindingSource bsRessource;
        private BindingSource bsAuteur;
        private DataGridViewCheckBoxColumn selectAuteurs;
        private Label label2;
        private Label label1;
    }
}