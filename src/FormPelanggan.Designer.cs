namespace src
{
    partial class FormPelanggan
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.listPelanggan = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbKota = new System.Windows.Forms.TextBox();
            this.tbAlamat = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lbKota = new System.Windows.Forms.Label();
            this.lbAlamat = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.tbKodePos = new System.Windows.Forms.TextBox();
            this.lbTelp = new System.Windows.Forms.Label();
            this.lbKodePos = new System.Windows.Forms.Label();
            this.tbIdPelanggan = new System.Windows.Forms.TextBox();
            this.lbIdPelanggan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(167, 231);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(56, 19);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(102, 231);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 19);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(26, 231);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(56, 19);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // listPelanggan
            // 
            this.listPelanggan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listPelanggan.HideSelection = false;
            this.listPelanggan.Location = new System.Drawing.Point(250, 23);
            this.listPelanggan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listPelanggan.Name = "listPelanggan";
            this.listPelanggan.Size = new System.Drawing.Size(330, 227);
            this.listPelanggan.TabIndex = 16;
            this.listPelanggan.UseCompatibleStateImageBehavior = false;
            this.listPelanggan.View = System.Windows.Forms.View.Details;
            this.listPelanggan.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listPelanggan_MouseClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "ID Pelanggan";
            this.columnHeader6.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama";
            this.columnHeader1.Width = 82;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Alamat";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Kota";
            this.columnHeader3.Width = 85;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kode Pos";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Telp";
            this.columnHeader5.Width = 77;
            // 
            // tbKota
            // 
            this.tbKota.Location = new System.Drawing.Point(77, 106);
            this.tbKota.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(148, 20);
            this.tbKota.TabIndex = 15;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(77, 79);
            this.tbAlamat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(148, 20);
            this.tbAlamat.TabIndex = 14;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(77, 50);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(148, 20);
            this.tbNama.TabIndex = 13;
            // 
            // lbKota
            // 
            this.lbKota.AutoSize = true;
            this.lbKota.Location = new System.Drawing.Point(30, 107);
            this.lbKota.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKota.Name = "lbKota";
            this.lbKota.Size = new System.Drawing.Size(29, 13);
            this.lbKota.TabIndex = 12;
            this.lbKota.Text = "Kota";
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(24, 82);
            this.lbAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(39, 13);
            this.lbAlamat.TabIndex = 11;
            this.lbAlamat.Text = "Alamat";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(24, 51);
            this.lbNama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(35, 13);
            this.lbNama.TabIndex = 10;
            this.lbNama.Text = "Nama";
            // 
            // tbTelp
            // 
            this.tbTelp.Location = new System.Drawing.Point(76, 156);
            this.tbTelp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(148, 20);
            this.tbTelp.TabIndex = 23;
            // 
            // tbKodePos
            // 
            this.tbKodePos.Location = new System.Drawing.Point(76, 131);
            this.tbKodePos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbKodePos.Name = "tbKodePos";
            this.tbKodePos.Size = new System.Drawing.Size(148, 20);
            this.tbKodePos.TabIndex = 22;
            // 
            // lbTelp
            // 
            this.lbTelp.AutoSize = true;
            this.lbTelp.Location = new System.Drawing.Point(32, 158);
            this.lbTelp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTelp.Name = "lbTelp";
            this.lbTelp.Size = new System.Drawing.Size(28, 13);
            this.lbTelp.TabIndex = 21;
            this.lbTelp.Text = "Telp";
            // 
            // lbKodePos
            // 
            this.lbKodePos.AutoSize = true;
            this.lbKodePos.Location = new System.Drawing.Point(10, 132);
            this.lbKodePos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKodePos.Name = "lbKodePos";
            this.lbKodePos.Size = new System.Drawing.Size(53, 13);
            this.lbKodePos.TabIndex = 20;
            this.lbKodePos.Text = "Kode Pos";
            // 
            // tbIdPelanggan
            // 
            this.tbIdPelanggan.Location = new System.Drawing.Point(77, 23);
            this.tbIdPelanggan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbIdPelanggan.Name = "tbIdPelanggan";
            this.tbIdPelanggan.ReadOnly = true;
            this.tbIdPelanggan.Size = new System.Drawing.Size(148, 20);
            this.tbIdPelanggan.TabIndex = 25;
            // 
            // lbIdPelanggan
            // 
            this.lbIdPelanggan.AutoSize = true;
            this.lbIdPelanggan.Location = new System.Drawing.Point(2, 23);
            this.lbIdPelanggan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdPelanggan.Name = "lbIdPelanggan";
            this.lbIdPelanggan.Size = new System.Drawing.Size(72, 13);
            this.lbIdPelanggan.TabIndex = 24;
            this.lbIdPelanggan.Text = "ID Pelanggan";
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 282);
            this.Controls.Add(this.tbIdPelanggan);
            this.Controls.Add(this.lbIdPelanggan);
            this.Controls.Add(this.tbTelp);
            this.Controls.Add(this.tbKodePos);
            this.Controls.Add(this.lbTelp);
            this.Controls.Add(this.lbKodePos);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.listPelanggan);
            this.Controls.Add(this.tbKota);
            this.Controls.Add(this.tbAlamat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbKota);
            this.Controls.Add(this.lbAlamat);
            this.Controls.Add(this.lbNama);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormPelanggan";
            this.Text = "FormPelanggan";
            this.Load += new System.EventHandler(this.FormPelanggan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ListView listPelanggan;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tbKota;
        private System.Windows.Forms.TextBox tbAlamat;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lbKota;
        private System.Windows.Forms.Label lbAlamat;
        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.TextBox tbKodePos;
        private System.Windows.Forms.Label lbTelp;
        private System.Windows.Forms.Label lbKodePos;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox tbIdPelanggan;
        private System.Windows.Forms.Label lbIdPelanggan;
    }
}