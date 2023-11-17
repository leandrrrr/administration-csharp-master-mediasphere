namespace AP3_MEDIA
{
    partial class FormRetourExemplaire
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            gcbEmprunteurs = new Guna.UI2.WinForms.Guna2ComboBox();
            gbtRendre = new Guna.UI2.WinForms.Guna2Button();
            gbtClose = new Guna.UI2.WinForms.Guna2Button();
            gbtHelp = new Guna.UI2.WinForms.Guna2CircleButton();
            guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            gdgvEmprunt = new Guna.UI2.WinForms.Guna2DataGridView();
            selectAuteurs = new DataGridViewCheckBoxColumn();
            bsEmprunt = new BindingSource(components);
            bsEmprunteur = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gdgvEmprunt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunt).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteur).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(699, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 382);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
            // 
            // gcbEmprunteurs
            // 
            gcbEmprunteurs.BackColor = Color.Transparent;
            gcbEmprunteurs.BorderRadius = 6;
            gcbEmprunteurs.CustomizableEdges = customizableEdges1;
            gcbEmprunteurs.DrawMode = DrawMode.OwnerDrawFixed;
            gcbEmprunteurs.DropDownStyle = ComboBoxStyle.DropDownList;
            gcbEmprunteurs.FocusedColor = Color.FromArgb(94, 148, 255);
            gcbEmprunteurs.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gcbEmprunteurs.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            gcbEmprunteurs.ForeColor = Color.FromArgb(68, 88, 112);
            gcbEmprunteurs.ItemHeight = 30;
            gcbEmprunteurs.Location = new Point(31, 17);
            gcbEmprunteurs.Name = "gcbEmprunteurs";
            gcbEmprunteurs.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gcbEmprunteurs.Size = new Size(490, 36);
            gcbEmprunteurs.TabIndex = 51;
            gcbEmprunteurs.SelectedIndexChanged += gcbEmprunteurs_SelectedIndexChanged;
            // 
            // gbtRendre
            // 
            gbtRendre.BackColor = Color.FromArgb(154, 206, 234);
            gbtRendre.BorderRadius = 6;
            gbtRendre.CustomizableEdges = customizableEdges3;
            gbtRendre.DisabledState.BorderColor = Color.DarkGray;
            gbtRendre.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtRendre.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtRendre.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtRendre.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbtRendre.ForeColor = Color.White;
            gbtRendre.Location = new Point(542, 209);
            gbtRendre.Name = "gbtRendre";
            gbtRendre.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gbtRendre.Size = new Size(135, 74);
            gbtRendre.TabIndex = 49;
            gbtRendre.Text = "Rendre";
            gbtRendre.Click += gbtRendre_Click;
            // 
            // gbtClose
            // 
            gbtClose.BackColor = Color.FromArgb(154, 206, 234);
            gbtClose.BorderRadius = 6;
            gbtClose.CustomizableEdges = customizableEdges5;
            gbtClose.DisabledState.BorderColor = Color.DarkGray;
            gbtClose.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtClose.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbtClose.ForeColor = Color.White;
            gbtClose.Location = new Point(862, 447);
            gbtClose.Name = "gbtClose";
            gbtClose.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gbtClose.Size = new Size(135, 58);
            gbtClose.TabIndex = 47;
            gbtClose.Text = "Fermer";
            gbtClose.Click += gbtClose_Click;
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
            gbtHelp.Location = new Point(957, 12);
            gbtHelp.Name = "gbtHelp";
            gbtHelp.ShadowDecoration.CustomizableEdges = customizableEdges7;
            gbtHelp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gbtHelp.Size = new Size(40, 40);
            gbtHelp.TabIndex = 46;
            gbtHelp.Click += gbtHelp_Click;
            // 
            // guna2GroupBox2
            // 
            guna2GroupBox2.Anchor = AnchorStyles.Top;
            guna2GroupBox2.BorderColor = Color.White;
            guna2GroupBox2.BorderRadius = 4;
            guna2GroupBox2.Controls.Add(gdgvEmprunt);
            guna2GroupBox2.CustomBorderColor = Color.White;
            guna2GroupBox2.CustomizableEdges = customizableEdges8;
            guna2GroupBox2.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2GroupBox2.ForeColor = Color.FromArgb(125, 137, 149);
            guna2GroupBox2.Location = new Point(31, 59);
            guna2GroupBox2.Name = "guna2GroupBox2";
            guna2GroupBox2.ShadowDecoration.CustomizableEdges = customizableEdges9;
            guna2GroupBox2.Size = new Size(490, 382);
            guna2GroupBox2.TabIndex = 45;
            guna2GroupBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // gdgvEmprunt
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            gdgvEmprunt.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            gdgvEmprunt.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            gdgvEmprunt.ColumnHeadersHeight = 25;
            gdgvEmprunt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gdgvEmprunt.Columns.AddRange(new DataGridViewColumn[] { selectAuteurs });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(125, 137, 149);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            gdgvEmprunt.DefaultCellStyle = dataGridViewCellStyle3;
            gdgvEmprunt.GridColor = Color.FromArgb(231, 229, 255);
            gdgvEmprunt.Location = new Point(3, 9);
            gdgvEmprunt.Name = "gdgvEmprunt";
            gdgvEmprunt.RowHeadersVisible = false;
            gdgvEmprunt.RowHeadersWidth = 51;
            gdgvEmprunt.RowTemplate.Height = 29;
            gdgvEmprunt.Size = new Size(484, 370);
            gdgvEmprunt.TabIndex = 45;
            gdgvEmprunt.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            gdgvEmprunt.ThemeStyle.AlternatingRowsStyle.Font = null;
            gdgvEmprunt.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            gdgvEmprunt.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            gdgvEmprunt.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            gdgvEmprunt.ThemeStyle.BackColor = Color.White;
            gdgvEmprunt.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            gdgvEmprunt.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            gdgvEmprunt.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            gdgvEmprunt.ThemeStyle.HeaderStyle.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gdgvEmprunt.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            gdgvEmprunt.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            gdgvEmprunt.ThemeStyle.HeaderStyle.Height = 25;
            gdgvEmprunt.ThemeStyle.ReadOnly = false;
            gdgvEmprunt.ThemeStyle.RowsStyle.BackColor = Color.White;
            gdgvEmprunt.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gdgvEmprunt.ThemeStyle.RowsStyle.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gdgvEmprunt.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            gdgvEmprunt.ThemeStyle.RowsStyle.Height = 29;
            gdgvEmprunt.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            gdgvEmprunt.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            gdgvEmprunt.CellClick += gdgvEmprunt_CellClick;
            // 
            // selectAuteurs
            // 
            selectAuteurs.HeaderText = "X";
            selectAuteurs.MinimumWidth = 6;
            selectAuteurs.Name = "selectAuteurs";
            // 
            // FormRetourExemplaire
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 517);
            Controls.Add(pictureBox1);
            Controls.Add(gcbEmprunteurs);
            Controls.Add(gbtRendre);
            Controls.Add(gbtClose);
            Controls.Add(gbtHelp);
            Controls.Add(guna2GroupBox2);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRetourExemplaire";
            Text = "Retour Exemplaire";
            Load += FormRetourExemplaire_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            guna2GroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gdgvEmprunt).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunt).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteur).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox gcbEmprunteurs;
        private Guna.UI2.WinForms.Guna2Button gbtRendre;
        private Guna.UI2.WinForms.Guna2Button gbtClose;
        private Guna.UI2.WinForms.Guna2CircleButton gbtHelp;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView gdgvEmprunt;
        private DataGridViewCheckBoxColumn selectAuteurs;
        private BindingSource bsEmprunt;
        private BindingSource bsEmprunteur;
    }
}