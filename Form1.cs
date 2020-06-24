using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Курсовая_Работа
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string Alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦШЩЪЫЬЭЮЯ";

        private void ЗашифроватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string key = txtBxKeyWordEncrypt.Text;
            string encryptText = richtxtboxEncrypt.Text;

            if (txtBxKeyWordEncrypt.Text == null || richtxtboxEncrypt.Text == null)
            {
                MessageBox.Show("Введите необходимые данные");
            }

            string result = "";

            for (int i = 0, j = 0; i < encryptText.Length; i++, j++)
            {
                if (j == key.Length)
                    j = 0;

                char code = encryptText[i];
                char c = char.ToUpper(encryptText[i]);
                int pos = Alphabet.IndexOf(c);

                if (pos != -1)
                {
                    char cKey = char.ToUpper(key[j]);
                    int posKey = Alphabet.IndexOf(cKey);

                    code = Alphabet[(posKey + pos + 1) % Alphabet.Length];
                    if (char.IsLower(encryptText[i]))
                        code = char.ToLower(code);
                }
                else
                    j--;

                result += code;
            }

            richTtxtboxDecrypt.Text = result;
        }

        private void txtBxKeyWordEncrypt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void расшифроватьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string key = txtBxKeyWordEncrypt.Text;
            string encryptText = richtxtboxEncrypt.Text;

            string result = "";

            for (int i = 0, j = 0; i < encryptText.Length; i++, j++)
            {
                if (j == key.Length)
                    j = 0;

                char code = encryptText[i];
                char c = char.ToUpper(encryptText[i]);
                int pos = Alphabet.IndexOf(c);

                if (pos != -1)
                {
                    char cKey = char.ToUpper(key[j]);
                    int posKey = Alphabet.IndexOf(cKey);

                    code = Alphabet[(pos - posKey - 1 + Alphabet.Length) % Alphabet.Length];
                    if (char.IsLower(encryptText[i]))
                        code = char.ToLower(code);
                }
                else
                    j--;

                result += code;
            }

            richTtxtboxDecrypt.Text = result;
        }

        private void сохранитьToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                sw.WriteLine(richtxtboxEncrypt.Text);
                sw.Close();
            }
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richtxtboxEncrypt.Clear();
            richTtxtboxDecrypt.Clear();
            txtBxKeyWordEncrypt.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                richtxtboxEncrypt.Text = sr.ReadLine();
                sr.Close();
            }
        }
    }
}
