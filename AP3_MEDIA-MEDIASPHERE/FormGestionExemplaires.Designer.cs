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
            lbRessources = new ListBox();
            bsRessources = new BindingSource(components);
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            tbLibelle = new TextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            cbEtat = new ComboBox();
            label8 = new Label();
            label1 = new Label();
            bsEtat = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)bsRessources).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).BeginInit();
            SuspendLayout();
            // 
            // lbRessources
            // 
            lbRessources.Anchor = AnchorStyles.Top;
            lbRessources.BorderStyle = BorderStyle.None;
            lbRessources.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbRessources.FormattingEnabled = true;
            lbRessources.ItemHeight = 21;
            lbRessources.Location = new Point(49, 69);
            lbRessources.Margin = new Padding(3, 4, 3, 4);
            lbRessources.Name = "lbRessources";
            lbRessources.Size = new Size(280, 273);
            lbRessources.TabIndex = 9;
            lbRessources.SelectedIndexChanged += lbRessources_SelectedIndexChanged;
            // 
            // bsRessources
            // 
            bsRessources.CurrentChanged += bsCategories_CurrentChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = Properties.Resources.border_style___Copie;
            pictureBox1.Location = new Point(381, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(584, 277);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.BackColor = Color.Black;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Oxanium Medium", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(614, 271);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 59);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "AJOUTER";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnFermer_Click;
            // 
            // tbLibelle
            // 
            tbLibelle.Anchor = AnchorStyles.Top;
            tbLibelle.BackColor = SystemColors.ButtonHighlight;
            tbLibelle.Font = new Font("Oxanium Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            tbLibelle.Location = new Point(392, 92);
            tbLibelle.Margin = new Padding(3, 4, 3, 4);
            tbLibelle.Multiline = true;
            tbLibelle.Name = "tbLibelle";
            tbLibelle.ReadOnly = true;
            tbLibelle.Size = new Size(559, 46);
            tbLibelle.TabIndex = 12;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top;
            textBox1.BackColor = SystemColors.ButtonHighlight;
            textBox1.Font = new Font("Oxanium Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(392, 167);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(559, 38);
            textBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
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
            // cbEtat
            // 
            cbEtat.Anchor = AnchorStyles.Top;
            cbEtat.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEtat.FlatStyle = FlatStyle.Flat;
            cbEtat.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            cbEtat.FormattingEnabled = true;
            cbEtat.Location = new Point(392, 234);
            cbEtat.Margin = new Padding(3, 4, 3, 4);
            cbEtat.Name = "cbEtat";
            cbEtat.Size = new Size(559, 29);
            cbEtat.TabIndex = 15;
            cbEtat.SelectedIndexChanged += cbCategories_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(641, 209);
            label8.Name = "label8";
            label8.Size = new Size(57, 21);
            label8.TabIndex = 16;
            label8.Text = "Etats";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Oxanium Medium", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(644, 142);
            label1.Name = "label1";
            label1.Size = new Size(52, 21);
            label1.TabIndex = 17;
            label1.Text = "Date";
            // 
            // bsEtat
            // 
            bsEtat.CurrentChanged += bsExemples_CurrentChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top;
            dateTimePicker1.CustomFormat = "dd / MM / yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(932, 167);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(19, 26);
            dateTimePicker1.TabIndex = 18;
            dateTimePicker1.Value = new DateTime(2023, 10, 17, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // FormGestionExemplaires
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(154, 206, 234);
            ClientSize = new Size(1028, 428);
            Controls.Add(dateTimePicker1);
            Controls.Add(label1);
            Controls.Add(cbEtat);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(tbLibelle);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(lbRessources);
            Font = new Font("Oxanium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGestionExemplaires";
            Text = "FormGestionExemplaires";
            Load += FormGestionExemplaires_Load;
            ((System.ComponentModel.ISupportInitialize)bsRessources).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bsEtat).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbRessources;
        private BindingSource bsRessources;
        private PictureBox pictureBox1;
        private Button btnAdd;
        private TextBox tbLibelle;
        private TextBox textBox1;
        private Button button1;
        private ComboBox cbEtat;
        private Label label8;
        private Label label1;
        private BindingSource bsEtat;
        private DateTimePicker dateTimePicker1;
    }
}