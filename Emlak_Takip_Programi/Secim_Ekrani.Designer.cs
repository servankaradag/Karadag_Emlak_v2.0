namespace Emlak_Takip_Programi
{
    partial class Secim_Ekrani
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Secim_Ekrani));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pcIkon = new System.Windows.Forms.PictureBox();
            this.pbYukle = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbSayac = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcIkon)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(180, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "LÜTFEN BEKLEYİNİZ...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(154, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Giriş Başarılı";
            // 
            // pcIkon
            // 
            this.pcIkon.Image = ((System.Drawing.Image)(resources.GetObject("pcIkon.Image")));
            this.pcIkon.Location = new System.Drawing.Point(114, 25);
            this.pcIkon.Name = "pcIkon";
            this.pcIkon.Size = new System.Drawing.Size(256, 54);
            this.pcIkon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcIkon.TabIndex = 6;
            this.pcIkon.TabStop = false;
            // 
            // pbYukle
            // 
            this.pbYukle.Location = new System.Drawing.Point(29, 255);
            this.pbYukle.Name = "pbYukle";
            this.pbYukle.Size = new System.Drawing.Size(441, 23);
            this.pbYukle.TabIndex = 9;
            this.pbYukle.Tag = "";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbSayac
            // 
            this.lbSayac.AutoSize = true;
            this.lbSayac.BackColor = System.Drawing.Color.Lime;
            this.lbSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbSayac.ForeColor = System.Drawing.Color.White;
            this.lbSayac.Location = new System.Drawing.Point(234, 259);
            this.lbSayac.Name = "lbSayac";
            this.lbSayac.Size = new System.Drawing.Size(15, 16);
            this.lbSayac.TabIndex = 11;
            this.lbSayac.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(206, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "KARADAĞ EMLAK";
            // 
            // Secim_Ekrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSayac);
            this.Controls.Add(this.pbYukle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcIkon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Secim_Ekrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seçim Ekranı";
            this.Load += new System.EventHandler(this.Secim_Ekrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcIkon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pcIkon;
        private System.Windows.Forms.ProgressBar pbYukle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbSayac;
        private System.Windows.Forms.Label label3;
    }
}