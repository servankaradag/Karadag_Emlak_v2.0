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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }


        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Karadag_Emlak Ke1 = new Karadag_Emlak();
            Ke1.Show();
            this.Hide();
        }

        private void btnAnasayfa2_Click(object sender, EventArgs e)
        {
            Karadag_Emlak Ke2 = new Karadag_Emlak();
            Ke2.Show();
            this.Hide();
        }

        private void Musteri_Load(object sender, EventArgs e)
        {
            DataTable dt = vt.dtGetir("select * from emlaklar");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgEmlak.Rows.Add(dt.Rows[i]["emlakNo"].ToString(), dt.Rows[i]["emlakbicimi"].ToString(), dt.Rows[i]["kacıncıkat"].ToString(), dt.Rows[i]["adres"].ToString(), Image.FromFile(Application.StartupPath + "/Resimler/" + dt.Rows[i]["resimYol"].ToString()));
            }
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = vt.dtGetir("select * from emlaklar where  emlakbicimi like'" + txtAra.Text + "%' or adres like'" + txtAra.Text + "%' or kacıncıkat like'" + txtAra.Text + "%' order by emlakbicimi");
            dgEmlak.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgEmlak.Rows.Add(dt.Rows[i]["emlakNo"].ToString(), dt.Rows[i]["emlakbicimi"].ToString(), dt.Rows[i]["kacıncıkat"].ToString(), dt.Rows[i]["adres"].ToString());
            }
        }

        }
        }
