using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Armstrong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

		private void altsinirtxt_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void bul_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();

			if (altsinirtxt.Text == "" || ustsinirtxt.Text == "" )
			{
				MessageBox.Show("Lütfen Sayı Değerlerini Giriniz");
			}
			else
			{
				int altsinir = Convert.ToInt32(altsinirtxt.Text) + 1;
				int ustsinir = Convert.ToInt32(ustsinirtxt.Text);
				

				for (int i = altsinir; i < ustsinir; i++)
				{
					string sayiText = i.ToString();
					int sayi = i;
					int basamakSayisi = sayiText.Length;
					int toplam = 0;
					for (int j = 0; j < basamakSayisi; j++)
					{
						string sayiTabani = sayiText[j].ToString();
						int sayiKuvveti = (int)Math.Pow(Convert.ToInt32(sayiTabani), basamakSayisi);
						toplam += sayiKuvveti;

					}
					if (toplam == sayi)
					{
						listBox1.Items.Add(sayi);
					}
				}
			}
		}
	}
}
