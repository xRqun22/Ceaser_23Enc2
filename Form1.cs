using System.Diagnostics.Eventing.Reader;

namespace Caesar_23
{
    public partial class Form1 : Form
    {
        string turkce_harf = "çğıöşüÇĞİÖŞÜ";
        string numbers = "1234567890";

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        private void btn_pres_Click(object sender, EventArgs e)
        {
            if (rbt_alph.Checked!)
            {
                string metin = textBox1.Text.ToLower();
                string alfabe = "abcdefghijklmnopqrstuvwxyz";
                string cozum = "";

                foreach (char harf in metin)
                {
                    int index = alfabe.IndexOf(harf);

                    if (index != -1)
                    {

                        int yeniIndex = (index - 23 + 26) % 26;
                        cozum += alfabe[yeniIndex];
                    }
                    else
                    {
                        cozum += harf;
                    }
                    textBox2.Text = cozum;
                }
            }
            else
            {
                string metin = textBox1.Text.ToLower();
                string alfabe = "abcdefghijklmnopqrstuvwxyz";
                string cozum = "";

                foreach (char harf in metin)
                {
                    int index = alfabe.IndexOf(harf);

                    if (index != -1)
                    {
                        int yeniIndex = (index + 23) % 26;
                        cozum += alfabe[yeniIndex];
                    }
                    else
                    {
                        cozum += harf;
                    }
                    textBox2.Text = cozum;

                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (char harf in turkce_harf)
            {
                if (textBox1.Text.Contains(harf))
                {
                    textBox1.Clear();
                    break;
                }
            }
            foreach (char harf in numbers)
            {
                if (textBox1.Text.Contains(harf))
                {
                    textBox1.Clear();
                    break;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Türkçe")
            {
                label1.Text = "Giriş:";
                label2.Text = "İşlem:";
                rbt_alph.Text = "Alfabe";
                groupBox2.Text = "Sonuç";
            }
            else if (comboBox1.SelectedItem.ToString() == "English")
            {
                label1.Text = "İnput:";
                label2.Text = "Options:";
                rbt_alph.Text = "Alphabet";
                groupBox2.Text = "Output";
            }
        }
    }
}
