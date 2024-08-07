using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon_v2
{
    public partial class HelpPage : Form
    {
        public HelpPage()
        {
            InitializeComponent();
        }

        private void yardimText_Click(object sender, EventArgs e)
        {
            string mailAdresi = txtMailAdress.Text.Trim();

            if (string.IsNullOrEmpty(mailAdresi))
            {
                MessageBox.Show("Mesaj gönderebilmek için e-posta adresinizi giriniz!", "Mesaj İletilemedi: Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!mailAdresi.Contains("@") || mailAdresi.EndsWith("@example.com"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz!", "Geçersiz E-posta Adresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Geliştirici ekibe durum bildirildi.\n E-posta adresiniz: {mailAdresi}. \n Bilgilendirme yapılacaktır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomePage anasayfa = new HomePage();
                anasayfa.Show();
                this.Close();
            }
        }

        private void yardimText_MouseHover(object sender, EventArgs e)
        {
            yardimText.ForeColor = Color.DarkOrange;
        }

        private void yardimText_MouseLeave(object sender, EventArgs e)
        {
            yardimText.ForeColor = Color.Goldenrod;
        }

        private void btnYardimAl_Click(object sender, EventArgs e)
        {
            bool erisimSorunuVar = true;

            if (erisimSorunuVar)
            {
                MessageBox.Show("E-posta adresine erişemiyorsanız. Lütfen kuruluşunuz ile iletişime geçin.", "Erişim Sorunu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Hayır, e-posta adresine erişebiliyorum.", "Erişim Durumu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string mailAdresi = txtMailAdress.Text.Trim();

            if (string.IsNullOrEmpty(mailAdresi))
            {
                MessageBox.Show("Giriş bağlantısı almak için e-posta adresinizi giriniz!", "Mesaj gönderilemedi: Bilgiler Eksik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!mailAdresi.Contains("@") || mailAdresi.EndsWith("@example.com"))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz!", "Geçersiz E-posta Adresi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show($"Giriş bağlantısı gönderildi.\n E-posta adresiniz: {mailAdresi}.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HomePage anasayfa = new HomePage();
                anasayfa.Show();
                this.Close();
            }
        }
    }
}
