using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_yazılı_ortalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sinav1 = Convert.ToInt32(txtSinav1.Text);
            int Sinav3 = Convert.ToInt32(txtSinav2.Text);
            int Sinav2 = Convert.ToInt32(txtSinav3.Text);
            int ortalama = (Sinav1 + Sinav2 + Sinav3) / 3;
            lblOrtalama.Text = "Ortalamanız: " + ortalama.ToString();
         }
    }
}
