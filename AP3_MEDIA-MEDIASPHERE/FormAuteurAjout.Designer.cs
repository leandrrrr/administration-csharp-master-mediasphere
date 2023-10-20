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
            dgvAuteur = new DataGridView();
            button1 = new Button();
            btnFermer = new Button();
            lbRessources = new ListBox();
            btnAdd = new Button();
            tbLibelle = new TextBox();
            cbSelect = new DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).BeginInit();
            SuspendLayout();
            // 
            // dgvAuteur
            // 
            dgvAuteur.AllowUserToAddRows = false;
            dgvAuteur.AllowUserToDeleteRows = false;
            dgvAuteur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAuteur.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAuteur.BackgroundColor = Color.FromArgb(154, 206, 234);
            dgvAuteur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuteur.Columns.AddRange(new DataGridViewColumn[] { cbSelect });
            dgvAuteur.Location = new Point(658, 55);
            dgvAuteur.Margin = new Padding(3, 4, 3, 4);
            dgvAuteur.Name = "dgvAuteur";
            dgvAuteur.ReadOnly = true;
            dgvAuteur.RowHeadersWidth = 51;
            dgvAuteur.RowTemplate.Height = 25;
            dgvAuteur.Size = new Size(358, 294);
            dgvAuteur.TabIndex = 1;
            dgvAuteur.CellContentClick += dgvAuteur_CellContentClick;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Oxanium ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(981, 13);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 16;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Oxanium Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(881, 357);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(135, 58);
            btnFermer.TabIndex = 15;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            // 
            // lbRessources
            // 
            lbRessources.Anchor = AnchorStyles.Top;
            lbRessources.BorderStyle = BorderStyle.None;
            lbRessources.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbRessources.FormattingEnabled = true;
            lbRessources.ItemHeight = 21;
            lbRessources.Location = new Point(44, 56);
            lbRessources.Margin = new Padding(3, 4, 3, 4);
            lbRessources.Name = "lbRessources";
            lbRessources.Size = new Size(280, 294);
            lbRessources.TabIndex = 17;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Oxanium Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(330, 199);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(322, 59);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "AJOUTER AUTEURS";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // tbLibelle
            // 
            tbLibelle.Anchor = AnchorStyles.Top;
            tbLibelle.BackColor = SystemColors.ButtonHighlight;
            tbLibelle.Font = new Font("Oxanium Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbLibelle.Location = new Point(330, 132);
            tbLibelle.Margin = new Padding(3, 4, 3, 4);
            tbLibelle.Multiline = true;
            tbLibelle.Name = "tbLibelle";
            tbLibelle.ReadOnly = true;
            tbLibelle.Size = new Size(322, 59);
            tbLibelle.TabIndex = 19;
            // 
            // cbSelect
            // 
            cbSelect.HeaderText = "◙";
            cbSelect.MinimumWidth = 6;
            cbSelect.Name = "cbSelect";
            cbSelect.ReadOnly = true;
            cbSelect.Width = 24;
            // 
            // FormAuteurAjout
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 428);
            Controls.Add(tbLibelle);
            Controls.Add(btnAdd);
            Controls.Add(lbRessources);
            Controls.Add(button1);
            Controls.Add(btnFermer);
            Controls.Add(dgvAuteur);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormAuteurAjout";
            Text = "FormAuteurAjout";
            ((System.ComponentModel.ISupportInitialize)dgvAuteur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAuteur;
        private Button button1;
        private Button btnFermer;
        private ListBox lbRessources;
        private Button btnAdd;
        private TextBox tbLibelle;
        private DataGridViewComboBoxColumn cbSelect;
    }
}