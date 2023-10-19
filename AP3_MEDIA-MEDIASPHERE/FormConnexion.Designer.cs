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
            labelId = new Label();
            labelMdp = new Label();
            tbId = new TextBox();
            btnConnexion = new Button();
            pictureBox1 = new PictureBox();
            tbMdp = new TextBox();
            bsUser = new BindingSource(components);
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsUser).BeginInit();
            SuspendLayout();
            // 
            // labelId
            // 
            labelId.Anchor = AnchorStyles.Top;
            labelId.AutoSize = true;
            labelId.Font = new Font("Oxanium Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelId.Location = new Point(439, 41);
            labelId.Name = "labelId";
            labelId.Size = new Size(160, 35);
            labelId.TabIndex = 25;
            labelId.Text = "Identifiant";
            // 
            // labelMdp
            // 
            labelMdp.Anchor = AnchorStyles.Top;
            labelMdp.AutoSize = true;
            labelMdp.Font = new Font("Oxanium Medium", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelMdp.Location = new Point(424, 138);
            labelMdp.Name = "labelMdp";
            labelMdp.Size = new Size(200, 35);
            labelMdp.TabIndex = 24;
            labelMdp.Text = "Mot de Passe";
            // 
            // tbId
            // 
            tbId.Anchor = AnchorStyles.Top;
            tbId.BackColor = SystemColors.ButtonHighlight;
            tbId.Font = new Font("Oxanium Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbId.Location = new Point(233, 80);
            tbId.Margin = new Padding(3, 4, 3, 4);
            tbId.Multiline = true;
            tbId.Name = "tbId";
            tbId.Size = new Size(559, 46);
            tbId.TabIndex = 21;
            // 
            // btnConnexion
            // 
            btnConnexion.Anchor = AnchorStyles.Top;
            btnConnexion.BackColor = Color.Black;
            btnConnexion.FlatStyle = FlatStyle.Popup;
            btnConnexion.Font = new Font("Oxanium Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnConnexion.ForeColor = Color.White;
            btnConnexion.Location = new Point(233, 278);
            btnConnexion.Margin = new Padding(3, 4, 3, 4);
            btnConnexion.Name = "btnConnexion";
            btnConnexion.Size = new Size(559, 59);
            btnConnexion.TabIndex = 20;
            btnConnexion.Text = "CONNECTION";
            btnConnexion.UseVisualStyleBackColor = false;
            btnConnexion.Click += btnConnexion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.border_style___Copie;
            pictureBox1.Location = new Point(222, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 378);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // tbMdp
            // 
            tbMdp.Anchor = AnchorStyles.Top;
            tbMdp.BackColor = SystemColors.ButtonHighlight;
            tbMdp.Font = new Font("Oxanium Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbMdp.Location = new Point(233, 177);
            tbMdp.Margin = new Padding(3, 4, 3, 4);
            tbMdp.Multiline = true;
            tbMdp.Name = "tbMdp";
            tbMdp.Size = new Size(559, 46);
            tbMdp.TabIndex = 26;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Oxanium ExtraBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(981, 12);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 27;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormConnexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 428);
            Controls.Add(button1);
            Controls.Add(tbMdp);
            Controls.Add(labelId);
            Controls.Add(labelMdp);
            Controls.Add(tbId);
            Controls.Add(btnConnexion);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormConnexion";
            Text = "FormConnexion";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelId;
        private Label labelMdp;
        private TextBox tbId;
        private Button btnConnexion;
        private PictureBox pictureBox1;
        private TextBox tbMdp;
        private BindingSource bsUser;
        private Button button1;
    }
}