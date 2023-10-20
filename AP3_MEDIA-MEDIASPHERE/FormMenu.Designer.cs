namespace AP3_MEDIA
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            menuStrip1 = new MenuStrip();
            qUITTERToolStripMenuItem = new ToolStripMenuItem();
            rESSOURCESToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            ajoutToolStripMenuItem = new ToolStripMenuItem();
            modificationToolStripMenuItem = new ToolStripMenuItem();
            supressionToolStripMenuItem = new ToolStripMenuItem();
            eMPRUNTEURToolStripMenuItem = new ToolStripMenuItem();
            cATEGORIESToolStripMenuItem = new ToolStripMenuItem();
            exemplairesToolStripMenuItem = new ToolStripMenuItem();
            deconnexionToolStripMenuItem = new ToolStripMenuItem();
            aUTEURToolStripMenuItem = new ToolStripMenuItem();
            aJOUTToolStripMenuItem1 = new ToolStripMenuItem();
            lISTEToolStripMenuItem1 = new ToolStripMenuItem();
            panelPrincipal = new Panel();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panelPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Window;
            menuStrip1.Font = new Font("Oxanium Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { qUITTERToolStripMenuItem, rESSOURCESToolStripMenuItem, eMPRUNTEURToolStripMenuItem, cATEGORIESToolStripMenuItem, exemplairesToolStripMenuItem, deconnexionToolStripMenuItem, aUTEURToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 10, 0, 10);
            menuStrip1.Size = new Size(1028, 52);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // qUITTERToolStripMenuItem
            // 
            qUITTERToolStripMenuItem.BackColor = SystemColors.ButtonFace;
            qUITTERToolStripMenuItem.Font = new Font("Lucida Sans Unicode", 9F, FontStyle.Bold, GraphicsUnit.Point);
            qUITTERToolStripMenuItem.ForeColor = Color.Crimson;
            qUITTERToolStripMenuItem.Margin = new Padding(0, 0, 20, 0);
            qUITTERToolStripMenuItem.Name = "qUITTERToolStripMenuItem";
            qUITTERToolStripMenuItem.Padding = new Padding(7, 5, 7, 5);
            qUITTERToolStripMenuItem.Size = new Size(36, 32);
            qUITTERToolStripMenuItem.Text = "X";
            qUITTERToolStripMenuItem.Click += qUITTERToolStripMenuItem_Click;
            // 
            // rESSOURCESToolStripMenuItem
            // 
            rESSOURCESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { listeToolStripMenuItem, ajoutToolStripMenuItem, modificationToolStripMenuItem, supressionToolStripMenuItem });
            rESSOURCESToolStripMenuItem.Name = "rESSOURCESToolStripMenuItem";
            rESSOURCESToolStripMenuItem.Size = new Size(118, 32);
            rESSOURCESToolStripMenuItem.Text = "RESSOURCES";
            rESSOURCESToolStripMenuItem.Click += rESSOURCESToolStripMenuItem_Click;
            // 
            // listeToolStripMenuItem
            // 
            listeToolStripMenuItem.Name = "listeToolStripMenuItem";
            listeToolStripMenuItem.Size = new Size(224, 26);
            listeToolStripMenuItem.Text = "Liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // ajoutToolStripMenuItem
            // 
            ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            ajoutToolStripMenuItem.Size = new Size(224, 26);
            ajoutToolStripMenuItem.Text = "Ajout";
            ajoutToolStripMenuItem.Click += ajoutToolStripMenuItem_Click;
            // 
            // modificationToolStripMenuItem
            // 
            modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            modificationToolStripMenuItem.Size = new Size(224, 26);
            modificationToolStripMenuItem.Text = "Modification";
            modificationToolStripMenuItem.Click += modificationToolStripMenuItem_Click;
            // 
            // supressionToolStripMenuItem
            // 
            supressionToolStripMenuItem.Name = "supressionToolStripMenuItem";
            supressionToolStripMenuItem.Size = new Size(224, 26);
            supressionToolStripMenuItem.Text = "Supression";
            supressionToolStripMenuItem.Click += supressionToolStripMenuItem_Click;
            // 
            // eMPRUNTEURToolStripMenuItem
            // 
            eMPRUNTEURToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            eMPRUNTEURToolStripMenuItem.Name = "eMPRUNTEURToolStripMenuItem";
            eMPRUNTEURToolStripMenuItem.Size = new Size(132, 32);
            eMPRUNTEURToolStripMenuItem.Text = "EMPRUNTEURS";
            eMPRUNTEURToolStripMenuItem.Click += eMPRUNTEURToolStripMenuItem_Click;
            // 
            // cATEGORIESToolStripMenuItem
            // 
            cATEGORIESToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            cATEGORIESToolStripMenuItem.Name = "cATEGORIESToolStripMenuItem";
            cATEGORIESToolStripMenuItem.Size = new Size(112, 32);
            cATEGORIESToolStripMenuItem.Text = "CATEGORIES";
            cATEGORIESToolStripMenuItem.Click += cATEGORIESToolStripMenuItem_Click;
            // 
            // exemplairesToolStripMenuItem
            // 
            exemplairesToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            exemplairesToolStripMenuItem.Name = "exemplairesToolStripMenuItem";
            exemplairesToolStripMenuItem.Size = new Size(122, 32);
            exemplairesToolStripMenuItem.Text = "EXEMPLAIRES";
            exemplairesToolStripMenuItem.Click += exemplairesToolStripMenuItem_Click;
            // 
            // deconnexionToolStripMenuItem
            // 
            deconnexionToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
            deconnexionToolStripMenuItem.Name = "deconnexionToolStripMenuItem";
            deconnexionToolStripMenuItem.Size = new Size(128, 32);
            deconnexionToolStripMenuItem.Text = "DECONNEXION";
            deconnexionToolStripMenuItem.Click += deconnexionToolStripMenuItem_Click;
            // 
            // aUTEURToolStripMenuItem
            // 
            aUTEURToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aJOUTToolStripMenuItem1, lISTEToolStripMenuItem1 });
            aUTEURToolStripMenuItem.Margin = new Padding(20, 0, 0, 0);
            aUTEURToolStripMenuItem.Name = "aUTEURToolStripMenuItem";
            aUTEURToolStripMenuItem.Size = new Size(81, 32);
            aUTEURToolStripMenuItem.Text = "AUTEUR";
            // 
            // aJOUTToolStripMenuItem1
            // 
            aJOUTToolStripMenuItem1.Name = "aJOUTToolStripMenuItem1";
            aJOUTToolStripMenuItem1.Size = new Size(224, 26);
            aJOUTToolStripMenuItem1.Text = "AJOUT";
            // 
            // lISTEToolStripMenuItem1
            // 
            lISTEToolStripMenuItem1.Name = "lISTEToolStripMenuItem1";
            lISTEToolStripMenuItem1.Size = new Size(224, 26);
            lISTEToolStripMenuItem1.Text = "LISTE";
            lISTEToolStripMenuItem1.Click += lISTEToolStripMenuItem1_Click;
            // 
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(154, 206, 234);
            panelPrincipal.BackgroundImageLayout = ImageLayout.Center;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(-10, 45);
            panelPrincipal.Margin = new Padding(3, 4, 3, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(1051, 417);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oxanium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(312, 164);
            label1.Name = "label1";
            label1.Size = new Size(416, 37);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue à la Médiathèque";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 453);
            ControlBox = false;
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMenu";
            Text = "Application MEDIA'TOUT";
            TransparencyKey = Color.FromArgb(255, 66, 255);
            Load += Form1_Load;
            KeyDown += FormMenu_KeyDown;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelPrincipal.ResumeLayout(false);
            panelPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem rESSOURCESToolStripMenuItem;
        private ToolStripMenuItem listeToolStripMenuItem;
        private ToolStripMenuItem ajoutToolStripMenuItem;
        private ToolStripMenuItem modificationToolStripMenuItem;
        private ToolStripMenuItem eMPRUNTEURToolStripMenuItem;
        private ToolStripMenuItem cATEGORIESToolStripMenuItem;
        private ToolStripMenuItem qUITTERToolStripMenuItem;
        private Panel panelPrincipal;
        private Label label1;
        private ToolStripMenuItem supressionToolStripMenuItem;
        private ToolStripMenuItem exemplairesToolStripMenuItem;
        public MenuStrip menuStrip1;
        private ToolStripMenuItem deconnexionToolStripMenuItem;
        private ToolStripMenuItem aUTEURToolStripMenuItem;
        private ToolStripMenuItem aJOUTToolStripMenuItem1;
        private ToolStripMenuItem lISTEToolStripMenuItem1;
    }
}