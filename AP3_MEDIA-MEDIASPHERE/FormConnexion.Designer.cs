namespace AP3_MEDIA
{
    partial class FormConnexion
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            bsUser = new BindingSource(components);
            ggbMenuStrip = new Guna.UI2.WinForms.Guna2GroupBox();
            gbtExemplaires = new Guna.UI2.WinForms.Guna2Button();
            gbtId = new Guna.UI2.WinForms.Guna2TextBox();
            gtbMdp = new Guna.UI2.WinForms.Guna2TextBox();
            gbtClose = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)bsUser).BeginInit();
            ggbMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // ggbMenuStrip
            // 
            ggbMenuStrip.Anchor = AnchorStyles.Top;
            ggbMenuStrip.BorderColor = Color.White;
            ggbMenuStrip.BorderRadius = 4;
            ggbMenuStrip.Controls.Add(gbtExemplaires);
            ggbMenuStrip.Controls.Add(gbtId);
            ggbMenuStrip.Controls.Add(gtbMdp);
            ggbMenuStrip.CustomBorderColor = Color.White;
            ggbMenuStrip.CustomizableEdges = customizableEdges7;
            ggbMenuStrip.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            ggbMenuStrip.ForeColor = Color.FromArgb(125, 137, 149);
            ggbMenuStrip.Location = new Point(175, 12);
            ggbMenuStrip.Name = "ggbMenuStrip";
            ggbMenuStrip.ShadowDecoration.CustomizableEdges = customizableEdges8;
            ggbMenuStrip.Size = new Size(672, 379);
            ggbMenuStrip.TabIndex = 28;
            ggbMenuStrip.TextAlign = HorizontalAlignment.Center;
            // 
            // gbtExemplaires
            // 
            gbtExemplaires.Anchor = AnchorStyles.Top;
            gbtExemplaires.BackColor = Color.White;
            gbtExemplaires.BorderRadius = 6;
            gbtExemplaires.CustomizableEdges = customizableEdges1;
            gbtExemplaires.DisabledState.BorderColor = Color.DarkGray;
            gbtExemplaires.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtExemplaires.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtExemplaires.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtExemplaires.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbtExemplaires.ForeColor = Color.White;
            gbtExemplaires.Location = new Point(57, 256);
            gbtExemplaires.Name = "gbtExemplaires";
            gbtExemplaires.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbtExemplaires.Size = new Size(559, 59);
            gbtExemplaires.TabIndex = 4;
            gbtExemplaires.Text = "Connexion";
            gbtExemplaires.Click += gbtExemplaires_Click;
            // 
            // gbtId
            // 
            gbtId.Anchor = AnchorStyles.Top;
            gbtId.BackColor = Color.White;
            gbtId.BorderRadius = 6;
            gbtId.CustomizableEdges = customizableEdges3;
            gbtId.DefaultText = "";
            gbtId.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gbtId.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gbtId.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gbtId.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gbtId.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gbtId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbtId.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gbtId.Location = new Point(57, 53);
            gbtId.Margin = new Padding(3, 4, 3, 4);
            gbtId.Name = "gbtId";
            gbtId.PasswordChar = '\0';
            gbtId.PlaceholderText = "Email";
            gbtId.SelectedText = "";
            gbtId.ShadowDecoration.CustomizableEdges = customizableEdges4;
            gbtId.Size = new Size(559, 46);
            gbtId.TabIndex = 1;
            // 
            // gtbMdp
            // 
            gtbMdp.Anchor = AnchorStyles.Top;
            gtbMdp.BackColor = Color.White;
            gtbMdp.BorderRadius = 6;
            gtbMdp.CustomizableEdges = customizableEdges5;
            gtbMdp.DefaultText = "";
            gtbMdp.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            gtbMdp.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            gtbMdp.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            gtbMdp.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            gtbMdp.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbMdp.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gtbMdp.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            gtbMdp.Location = new Point(57, 154);
            gtbMdp.Margin = new Padding(3, 4, 3, 4);
            gtbMdp.Name = "gtbMdp";
            gtbMdp.PasswordChar = '\0';
            gtbMdp.PlaceholderText = "Mot de passe";
            gtbMdp.SelectedText = "";
            gtbMdp.ShadowDecoration.CustomizableEdges = customizableEdges6;
            gtbMdp.Size = new Size(559, 46);
            gtbMdp.TabIndex = 0;
            // 
            // gbtClose
            // 
            gbtClose.Anchor = AnchorStyles.Top;
            gbtClose.DisabledState.BorderColor = Color.DarkGray;
            gbtClose.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtClose.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gbtClose.ForeColor = Color.White;
            gbtClose.Image = Properties.Resources.icons8_close_50;
            gbtClose.ImageSize = new Size(35, 35);
            gbtClose.Location = new Point(492, 412);
            gbtClose.Name = "gbtClose";
            gbtClose.ShadowDecoration.CustomizableEdges = customizableEdges9;
            gbtClose.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            gbtClose.Size = new Size(51, 49);
            gbtClose.TabIndex = 29;
            gbtClose.Click += gbtClose_Click;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 520);
            Controls.Add(gbtClose);
            Controls.Add(ggbMenuStrip);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConnexion";
            Text = "FormConnexion";
            Load += FormConnexion_Load;
            ((System.ComponentModel.ISupportInitialize)bsUser).EndInit();
            ggbMenuStrip.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelId;
        private Label labelMdp;
        private TextBox tbId;
        private Button btnConnexion;
        private TextBox tbMdp;
        private BindingSource bsUser;
        private Button button1;
        private Guna.UI2.WinForms.Guna2GroupBox ggbMenuStrip;
        private Guna.UI2.WinForms.Guna2TextBox gtbMdp;
        private Guna.UI2.WinForms.Guna2TextBox gbtId;
        private Guna.UI2.WinForms.Guna2Button gbtExemplaires;
        private Guna.UI2.WinForms.Guna2CircleButton gbtClose;
    }
}