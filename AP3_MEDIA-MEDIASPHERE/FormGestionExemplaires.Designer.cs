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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lbRessources = new ListBox();
            bsRessources = new BindingSource(components);
            bsEtat = new BindingSource(components);
            gbtHelp = new Guna.UI2.WinForms.Guna2CircleButton();
            gtbDate = new Guna.UI2.WinForms.Guna2TextBox();
            gtbLibelle = new Guna.UI2.WinForms.Guna2TextBox();
            gbtAjouter = new Guna.UI2.WinForms.Guna2Button();
            gcbEtat = new Guna.UI2.WinForms.Guna2ComboBox();
            gdtpDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            ggbMenuStrip = new Guna.UI2.WinForms.Guna2GroupBox();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).BeginInit();
            ggbMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // lbRessources
            // 
            lbRessources.Anchor = AnchorStyles.Top;
            lbRessources.BorderStyle = BorderStyle.None;
            lbRessources.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbRessources.FormattingEnabled = true;
            lbRessources.ItemHeight = 21;
            lbRessources.Location = new Point(49, 56);
            lbRessources.Margin = new Padding(3, 4, 3, 4);
            lbRessources.Name = "lbRessources";
            lbRessources.Size = new Size(280, 336);
            lbRessources.TabIndex = 9;
            lbRessources.SelectedIndexChanged += lbRessources_SelectedIndexChanged;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsCategories_CurrentChanged;
            // 
            // bsEtat
            // 
            bsEtat.CurrentChanged += bsExemples_CurrentChanged;
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
            gbtHelp.TabIndex = 30;
            gbtHelp.Click += gbtHelp_Click;
            // 
            // gtbDate
            // 
            gtbDate.BackColor = Color.White;
            gtbDate.BorderRadius = 6;
            gtbDate.CustomizableEdges = customizableEdges2;
            gtbDate.DefaultText = "";
            gtbDate.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtbDate.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtbDate.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtbDate.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtbDate.Enabled = false;
            gtbDate.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbDate.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gtbDate.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbDate.Location = new Point(20, 100);
            gtbDate.Margin = new Padding(3, 4, 3, 4);
            gtbDate.Name = "gtbDate";
            gtbDate.PasswordChar = '\0';
            gtbDate.PlaceholderText = "Date";
            gtbDate.SelectedText = "";
            gtbDate.ShadowDecoration.CustomizableEdges = customizableEdges3;
            gtbDate.Size = new Size(579, 46);
            gtbDate.TabIndex = 0;
            // 
            // gtbLibelle
            // 
            gtbLibelle.BackColor = Color.White;
            gtbLibelle.BorderRadius = 6;
            gtbLibelle.CustomizableEdges = customizableEdges4;
            gtbLibelle.DefaultText = "";
            gtbLibelle.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtbLibelle.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtbLibelle.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtbLibelle.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtbLibelle.Enabled = false;
            gtbLibelle.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbLibelle.Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gtbLibelle.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbLibelle.Location = new Point(20, 25);
            gtbLibelle.Margin = new Padding(3, 4, 3, 4);
            gtbLibelle.Name = "gtbLibelle";
            gtbLibelle.PasswordChar = '\0';
            gtbLibelle.PlaceholderText = "";
            gtbLibelle.SelectedText = "";
            gtbLibelle.ShadowDecoration.CustomizableEdges = customizableEdges5;
            gtbLibelle.Size = new Size(579, 46);
            gtbLibelle.TabIndex = 1;
            gtbLibelle.TextAlign = HorizontalAlignment.Center;
            // 
            // gbtAjouter
            // 
            gbtAjouter.BackColor = Color.White;
            gbtAjouter.BorderRadius = 6;
            gbtAjouter.CustomizableEdges = customizableEdges6;
            gbtAjouter.DisabledState.BorderColor = Color.DarkGray;
            gbtAjouter.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtAjouter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtAjouter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtAjouter.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbtAjouter.ForeColor = Color.White;
            gbtAjouter.Location = new Point(20, 243);
            gbtAjouter.Name = "gbtAjouter";
            gbtAjouter.ShadowDecoration.CustomizableEdges = customizableEdges7;
            gbtAjouter.Size = new Size(579, 59);
            gbtAjouter.TabIndex = 4;
            gbtAjouter.Text = "Ajouter";
            gbtAjouter.Click += gbtAjouter_Click;
            // 
            // gcbEtat
            // 
            gcbEtat.BackColor = Color.Transparent;
            gcbEtat.BorderRadius = 6;
            gcbEtat.CustomizableEdges = customizableEdges8;
            gcbEtat.DrawMode = DrawMode.OwnerDrawFixed;
            gcbEtat.DropDownStyle = ComboBoxStyle.DropDownList;
            gcbEtat.FocusedColor = Color.FromArgb(94, 148, 255);
            gcbEtat.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gcbEtat.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gcbEtat.ForeColor = Color.FromArgb(68, 88, 112);
            gcbEtat.ItemHeight = 30;
            gcbEtat.Location = new Point(20, 172);
            gcbEtat.Name = "gcbEtat";
            gcbEtat.ShadowDecoration.CustomizableEdges = customizableEdges9;
            gcbEtat.Size = new Size(579, 36);
            gcbEtat.TabIndex = 5;
            // 
            // gdtpDate
            // 
            gdtpDate.Animated = true;
            gdtpDate.BackColor = Color.White;
            gdtpDate.BorderColor = Color.White;
            gdtpDate.BorderRadius = 6;
            gdtpDate.Checked = true;
            customizableEdges10.BottomLeft = false;
            customizableEdges10.TopLeft = false;
            gdtpDate.CustomizableEdges = customizableEdges10;
            gdtpDate.FillColor = Color.White;
            gdtpDate.FocusedColor = Color.White;
            gdtpDate.Font = new Font("Oxanium Medium", 7.6F, FontStyle.Bold, GraphicsUnit.Point);
            gdtpDate.ForeColor = SystemColors.AppWorkspace;
            gdtpDate.Format = DateTimePickerFormat.Long;
            gdtpDate.Location = new Point(394, 100);
            gdtpDate.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            gdtpDate.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            gdtpDate.Name = "gdtpDate";
            gdtpDate.ShadowDecoration.CustomizableEdges = customizableEdges11;
            gdtpDate.Size = new Size(205, 46);
            gdtpDate.TabIndex = 6;
            gdtpDate.Value = new DateTime(2023, 10, 22, 22, 45, 32, 954);
            gdtpDate.ValueChanged += gdtpDate_ValueChanged;
            // 
            // ggbMenuStrip
            // 
            ggbMenuStrip.Anchor = AnchorStyles.Top;
            ggbMenuStrip.BorderColor = Color.White;
            ggbMenuStrip.BorderRadius = 4;
            ggbMenuStrip.Controls.Add(gdtpDate);
            ggbMenuStrip.Controls.Add(gcbEtat);
            ggbMenuStrip.Controls.Add(gbtAjouter);
            ggbMenuStrip.Controls.Add(gtbLibelle);
            ggbMenuStrip.Controls.Add(gtbDate);
            ggbMenuStrip.CustomBorderColor = Color.White;
            ggbMenuStrip.CustomizableEdges = customizableEdges12;
            ggbMenuStrip.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ggbMenuStrip.ForeColor = Color.FromArgb(125, 137, 149);
            ggbMenuStrip.Location = new Point(348, 56);
            ggbMenuStrip.Name = "ggbMenuStrip";
            ggbMenuStrip.ShadowDecoration.CustomizableEdges = customizableEdges13;
            ggbMenuStrip.Size = new Size(615, 336);
            ggbMenuStrip.TabIndex = 29;
            ggbMenuStrip.TextAlign = HorizontalAlignment.Center;
            // 
            // FormGestionExemplaires
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 428);
            Controls.Add(gbtHelp);
            Controls.Add(ggbMenuStrip);
            Controls.Add(lbRessources);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionExemplaires";
            Text = "FormGestionExemplaires";
            Load += FormGestionExemplaires_Load;
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).EndInit();
            ggbMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbRessources;
        private BindingSource bsRessources;
        private BindingSource bsEtat;
        private Guna.UI2.WinForms.Guna2CircleButton gbtHelp;
        private Guna.UI2.WinForms.Guna2TextBox gtbDate;
        private Guna.UI2.WinForms.Guna2TextBox gtbLibelle;
        private Guna.UI2.WinForms.Guna2Button gbtAjouter;
        private Guna.UI2.WinForms.Guna2ComboBox gcbEtat;
        private Guna.UI2.WinForms.Guna2DateTimePicker gdtpDate;
        private Guna.UI2.WinForms.Guna2GroupBox ggbMenuStrip;
    }
}