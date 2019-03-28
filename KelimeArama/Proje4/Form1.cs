using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int sayi = 0;
            string metin = txtMetin.Text;
            string kelime = txtAranacakKelime.Text;
            int konum = metin.IndexOf(kelime);

            while(konum != -1)
            {
                konum = metin.IndexOf(kelime, konum + 1);
                sayi++;
            }

            MessageBox.Show("Girdiğiniz Kelime metin içerisinde " + sayi.ToString() + " kere geçiyor");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
