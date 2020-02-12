namespace Emlak_Takip_Programi
{
    partial class Emlak_Kayit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emlak_Kayit));
            this.btnYeniEmlak = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dgEmlak = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnGozat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTeklif = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.txtKacKat = new System.Windows.Forms.TextBox();
            this.txtMulkSahibi = new System.Windows.Forms.TextBox();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.txtEmlakBi = new System.Windows.Forms.TextBox();
            this.txtEmlakNo = new System.Windows.Forms.TextBox();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mstKE = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmlak)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnYeniEmlak
            // 
            this.btnYeniEmlak.BackColor = System.Drawing.Color.Lime;
            this.btnYeniEmlak.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniEmlak.Location = new System.Drawing.Point(731, 38);
            this.btnYeniEmlak.Name = "btnYeniEmlak";
            this.btnYeniEmlak.Size = new System.Drawing.Size(111, 24);
            this.btnYeniEmlak.TabIndex = 31;
            this.btnYeniEmlak.Text = "Yeni Emlak";
            this.btnYeniEmlak.UseVisualStyleBackColor = false;
            this.btnYeniEmlak.Click += new System.EventHandler(this.btnYeniEmlak_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(173, 360);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 100);
            this.txtAciklama.TabIndex = 25;
            // 
            // dgEmlak
            // 
            this.dgEmlak.AllowUserToAddRows = false;
            this.dgEmlak.AllowUserToDeleteRows = false;
            this.dgEmlak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmlak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgEmlak.Location = new System.Drawing.Point(437, 68);
            this.dgEmlak.Name = "dgEmlak";
            this.dgEmlak.ReadOnly = true;
            this.dgEmlak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmlak.Size = new System.Drawing.Size(405, 433);
            this.dgEmlak.TabIndex = 32;
            this.dgEmlak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEmlak_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "E.No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Emlak Biçimi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Kaçıncı Kat";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Adres";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Location = new System.Drawing.Point(312, 71);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(61, 33);
            this.btnTemizle.TabIndex = 30;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(279, 503);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 41);
            this.btnKapat.TabIndex = 29;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnGozat
            // 
            this.btnGozat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGozat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGozat.Location = new System.Drawing.Point(240, 71);
            this.btnGozat.Name = "btnGozat";
            this.btnGozat.Size = new System.Drawing.Size(66, 33);
            this.btnGozat.TabIndex = 28;
            this.btnGozat.Text = "Gözat";
            this.btnGozat.UseVisualStyleBackColor = false;
            this.btnGozat.Click += new System.EventHandler(this.btnGozat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Lime;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(173, 503);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 41);
            this.btnKaydet.TabIndex = 27;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Enabled = false;
            this.txtAdres.Location = new System.Drawing.Point(173, 180);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(200, 100);
            this.txtAdres.TabIndex = 24;
            // 
            // txtTeklif
            // 
            this.txtTeklif.Location = new System.Drawing.Point(173, 475);
            this.txtTeklif.Name = "txtTeklif";
            this.txtTeklif.Size = new System.Drawing.Size(167, 20);
            this.txtTeklif.TabIndex = 23;
            // 
            // txtUcret
            // 
            this.txtUcret.Location = new System.Drawing.Point(173, 327);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(167, 20);
            this.txtUcret.TabIndex = 22;
            // 
            // txtKacKat
            // 
            this.txtKacKat.Enabled = false;
            this.txtKacKat.Location = new System.Drawing.Point(173, 147);
            this.txtKacKat.Name = "txtKacKat";
            this.txtKacKat.Size = new System.Drawing.Size(100, 20);
            this.txtKacKat.TabIndex = 21;
            // 
            // txtMulkSahibi
            // 
            this.txtMulkSahibi.Location = new System.Drawing.Point(173, 295);
            this.txtMulkSahibi.Name = "txtMulkSahibi";
            this.txtMulkSahibi.Size = new System.Drawing.Size(200, 20);
            this.txtMulkSahibi.TabIndex = 20;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(555, 40);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(170, 20);
            this.txtAra.TabIndex = 26;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // txtEmlakBi
            // 
            this.txtEmlakBi.Enabled = false;
            this.txtEmlakBi.Location = new System.Drawing.Point(173, 115);
            this.txtEmlakBi.Name = "txtEmlakBi";
            this.txtEmlakBi.Size = new System.Drawing.Size(200, 20);
            this.txtEmlakBi.TabIndex = 19;
            // 
            // txtEmlakNo
            // 
            this.txtEmlakNo.Enabled = false;
            this.txtEmlakNo.Location = new System.Drawing.Point(173, 79);
            this.txtEmlakNo.Name = "txtEmlakNo";
            this.txtEmlakNo.Size = new System.Drawing.Size(61, 20);
            this.txtEmlakNo.TabIndex = 18;
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(173, 41);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 20);
            this.dtTarih.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(10, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Açıklama:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(346, 476);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(346, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(10, 476);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Teklifler:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(10, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fiyatı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(10, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(10, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mülk Sahibi:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(10, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kaçıncı Kat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(10, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Emlak Biçimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Emlak No:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(434, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "Emlak Arama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tarih:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstKE});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mstKE
            // 
            this.mstKE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.mstKE.Name = "mstKE";
            this.mstKE.Size = new System.Drawing.Size(114, 20);
            this.mstKE.Text = "KARADAĞ EMLAK";
            this.mstKE.Click += new System.EventHandler(this.mstKE_Click);
            // 
            // Emlak_Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(860, 558);
            this.Controls.Add(this.btnYeniEmlak);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.dgEmlak);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGozat);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTeklif);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtKacKat);
            this.Controls.Add(this.txtMulkSahibi);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.txtEmlakBi);
            this.Controls.Add(this.txtEmlakNo);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Emlak_Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emlak Kayıt";
            this.Load += new System.EventHandler(this.Emlak_Kayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmlak)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYeniEmlak;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dgEmlak;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnGozat;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTeklif;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.TextBox txtKacKat;
        private System.Windows.Forms.TextBox txtMulkSahibi;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.TextBox txtEmlakBi;
        private System.Windows.Forms.TextBox txtEmlakNo;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mstKE;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}