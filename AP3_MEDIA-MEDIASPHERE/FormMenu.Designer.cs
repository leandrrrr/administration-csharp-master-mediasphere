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
            rESSOURCESToolStripMenuItem = new ToolStripMenuItem();
            listeToolStripMenuItem = new ToolStripMenuItem();
            ajoutToolStripMenuItem = new ToolStripMenuItem();
            modificationToolStripMenuItem = new ToolStripMenuItem();
            supressionToolStripMenuItem = new ToolStripMenuItem();
            eMPRUNTEURToolStripMenuItem = new ToolStripMenuItem();
            cATEGORIESToolStripMenuItem = new ToolStripMenuItem();
            qUITTERToolStripMenuItem = new ToolStripMenuItem();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { rESSOURCESToolStripMenuItem, eMPRUNTEURToolStripMenuItem, cATEGORIESToolStripMenuItem, qUITTERToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 10, 0, 10);
            menuStrip1.Size = new Size(914, 52);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
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
            listeToolStripMenuItem.Size = new Size(181, 26);
            listeToolStripMenuItem.Text = "Liste";
            listeToolStripMenuItem.Click += listeToolStripMenuItem_Click;
            // 
            // ajoutToolStripMenuItem
            // 
            ajoutToolStripMenuItem.Name = "ajoutToolStripMenuItem";
            ajoutToolStripMenuItem.Size = new Size(181, 26);
            ajoutToolStripMenuItem.Text = "Ajout";
            ajoutToolStripMenuItem.Click += ajoutToolStripMenuItem_Click;
            // 
            // modificationToolStripMenuItem
            // 
            modificationToolStripMenuItem.Name = "modificationToolStripMenuItem";
            modificationToolStripMenuItem.Size = new Size(181, 26);
            modificationToolStripMenuItem.Text = "Modification";
            modificationToolStripMenuItem.Click += modificationToolStripMenuItem_Click;
            // 
            // supressionToolStripMenuItem
            // 
            supressionToolStripMenuItem.Name = "supressionToolStripMenuItem";
            supressionToolStripMenuItem.Size = new Size(181, 26);
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
            // qUITTERToolStripMenuItem
            // 
            qUITTERToolStripMenuItem.Alignment = ToolStripItemAlignment.Right;
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
            // panelPrincipal
            // 
            panelPrincipal.BackColor = Color.FromArgb(154, 206, 234);
            panelPrincipal.BackgroundImageLayout = ImageLayout.Center;
            panelPrincipal.Controls.Add(label1);
            panelPrincipal.Location = new Point(-9, 47);
            panelPrincipal.Margin = new Padding(3, 4, 3, 4);
            panelPrincipal.Name = "panelPrincipal";
            panelPrincipal.Size = new Size(934, 439);
            panelPrincipal.TabIndex = 2;
            panelPrincipal.Paint += panelPrincipal_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oxanium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(277, 173);
            label1.Name = "label1";
            label1.Size = new Size(416, 37);
            label1.TabIndex = 0;
            label1.Text = "Bienvenue à la Médiathèque";
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 477);
            ControlBox = false;
            Controls.Add(panelPrincipal);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
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

        private MenuStrip menuStrip1;
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
    }
}