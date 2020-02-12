namespace Emlak_Takip_Programi
{
    partial class Musteri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteri));
            this.label1 = new System.Windows.Forms.Label();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.btnAnasayfa2 = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.dgEmlak = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEmlak)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Emlak Arama";
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(168, 51);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(231, 20);
            this.txtAra.TabIndex = 1;
            this.txtAra.TextChanged += new System.EventHandler(this.txtAra_TextChanged);
            // 
            // btnAnasayfa2
            // 
            this.btnAnasayfa2.BackColor = System.Drawing.Color.LightCyan;
            this.btnAnasayfa2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnasayfa2.BackgroundImage")));
            this.btnAnasayfa2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnasayfa2.Location = new System.Drawing.Point(499, 9);
            this.btnAnasayfa2.Name = "btnAnasayfa2";
            this.btnAnasayfa2.Size = new System.Drawing.Size(61, 52);
            this.btnAnasayfa2.TabIndex = 15;
            this.btnAnasayfa2.UseVisualStyleBackColor = false;
            this.btnAnasayfa2.Click += new System.EventHandler(this.btnAnasayfa2_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.LightCyan;
            this.btnAnaSayfa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.BackgroundImage")));
            this.btnAnaSayfa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnaSayfa.Location = new System.Drawing.Point(12, 9);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(61, 52);
            this.btnAnaSayfa.TabIndex = 16;
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // dgEmlak
            // 
            this.dgEmlak.AllowUserToAddRows = false;
            this.dgEmlak.AllowUserToDeleteRows = false;
            this.dgEmlak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEmlak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgEmlak.Location = new System.Drawing.Point(12, 98);
            this.dgEmlak.Name = "dgEmlak";
            this.dgEmlak.ReadOnly = true;
            this.dgEmlak.RowTemplate.Height = 100;
            this.dgEmlak.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEmlak.Size = new System.Drawing.Size(548, 268);
            this.dgEmlak.TabIndex = 17;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Emlak No";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Emlak Biçimi";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Kaçıncı Kat";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Adres";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fotoğraf";
            this.Column4.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(572, 378);
            this.Controls.Add(this.dgEmlak);
            this.Controls.Add(this.btnAnaSayfa);
            this.Controls.Add(this.btnAnasayfa2);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteri";
            this.Text = "Emlak Arama";
            this.Load += new System.EventHandler(this.Musteri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEmlak)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Button btnAnasayfa2;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.DataGridView dgEmlak;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
    }
}