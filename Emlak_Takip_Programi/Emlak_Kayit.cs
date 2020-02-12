using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Emlak_Takip_Programi
{
    public partial class Emlak_Kayit : Form
    {
        public Emlak_Kayit()
        {
            InitializeComponent();
        }

        private void Emlak_Kayit_Load(object sender, EventArgs e)
        {
            this.Width = 424;
            DataTable dt = vt.dtGetir("Select * from emlaklar");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dgEmlak.Rows.Add(dt.Rows[i]["emlakNo"].ToString(), dt.Rows[i]["emlakbicimi"].ToString(), dt.Rows[i]["kacıncıkat"].ToString(), dt.Rows[i]["adres"].ToString());
            }
        }

        private void btnGozat_Click(object sender, EventArgs e)
        {
            this.Width = 890;
        }

        private void dgEmlak_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtEmlakNo.Text = dgEmlak.CurrentRow.Cells[0].Value.ToString();
            txtEmlakBi.Text = dgEmlak.CurrentRow.Cells[1].Value.ToString();
            txtKacKat.Text = dgEmlak.CurrentRow.Cells[2].Value.ToString();
            txtAdres.Text = dgEmlak.CurrentRow.Cells[3].Value.ToString();
            this.Width = 424;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
            Karadag_Emlak ke3 = new Karadag_Emlak();
            ke3.Show();
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int gun = dtTarih.Value.Day;
            int ay = dtTarih.Value.Month;
            int yil = dtTarih.Value.Year;
            int emlakNo = Convert.ToInt32(txtEmlakNo.Text);
            double ucret = Convert.ToDouble(txtUcret.Text);

            vt.sqlCalistir("insert into kayitlar (baslik,aciklama,kayGun,kayAy,kayYil,emlakNo,teklifler) values ('" + txtMulkSahibi.Text + "','" + txtAciklama.Text + "'," + gun + "," + ay + "," + yil + "," + emlakNo + "," + ucret + ")");
            if (txtTeklif.Text != "")
            {
                double odenen = Convert.ToDouble(txtTeklif.Text);
                vt.sqlCalistir("insert into odemeler (odemeGun,odemeAy,odemeYil,odenen,emlakNo) values (" + gun + "," + ay + "," + yil + "," + odenen + "," + emlakNo + ")");
            }
            MessageBox.Show("Emlak kaydı yapılmıştır", "İşlem tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnYeniEmlak_Click(object sender, EventArgs e)
        {
            Yeni_Emlak Ye = new Yeni_Emlak();
            Ye.MdiParent = this.ParentForm;
            Ye.Show();
        }

        private void mstKE_Click(object sender, EventArgs e)
        {
            Karadag_Emlak Ke = new Karadag_Emlak();
            Ke.Show();
            this.Hide();
        }
        }
        }
