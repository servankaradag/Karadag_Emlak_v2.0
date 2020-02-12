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
    public partial class Secim_Ekrani : Form
    {
        Karadag_Emlak KE = new Karadag_Emlak();
        public Secim_Ekrani()
        {
            InitializeComponent();
        }

        private void Secim_Ekrani_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            pcIkon.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbYukle.Increment(1);
            lbSayac.Text = "%" + pbYukle.Value.ToString();
            if (pbYukle.Value == 100)
                timer1.Stop();
            if (this.pbYukle.Value == 5)
                this.lbSayac.Text = "Sistem Başlatılıyor";
            if (this.pbYukle.Value == 25)
                this.lbSayac.Text = "Sistem Hazırlanıyor";
            if (this.pbYukle.Value == 50)
                this.lbSayac.Text = "Veri Çekiliyor";
            if (this.pbYukle.Value == 75)
                this.lbSayac.Text = "Sistem Açılıyor";
            if (this.pbYukle.Value == 99)
                this.Hide();
            if (this.pbYukle.Value == 100)
                    this.KE.Show();
        }
        }

            }