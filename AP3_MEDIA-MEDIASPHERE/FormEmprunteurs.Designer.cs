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
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(49, 35);
            label1.Name = "label1";
            label1.Size = new Size(267, 32);
            label1.TabIndex = 4;
            label1.Text = "Liste des emprunteurs";
            // 
            // dgvEmprunteurs
            // 
            dgvEmprunteurs.AllowUserToAddRows = false;
            dgvEmprunteurs.AllowUserToDeleteRows = false;
            dgvEmprunteurs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmprunteurs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmprunteurs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmprunteurs.Location = new Point(49, 71);
            dgvEmprunteurs.Margin = new Padding(3, 4, 3, 4);
            dgvEmprunteurs.Name = "dgvEmprunteurs";
            dgvEmprunteurs.ReadOnly = true;
            dgvEmprunteurs.RowHeadersWidth = 51;
            dgvEmprunteurs.RowTemplate.Height = 25;
            dgvEmprunteurs.Size = new Size(766, 287);
            dgvEmprunteurs.TabIndex = 5;
            dgvEmprunteurs.CellContentClick += dgvEmprunteurs_CellContentClick;
            // 
            // bsEmprunteurs
            // 
            bsEmprunteurs.CurrentChanged += bsEmprunteurs_CurrentChanged;
            // 
            // FormEmprunteurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(896, 397);
            Controls.Add(dgvEmprunteurs);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormEmprunteurs";
            Text = "FormEmprunteurs";
            Load += FormEmprunteurs_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmprunteurs).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEmprunteurs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvEmprunteurs;
        private BindingSource bsEmprunteurs;
    }
}