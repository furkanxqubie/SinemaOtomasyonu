namespace sinematik
{
    partial class FilmListesi
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmListesi));
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.lblIdNo = new System.Windows.Forms.Label();
            this.lblFilmAdi = new System.Windows.Forms.Label();
            this.btnFilmYukle = new System.Windows.Forms.Button();
            this.pBResim = new System.Windows.Forms.PictureBox();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.lblIdNo);
            this.groupBox9.Controls.Add(this.lblFilmAdi);
            this.groupBox9.Controls.Add(this.btnFilmYukle);
            this.groupBox9.Controls.Add(this.pBResim);
            this.groupBox9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.groupBox9.Location = new System.Drawing.Point(4, 9);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.groupBox9.Size = new System.Drawing.Size(90, 124);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            // 
            // lblIdNo
            // 
            this.lblIdNo.AutoSize = true;
            this.lblIdNo.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdNo.Location = new System.Drawing.Point(-1, 91);
            this.lblIdNo.Name = "lblIdNo";
            this.lblIdNo.Size = new System.Drawing.Size(45, 13);
            this.lblIdNo.TabIndex = 13;
            this.lblIdNo.Text = "lblIdNo";
            this.lblIdNo.Visible = false;
            // 
            // lblFilmAdi
            // 
            this.lblFilmAdi.AutoSize = true;
            this.lblFilmAdi.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFilmAdi.Location = new System.Drawing.Point(9, 3);
            this.lblFilmAdi.Name = "lblFilmAdi";
            this.lblFilmAdi.Size = new System.Drawing.Size(61, 19);
            this.lblFilmAdi.TabIndex = 12;
            this.lblFilmAdi.Text = "Film Adı";
            // 
            // btnFilmYukle
            // 
            this.btnFilmYukle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(164)))), ((int)(((byte)(26)))));
            this.btnFilmYukle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilmYukle.FlatAppearance.BorderSize = 0;
            this.btnFilmYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilmYukle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilmYukle.ForeColor = System.Drawing.Color.White;
            this.btnFilmYukle.Location = new System.Drawing.Point(5, 98);
            this.btnFilmYukle.Name = "btnFilmYukle";
            this.btnFilmYukle.Size = new System.Drawing.Size(77, 20);
            this.btnFilmYukle.TabIndex = 11;
            this.btnFilmYukle.Text = "DETAY";
            this.btnFilmYukle.UseVisualStyleBackColor = false;
            this.btnFilmYukle.Click += new System.EventHandler(this.btnFilmYukle_Click);
            // 
            // pBResim
            // 
            this.pBResim.Image = ((System.Drawing.Image)(resources.GetObject("pBResim.Image")));
            this.pBResim.Location = new System.Drawing.Point(5, 22);
            this.pBResim.Name = "pBResim";
            this.pBResim.Size = new System.Drawing.Size(77, 70);
            this.pBResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBResim.TabIndex = 0;
            this.pBResim.TabStop = false;
            // 
            // FilmListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox9);
            this.Name = "FilmListesi";
            this.Size = new System.Drawing.Size(96, 137);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBResim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox9;
        public System.Windows.Forms.Button btnFilmYukle;
        public System.Windows.Forms.PictureBox pBResim;
        public System.Windows.Forms.Label lblFilmAdi;
        public System.Windows.Forms.Label lblIdNo;
    }
}
