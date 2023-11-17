namespace AP3_MEDIA
{
    partial class FormEmprunteurs
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
            dgvEmprunteurs = new DataGridView();
            bsEmprunteurs = new BindingSource(components);
            button1 = new Button();
            dgvEmprunts = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voirLesEmpruntsToolStripMenuItem = new ToolStripMenuItem();
            rendreExemplaireToolStripMenuItem = new ToolStripMenuItem();
            bsEmprunts = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsEmprunts).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oxanium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(404, 40);
            label1.Name = "label1";
            label1.Size = new Size(268, 37);
            label1.TabIndex = 4;
            label1.Text = "FORM INUTILISER";
            // 
            // dgvEmprunteurs
            // 
            dgvEmprunteurs.AllowUserToAddRows = false;
            dgvEmprunteurs.AllowUserToDeleteRows = false;
            dgvEmprunteurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmprunteurs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmprunteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunteurs.Location = new Point(-57, 111);
            dgvEmprunteurs.Margin = new Padding(3, 4, 3, 4);
            dgvEmprunteurs.Name = "dgvEmprunteurs";
            dgvEmprunteurs.ReadOnly = true;
            dgvEmprunteurs.RowHeadersWidth = 51;
            dgvEmprunteurs.RowTemplate.Height = 25;
            dgvEmprunteurs.Size = new Size(862, 263);
            dgvEmprunteurs.TabIndex = 5;
            dgvEmprunteurs.CellContentClick += dgvEmprunteurs_CellContentClick;
            dgvEmprunteurs.CellMouseClick += dgvEmprunteurs_CellMouseClick;
            // 
            // bsEmprunteurs
            // 
            bsEmprunteurs.CurrentChanged += bsEmprunteurs_CurrentChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Oxanium ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(961, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 14;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dgvEmprunts
            // 
            dgvEmprunts.AllowUserToAddRows = false;
            dgvEmprunts.AllowUserToDeleteRows = false;
            dgvEmprunts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunts.Location = new Point(586, 122);
            dgvEmprunts.Margin = new Padding(3, 4, 3, 4);
            dgvEmprunts.Name = "dgvEmprunts";
            dgvEmprunts.ReadOnly = true;
            dgvEmprunts.RowHeadersWidth = 51;
            dgvEmprunts.RowTemplate.Height = 25;
            dgvEmprunts.Size = new Size(489, 284);
            dgvEmprunts.TabIndex = 15;
            dgvEmprunts.Visible = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirLesEmpruntsToolStripMenuItem, rendreExemplaireToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(211, 80);
            contextMenuStrip1.Click += contextMenuStrip1_Click;
            // 
            // voirLesEmpruntsToolStripMenuItem
            // 
            voirLesEmpruntsToolStripMenuItem.Name = "voirLesEmpruntsToolStripMenuItem";
            voirLesEmpruntsToolStripMenuItem.Size = new Size(210, 24);
            voirLesEmpruntsToolStripMenuItem.Text = "voir les emprunts";
            voirLesEmpruntsToolStripMenuItem.Click += voirLesEmpruntsToolStripMenuItem_Click;
            // 
            // rendreExemplaireToolStripMenuItem
            // 
            rendreExemplaireToolStripMenuItem.Name = "rendreExemplaireToolStripMenuItem";
            rendreExemplaireToolStripMenuItem.Size = new Size(210, 24);
            rendreExemplaireToolStripMenuItem.Text = "Rendre exemplaire";
            rendreExemplaireToolStripMenuItem.Click += rendreExemplaireToolStripMenuItem_Click;
            // 
            // bsEmprunts
            // 
            bsEmprunts.CurrentChanged += bsExemplaires_CurrentChanged;
            // 
            // FormEmprunteurs
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1008, 377);
            Controls.Add(dgvEmprunts);
            Controls.Add(button1);
            Controls.Add(dgvEmprunteurs);
            Controls.Add(label1);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEmprunteurs";
            Text = "FormEmprunteurs";
            Load += FormEmprunteurs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmprunts).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsEmprunts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEmprunteurs;
        private BindingSource bsEmprunteurs;
        private Button button1;
        private DataGridView dgvEmprunts;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem voirLesEmpruntsToolStripMenuItem;
        private BindingSource bsEmprunts;
        private ToolStripMenuItem rendreExemplaireToolStripMenuItem;
    }
}