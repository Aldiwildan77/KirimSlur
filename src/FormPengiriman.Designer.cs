namespace src
{
    partial class FormPengiriman
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
            this.lbKategori = new System.Windows.Forms.Label();
            this.lbKurir = new System.Windows.Forms.Label();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.listPengiriman = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbBarang = new System.Windows.Forms.Label();
            this.lbPenerima = new System.Windows.Forms.Label();
            this.lbPengirim = new System.Windows.Forms.Label();
            this.cbPengirim = new System.Windows.Forms.ComboBox();
            this.cbPenerima = new System.Windows.Forms.ComboBox();
            this.cbBarang = new System.Windows.Forms.ComboBox();
            this.cbKurir = new System.Windows.Forms.ComboBox();
            this.rbRegular = new System.Windows.Forms.RadioButton();
            this.rbExpress = new System.Windows.Forms.RadioButton();
            this.lbTanggal = new System.Windows.Forms.Label();
            this.dtTanggal = new System.Windows.Forms.DateTimePicker();
            this.lbTotal = new System.Windows.Forms.Label();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.no_resi = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbKategori
            // 
            this.lbKategori.AutoSize = true;
            this.lbKategori.Location = new System.Drawing.Point(32, 271);
            this.lbKategori.Name = "lbKategori";
            this.lbKategori.Size = new System.Drawing.Size(61, 17);
            this.lbKategori.TabIndex = 35;
            this.lbKategori.Text = "Kategori";
            // 
            // lbKurir
            // 
            this.lbKurir.AutoSize = true;
            this.lbKurir.Location = new System.Drawing.Point(32, 218);
            this.lbKurir.Name = "lbKurir";
            this.lbKurir.Size = new System.Drawing.Size(38, 17);
            this.lbKurir.TabIndex = 34;
            this.lbKurir.Text = "Kurir";
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(223, 353);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 33;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(647, 384);
            this.btnStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(123, 39);
            this.btnStatus.TabIndex = 32;
            this.btnStatus.Text = "Tambah Status";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(35, 353);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 31;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // listPengiriman
            // 
            this.listPengiriman.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listPengiriman.HideSelection = false;
            this.listPengiriman.Location = new System.Drawing.Point(331, 30);
            this.listPengiriman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPengiriman.Name = "listPengiriman";
            this.listPengiriman.Size = new System.Drawing.Size(439, 346);
            this.listPengiriman.TabIndex = 30;
            this.listPengiriman.UseCompatibleStateImageBehavior = false;
            this.listPengiriman.View = System.Windows.Forms.View.Details;
            this.listPengiriman.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listPengiriman_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tanggal";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "No Resi";
            this.columnHeader8.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Pengirim";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Penerima";
            this.columnHeader3.Width = 91;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Barang";
            this.columnHeader4.Width = 94;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kurir";
            this.columnHeader5.Width = 77;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Kategori";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Total";
            // 
            // lbBarang
            // 
            this.lbBarang.AutoSize = true;
            this.lbBarang.Location = new System.Drawing.Point(32, 169);
            this.lbBarang.Name = "lbBarang";
            this.lbBarang.Size = new System.Drawing.Size(54, 17);
            this.lbBarang.TabIndex = 26;
            this.lbBarang.Text = "Barang";
            // 
            // lbPenerima
            // 
            this.lbPenerima.AutoSize = true;
            this.lbPenerima.Location = new System.Drawing.Point(32, 116);
            this.lbPenerima.Name = "lbPenerima";
            this.lbPenerima.Size = new System.Drawing.Size(68, 17);
            this.lbPenerima.TabIndex = 25;
            this.lbPenerima.Text = "Penerima";
            // 
            // lbPengirim
            // 
            this.lbPengirim.AutoSize = true;
            this.lbPengirim.Location = new System.Drawing.Point(32, 70);
            this.lbPengirim.Name = "lbPengirim";
            this.lbPengirim.Size = new System.Drawing.Size(63, 17);
            this.lbPengirim.TabIndex = 24;
            this.lbPengirim.Text = "Pengirim";
            // 
            // cbPengirim
            // 
            this.cbPengirim.FormattingEnabled = true;
            this.cbPengirim.Location = new System.Drawing.Point(121, 70);
            this.cbPengirim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPengirim.Name = "cbPengirim";
            this.cbPengirim.Size = new System.Drawing.Size(177, 24);
            this.cbPengirim.TabIndex = 36;
            // 
            // cbPenerima
            // 
            this.cbPenerima.FormattingEnabled = true;
            this.cbPenerima.Location = new System.Drawing.Point(121, 113);
            this.cbPenerima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPenerima.Name = "cbPenerima";
            this.cbPenerima.Size = new System.Drawing.Size(177, 24);
            this.cbPenerima.TabIndex = 37;
            // 
            // cbBarang
            // 
            this.cbBarang.FormattingEnabled = true;
            this.cbBarang.Location = new System.Drawing.Point(121, 166);
            this.cbBarang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBarang.Name = "cbBarang";
            this.cbBarang.Size = new System.Drawing.Size(177, 24);
            this.cbBarang.TabIndex = 38;
            // 
            // cbKurir
            // 
            this.cbKurir.FormattingEnabled = true;
            this.cbKurir.Location = new System.Drawing.Point(121, 215);
            this.cbKurir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKurir.Name = "cbKurir";
            this.cbKurir.Size = new System.Drawing.Size(177, 24);
            this.cbKurir.TabIndex = 39;
            // 
            // rbRegular
            // 
            this.rbRegular.AutoSize = true;
            this.rbRegular.Location = new System.Drawing.Point(149, 256);
            this.rbRegular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbRegular.Name = "rbRegular";
            this.rbRegular.Size = new System.Drawing.Size(79, 21);
            this.rbRegular.TabIndex = 40;
            this.rbRegular.TabStop = true;
            this.rbRegular.Text = "Regular";
            this.rbRegular.UseVisualStyleBackColor = true;
            this.rbRegular.CheckedChanged += new System.EventHandler(this.Regular_Checked);
            // 
            // rbExpress
            // 
            this.rbExpress.AutoSize = true;
            this.rbExpress.Location = new System.Drawing.Point(149, 283);
            this.rbExpress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbExpress.Name = "rbExpress";
            this.rbExpress.Size = new System.Drawing.Size(79, 21);
            this.rbExpress.TabIndex = 41;
            this.rbExpress.TabStop = true;
            this.rbExpress.Text = "Express";
            this.rbExpress.UseVisualStyleBackColor = true;
            this.rbExpress.CheckedChanged += new System.EventHandler(this.Express_Checked);
            // 
            // lbTanggal
            // 
            this.lbTanggal.AutoSize = true;
            this.lbTanggal.Location = new System.Drawing.Point(32, 30);
            this.lbTanggal.Name = "lbTanggal";
            this.lbTanggal.Size = new System.Drawing.Size(60, 17);
            this.lbTanggal.TabIndex = 42;
            this.lbTanggal.Text = "Tanggal";
            // 
            // dtTanggal
            // 
            this.dtTanggal.Location = new System.Drawing.Point(121, 30);
            this.dtTanggal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtTanggal.Name = "dtTanggal";
            this.dtTanggal.Size = new System.Drawing.Size(177, 22);
            this.dtTanggal.TabIndex = 43;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Location = new System.Drawing.Point(32, 310);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(40, 17);
            this.lbTotal.TabIndex = 44;
            this.lbTotal.Text = "Total";
            // 
            // tbTotal
            // 
            this.tbTotal.Enabled = false;
            this.tbTotal.Location = new System.Drawing.Point(121, 310);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(177, 22);
            this.tbTotal.TabIndex = 45;
            // 
            // no_resi
            // 
            this.no_resi.Location = new System.Drawing.Point(331, 384);
            this.no_resi.Margin = new System.Windows.Forms.Padding(4);
            this.no_resi.Name = "no_resi";
            this.no_resi.Size = new System.Drawing.Size(132, 22);
            this.no_resi.TabIndex = 46;
            this.no_resi.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(132, 353);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 47;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FormPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.no_resi);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.dtTanggal);
            this.Controls.Add(this.lbTanggal);
            this.Controls.Add(this.rbExpress);
            this.Controls.Add(this.rbRegular);
            this.Controls.Add(this.cbKurir);
            this.Controls.Add(this.cbBarang);
            this.Controls.Add(this.cbPenerima);
            this.Controls.Add(this.cbPengirim);
            this.Controls.Add(this.lbKategori);
            this.Controls.Add(this.lbKurir);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.listPengiriman);
            this.Controls.Add(this.lbBarang);
            this.Controls.Add(this.lbPenerima);
            this.Controls.Add(this.lbPengirim);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPengiriman";
            this.Text = "FormPengiriman";
            this.Load += new System.EventHandler(this.FormPengiriman_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbKategori;
        private System.Windows.Forms.Label lbKurir;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ListView listPengiriman;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label lbBarang;
        private System.Windows.Forms.Label lbPenerima;
        private System.Windows.Forms.Label lbPengirim;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cbPengirim;
        private System.Windows.Forms.ComboBox cbPenerima;
        private System.Windows.Forms.ComboBox cbBarang;
        private System.Windows.Forms.ComboBox cbKurir;
        private System.Windows.Forms.RadioButton rbRegular;
        private System.Windows.Forms.RadioButton rbExpress;
        private System.Windows.Forms.Label lbTanggal;
        private System.Windows.Forms.DateTimePicker dtTanggal;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.TextBox no_resi;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button btnUpdate;
    }
}