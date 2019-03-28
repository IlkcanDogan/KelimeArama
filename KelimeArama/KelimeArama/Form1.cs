using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KelimeArama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
         
                string kelime = txtKelime.Text;
                string metin = txtMetin.Text;
                int sonuc = metin.IndexOf(kelime);

                if (sonuc == -1)
                {
                    MessageBox.Show("Bulunamadı");
                }
                else
                {
                    MessageBox.Show("bulundu!! ");

                }
          
        }
    }
}
