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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            int okumaHedef = 50;
            int bitirilenKitap = 30;
            int okunanKitap = 25;
            int kitapSayfa = 300;

            bitirilenKitapGosterge.Value = bitirilenKitap;
            bitirilenKitapGosterge.Maximum = okumaHedef;

            okumaHedefGosterge.Value = okunanKitap;
            okumaHedefGosterge.Maximum = okumaHedef;

            okumaHedefVeri.Text = okumaHedef.ToString();
            bitirilenKitapVeri.Text = bitirilenKitap.ToString();
            okunanKitapVeri.Text = okunanKitap.ToString();
            kitapSayfaVeri.Text = kitapSayfa.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NotificationsPage bildirimPaneli = new NotificationsPage();
            bildirimPaneli.Show();
        }
    }
}
