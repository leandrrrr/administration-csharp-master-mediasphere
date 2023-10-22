namespace AP3_MEDIA
{
    partial class FormPopDGV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPopDGV));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            gbtExemplaires = new Guna.UI2.WinForms.Guna2Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(481, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // gbtExemplaires
            // 
            gbtExemplaires.BackColor = Color.White;
            gbtExemplaires.BorderRadius = 6;
            gbtExemplaires.CustomizableEdges = customizableEdges1;
            gbtExemplaires.DisabledState.BorderColor = Color.DarkGray;
            gbtExemplaires.DisabledState.CustomBorderColor = Color.DarkGray;
            gbtExemplaires.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            gbtExemplaires.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            gbtExemplaires.Font = new Font("Oxanium Medium", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            gbtExemplaires.ForeColor = Color.White;
            gbtExemplaires.Location = new Point(49, 345);
            gbtExemplaires.Name = "gbtExemplaires";
            gbtExemplaires.ShadowDecoration.CustomizableEdges = customizableEdges2;
            gbtExemplaires.Size = new Size(426, 52);
            gbtExemplaires.TabIndex = 14;
            gbtExemplaires.Text = "OK";
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.Font = new Font("Oxanium", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = Color.MidnightBlue;
            richTextBox1.Location = new Point(49, 40);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBox1.Size = new Size(426, 357);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // FormPopDGV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(525, 435);
            Controls.Add(gbtExemplaires);
            Controls.Add(richTextBox1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPopDGV";
            Text = "FormPopDGV";
            TransparencyKey = Color.Black;
            Load += FormPopDGV_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button gbtExemplaires;
        private RichTextBox richTextBox1;
    }
}