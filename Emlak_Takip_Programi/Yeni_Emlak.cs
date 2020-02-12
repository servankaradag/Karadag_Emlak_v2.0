using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Emlak_Takip_Programi
{
    public partial class Yeni_Emlak : Form
    {
        public Yeni_Emlak()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtEmlakBicimi.Text == "" || txtKacıncıKat.Text == "" || txtAdres.Text == "")
            {
                MessageBox.Show("Bütün alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pbFoto.Image == null)
            {
                MessageBox.Show("Lütfen Resim Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string uzanti = Path.GetExtension(openFileDialog1.FileName);
            string dosyaAdi = string.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + uzanti;
            pbFoto.Image.Save(Application.StartupPath + "/Resimler/" + dosyaAdi);

            vt.sqlCalistir("insert into emlaklar (emlakbicimi,kacıncıkat,adres,resimYol) values ('" + txtEmlakBicimi.Text + "','" + txtKacıncıKat.Text + "','" + txtAdres.Text + "','" + dosyaAdi + "')");
            MessageBox.Show("Emlak Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtEmlakBicimi.Clear();
            txtKacıncıKat.Clear();
            txtAdres.Clear();

            kayitGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Dosyaları|*.jpg|PNG Dosyaları|*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            pbFoto.Image = Image.FromFile(openFileDialog1.FileName);

        }

        private void btnKayıtSil_Click(object sender, EventArgs e)
        {
            int emlakNo = Convert.ToInt32(dgKayitlar.CurrentRow.Cells[0].Value.ToString());

            DataTable dt = vt.dtGetir("select * from emlaklar where emlakNo=" + emlakNo);
            string resimYol = dt.Rows[0]["resimYol"].ToString();

            if (File.Exists(Application.StartupPath + "/Resimler/" + resimYol))
            {
                File.Delete(Application.StartupPath + "/Resimler/" + resimYol);
            }
            vt.sqlCalistir("delete from emlaklar where emlakNo=" + emlakNo);
            MessageBox.Show("Emlak Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            kayitGetir();

        }

        private void Yeni_Emlak_Load(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void kayitGetir()
        {
            DataTable dt = vt.dtGetir("Select * from emlaklar");
            dgKayitlar.Rows.Clear();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgKayitlar.Rows.Add(dt.Rows[i]["emlakNo"].ToString(), dt.Rows[i]["emlakbicimi"].ToString(), dt.Rows[i]["kacıncıkat"].ToString(), dt.Rows[i]["adres"].ToString(), Image.FromFile(Application.StartupPath + "/Resimler/" + dt.Rows[i]["resimYol"].ToString()));
            }
        }
    }
}
