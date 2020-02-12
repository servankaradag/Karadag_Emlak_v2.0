using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Takip_Programi
{
    public partial class Karadag_Emlak : Form
    {
        public Karadag_Emlak()
        {
            {
                InitializeComponent();
            }
        }

        private void btnEmlak_MouseMove(object sender, MouseEventArgs e)
        {
            btnEmlak.BackColor = Color.Red;
        
        }

        private void btnEmlak_Click(object sender, EventArgs e)
        {
            Emlak_Kayit frmEk = new Emlak_Kayit();
            frmEk.Show();
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mstKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mstEmlak_Click(object sender, EventArgs e)
        {
            Emlak_Kayit frmEk = new Emlak_Kayit();
            frmEk.Show();
            this.Hide();
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Show();
            this.Hide();
        }

        private void mstMusteri_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.Show();
            this.Hide();
        }

        private void mstAra_Click(object sender, EventArgs e)
        {
            Musteri m1 = new Musteri();
            m1.Show();
            this.Hide();
        }

        private void btnHakkında_Click(object sender, EventArgs e)
        {
            Hakkinda h = new Hakkinda();
            h.Show();
        }

        private void mstHakkindaa_Click(object sender, EventArgs e)
        {
            Hakkinda h1 = new Hakkinda();
            h1.Show();
        }

        private void mstHakkinda_Click(object sender, EventArgs e)
        {
            Hakkinda h2 = new Hakkinda();
            h2.Show();
        }

        private void mstSiteyeGit_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.servankaradag.blogspot.com");
        }
        }
        }

