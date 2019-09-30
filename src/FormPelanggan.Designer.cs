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
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(223, 284);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(136, 284);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(35, 284);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // listPelanggan
            // 
            this.listPelanggan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listPelanggan.Location = new System.Drawing.Point(333, 29);
            this.listPelanggan.Name = "listPelanggan";
            this.listPelanggan.Size = new System.Drawing.Size(438, 278);
            this.listPelanggan.TabIndex = 16;
            this.listPelanggan.UseCompatibleStateImageBehavior = false;
            this.listPelanggan.View = System.Windows.Forms.View.Details;
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
            this.tbKota.Location = new System.Drawing.Point(102, 128);
            this.tbKota.Name = "tbKota";
            this.tbKota.Size = new System.Drawing.Size(196, 22);
            this.tbKota.TabIndex = 15;
            // 
            // tbAlamat
            // 
            this.tbAlamat.Location = new System.Drawing.Point(102, 72);
            this.tbAlamat.Name = "tbAlamat";
            this.tbAlamat.Size = new System.Drawing.Size(196, 22);
            this.tbAlamat.TabIndex = 14;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(102, 29);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(196, 22);
            this.tbNama.TabIndex = 13;
            // 
            // lbKota
            // 
            this.lbKota.AutoSize = true;
            this.lbKota.Location = new System.Drawing.Point(32, 128);
            this.lbKota.Name = "lbKota";
            this.lbKota.Size = new System.Drawing.Size(37, 17);
            this.lbKota.TabIndex = 12;
            this.lbKota.Text = "Kota";
            // 
            // lbAlamat
            // 
            this.lbAlamat.AutoSize = true;
            this.lbAlamat.Location = new System.Drawing.Point(32, 75);
            this.lbAlamat.Name = "lbAlamat";
            this.lbAlamat.Size = new System.Drawing.Size(51, 17);
            this.lbAlamat.TabIndex = 11;
            this.lbAlamat.Text = "Alamat";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(32, 29);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(45, 17);
            this.lbNama.TabIndex = 10;
            this.lbNama.Text = "Nama";
            // 
            // tbTelp
            // 
            this.tbTelp.Location = new System.Drawing.Point(102, 230);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(196, 22);
            this.tbTelp.TabIndex = 23;
            // 
            // tbKodePos
            // 
            this.tbKodePos.Location = new System.Drawing.Point(102, 174);
            this.tbKodePos.Name = "tbKodePos";
            this.tbKodePos.Size = new System.Drawing.Size(196, 22);
            this.tbKodePos.TabIndex = 22;
            // 
            // lbTelp
            // 
            this.lbTelp.AutoSize = true;
            this.lbTelp.Location = new System.Drawing.Point(32, 230);
            this.lbTelp.Name = "lbTelp";
            this.lbTelp.Size = new System.Drawing.Size(36, 17);
            this.lbTelp.TabIndex = 21;
            this.lbTelp.Text = "Telp";
            // 
            // lbKodePos
            // 
            this.lbKodePos.AutoSize = true;
            this.lbKodePos.Location = new System.Drawing.Point(32, 177);
            this.lbKodePos.Name = "lbKodePos";
            this.lbKodePos.Size = new System.Drawing.Size(69, 17);
            this.lbKodePos.TabIndex = 20;
            this.lbKodePos.Text = "Kode Pos";
            // 
            // FormPelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 347);
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
            this.Name = "FormPelanggan";
            this.Text = "FormPelanggan";
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
    }
}