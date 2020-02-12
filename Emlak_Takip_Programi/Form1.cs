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
    public partial class Emlak : Form
    {
        Giris frm = new Giris();
        private int zaman;
        public Emlak()
        {
            InitializeComponent();
        }

        private void Emlak_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            zaman = 1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman--;
            lbOtomatik.Text = zaman.ToString();
            if (zaman == 0)
                frm.Show();
            this.Hide();
        }

      
    }
}
