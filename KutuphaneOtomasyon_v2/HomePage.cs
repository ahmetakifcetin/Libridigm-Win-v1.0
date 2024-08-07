using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KutuphaneOtomasyon_v2
{
    public partial class HomePage : Form
    {
        private int girisHakki = 3;
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private string rememberMeFilePath = "rememberMe.txt";

        public HomePage()
        {
            InitializeComponent();
            LoadRememberedCredentials();
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "kutuphane_db";
            uid = "root";
            password = "123456";
            string connectionString = $"SERVER={server}; DATABASE={database}; UID={uid}; PASSWORD={password}";
            connection = new MySqlConnection(connectionString);
        }

        private void chkPasswordHide_CheckedChanged(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = chkPasswordHide.Checked ? '\0' : '•';
        }

        private bool GirisKontrolu(string personelMail, string sifre)
        {
            try
            {
                connection.Open();
                string query = "SELECT personel_yetki FROM personel_tbl WHERE personel_mail = @personelMail AND sifre = @sifre";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@personelMail", personelMail);
                command.Parameters.AddWithValue("@sifre", sifre);
                string yetkiSeviyesi = Convert.ToString(command.ExecuteScalar());
                connection.Close();

                return !string.IsNullOrEmpty(yetkiSeviyesi);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                return false;
            }
        }

        private void LogKaydet(string logMesaji, bool isSuccessful)
        {
            string logDosyaYolu = "GirisLog.txt";

            try
            {
                using (StreamWriter sw = File.AppendText(logDosyaYolu))
                {
                    string status = isSuccessful ? "BAŞARILI" : "BAŞARISIZ";
                    sw.WriteLine($"{DateTime.Now} - {status} - {logMesaji}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Log dosyasına yazılırken hata oluştu: {ex.Message}", "Kayıt Yazma Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetYetkiSeviyesi(string kullaniciAdi)
        {
            try
            {
                connection.Open();
                string query = "SELECT personel_yetki FROM personel_tbl WHERE personel_mail = @personelMail";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@personelMail", kullaniciAdi);
                string yetkiSeviyesi = Convert.ToString(command.ExecuteScalar());
                connection.Close();

                return yetkiSeviyesi;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantı hatası: " + ex.Message);
                return null;
            }
        }

        private DateTime kilitliBitisZamani;

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text;
            string sifre = txtSifre.Text;

            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(sifre))
            {
                MessageBox.Show("Lütfen e-posta ve şifrenizi giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (DateTime.Now < kilitliBitisZamani)
            {
                double kalanDakika = Math.Ceiling(kilitliBitisZamani.Subtract(DateTime.Now).TotalMinutes);
                MessageBox.Show($"Sistem şu anda kilitli. Kalan süre: {kalanDakika} dakika. Lütfen bekleyiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (GirisKontrolu(kullaniciAdi, sifre))
            {
                SaveOrClearCredentials();

                string yetkiSeviyesi = GetYetkiSeviyesi(kullaniciAdi);
                LogKaydet("Kullanıcı girişi başarılı.", true);

                switch (yetkiSeviyesi)
                {
                    case "Kullanıcı":
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();
                        break;
                    case "Moderatör":
                        ModeratorOnly moderatorForm = new ModeratorOnly();
                        moderatorForm.Show();
                        break;
                    case "Admin":
                        ManageAdmin adminForm = new ManageAdmin();
                        adminForm.Show();
                        break;
                    default:
                        MessageBox.Show("Geçersiz yetki seviyesi!");
                        break;
                }
            }
            else
            {
                MessageBox.Show($"Kullanıcı adı ve şifrenizi kontrol edip, tekrar deneyin! Kalan deneme hakkınız: {girisHakki}", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                yardimMessageBox.Visible = true;
                LogKaydet($"Hatalı giriş denemesi - Kullanıcı Adı: {kullaniciAdi}, Şifre: {sifre}", false);

                if (girisHakki > 0)
                {
                    girisHakki--;
                }

                if (girisHakki == 0)
                {
                    MessageBox.Show("3 başarısız giriş denemesi. Uygulama kilitleniyor.");
                    kilitliBitisZamani = DateTime.Now.AddMinutes(1);
                }
            }
        }

        private void SaveOrClearCredentials()
        {
            if (chkBeniHatirla.Checked)
            {
                using (StreamWriter sw = new StreamWriter(rememberMeFilePath))
                {
                    sw.WriteLine(txtKullaniciAdi.Text);
                    sw.WriteLine(txtSifre.Text);
                }
            }
            else if (File.Exists(rememberMeFilePath))
            {
                File.Delete(rememberMeFilePath);
            }
        }

        private void LoadRememberedCredentials()
        {
            if (File.Exists(rememberMeFilePath))
            {
                string[] credentials = File.ReadAllLines(rememberMeFilePath);
                if (credentials.Length == 2)
                {
                    txtKullaniciAdi.Text = credentials[0];
                    txtSifre.Text = credentials[1];
                    chkBeniHatirla.Checked = true;
                }
            }
        }

        private void YardimText_Click(object sender, EventArgs e)
        {
            HelpPage HelpPage = new HelpPage();
            HelpPage.Show();
        }
    }
}

