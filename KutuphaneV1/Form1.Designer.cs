namespace KutuphaneV1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbKitap = new System.Windows.Forms.TabPage();
            this.dtgKitaplar = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.cbSec = new System.Windows.Forms.ComboBox();
            this.rbKategori = new System.Windows.Forms.RadioButton();
            this.rbYazar = new System.Windows.Forms.RadioButton();
            this.rbKitap = new System.Windows.Forms.RadioButton();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.tbYazar = new System.Windows.Forms.TabPage();
            this.dtgYazarlar = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.tbKategori = new System.Windows.Forms.TabPage();
            this.tbKullanici = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgKitaplar)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tbYazar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgYazarlar)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbKitap);
            this.tabControl1.Controls.Add(this.tbYazar);
            this.tabControl1.Controls.Add(this.tbKategori);
            this.tabControl1.Controls.Add(this.tbKullanici);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.ItemSize = new System.Drawing.Size(200, 50);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1181, 559);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tbKitap
            // 
            this.tbKitap.Controls.Add(this.dtgKitaplar);
            this.tbKitap.Controls.Add(this.panel1);
            this.tbKitap.Location = new System.Drawing.Point(4, 54);
            this.tbKitap.Margin = new System.Windows.Forms.Padding(2);
            this.tbKitap.Name = "tbKitap";
            this.tbKitap.Padding = new System.Windows.Forms.Padding(2);
            this.tbKitap.Size = new System.Drawing.Size(1173, 501);
            this.tbKitap.TabIndex = 0;
            this.tbKitap.Text = "Kitap Yönetimi";
            this.tbKitap.UseVisualStyleBackColor = true;
            // 
            // dtgKitaplar
            // 
            this.dtgKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgKitaplar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgKitaplar.Location = new System.Drawing.Point(2, 69);
            this.dtgKitaplar.Margin = new System.Windows.Forms.Padding(2);
            this.dtgKitaplar.Name = "dtgKitaplar";
            this.dtgKitaplar.ReadOnly = true;
            this.dtgKitaplar.RowHeadersWidth = 51;
            this.dtgKitaplar.RowTemplate.Height = 24;
            this.dtgKitaplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgKitaplar.Size = new System.Drawing.Size(1169, 430);
            this.dtgKitaplar.TabIndex = 1;
            this.dtgKitaplar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgKitaplar_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.btnKitapSil);
            this.panel1.Controls.Add(this.btnKitapGuncelle);
            this.panel1.Controls.Add(this.btnKitapEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 67);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAra);
            this.groupBox1.Controls.Add(this.txtAra);
            this.groupBox1.Controls.Add(this.cbSec);
            this.groupBox1.Controls.Add(this.rbKategori);
            this.groupBox1.Controls.Add(this.rbYazar);
            this.groupBox1.Controls.Add(this.rbKitap);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(490, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(679, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listeleme | Arama";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(574, 36);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(56, 26);
            this.btnAra.TabIndex = 5;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(457, 38);
            this.txtAra.Margin = new System.Windows.Forms.Padding(2);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(113, 23);
            this.txtAra.TabIndex = 4;
            // 
            // cbSec
            // 
            this.cbSec.FormattingEnabled = true;
            this.cbSec.Location = new System.Drawing.Point(333, 37);
            this.cbSec.Margin = new System.Windows.Forms.Padding(2);
            this.cbSec.Name = "cbSec";
            this.cbSec.Size = new System.Drawing.Size(120, 24);
            this.cbSec.TabIndex = 3;
            // 
            // rbKategori
            // 
            this.rbKategori.AutoSize = true;
            this.rbKategori.Location = new System.Drawing.Point(227, 36);
            this.rbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.rbKategori.Name = "rbKategori";
            this.rbKategori.Size = new System.Drawing.Size(119, 21);
            this.rbKategori.TabIndex = 2;
            this.rbKategori.TabStop = true;
            this.rbKategori.Text = "Türüne Göre";
            this.rbKategori.UseVisualStyleBackColor = true;
            // 
            // rbYazar
            // 
            this.rbYazar.AutoSize = true;
            this.rbYazar.Location = new System.Drawing.Point(119, 36);
            this.rbYazar.Margin = new System.Windows.Forms.Padding(2);
            this.rbYazar.Name = "rbYazar";
            this.rbYazar.Size = new System.Drawing.Size(118, 21);
            this.rbYazar.TabIndex = 1;
            this.rbYazar.TabStop = true;
            this.rbYazar.Text = "Yazara Göre";
            this.rbYazar.UseVisualStyleBackColor = true;
            // 
            // rbKitap
            // 
            this.rbKitap.AutoSize = true;
            this.rbKitap.Location = new System.Drawing.Point(20, 36);
            this.rbKitap.Margin = new System.Windows.Forms.Padding(2);
            this.rbKitap.Name = "rbKitap";
            this.rbKitap.Size = new System.Drawing.Size(104, 21);
            this.rbKitap.TabIndex = 0;
            this.rbKitap.TabStop = true;
            this.rbKitap.Text = "Kitap Göre";
            this.rbKitap.UseVisualStyleBackColor = true;
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKitapSil.Location = new System.Drawing.Point(330, 0);
            this.btnKitapSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(160, 67);
            this.btnKitapSil.TabIndex = 2;
            this.btnKitapSil.Text = "Seçili Kaydı Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKitapGuncelle.Location = new System.Drawing.Point(169, 0);
            this.btnKitapGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(161, 67);
            this.btnKitapGuncelle.TabIndex = 1;
            this.btnKitapGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKitapEkle.Location = new System.Drawing.Point(0, 0);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(169, 67);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Yeni Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // tbYazar
            // 
            this.tbYazar.Controls.Add(this.dtgYazarlar);
            this.tbYazar.Controls.Add(this.panel2);
            this.tbYazar.Location = new System.Drawing.Point(4, 54);
            this.tbYazar.Margin = new System.Windows.Forms.Padding(2);
            this.tbYazar.Name = "tbYazar";
            this.tbYazar.Padding = new System.Windows.Forms.Padding(2);
            this.tbYazar.Size = new System.Drawing.Size(1173, 501);
            this.tbYazar.TabIndex = 1;
            this.tbYazar.Text = "Yazar Yönetimi";
            this.tbYazar.UseVisualStyleBackColor = true;
            // 
            // dtgYazarlar
            // 
            this.dtgYazarlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgYazarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgYazarlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgYazarlar.Location = new System.Drawing.Point(2, 69);
            this.dtgYazarlar.Margin = new System.Windows.Forms.Padding(2);
            this.dtgYazarlar.Name = "dtgYazarlar";
            this.dtgYazarlar.RowHeadersWidth = 51;
            this.dtgYazarlar.RowTemplate.Height = 24;
            this.dtgYazarlar.Size = new System.Drawing.Size(1169, 430);
            this.dtgYazarlar.TabIndex = 1;
            this.dtgYazarlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgYazarlar_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PowderBlue;
            this.panel2.Controls.Add(this.btnYazarSil);
            this.panel2.Controls.Add(this.btnYazarGuncelle);
            this.panel2.Controls.Add(this.btnYazarEkle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1169, 67);
            this.panel2.TabIndex = 0;
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYazarSil.Location = new System.Drawing.Point(335, 0);
            this.btnYazarSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(173, 67);
            this.btnYazarSil.TabIndex = 2;
            this.btnYazarSil.Text = "Seçili Kaydı Sil";
            this.btnYazarSil.UseVisualStyleBackColor = true;
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYazarGuncelle.Location = new System.Drawing.Point(151, 0);
            this.btnYazarGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(184, 67);
            this.btnYazarGuncelle.TabIndex = 1;
            this.btnYazarGuncelle.Text = "Seçili Kaydı Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnYazarEkle.Location = new System.Drawing.Point(0, 0);
            this.btnYazarEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(151, 67);
            this.btnYazarEkle.TabIndex = 0;
            this.btnYazarEkle.Text = "Yazar Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = true;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // tbKategori
            // 
            this.tbKategori.Location = new System.Drawing.Point(4, 54);
            this.tbKategori.Margin = new System.Windows.Forms.Padding(2);
            this.tbKategori.Name = "tbKategori";
            this.tbKategori.Size = new System.Drawing.Size(1173, 501);
            this.tbKategori.TabIndex = 2;
            this.tbKategori.Text = "Kategori Yönetimi";
            this.tbKategori.UseVisualStyleBackColor = true;
            // 
            // tbKullanici
            // 
            this.tbKullanici.Location = new System.Drawing.Point(4, 54);
            this.tbKullanici.Margin = new System.Windows.Forms.Padding(2);
            this.tbKullanici.Name = "tbKullanici";
            this.tbKullanici.Size = new System.Drawing.Size(1173, 501);
            this.tbKullanici.TabIndex = 3;
            this.tbKullanici.Text = "Kullanıcı Yönetimi";
            this.tbKullanici.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 559);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbKitap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgKitaplar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbYazar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgYazarlar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbKitap;
        private System.Windows.Forms.TabPage tbYazar;
        private System.Windows.Forms.TabPage tbKategori;
        private System.Windows.Forms.TabPage tbKullanici;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgKitaplar;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.RadioButton rbKategori;
        private System.Windows.Forms.RadioButton rbYazar;
        private System.Windows.Forms.RadioButton rbKitap;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ComboBox cbSec;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.DataGridView dtgYazarlar;
        private System.Windows.Forms.Button btnYazarSil;
    }
}

