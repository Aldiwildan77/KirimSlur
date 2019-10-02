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
            this.label1 = new System.Windows.Forms.Label();
            this.tbCekResi = new System.Windows.Forms.TextBox();
            this.lbJudulLaporan = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.cbTambahStatus);
            this.groupBox4.Controls.Add(this.btnTambahStatus);
            this.groupBox4.Location = new System.Drawing.Point(17, 105);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox4.Size = new System.Drawing.Size(516, 243);
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
            this.btnTambahStatus.Click += new System.EventHandler(this.BtnTambahStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nomor Resi";
            // 
            // tbCekResi
            // 
            this.tbCekResi.Enabled = false;
            this.tbCekResi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCekResi.Location = new System.Drawing.Point(112, 57);
            this.tbCekResi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCekResi.Multiline = true;
            this.tbCekResi.Name = "tbCekResi";
            this.tbCekResi.Size = new System.Drawing.Size(421, 24);
            this.tbCekResi.TabIndex = 9;
            this.tbCekResi.Text = "08123433";
            this.tbCekResi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbJudulLaporan
            // 
            this.lbJudulLaporan.AutoSize = true;
            this.lbJudulLaporan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJudulLaporan.Location = new System.Drawing.Point(75, 19);
            this.lbJudulLaporan.Name = "lbJudulLaporan";
            this.lbJudulLaporan.Size = new System.Drawing.Size(419, 26);
            this.lbJudulLaporan.TabIndex = 8;
            this.lbJudulLaporan.Text = "FORM STATUS PENGIRIMAN PAKET";
            // 
            // FormStatusPengiriman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 377);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCekResi);
            this.Controls.Add(this.lbJudulLaporan);
            this.Name = "FormStatusPengiriman";
            this.Text = "FormStatusPengiriman";
            this.Load += new System.EventHandler(this.FormStatusPengiriman_Load);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCekResi;
        private System.Windows.Forms.Label lbJudulLaporan;
    }
}