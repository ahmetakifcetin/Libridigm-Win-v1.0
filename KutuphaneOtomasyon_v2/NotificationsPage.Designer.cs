namespace KutuphaneOtomasyon_v2
{
    partial class NotificationsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotificationsPage));
            this.allNotifyBox = new System.Windows.Forms.GroupBox();
            this.messageText3 = new System.Windows.Forms.Label();
            this.messageText2 = new System.Windows.Forms.Label();
            this.notNotifyBox = new System.Windows.Forms.GroupBox();
            this.sorun1Text = new System.Windows.Forms.Label();
            this.sorun2Text = new System.Windows.Forms.Label();
            this.sorunBildirText = new System.Windows.Forms.Label();
            this.notNotifyBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // allNotifyBox
            // 
            this.allNotifyBox.BackColor = System.Drawing.Color.Transparent;
            this.allNotifyBox.Location = new System.Drawing.Point(47, 17);
            this.allNotifyBox.Name = "allNotifyBox";
            this.allNotifyBox.Size = new System.Drawing.Size(698, 79);
            this.allNotifyBox.TabIndex = 0;
            this.allNotifyBox.TabStop = false;
            this.allNotifyBox.Visible = false;
            // 
            // messageText3
            // 
            this.messageText3.AutoSize = true;
            this.messageText3.BackColor = System.Drawing.Color.Transparent;
            this.messageText3.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageText3.ForeColor = System.Drawing.Color.White;
            this.messageText3.Location = new System.Drawing.Point(299, 397);
            this.messageText3.Name = "messageText3";
            this.messageText3.Size = new System.Drawing.Size(362, 33);
            this.messageText3.TabIndex = 20;
            this.messageText3.Text = "Kitaplarınızın Dijital Rehberi";
            // 
            // messageText2
            // 
            this.messageText2.AutoSize = true;
            this.messageText2.BackColor = System.Drawing.Color.Transparent;
            this.messageText2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageText2.ForeColor = System.Drawing.Color.White;
            this.messageText2.Location = new System.Drawing.Point(175, 398);
            this.messageText2.Name = "messageText2";
            this.messageText2.Size = new System.Drawing.Size(132, 32);
            this.messageText2.TabIndex = 18;
            this.messageText2.Text = "Libridigm";
            // 
            // notNotifyBox
            // 
            this.notNotifyBox.BackColor = System.Drawing.Color.Transparent;
            this.notNotifyBox.Controls.Add(this.sorun1Text);
            this.notNotifyBox.Controls.Add(this.sorun2Text);
            this.notNotifyBox.Controls.Add(this.sorunBildirText);
            this.notNotifyBox.Location = new System.Drawing.Point(47, 13);
            this.notNotifyBox.Name = "notNotifyBox";
            this.notNotifyBox.Size = new System.Drawing.Size(698, 79);
            this.notNotifyBox.TabIndex = 22;
            this.notNotifyBox.TabStop = false;
            this.notNotifyBox.Visible = false;
            // 
            // sorun1Text
            // 
            this.sorun1Text.AutoSize = true;
            this.sorun1Text.BackColor = System.Drawing.Color.Transparent;
            this.sorun1Text.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.sorun1Text.ForeColor = System.Drawing.Color.Black;
            this.sorun1Text.Location = new System.Drawing.Point(243, 21);
            this.sorun1Text.Name = "sorun1Text";
            this.sorun1Text.Size = new System.Drawing.Size(221, 19);
            this.sorun1Text.TabIndex = 17;
            this.sorun1Text.Text = "Herhangi bir bildirim almadınız.";
            this.sorun1Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sorun2Text
            // 
            this.sorun2Text.AutoSize = true;
            this.sorun2Text.BackColor = System.Drawing.Color.Transparent;
            this.sorun2Text.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.sorun2Text.ForeColor = System.Drawing.Color.Black;
            this.sorun2Text.Location = new System.Drawing.Point(131, 40);
            this.sorun2Text.Name = "sorun2Text";
            this.sorun2Text.Size = new System.Drawing.Size(280, 19);
            this.sorun2Text.TabIndex = 19;
            this.sorun2Text.Text = "Eğer bir sorun olduğunu düşünüyorsanız";
            this.sorun2Text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // sorunBildirText
            // 
            this.sorunBildirText.AutoSize = true;
            this.sorunBildirText.BackColor = System.Drawing.Color.Transparent;
            this.sorunBildirText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sorunBildirText.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.sorunBildirText.ForeColor = System.Drawing.Color.Goldenrod;
            this.sorunBildirText.Location = new System.Drawing.Point(409, 42);
            this.sorunBildirText.Name = "sorunBildirText";
            this.sorunBildirText.Size = new System.Drawing.Size(102, 17);
            this.sorunBildirText.TabIndex = 21;
            this.sorunBildirText.Text = "SORUN BİLDİR.";
            this.sorunBildirText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sorunBildirText.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.sorunBildirText.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // NotificationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KutuphaneOtomasyon_v2.Properties.Resources.bg_light;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.messageText3);
            this.Controls.Add(this.messageText2);
            this.Controls.Add(this.allNotifyBox);
            this.Controls.Add(this.notNotifyBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NotificationsPage";
            this.Text = "Bildirimler";
            this.Load += new System.EventHandler(this.NotificationsPage_Load);
            this.notNotifyBox.ResumeLayout(false);
            this.notNotifyBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox allNotifyBox;
        private System.Windows.Forms.Label messageText3;
        private System.Windows.Forms.Label messageText2;
        private System.Windows.Forms.GroupBox notNotifyBox;
        private System.Windows.Forms.Label sorun1Text;
        private System.Windows.Forms.Label sorun2Text;
        private System.Windows.Forms.Label sorunBildirText;
    }
}