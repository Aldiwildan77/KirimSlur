namespace src
{
    partial class FormKurir
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
            this.lbNama = new System.Windows.Forms.Label();
            this.lbNoKTP = new System.Windows.Forms.Label();
            this.lbTelp = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbNoKTP = new System.Windows.Forms.TextBox();
            this.tbTelp = new System.Windows.Forms.TextBox();
            this.listKurir = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(38, 50);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(45, 17);
            this.lbNama.TabIndex = 0;
            this.lbNama.Text = "Nama";
            // 
            // lbNoKTP
            // 
            this.lbNoKTP.AutoSize = true;
            this.lbNoKTP.Location = new System.Drawing.Point(38, 96);
            this.lbNoKTP.Name = "lbNoKTP";
            this.lbNoKTP.Size = new System.Drawing.Size(61, 17);
            this.lbNoKTP.TabIndex = 1;
            this.lbNoKTP.Text = "No. KTP";
            // 
            // lbTelp
            // 
            this.lbTelp.AutoSize = true;
            this.lbTelp.Location = new System.Drawing.Point(38, 149);
            this.lbTelp.Name = "lbTelp";
            this.lbTelp.Size = new System.Drawing.Size(36, 17);
            this.lbTelp.TabIndex = 2;
            this.lbTelp.Text = "Telp";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(108, 50);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(196, 22);
            this.tbNama.TabIndex = 3;
            // 
            // tbNoKTP
            // 
            this.tbNoKTP.Location = new System.Drawing.Point(108, 93);
            this.tbNoKTP.Name = "tbNoKTP";
            this.tbNoKTP.Size = new System.Drawing.Size(196, 22);
            this.tbNoKTP.TabIndex = 4;
            // 
            // tbTelp
            // 
            this.tbTelp.Location = new System.Drawing.Point(108, 149);
            this.tbTelp.Name = "tbTelp";
            this.tbTelp.Size = new System.Drawing.Size(196, 22);
            this.tbTelp.TabIndex = 5;
            // 
            // listKurir
            // 
            this.listKurir.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listKurir.Location = new System.Drawing.Point(343, 18);
            this.listKurir.Name = "listKurir";
            this.listKurir.Size = new System.Drawing.Size(431, 236);
            this.listKurir.TabIndex = 6;
            this.listKurir.UseCompatibleStateImageBehavior = false;
            this.listKurir.View = System.Windows.Forms.View.Details;
            this.listKurir.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listKurir_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nama";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "No. KTP";
            this.columnHeader2.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Telp";
            this.columnHeader3.Width = 132;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(41, 206);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.BtnTambah_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(133, 206);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(229, 206);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 9;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click);
            // 
            // FormKurir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 294);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.listKurir);
            this.Controls.Add(this.tbTelp);
            this.Controls.Add(this.tbNoKTP);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbTelp);
            this.Controls.Add(this.lbNoKTP);
            this.Controls.Add(this.lbNama);
            this.Name = "FormKurir";
            this.Text = "FormKurir";
            this.Load += new System.EventHandler(this.FormKurir_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListKurir_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNama;
        private System.Windows.Forms.Label lbNoKTP;
        private System.Windows.Forms.Label lbTelp;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbNoKTP;
        private System.Windows.Forms.TextBox tbTelp;
        private System.Windows.Forms.ListView listKurir;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}