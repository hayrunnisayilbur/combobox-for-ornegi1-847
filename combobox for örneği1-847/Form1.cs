using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_for_örneği1_847
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // formu calıştırır.
            // 20 sayıyı burada oluşturabilir. metot bilgisi gerekiyor.
        }

        // butonunu tıklayınca calıştırır.


        private void btnSayilar_Click(object sender, EventArgs e)
        {
            cmbCiftSayilar.Items.Clear();
            // rastgele oluşturulmus olan sayılardan çift olanlarını aktar
            for (int i = 0; i < 20; i++)
            {
                int sayi = Convert.ToInt32(lbSayilar.Items[i]);
                if (sayi % 2 == 0)
                {
                    cmbCiftSayilar.Items.Add(sayi);
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // rastgele 20 sayı olustur
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                lbSayilar.Items.Add(rnd.Next(1, 101));
            }
        }
    }
}