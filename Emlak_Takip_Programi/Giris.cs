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
    public partial class Giris : Form
    {
        Secim_Ekrani frm = new Secim_Ekrani();
        Sifrenizimi_Unuttunuz frm2 = new Sifrenizimi_Unuttunuz();
        Karadag_Emlak frmEk = new Karadag_Emlak();
        private int zaman;
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            zaman = 1000; 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            lbSayi.Text = zaman.ToString();
            if (zaman == 0)
                Application.Exit();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string sifre;
            sifre = txtGiris.Text;
            if (sifre == "123")
                frm.Show();
            else
                MessageBox.Show("Hatalı Giriş Yaptınız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Hide();
            return;
        }

        private void lbSifremiUnuttum_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        }

        }
