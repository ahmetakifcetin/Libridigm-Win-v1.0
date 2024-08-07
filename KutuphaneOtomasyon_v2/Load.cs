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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();

            timer1 = new Timer();
            timer1.Interval = 20;
            timer1.Tick += timer1_Tick;
            timer1.Start();
        }

        private int progress = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            progress += 3;
            
            if(progress <= 100) { 
                progressBar1.Value = progress;
                loadingStatus.Text = "%" + progress;
            }
            else{
                timer1.Stop();
                this.Cursor = Cursors.Default;
                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();}
        }

        private void Load_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
        }

        private void Load_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void Load_Load(object sender, EventArgs e)
        {

        }
    }
}
