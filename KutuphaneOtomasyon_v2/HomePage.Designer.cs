namespace KutuphaneOtomasyon_v2
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.logoDark = new System.Windows.Forms.PictureBox();
            this.welcomeMessageText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkBeniHatirla = new System.Windows.Forms.CheckBox();
            this.chkPasswordHide = new System.Windows.Forms.CheckBox();
            this.yardimMessageBox = new System.Windows.Forms.GroupBox();
            this.YardimText = new System.Windows.Forms.Label();
            this.informationText2 = new System.Windows.Forms.Label();
            this.informationText1 = new System.Windows.Forms.Label();
            this.yardimLight = new System.Windows.Forms.PictureBox();
            this.sifreText = new System.Windows.Forms.Label();
            this.messageText3 = new System.Windows.Forms.Label();
            this.epostaText = new System.Windows.Forms.Label();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.messageText2 = new System.Windows.Forms.Label();
            this.personelDark = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoDark)).BeginInit();
            this.panel2.SuspendLayout();
            this.yardimMessageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yardimLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDark)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoDark
            // 
            this.logoDark.BackColor = System.Drawing.Color.Transparent;
            this.logoDark.Image = global::KutuphaneOtomasyon_v2.Properties.Resources.logo_light;
            this.logoDark.Location = new System.Drawing.Point(123, 12);
            this.logoDark.Name = "logoDark";
            this.logoDark.Size = new System.Drawing.Size(61, 58);
            this.logoDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoDark.TabIndex = 8;
            this.logoDark.TabStop = false;
            // 
            // welcomeMessageText
            // 
            this.welcomeMessageText.AutoSize = true;
            this.welcomeMessageText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeMessageText.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeMessageText.ForeColor = System.Drawing.Color.Black;
            this.welcomeMessageText.Location = new System.Drawing.Point(230, 13);
            this.welcomeMessageText.Name = "welcomeMessageText";
            this.welcomeMessageText.Size = new System.Drawing.Size(160, 32);
            this.welcomeMessageText.TabIndex = 5;
            this.welcomeMessageText.Text = "Hoşgeldiniz";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::KutuphaneOtomasyon_v2.Properties.Resources.bg_light;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.logoDark);
            this.panel2.Controls.Add(this.yardimMessageBox);
            this.panel2.Controls.Add(this.messageText3);
            this.panel2.Controls.Add(this.messageText2);
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 454);
            this.panel2.TabIndex = 4;
            // 
            // chkBeniHatirla
            // 
            this.chkBeniHatirla.AutoSize = true;
            this.chkBeniHatirla.BackColor = System.Drawing.Color.Transparent;
            this.chkBeniHatirla.ForeColor = System.Drawing.Color.Black;
            this.chkBeniHatirla.Location = new System.Drawing.Point(332, 165);
            this.chkBeniHatirla.Name = "chkBeniHatirla";
            this.chkBeniHatirla.Size = new System.Drawing.Size(80, 17);
            this.chkBeniHatirla.TabIndex = 15;
            this.chkBeniHatirla.Text = "Beni Hatırla";
            this.chkBeniHatirla.UseVisualStyleBackColor = false;
            // 
            // chkPasswordHide
            // 
            this.chkPasswordHide.AutoSize = true;
            this.chkPasswordHide.BackColor = System.Drawing.Color.Transparent;
            this.chkPasswordHide.ForeColor = System.Drawing.Color.Black;
            this.chkPasswordHide.Location = new System.Drawing.Point(205, 165);
            this.chkPasswordHide.Name = "chkPasswordHide";
            this.chkPasswordHide.Size = new System.Drawing.Size(88, 17);
            this.chkPasswordHide.TabIndex = 14;
            this.chkPasswordHide.Text = "Şifreyi Göster";
            this.chkPasswordHide.UseVisualStyleBackColor = false;
            this.chkPasswordHide.CheckedChanged += new System.EventHandler(this.chkPasswordHide_CheckedChanged);
            // 
            // yardimMessageBox
            // 
            this.yardimMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.yardimMessageBox.Controls.Add(this.YardimText);
            this.yardimMessageBox.Controls.Add(this.informationText2);
            this.yardimMessageBox.Controls.Add(this.informationText1);
            this.yardimMessageBox.Controls.Add(this.yardimLight);
            this.yardimMessageBox.Location = new System.Drawing.Point(186, 385);
            this.yardimMessageBox.Name = "yardimMessageBox";
            this.yardimMessageBox.Size = new System.Drawing.Size(432, 53);
            this.yardimMessageBox.TabIndex = 13;
            this.yardimMessageBox.TabStop = false;
            this.yardimMessageBox.Visible = false;
            // 
            // YardimText
            // 
            this.YardimText.AutoSize = true;
            this.YardimText.BackColor = System.Drawing.Color.Transparent;
            this.YardimText.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.YardimText.ForeColor = System.Drawing.Color.Goldenrod;
            this.YardimText.Location = new System.Drawing.Point(335, 29);
            this.YardimText.Name = "YardimText";
            this.YardimText.Size = new System.Drawing.Size(99, 17);
            this.YardimText.TabIndex = 16;
            this.YardimText.Text = "YARDIM ALIN!";
            this.YardimText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.YardimText.Click += new System.EventHandler(this.YardimText_Click);
            // 
            // informationText2
            // 
            this.informationText2.AutoSize = true;
            this.informationText2.BackColor = System.Drawing.Color.Transparent;
            this.informationText2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.informationText2.ForeColor = System.Drawing.Color.White;
            this.informationText2.Location = new System.Drawing.Point(55, 28);
            this.informationText2.Name = "informationText2";
            this.informationText2.Size = new System.Drawing.Size(287, 19);
            this.informationText2.TabIndex = 15;
            this.informationText2.Text = "Butona tıklayarak şifrenizi sıfırlayabilirsiniz.";
            this.informationText2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // informationText1
            // 
            this.informationText1.AutoSize = true;
            this.informationText1.BackColor = System.Drawing.Color.Transparent;
            this.informationText1.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.informationText1.ForeColor = System.Drawing.Color.White;
            this.informationText1.Location = new System.Drawing.Point(64, 9);
            this.informationText1.Name = "informationText1";
            this.informationText1.Size = new System.Drawing.Size(360, 19);
            this.informationText1.TabIndex = 14;
            this.informationText1.Text = "Giriş yapmak için yardım alın veya şifrenizi sıfırlayın. ";
            this.informationText1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // yardimLight
            // 
            this.yardimLight.BackColor = System.Drawing.Color.Transparent;
            this.yardimLight.Image = global::KutuphaneOtomasyon_v2.Properties.Resources.yardim_icon_light;
            this.yardimLight.Location = new System.Drawing.Point(6, 9);
            this.yardimLight.Name = "yardimLight";
            this.yardimLight.Size = new System.Drawing.Size(43, 38);
            this.yardimLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yardimLight.TabIndex = 10;
            this.yardimLight.TabStop = false;
            // 
            // sifreText
            // 
            this.sifreText.AutoSize = true;
            this.sifreText.BackColor = System.Drawing.Color.Transparent;
            this.sifreText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreText.ForeColor = System.Drawing.Color.Black;
            this.sifreText.Location = new System.Drawing.Point(129, 89);
            this.sifreText.Name = "sifreText";
            this.sifreText.Size = new System.Drawing.Size(44, 19);
            this.sifreText.TabIndex = 12;
            this.sifreText.Text = "Şifre:";
            // 
            // messageText3
            // 
            this.messageText3.AutoSize = true;
            this.messageText3.BackColor = System.Drawing.Color.Transparent;
            this.messageText3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageText3.ForeColor = System.Drawing.Color.Black;
            this.messageText3.Location = new System.Drawing.Point(314, 20);
            this.messageText3.Name = "messageText3";
            this.messageText3.Size = new System.Drawing.Size(362, 33);
            this.messageText3.TabIndex = 11;
            this.messageText3.Text = "Kitaplarınızın Dijital Rehberi";
            // 
            // epostaText
            // 
            this.epostaText.AutoSize = true;
            this.epostaText.BackColor = System.Drawing.Color.Transparent;
            this.epostaText.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.epostaText.ForeColor = System.Drawing.Color.Black;
            this.epostaText.Location = new System.Drawing.Point(129, 56);
            this.epostaText.Name = "epostaText";
            this.epostaText.Size = new System.Drawing.Size(70, 19);
            this.epostaText.TabIndex = 10;
            this.epostaText.Text = "E-posta:";
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.ForeColor = System.Drawing.Color.Black;
            this.btnGirisYap.Location = new System.Drawing.Point(205, 131);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(207, 28);
            this.btnGirisYap.TabIndex = 9;
            this.btnGirisYap.Text = "Giriş Yap";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            this.btnGirisYap.Click += new System.EventHandler(this.btnGirisYap_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSifre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.Black;
            this.txtSifre.Location = new System.Drawing.Point(205, 89);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '•';
            this.txtSifre.Size = new System.Drawing.Size(208, 23);
            this.txtSifre.TabIndex = 8;
            this.txtSifre.Tag = "";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtKullaniciAdi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKullaniciAdi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.ForeColor = System.Drawing.Color.Black;
            this.txtKullaniciAdi.Location = new System.Drawing.Point(205, 56);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(208, 23);
            this.txtKullaniciAdi.TabIndex = 7;
            // 
            // messageText2
            // 
            this.messageText2.AutoSize = true;
            this.messageText2.BackColor = System.Drawing.Color.Transparent;
            this.messageText2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageText2.ForeColor = System.Drawing.Color.Black;
            this.messageText2.Location = new System.Drawing.Point(190, 22);
            this.messageText2.Name = "messageText2";
            this.messageText2.Size = new System.Drawing.Size(132, 32);
            this.messageText2.TabIndex = 6;
            this.messageText2.Text = "Libridigm";
            // 
            // personelDark
            // 
            this.personelDark.BackColor = System.Drawing.Color.Transparent;
            this.personelDark.Image = global::KutuphaneOtomasyon_v2.Properties.Resources.personel_icon_dark;
            this.personelDark.Location = new System.Drawing.Point(442, 11);
            this.personelDark.Name = "personelDark";
            this.personelDark.Size = new System.Drawing.Size(225, 207);
            this.personelDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personelDark.TabIndex = 3;
            this.personelDark.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.chkBeniHatirla);
            this.groupBox1.Controls.Add(this.chkPasswordHide);
            this.groupBox1.Controls.Add(this.welcomeMessageText);
            this.groupBox1.Controls.Add(this.sifreText);
            this.groupBox1.Controls.Add(this.epostaText);
            this.groupBox1.Controls.Add(this.btnGirisYap);
            this.groupBox1.Controls.Add(this.txtSifre);
            this.groupBox1.Controls.Add(this.txtKullaniciAdi);
            this.groupBox1.Controls.Add(this.personelDark);
            this.groupBox1.Location = new System.Drawing.Point(67, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(685, 211);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::KutuphaneOtomasyon_v2.Properties.Resources.bg_dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa - Libridigm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.Enter += new System.EventHandler(this.btnGirisYap_Click);
            ((System.ComponentModel.ISupportInitialize)(this.logoDark)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.yardimMessageBox.ResumeLayout(false);
            this.yardimMessageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yardimLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDark)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label messageText2;
        private System.Windows.Forms.Label welcomeMessageText;
        private System.Windows.Forms.PictureBox personelDark;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.PictureBox logoDark;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label sifreText;
        private System.Windows.Forms.Label messageText3;
        private System.Windows.Forms.Label epostaText;
        private System.Windows.Forms.PictureBox yardimLight;
        private System.Windows.Forms.GroupBox yardimMessageBox;
        private System.Windows.Forms.Label informationText1;
        private System.Windows.Forms.Label YardimText;
        private System.Windows.Forms.Label informationText2;
        private System.Windows.Forms.CheckBox chkBeniHatirla;
        private System.Windows.Forms.CheckBox chkPasswordHide;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}