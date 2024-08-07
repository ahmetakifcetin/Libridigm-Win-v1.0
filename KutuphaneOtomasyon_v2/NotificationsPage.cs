using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon_v2
{
    public partial class NotificationsPage : Form
    {
        bool notify = false;

        public NotificationsPage()
        {
            InitializeComponent();
        }

        private void NotificationsPage_Load(object sender, EventArgs e)
        {
                notify = false;

                if (notify == true)
                {
                    notNotifyBox.Visible = false;
                    allNotifyBox.Visible = true;
                }
                else
                {
                    notNotifyBox.Visible = true;
                    allNotifyBox.Visible = false;
                }
            }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            sorunBildirText.ForeColor = Color.DarkOrange;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            sorunBildirText.ForeColor = Color.Goldenrod;
        }
    }
}
