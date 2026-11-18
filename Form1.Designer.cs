namespace Caesar_23
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            label1 = new Label();
            textBox1 = new TextBox();
            btn_pres = new Button();
            rbt_alph = new RadioButton();
            rbt_ceaser = new RadioButton();
            label2 = new Label();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btn_pres);
            groupBox1.Controls.Add(rbt_alph);
            groupBox1.Controls.Add(rbt_ceaser);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 189);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ceaser 23";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 47);
            label1.Name = "label1";
            label1.Size = new Size(52, 23);
            label1.TabIndex = 11;
            label1.Text = "Giriş:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(70, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 30);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // btn_pres
            // 
            btn_pres.Location = new Point(10, 157);
            btn_pres.Name = "btn_pres";
            btn_pres.Size = new Size(75, 23);
            btn_pres.TabIndex = 9;
            btn_pres.UseVisualStyleBackColor = true;
            btn_pres.Click += btn_pres_Click;
            // 
            // rbt_alph
            // 
            rbt_alph.Location = new Point(226, 110);
            rbt_alph.Name = "rbt_alph";
            rbt_alph.Size = new Size(109, 31);
            rbt_alph.TabIndex = 4;
            rbt_alph.TabStop = true;
            rbt_alph.Text = "Alfabe";
            rbt_alph.UseVisualStyleBackColor = true;
            // 
            // rbt_ceaser
            // 
            rbt_ceaser.Location = new Point(89, 110);
            rbt_ceaser.Name = "rbt_ceaser";
            rbt_ceaser.Size = new Size(111, 31);
            rbt_ceaser.TabIndex = 3;
            rbt_ceaser.TabStop = true;
            rbt_ceaser.Text = "Ceaser 23";
            rbt_ceaser.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 114);
            label2.Name = "label2";
            label2.Size = new Size(59, 23);
            label2.TabIndex = 1;
            label2.Text = "İşlem:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaption;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(12, 216);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(360, 67);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sonuç";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(18, 26);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(325, 30);
            textBox2.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Türkçe", "English" });
            comboBox1.Location = new Point(561, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            comboBox1.Text = "Language/Dil";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(694, 411);
            Controls.Add(comboBox1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ceaser 23 Encryption";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private GroupBox groupBox2;
        private ComboBox comboBox1;
        private RadioButton rbt_alph;
        private RadioButton rbt_ceaser;
        private TextBox unp_text;
        private TextBox inp_text;
        private Button btn_pres;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
    }
}
