using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SesliSessizForms
{
    public partial class Form1 : Form
    {
        string word;
        string sonuc;
        public Form1()
        {
            InitializeComponent();
        }

        char[] letters = new char[8] { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

        private void button1_Click(object sender, EventArgs e)
        {
            word = tbKelime.Text.ToLower();

            foreach (var item in word)
            {
                if (letters.Contains(item))
                {
                    if (!(tbSesli.Text.Contains(item)))
                    {
                        tbSesli.Text += item;
                    }
                    
                }
                else
                {
                    if (!(tbSessiz.Text.Contains(item)))
                    {
                        tbSessiz.Text += item;
                    }
                    
                }
            }
        }

        private void bTemizle_Click(object sender, EventArgs e)
        {
            tbKelime.Clear();
            tbSesli.Clear();
            tbSessiz.Clear();
        }
    }
}
