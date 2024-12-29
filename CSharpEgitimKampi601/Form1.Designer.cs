namespace CSharpEgitimKampi601
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMusteriId = new System.Windows.Forms.Label();
            this.txtMusteriId = new System.Windows.Forms.TextBox();
            this.txtMusteriSoyad = new System.Windows.Forms.TextBox();
            this.lblMusteriSoyad = new System.Windows.Forms.Label();
            this.txtMusteriAd = new System.Windows.Forms.TextBox();
            this.lblMusteriAd = new System.Windows.Forms.Label();
            this.txtMusteriSehir = new System.Windows.Forms.TextBox();
            this.lblMusteriSehir = new System.Windows.Forms.Label();
            this.txtMusteriBakiye = new System.Windows.Forms.TextBox();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.txtMusteriTutar = new System.Windows.Forms.TextBox();
            this.lblAlisverisTutari = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGetById = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMusteriId
            // 
            this.lblMusteriId.AutoSize = true;
            this.lblMusteriId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriId.Location = new System.Drawing.Point(52, 63);
            this.lblMusteriId.Name = "lblMusteriId";
            this.lblMusteriId.Size = new System.Drawing.Size(103, 20);
            this.lblMusteriId.TabIndex = 0;
            this.lblMusteriId.Text = "Müşteri ID:";
            // 
            // txtMusteriId
            // 
            this.txtMusteriId.Location = new System.Drawing.Point(174, 61);
            this.txtMusteriId.Name = "txtMusteriId";
            this.txtMusteriId.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriId.TabIndex = 1;
            // 
            // txtMusteriSoyad
            // 
            this.txtMusteriSoyad.Location = new System.Drawing.Point(174, 117);
            this.txtMusteriSoyad.Name = "txtMusteriSoyad";
            this.txtMusteriSoyad.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriSoyad.TabIndex = 3;
            // 
            // lblMusteriSoyad
            // 
            this.lblMusteriSoyad.AutoSize = true;
            this.lblMusteriSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSoyad.Location = new System.Drawing.Point(20, 119);
            this.lblMusteriSoyad.Name = "lblMusteriSoyad";
            this.lblMusteriSoyad.Size = new System.Drawing.Size(135, 20);
            this.lblMusteriSoyad.TabIndex = 2;
            this.lblMusteriSoyad.Text = "Müşteri Soyad:";
            // 
            // txtMusteriAd
            // 
            this.txtMusteriAd.Location = new System.Drawing.Point(174, 89);
            this.txtMusteriAd.Name = "txtMusteriAd";
            this.txtMusteriAd.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriAd.TabIndex = 5;
            // 
            // lblMusteriAd
            // 
            this.lblMusteriAd.AutoSize = true;
            this.lblMusteriAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriAd.Location = new System.Drawing.Point(49, 91);
            this.lblMusteriAd.Name = "lblMusteriAd";
            this.lblMusteriAd.Size = new System.Drawing.Size(106, 20);
            this.lblMusteriAd.TabIndex = 4;
            this.lblMusteriAd.Text = "Müşteri Ad:";
            // 
            // txtMusteriSehir
            // 
            this.txtMusteriSehir.Location = new System.Drawing.Point(174, 145);
            this.txtMusteriSehir.Name = "txtMusteriSehir";
            this.txtMusteriSehir.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriSehir.TabIndex = 7;
            // 
            // lblMusteriSehir
            // 
            this.lblMusteriSehir.AutoSize = true;
            this.lblMusteriSehir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMusteriSehir.Location = new System.Drawing.Point(27, 147);
            this.lblMusteriSehir.Name = "lblMusteriSehir";
            this.lblMusteriSehir.Size = new System.Drawing.Size(128, 20);
            this.lblMusteriSehir.TabIndex = 6;
            this.lblMusteriSehir.Text = "Müşteri Şehir:";
            // 
            // txtMusteriBakiye
            // 
            this.txtMusteriBakiye.Location = new System.Drawing.Point(174, 173);
            this.txtMusteriBakiye.Name = "txtMusteriBakiye";
            this.txtMusteriBakiye.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriBakiye.TabIndex = 9;
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.Location = new System.Drawing.Point(84, 175);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(71, 20);
            this.lblBakiye.TabIndex = 8;
            this.lblBakiye.Text = "Bakiye:";
            // 
            // txtMusteriTutar
            // 
            this.txtMusteriTutar.Location = new System.Drawing.Point(174, 201);
            this.txtMusteriTutar.Name = "txtMusteriTutar";
            this.txtMusteriTutar.Size = new System.Drawing.Size(200, 22);
            this.txtMusteriTutar.TabIndex = 11;
            // 
            // lblAlisverisTutari
            // 
            this.lblAlisverisTutari.AutoSize = true;
            this.lblAlisverisTutari.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlisverisTutari.Location = new System.Drawing.Point(12, 203);
            this.lblAlisverisTutari.Name = "lblAlisverisTutari";
            this.lblAlisverisTutari.Size = new System.Drawing.Size(143, 20);
            this.lblAlisverisTutari.TabIndex = 10;
            this.lblAlisverisTutari.Text = "Alışveriş Tutarı:";
            // 
            // btnListele
            // 
            this.btnListele.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnListele.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListele.Location = new System.Drawing.Point(174, 229);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(200, 36);
            this.btnListele.TabIndex = 12;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = false;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuncelle.Location = new System.Drawing.Point(174, 354);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(200, 36);
            this.btnGuncelle.TabIndex = 14;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSil.Location = new System.Drawing.Point(174, 312);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(200, 36);
            this.btnSil.TabIndex = 15;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEkle.Location = new System.Drawing.Point(174, 270);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(200, 36);
            this.btnEkle.TabIndex = 16;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(404, 61);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(908, 371);
            this.DataGridView1.TabIndex = 18;
            // 
            // btnGetById
            // 
            this.btnGetById.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnGetById.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetById.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGetById.Location = new System.Drawing.Point(174, 396);
            this.btnGetById.Name = "btnGetById";
            this.btnGetById.Size = new System.Drawing.Size(200, 36);
            this.btnGetById.TabIndex = 13;
            this.btnGetById.Text = "ID\'ye Göre Getir";
            this.btnGetById.UseVisualStyleBackColor = false;
            this.btnGetById.Click += new System.EventHandler(this.btnGetById_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 448);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnGetById);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.txtMusteriTutar);
            this.Controls.Add(this.lblAlisverisTutari);
            this.Controls.Add(this.txtMusteriBakiye);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.txtMusteriSehir);
            this.Controls.Add(this.lblMusteriSehir);
            this.Controls.Add(this.txtMusteriAd);
            this.Controls.Add(this.lblMusteriAd);
            this.Controls.Add(this.txtMusteriSoyad);
            this.Controls.Add(this.lblMusteriSoyad);
            this.Controls.Add(this.txtMusteriId);
            this.Controls.Add(this.lblMusteriId);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMusteriId;
        private System.Windows.Forms.TextBox txtMusteriId;
        private System.Windows.Forms.TextBox txtMusteriSoyad;
        private System.Windows.Forms.Label lblMusteriSoyad;
        private System.Windows.Forms.TextBox txtMusteriAd;
        private System.Windows.Forms.Label lblMusteriAd;
        private System.Windows.Forms.TextBox txtMusteriSehir;
        private System.Windows.Forms.Label lblMusteriSehir;
        private System.Windows.Forms.TextBox txtMusteriBakiye;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.TextBox txtMusteriTutar;
        private System.Windows.Forms.Label lblAlisverisTutari;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.Button btnGetById;
    }
}

