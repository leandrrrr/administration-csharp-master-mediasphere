﻿namespace AP3_MEDIA
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
            dgvRessources = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            voirLesExemplaireToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnFermer = new Button();
            bsRessources = new BindingSource(components);
            bsExemplaires = new BindingSource(components);
            dgvExemplaires = new DataGridView();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRessources).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).BeginInit();
            SuspendLayout();
            // 
            // dgvRessources
            // 
            dgvRessources.AllowUserToAddRows = false;
            dgvRessources.AllowUserToDeleteRows = false;
            dgvRessources.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRessources.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRessources.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRessources.ContextMenuStrip = contextMenuStrip1;
            dgvRessources.Location = new Point(74, 52);
            dgvRessources.Margin = new Padding(3, 4, 3, 4);
            dgvRessources.Name = "dgvRessources";
            dgvRessources.ReadOnly = true;
            dgvRessources.RowHeadersWidth = 51;
            dgvRessources.RowTemplate.Height = 25;
            dgvRessources.Size = new Size(862, 273);
            dgvRessources.TabIndex = 0;
            dgvRessources.CellContentClick += dgvRessources_CellContentClick;
            dgvRessources.CellMouseClick += dgvRessources_CellMouseClick;
            dgvRessources.Click += dgvRessources_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { voirLesExemplaireToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(210, 28);
            // 
            // voirLesExemplaireToolStripMenuItem
            // 
            voirLesExemplaireToolStripMenuItem.Name = "voirLesExemplaireToolStripMenuItem";
            voirLesExemplaireToolStripMenuItem.Size = new Size(209, 24);
            voirLesExemplaireToolStripMenuItem.Text = "voir les exemplaires";
            voirLesExemplaireToolStripMenuItem.Click += voirLesExemplaireToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oxanium", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 16);
            label1.Name = "label1";
            label1.Size = new Size(244, 29);
            label1.TabIndex = 1;
            label1.Text = "Liste des Ressources";
            // 
            // btnFermer
            // 
            btnFermer.BackColor = Color.Black;
            btnFermer.FlatStyle = FlatStyle.Popup;
            btnFermer.Font = new Font("Oxanium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFermer.ForeColor = Color.White;
            btnFermer.Location = new Point(801, 332);
            btnFermer.Margin = new Padding(3, 4, 3, 4);
            btnFermer.Name = "btnFermer";
            btnFermer.Size = new Size(135, 58);
            btnFermer.TabIndex = 2;
            btnFermer.Text = "FERMER";
            btnFermer.UseVisualStyleBackColor = false;
            btnFermer.Click += btnFermer_Click;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsRessources_CurrentChanged;
            // 
            // dgvExemplaires
            // 
            dgvExemplaires.AllowUserToAddRows = false;
            dgvExemplaires.AllowUserToDeleteRows = false;
            dgvExemplaires.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExemplaires.Location = new Point(418, 52);
            dgvExemplaires.Margin = new Padding(3, 4, 3, 4);
            dgvExemplaires.Name = "dgvExemplaires";
            dgvExemplaires.ReadOnly = true;
            dgvExemplaires.RowHeadersWidth = 51;
            dgvExemplaires.RowTemplate.Height = 25;
            dgvExemplaires.Size = new Size(518, 273);
            dgvExemplaires.TabIndex = 5;
            dgvExemplaires.Visible = false;
            dgvExemplaires.CellContentClick += dgvExemplaires_CellContentClick;
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
            button1.TabIndex = 14;
            button1.Text = "?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormRessources
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 428);
            Controls.Add(button1);
            Controls.Add(dgvExemplaires);
            Controls.Add(btnFermer);
            Controls.Add(label1);
            Controls.Add(dgvRessources);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormRessources";
            Text = "Liste des Ressources";
            Load += FormRessources_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRessources).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsExemplaires).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExemplaires).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRessources;
        private Label label1;
        private Button btnFermer;
        private BindingSource bsRessources;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem voirLesExemplaireToolStripMenuItem;
        private BindingSource bsExemplaires;
        private DataGridView dgvExemplaires;
        private Button button1;
    }
}