namespace KutuphaneOtomasyon_v2
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGirisYap = new System.Windows.Forms.Button();
            this.personelDark = new System.Windows.Forms.PictureBox();
            this.welcomeMessageText = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.okumaHedefGosterge = new CircularProgressBar.CircularProgressBar();
            this.bildirimMessageBox = new System.Windows.Forms.GroupBox();
            this.CikisYapText = new System.Windows.Forms.Label();
            this.informationText2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.uyeDark = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kitapSayfaVeri = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bitirilenKitapVeri = new System.Windows.Forms.Label();
            this.bitirilenKitapGosterge = new CircularProgressBar.CircularProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.okumaHedefVeri = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.messageText3 = new System.Windows.Forms.Label();
            this.messageText2 = new System.Windows.Forms.Label();
            this.okunanKitapVeri = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDark)).BeginInit();
            this.panel2.SuspendLayout();
            this.bildirimMessageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyeDark)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnGirisYap);
            this.panel1.Controls.Add(this.personelDark);
            this.panel1.Controls.Add(this.welcomeMessageText);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 458);
            this.panel1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.Location = new System.Drawing.Point(3, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(184, 54);
            this.button4.TabIndex = 14;
            this.button4.Text = "Bildirimlerim";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(2, 372);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(184, 54);
            this.button3.TabIndex = 13;
            this.button3.Text = "Geçmiş";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(0, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 48);
            this.button2.TabIndex = 12;
            this.button2.Text = "Profilim";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGirisYap
            // 
            this.btnGirisYap.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGirisYap.Location = new System.Drawing.Point(2, 314);
            this.btnGirisYap.Name = "btnGirisYap";
            this.btnGirisYap.Size = new System.Drawing.Size(184, 54);
            this.btnGirisYap.TabIndex = 10;
            this.btnGirisYap.Text = "Kitaplarım";
            this.btnGirisYap.UseVisualStyleBackColor = true;
            // 
            // personelDark
            // 
            this.personelDark.BackColor = System.Drawing.Color.Transparent;
            this.personelDark.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personelDark.Image = global::KutuphaneOtomasyon_v2.Properties.Resources.personel_icon_dark;
            this.personelDark.Location = new System.Drawing.Point(34, 24);
            this.personelDark.Name = "personelDark";
            this.personelDark.Size = new System.Drawing.Size(122, 118);
            this.personelDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personelDark.TabIndex = 6;
            this.personelDark.TabStop = false;
            // 
            // welcomeMessageText
            // 
            this.welcomeMessageText.AutoSize = true;
            this.welcomeMessageText.BackColor = System.Drawing.Color.Transparent;
            this.welcomeMessageText.Font = new System.Drawing.Font("Century Gothic", 15.25F, System.Drawing.FontStyle.Bold);
            this.welcomeMessageText.ForeColor = System.Drawing.Color.Black;
            this.welcomeMessageText.Location = new System.Drawing.Point(11, 153);
            this.welcomeMessageText.Name = "welcomeMessageText";
            this.welcomeMessageText.Size = new System.Drawing.Size(173, 25);
            this.welcomeMessageText.TabIndex = 5;
            this.welcomeMessageText.Text = "Gösterge Paneli";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::KutuphaneOtomasyon_v2.Properties.Resources.bg_flat_light;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.okumaHedefGosterge);
            this.panel2.Controls.Add(this.bildirimMessageBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.kitapSayfaVeri);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.bitirilenKitapVeri);
            this.panel2.Controls.Add(this.bitirilenKitapGosterge);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.okumaHedefVeri);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.messageText3);
            this.panel2.Controls.Add(this.messageText2);
            this.panel2.Controls.Add(this.okunanKitapVeri);
            this.panel2.Location = new System.Drawing.Point(189, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 458);
            this.panel2.TabIndex = 10;
            // 
            // okumaHedefGosterge
            // 
            this.okumaHedefGosterge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.okumaHedefGosterge.AnimationSpeed = 500;
            this.okumaHedefGosterge.BackColor = System.Drawing.Color.Transparent;
            this.okumaHedefGosterge.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okumaHedefGosterge.ForeColor = System.Drawing.Color.Black;
            this.okumaHedefGosterge.InnerColor = System.Drawing.Color.White;
            this.okumaHedefGosterge.InnerMargin = 2;
            this.okumaHedefGosterge.InnerWidth = -1;
            this.okumaHedefGosterge.Location = new System.Drawing.Point(59, 72);
            this.okumaHedefGosterge.MarqueeAnimationSpeed = 2000;
            this.okumaHedefGosterge.Name = "okumaHedefGosterge";
            this.okumaHedefGosterge.OuterColor = System.Drawing.Color.White;
            this.okumaHedefGosterge.OuterMargin = -25;
            this.okumaHedefGosterge.OuterWidth = 30;
            this.okumaHedefGosterge.ProgressColor = System.Drawing.Color.Goldenrod;
            this.okumaHedefGosterge.ProgressWidth = 15;
            this.okumaHedefGosterge.SecondaryFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.okumaHedefGosterge.Size = new System.Drawing.Size(217, 216);
            this.okumaHedefGosterge.StartAngle = 270;
            this.okumaHedefGosterge.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.okumaHedefGosterge.SubscriptColor = System.Drawing.Color.White;
            this.okumaHedefGosterge.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.okumaHedefGosterge.SubscriptText = "";
            this.okumaHedefGosterge.SuperscriptColor = System.Drawing.Color.White;
            this.okumaHedefGosterge.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.okumaHedefGosterge.SuperscriptText = "%";
            this.okumaHedefGosterge.TabIndex = 27;
            this.okumaHedefGosterge.Text = "20";
            this.okumaHedefGosterge.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.okumaHedefGosterge.Value = 68;
            // 
            // bildirimMessageBox
            // 
            this.bildirimMessageBox.BackColor = System.Drawing.Color.Transparent;
            this.bildirimMessageBox.Controls.Add(this.CikisYapText);
            this.bildirimMessageBox.Controls.Add(this.informationText2);
            this.bildirimMessageBox.Controls.Add(this.label8);
            this.bildirimMessageBox.Controls.Add(this.uyeDark);
            this.bildirimMessageBox.ForeColor = System.Drawing.Color.Black;
            this.bildirimMessageBox.Location = new System.Drawing.Point(134, 388);
            this.bildirimMessageBox.Name = "bildirimMessageBox";
            this.bildirimMessageBox.Size = new System.Drawing.Size(437, 53);
            this.bildirimMessageBox.TabIndex = 26;
            this.bildirimMessageBox.TabStop = false;
            this.bildirimMessageBox.Visible = false;
            // 
            // CikisYapText
            // 
            this.CikisYapText.AutoSize = true;
            this.CikisYapText.BackColor = System.Drawing.Color.Transparent;
            this.CikisYapText.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.CikisYapText.ForeColor = System.Drawing.Color.Goldenrod;
            this.CikisYapText.Location = new System.Drawing.Point(353, 30);
            this.CikisYapText.Name = "CikisYapText";
            this.CikisYapText.Size = new System.Drawing.Size(77, 17);
            this.CikisYapText.TabIndex = 16;
            this.CikisYapText.Text = "ÇIKIŞ YAP.";
            this.CikisYapText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // informationText2
            // 
            this.informationText2.AutoSize = true;
            this.informationText2.BackColor = System.Drawing.Color.Transparent;
            this.informationText2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.informationText2.ForeColor = System.Drawing.Color.Black;
            this.informationText2.Location = new System.Drawing.Point(55, 29);
            this.informationText2.Name = "informationText2";
            this.informationText2.Size = new System.Drawing.Size(297, 19);
            this.informationText2.TabIndex = 15;
            this.informationText2.Text = "Eğer güncellenmiyorsa yeniden giriş yapın";
            this.informationText2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(67, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(324, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Göstergelerin çalışması için okumaya başlayın";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // uyeDark
            // 
            this.uyeDark.BackColor = System.Drawing.Color.Transparent;
            this.uyeDark.Image = global::KutuphaneOtomasyon_v2.Properties.Resources.uye_icon_dark;
            this.uyeDark.Location = new System.Drawing.Point(6, 9);
            this.uyeDark.Name = "uyeDark";
            this.uyeDark.Size = new System.Drawing.Size(43, 38);
            this.uyeDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.uyeDark.TabIndex = 10;
            this.uyeDark.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(429, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kitap sayfa toplamı:";
            // 
            // kitapSayfaVeri
            // 
            this.kitapSayfaVeri.AutoSize = true;
            this.kitapSayfaVeri.BackColor = System.Drawing.Color.Transparent;
            this.kitapSayfaVeri.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.kitapSayfaVeri.ForeColor = System.Drawing.Color.Black;
            this.kitapSayfaVeri.Location = new System.Drawing.Point(631, 357);
            this.kitapSayfaVeri.Name = "kitapSayfaVeri";
            this.kitapSayfaVeri.Size = new System.Drawing.Size(17, 19);
            this.kitapSayfaVeri.TabIndex = 24;
            this.kitapSayfaVeri.Text = "0";
            this.kitapSayfaVeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(429, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Bitirilen kitap sayısı:";
            // 
            // bitirilenKitapVeri
            // 
            this.bitirilenKitapVeri.AutoSize = true;
            this.bitirilenKitapVeri.BackColor = System.Drawing.Color.Transparent;
            this.bitirilenKitapVeri.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.bitirilenKitapVeri.ForeColor = System.Drawing.Color.Black;
            this.bitirilenKitapVeri.Location = new System.Drawing.Point(631, 328);
            this.bitirilenKitapVeri.Name = "bitirilenKitapVeri";
            this.bitirilenKitapVeri.Size = new System.Drawing.Size(17, 19);
            this.bitirilenKitapVeri.TabIndex = 22;
            this.bitirilenKitapVeri.Text = "0";
            this.bitirilenKitapVeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bitirilenKitapGosterge
            // 
            this.bitirilenKitapGosterge.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.bitirilenKitapGosterge.AnimationSpeed = 500;
            this.bitirilenKitapGosterge.BackColor = System.Drawing.Color.Transparent;
            this.bitirilenKitapGosterge.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitirilenKitapGosterge.ForeColor = System.Drawing.Color.Black;
            this.bitirilenKitapGosterge.InnerColor = System.Drawing.Color.White;
            this.bitirilenKitapGosterge.InnerMargin = 2;
            this.bitirilenKitapGosterge.InnerWidth = -1;
            this.bitirilenKitapGosterge.Location = new System.Drawing.Point(431, 72);
            this.bitirilenKitapGosterge.MarqueeAnimationSpeed = 2000;
            this.bitirilenKitapGosterge.Name = "bitirilenKitapGosterge";
            this.bitirilenKitapGosterge.OuterColor = System.Drawing.Color.White;
            this.bitirilenKitapGosterge.OuterMargin = -25;
            this.bitirilenKitapGosterge.OuterWidth = 30;
            this.bitirilenKitapGosterge.ProgressColor = System.Drawing.Color.Goldenrod;
            this.bitirilenKitapGosterge.ProgressWidth = 15;
            this.bitirilenKitapGosterge.SecondaryFont = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bitirilenKitapGosterge.Size = new System.Drawing.Size(217, 216);
            this.bitirilenKitapGosterge.StartAngle = 270;
            this.bitirilenKitapGosterge.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.bitirilenKitapGosterge.SubscriptColor = System.Drawing.Color.White;
            this.bitirilenKitapGosterge.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.bitirilenKitapGosterge.SubscriptText = "";
            this.bitirilenKitapGosterge.SuperscriptColor = System.Drawing.Color.White;
            this.bitirilenKitapGosterge.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.bitirilenKitapGosterge.SuperscriptText = "%";
            this.bitirilenKitapGosterge.TabIndex = 0;
            this.bitirilenKitapGosterge.Text = "20";
            this.bitirilenKitapGosterge.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.bitirilenKitapGosterge.Value = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(55, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 19);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kitap okuma hedefi:";
            // 
            // okumaHedefVeri
            // 
            this.okumaHedefVeri.AutoSize = true;
            this.okumaHedefVeri.BackColor = System.Drawing.Color.Transparent;
            this.okumaHedefVeri.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.okumaHedefVeri.ForeColor = System.Drawing.Color.Black;
            this.okumaHedefVeri.Location = new System.Drawing.Point(237, 357);
            this.okumaHedefVeri.Name = "okumaHedefVeri";
            this.okumaHedefVeri.Size = new System.Drawing.Size(17, 19);
            this.okumaHedefVeri.TabIndex = 19;
            this.okumaHedefVeri.Text = "0";
            this.okumaHedefVeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(56, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Okunan kitap sayısı:";
            // 
            // messageText3
            // 
            this.messageText3.AutoSize = true;
            this.messageText3.BackColor = System.Drawing.Color.Transparent;
            this.messageText3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageText3.ForeColor = System.Drawing.Color.Black;
            this.messageText3.Location = new System.Drawing.Point(254, 15);
            this.messageText3.Name = "messageText3";
            this.messageText3.Size = new System.Drawing.Size(362, 33);
            this.messageText3.TabIndex = 16;
            this.messageText3.Text = "Kitaplarınızın Dijital Rehberi";
            // 
            // messageText2
            // 
            this.messageText2.AutoSize = true;
            this.messageText2.BackColor = System.Drawing.Color.Transparent;
            this.messageText2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageText2.ForeColor = System.Drawing.Color.Black;
            this.messageText2.Location = new System.Drawing.Point(128, 15);
            this.messageText2.Name = "messageText2";
            this.messageText2.Size = new System.Drawing.Size(132, 32);
            this.messageText2.TabIndex = 15;
            this.messageText2.Text = "Libridigm";
            // 
            // okunanKitapVeri
            // 
            this.okunanKitapVeri.AutoSize = true;
            this.okunanKitapVeri.BackColor = System.Drawing.Color.Transparent;
            this.okunanKitapVeri.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.okunanKitapVeri.ForeColor = System.Drawing.Color.Black;
            this.okunanKitapVeri.Location = new System.Drawing.Point(236, 329);
            this.okunanKitapVeri.Name = "okunanKitapVeri";
            this.okunanKitapVeri.Size = new System.Drawing.Size(17, 19);
            this.okunanKitapVeri.TabIndex = 17;
            this.okunanKitapVeri.Text = "0";
            this.okunanKitapVeri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KutuphaneOtomasyon_v2.Properties.Resources.bg_flat_dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelDark)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.bildirimMessageBox.ResumeLayout(false);
            this.bildirimMessageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uyeDark)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label welcomeMessageText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox personelDark;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnGirisYap;
        private System.Windows.Forms.Label messageText3;
        private System.Windows.Forms.Label messageText2;
        private System.Windows.Forms.Label okunanKitapVeri;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label kitapSayfaVeri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label bitirilenKitapVeri;
        private CircularProgressBar.CircularProgressBar bitirilenKitapGosterge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label okumaHedefVeri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox bildirimMessageBox;
        private System.Windows.Forms.Label CikisYapText;
        private System.Windows.Forms.Label informationText2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox uyeDark;
        private CircularProgressBar.CircularProgressBar okumaHedefGosterge;
    }
}