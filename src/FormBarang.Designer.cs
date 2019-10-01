namespace src
{
    partial class FormBarang
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
            this.listBarang = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lbJenis = new System.Windows.Forms.Label();
            this.lbBerat = new System.Windows.Forms.Label();
            this.lbNamaBarang = new System.Windows.Forms.Label();
            this.tbIdBarang = new System.Windows.Forms.TextBox();
            this.lbIdBarang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(166, 164);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(56, 24);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(94, 164);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(56, 24);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(26, 164);
            this.btnTambah.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(56, 24);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // listBarang
            // 
            this.listBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listBarang.FullRowSelect = true;
            this.listBarang.HideSelection = false;
            this.listBarang.Location = new System.Drawing.Point(243, 20);
            this.listBarang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listBarang.Name = "listBarang";
            this.listBarang.Size = new System.Drawing.Size(324, 192);
            this.listBarang.TabIndex = 16;
            this.listBarang.UseCompatibleStateImageBehavior = false;
            this.listBarang.View = System.Windows.Forms.View.Details;
            this.listBarang.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBarang_MouseClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID Barang";
            this.columnHeader4.Width = 129;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Berat";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Jenis";
            this.columnHeader3.Width = 132;
            // 
            // tbJenis
            // 
            this.tbJenis.Location = new System.Drawing.Point(88, 105);
            this.tbJenis.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(148, 20);
            this.tbJenis.TabIndex = 15;
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(88, 76);
            this.tbBerat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(148, 20);
            this.tbBerat.TabIndex = 14;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(88, 48);
            this.tbNama.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(148, 20);
            this.tbNama.TabIndex = 13;
            // 
            // lbJenis
            // 
            this.lbJenis.AutoSize = true;
            this.lbJenis.Location = new System.Drawing.Point(8, 106);
            this.lbJenis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbJenis.Name = "lbJenis";
            this.lbJenis.Size = new System.Drawing.Size(68, 13);
            this.lbJenis.TabIndex = 12;
            this.lbJenis.Text = "Jenis Barang";
            // 
            // lbBerat
            // 
            this.lbBerat.AutoSize = true;
            this.lbBerat.Location = new System.Drawing.Point(8, 77);
            this.lbBerat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBerat.Name = "lbBerat";
            this.lbBerat.Size = new System.Drawing.Size(69, 13);
            this.lbBerat.TabIndex = 11;
            this.lbBerat.Text = "Berat Barang";
            // 
            // lbNamaBarang
            // 
            this.lbNamaBarang.AutoSize = true;
            this.lbNamaBarang.Location = new System.Drawing.Point(5, 49);
            this.lbNamaBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNamaBarang.Name = "lbNamaBarang";
            this.lbNamaBarang.Size = new System.Drawing.Size(72, 13);
            this.lbNamaBarang.TabIndex = 10;
            this.lbNamaBarang.Text = "Nama Barang";
            // 
            // tbIdBarang
            // 
            this.tbIdBarang.Location = new System.Drawing.Point(88, 20);
            this.tbIdBarang.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbIdBarang.Name = "tbIdBarang";
            this.tbIdBarang.ReadOnly = true;
            this.tbIdBarang.Size = new System.Drawing.Size(148, 20);
            this.tbIdBarang.TabIndex = 21;
            // 
            // lbIdBarang
            // 
            this.lbIdBarang.AutoSize = true;
            this.lbIdBarang.Location = new System.Drawing.Point(23, 22);
            this.lbIdBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdBarang.Name = "lbIdBarang";
            this.lbIdBarang.Size = new System.Drawing.Size(55, 13);
            this.lbIdBarang.TabIndex = 20;
            this.lbIdBarang.Text = "ID Barang";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 242);
            this.Controls.Add(this.tbIdBarang);
            this.Controls.Add(this.lbIdBarang);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.listBarang);
            this.Controls.Add(this.tbJenis);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbJenis);
            this.Controls.Add(this.lbBerat);
            this.Controls.Add(this.lbNamaBarang);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
            this.Load += new System.EventHandler(this.FormBarang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ListView listBarang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TextBox tbJenis;
        private System.Windows.Forms.TextBox tbBerat;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.Label lbJenis;
        private System.Windows.Forms.Label lbBerat;
        private System.Windows.Forms.Label lbNamaBarang;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox tbIdBarang;
        private System.Windows.Forms.Label lbIdBarang;
    }
}