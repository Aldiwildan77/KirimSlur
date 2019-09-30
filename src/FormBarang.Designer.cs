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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbJenis = new System.Windows.Forms.TextBox();
            this.tbBerat = new System.Windows.Forms.TextBox();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.lbJenis = new System.Windows.Forms.Label();
            this.lbBerat = new System.Windows.Forms.Label();
            this.lbNama = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(226, 212);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 19;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(130, 212);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(38, 212);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 23);
            this.btnTambah.TabIndex = 17;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // listBarang
            // 
            this.listBarang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listBarang.Location = new System.Drawing.Point(345, 25);
            this.listBarang.Name = "listBarang";
            this.listBarang.Size = new System.Drawing.Size(431, 236);
            this.listBarang.TabIndex = 16;
            this.listBarang.UseCompatibleStateImageBehavior = false;
            this.listBarang.View = System.Windows.Forms.View.Details;
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
            this.tbJenis.Location = new System.Drawing.Point(105, 155);
            this.tbJenis.Name = "tbJenis";
            this.tbJenis.Size = new System.Drawing.Size(196, 22);
            this.tbJenis.TabIndex = 15;
            // 
            // tbBerat
            // 
            this.tbBerat.Location = new System.Drawing.Point(105, 99);
            this.tbBerat.Name = "tbBerat";
            this.tbBerat.Size = new System.Drawing.Size(196, 22);
            this.tbBerat.TabIndex = 14;
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(105, 56);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(196, 22);
            this.tbNama.TabIndex = 13;
            // 
            // lbJenis
            // 
            this.lbJenis.AutoSize = true;
            this.lbJenis.Location = new System.Drawing.Point(35, 155);
            this.lbJenis.Name = "lbJenis";
            this.lbJenis.Size = new System.Drawing.Size(41, 17);
            this.lbJenis.TabIndex = 12;
            this.lbJenis.Text = "Jenis";
            // 
            // lbBerat
            // 
            this.lbBerat.AutoSize = true;
            this.lbBerat.Location = new System.Drawing.Point(35, 102);
            this.lbBerat.Name = "lbBerat";
            this.lbBerat.Size = new System.Drawing.Size(42, 17);
            this.lbBerat.TabIndex = 11;
            this.lbBerat.Text = "Berat";
            // 
            // lbNama
            // 
            this.lbNama.AutoSize = true;
            this.lbNama.Location = new System.Drawing.Point(35, 56);
            this.lbNama.Name = "lbNama";
            this.lbNama.Size = new System.Drawing.Size(45, 17);
            this.lbNama.TabIndex = 10;
            this.lbNama.Text = "Nama";
            // 
            // FormBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 298);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.listBarang);
            this.Controls.Add(this.tbJenis);
            this.Controls.Add(this.tbBerat);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.lbJenis);
            this.Controls.Add(this.lbBerat);
            this.Controls.Add(this.lbNama);
            this.Name = "FormBarang";
            this.Text = "FormBarang";
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
        private System.Windows.Forms.Label lbNama;
    }
}