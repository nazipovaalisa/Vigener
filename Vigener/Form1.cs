using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vigener
{
    public partial class Form1 : Form
    {
        string rusalf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя0123456789"; 
        string engalf = "abcdefghijklmnopqrstuvwxyz0123456789"; 
        bool lang; //true-русский
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
       
        }
        //преобразовываем ключ
        private void NewKey(string s, ref string key)
        {
            string res = "";
            int i = 0; 
            int j = 0; //индекс ключа
            while (i < s.Length)
            {
                if (j == key.Length)
                    j -= key.Length;
                res += key[j];
                j++;
                i++;
            }
            key=res;
        }
        //проверка на буквы и цифры
        private bool CheckText(string s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                if (Char.IsLetterOrDigit(s[i]) == false)
                    return false;
            }
            return true;
        }
        //проверка языка
        private bool CheckLang(string s)
        {
            if (lang == true)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsDigit(s[i]))
                        continue;
                    if (s[i] >= 'a' && s[i] <= 'z')
                    {
                        MessageBox.Show("Текст и ключ должны быть на русском языке");
                        return false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (char.IsDigit(s[i]))
                        continue;
                    if (s[i] >= 'а' && s[i] <= 'я')
                    {
                        MessageBox.Show("Текст и ключ должны быть на английском языке");
                        return false;
                    }
                }
            }
            return true;
        }

        private string Crypt(string s, string key, bool encrypt)
        {
            int nom; //позиция в алфавите
            string res=""; 
            string alf;
            if (lang == true)
                alf = rusalf;
            else
                alf = engalf;
            s=s.ToLower();
            key=key.ToLower();
            NewKey(s,ref key);
            for(int i = 0; i < s.Length; i++)
            {
                int m = alf.IndexOf(s[i]);
                int k = alf.IndexOf(key[i]);
                if (encrypt == true)
                    nom = (m + k) % alf.Length;
                else
                    nom = (m + alf.Length - k) % alf.Length;
                res += alf[nom];
            }
            return res;
        }
        private void Enbutton_Click(object sender, EventArgs e)
        {
            if(rus.Checked==false && eng.Checked == false)
            {
                MessageBox.Show("Выберете язык!");
                return;
            }
            if (inputBox.Text == "")
            {
                MessageBox.Show("Введите текст!");
                return;
            }
            if (keyBox.Text == "")
            {
                MessageBox.Show("Введите ключ!");
                return;
            }
            if (CheckLang(inputBox.Text) == false || CheckLang(keyBox.Text) == false)
                return;
            if (CheckText(inputBox.Text) && CheckText(keyBox.Text))
            {
                cryptBox.Text = Crypt(inputBox.Text, keyBox.Text, true);
                Debutton.Visible = true;
            }
            else
                MessageBox.Show("Исходный текст и ключ могут содержать только буквы и цифры! Пробелы и иные символы запрещены!");
        }

        private void Debutton_Click(object sender, EventArgs e)
        {
            if (rus.Checked == false && eng.Checked == false)
            {
                MessageBox.Show("Выберете язык!");
                return;
            }
            if (keyBox.Text == "")
            {
                MessageBox.Show("Введите ключ!");
                return;
            }
            if (cryptBox.Text == "")
            {
                MessageBox.Show("Криптограмма пустая!");
                return;
            }
            if (CheckLang(cryptBox.Text) == false || CheckLang(keyBox.Text) == false)
                return;
            if (CheckText(cryptBox.Text)&& CheckText(keyBox.Text))
                decryptBox.Text = Crypt(cryptBox.Text, keyBox.Text, false);
            else
              MessageBox.Show("Ключ и текст могут содержать только буквы и цифры! Пробелы и иные символы запрещены!");
        }

        private void rus_CheckedChanged(object sender, EventArgs e)
        {
            if (rus.Checked == true)
            {
                lang = true;
                MessageBox.Show("Проверьте, чтобы текст и ключ содержали буквы только русского алфавита");
            }
        }

        private void eng_CheckedChanged(object sender, EventArgs e)
        {
            if (eng.Checked == true)
            {
                lang = false;
                MessageBox.Show("Проверьте, чтобы текст и ключ содержали буквы только английского алфавита");
            }
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) return;
            else
            {
                if (Char.IsWhiteSpace(e.KeyChar))
                {
                    MessageBox.Show("Ввод пробелов запрещен!");
                    e.Handled = true;
                }
                if (Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                {
                    MessageBox.Show("Запрещено вводить иные символы, кроме букв и цифр!");
                    e.Handled = true;
                }
            }
        }
        private void keyBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar)) return;
            else
            {
                if (Char.IsWhiteSpace(e.KeyChar))
                {
                    MessageBox.Show("Ввод пробелов запрещен!");
                    e.Handled = true;
                }
                if (Char.IsSymbol(e.KeyChar) || Char.IsPunctuation(e.KeyChar))
                {
                    MessageBox.Show("Запрещено вводить иные символы, кроме букв и цифр!");
                    e.Handled = true;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            inputBox.Clear();
            keyBox.Clear();
            cryptBox.Clear();
            decryptBox.Clear();
            Debutton.Visible = false;
            rus.Checked = false;
            eng.Checked = false;
        }

    }
}
