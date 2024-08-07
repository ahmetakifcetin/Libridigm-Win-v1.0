namespace KutuphaneOtomasyon_v2
{
    partial class MyBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyBooks));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bitirdigimKitaplartbl = new System.Windows.Forms.DataGridView();
            this.messageText3 = new System.Windows.Forms.Label();
            this.aldigimKitaplartbl = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitirdigimKitaplartbl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aldigimKitaplartbl)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(0, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(0, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "Hedef Belirle";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(0, 156);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Kitap Ekle";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::KutuphaneOtomasyon_v2.Properties.Resources.bg_flat_light;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bitirdigimKitaplartbl);
            this.panel2.Controls.Add(this.messageText3);
            this.panel2.Controls.Add(this.aldigimKitaplartbl);
            this.panel2.Location = new System.Drawing.Point(201, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 450);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(193, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 33);
            this.label1.TabIndex = 19;
            this.label1.Text = "Bitirdiğim Kitaplar";
            // 
            // bitirdigimKitaplartbl
            // 
            this.bitirdigimKitaplartbl.BackgroundColor = System.Drawing.Color.White;
            this.bitirdigimKitaplartbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bitirdigimKitaplartbl.GridColor = System.Drawing.Color.White;
            this.bitirdigimKitaplartbl.Location = new System.Drawing.Point(0, 272);
            this.bitirdigimKitaplartbl.Name = "bitirdigimKitaplartbl";
            this.bitirdigimKitaplartbl.Size = new System.Drawing.Size(600, 150);
            this.bitirdigimKitaplartbl.TabIndex = 18;
            // 
            // messageText3
            // 
            this.messageText3.AutoSize = true;
            this.messageText3.BackColor = System.Drawing.Color.Transparent;
            this.messageText3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageText3.ForeColor = System.Drawing.Color.Black;
            this.messageText3.Location = new System.Drawing.Point(193, 8);
            this.messageText3.Name = "messageText3";
            this.messageText3.Size = new System.Drawing.Size(222, 33);
            this.messageText3.TabIndex = 17;
            this.messageText3.Text = "Aldığım Kitaplar";
            // 
            // aldigimKitaplartbl
            // 
            this.aldigimKitaplartbl.BackgroundColor = System.Drawing.Color.White;
            this.aldigimKitaplartbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aldigimKitaplartbl.GridColor = System.Drawing.Color.White;
            this.aldigimKitaplartbl.Location = new System.Drawing.Point(0, 51);
            this.aldigimKitaplartbl.Name = "aldigimKitaplartbl";
            this.aldigimKitaplartbl.Size = new System.Drawing.Size(600, 150);
            this.aldigimKitaplartbl.TabIndex = 0;
            // 
            // MyBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyon_v2.Properties.Resources.bg_flat_light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MyBooks";
            this.Text = "Kitaplarim - Libridigm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bitirdigimKitaplartbl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aldigimKitaplartbl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView aldigimKitaplartbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView bitirdigimKitaplartbl;
        private System.Windows.Forms.Label messageText3;
    }
}