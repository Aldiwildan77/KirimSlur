namespace src
{
    partial class FormStatusPengiriman
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvStatusPengiriman = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbTambahStatus = new System.Windows.Forms.ComboBox();
            this.btnTambahStatus = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbNoTelpPengirim = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbKotaPengirim = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbKodePosPengirim = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbAlamatPengirim = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbNamaPengirim = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCekResi = new System.Windows.Forms.Button();
            this.tbCekResi = new System.Windows.Forms.TextBox();
            this.lbJudulLaporan = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.cbTambahStatus);
            this.groupBox4.Controls.Add(this.btnTambahStatus);
            this.groupBox4.Location = new System.Drawing.Point(408, 62);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(488, 250);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Status Pengiriman";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lvStatusPengiriman);
            this.panel1.Location = new System.Drawing.Point(9, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(473, 164);
            this.panel1.TabIndex = 12;
            // 
            // lvStatusPengiriman
            // 
            this.lvStatusPengiriman.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvStatusPengiriman.HideSelection = false;
            this.lvStatusPengiriman.Location = new System.Drawing.Point(4, 4);
            this.lvStatusPengiriman.Name = "lvStatusPengiriman";
            this.lvStatusPengiriman.Size = new System.Drawing.Size(445, 163);
            this.lvStatusPengiriman.TabIndex = 0;
            this.lvStatusPengiriman.UseCompatibleStateImageBehavior = false;
            this.lvStatusPengiriman.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tanggal";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // cbTambahStatus
            // 
            this.cbTambahStatus.FormattingEnabled = true;
            this.cbTambahStatus.Location = new System.Drawing.Point(13, 195);
            this.cbTambahStatus.Name = "cbTambahStatus";
            this.cbTambahStatus.Size = new System.Drawing.Size(333, 24);
            this.cbTambahStatus.TabIndex = 11;
            // 
            // btnTambahStatus
            // 
            this.btnTambahStatus.Location = new System.Drawing.Point(361, 194);
            this.btnTambahStatus.Name = "btnTambahStatus";
            this.btnTambahStatus.Size = new System.Drawing.Size(121, 24);
            this.btnTambahStatus.TabIndex = 10;
            this.btnTambahStatus.Text = "Tambah Status";
            this.btnTambahStatus.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbNoTelpPengirim);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lbKotaPengirim);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbKodePosPengirim);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbAlamatPengirim);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lbNamaPengirim);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(17, 140);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(369, 172);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Pengirim";
            this.groupBox2.Visible = false;
            // 
            // lbNoTelpPengirim
            // 
            this.lbNoTelpPengirim.AutoSize = true;
            this.lbNoTelpPengirim.Location = new System.Drawing.Point(107, 143);
            this.lbNoTelpPengirim.Name = "lbNoTelpPengirim";
            this.lbNoTelpPengirim.Size = new System.Drawing.Size(104, 17);
            this.lbNoTelpPengirim.TabIndex = 23;
            this.lbNoTelpPengirim.Text = "081212121212";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "No Telepon";
            // 
            // lbKotaPengirim
            // 
            this.lbKotaPengirim.AutoSize = true;
            this.lbKotaPengirim.Location = new System.Drawing.Point(107, 114);
            this.lbKotaPengirim.Name = "lbKotaPengirim";
            this.lbKotaPengirim.Size = new System.Drawing.Size(54, 17);
            this.lbKotaPengirim.TabIndex = 21;
            this.lbKotaPengirim.Text = "Malang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Kota";
            // 
            // lbKodePosPengirim
            // 
            this.lbKodePosPengirim.AutoSize = true;
            this.lbKodePosPengirim.Location = new System.Drawing.Point(107, 84);
            this.lbKodePosPengirim.Name = "lbKodePosPengirim";
            this.lbKodePosPengirim.Size = new System.Drawing.Size(48, 17);
            this.lbKodePosPengirim.TabIndex = 19;
            this.lbKodePosPengirim.Text = "18210";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kode Pos";
            // 
            // lbAlamatPengirim
            // 
            this.lbAlamatPengirim.AutoSize = true;
            this.lbAlamatPengirim.Location = new System.Drawing.Point(107, 57);
            this.lbAlamatPengirim.Name = "lbAlamatPengirim";
            this.lbAlamatPengirim.Size = new System.Drawing.Size(192, 17);
            this.lbAlamatPengirim.TabIndex = 17;
            this.lbAlamatPengirim.Text = "Jalan Kenangan Indah No 62";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Alamat";
            // 
            // lbNamaPengirim
            // 
            this.lbNamaPengirim.AutoSize = true;
            this.lbNamaPengirim.Location = new System.Drawing.Point(107, 28);
            this.lbNamaPengirim.Name = "lbNamaPengirim";
            this.lbNamaPengirim.Size = new System.Drawing.Size(92, 17);
            this.lbNamaPengirim.TabIndex = 15;
            this.lbNamaPengirim.Text = "Budi Santoso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nama";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Masukkan Nomor Resi";
            // 
            // btnCekResi
            // 
            this.btnCekResi.Location = new System.Drawing.Point(242, 90);
            this.btnCekResi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCekResi.Name = "btnCekResi";
            this.btnCekResi.Size = new System.Drawing.Size(91, 25);
            this.btnCekResi.TabIndex = 10;
            this.btnCekResi.Text = "Cek Resi";
            this.btnCekResi.UseVisualStyleBackColor = true;
            // 
            // tbCekResi
            // 
            this.tbCekResi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCekResi.Location = new System.Drawing.Point(17, 89);
            this.tbCekResi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCekResi.Multiline = true;
            this.tbCekResi.Name = "tbCekResi";
            this.tbCekResi.Size = new System.Drawing.Size(219, 24);
            this.tbCekResi.TabIndex = 9;
            this.tbCekResi.Text = "08123433";
            this.tbCekResi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbJudulLaporan
            // 
            this.lbJudulLaporan.AutoSize = true;
            this.lbJudulLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudulLaporan.Location = new System.Drawing.Point(12, 19);
            this.lbJudulLaporan.Name = "lbJudulLaporan";
            this.lbJudulLaporan.Size = new System.Drawing.Size(366, 26);
            this.lbJudulLaporan.TabIndex = 8;
            this.lbJudulLaporan.Text = "LAPORAN PENGIRIMAN PAKET";
            // 
            // FormStatusPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 345);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCekResi);
            this.Controls.Add(this.tbCekResi);
            this.Controls.Add(this.lbJudulLaporan);
            this.Name = "FormStatusPengiriman";
            this.Text = "FormStatusPengiriman";
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvStatusPengiriman;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbTambahStatus;
        private System.Windows.Forms.Button btnTambahStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbNoTelpPengirim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbKotaPengirim;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbKodePosPengirim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbAlamatPengirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbNamaPengirim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCekResi;
        private System.Windows.Forms.TextBox tbCekResi;
        private System.Windows.Forms.Label lbJudulLaporan;
    }
}