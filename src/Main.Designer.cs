namespace src
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pelangganToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kurirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pengirimanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusPengirimanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pelangganToolStripMenuItem,
            this.barangToolStripMenuItem,
            this.kurirToolStripMenuItem,
            this.pengirimanToolStripMenuItem,
            this.statusPengirimanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pelangganToolStripMenuItem
            // 
            this.pelangganToolStripMenuItem.Name = "pelangganToolStripMenuItem";
            this.pelangganToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.pelangganToolStripMenuItem.Text = "Pelanggan";
            this.pelangganToolStripMenuItem.Click += new System.EventHandler(this.pelangganToolStripMenuItem_Click);
            // 
            // barangToolStripMenuItem
            // 
            this.barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            this.barangToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.barangToolStripMenuItem.Text = "Barang";
            this.barangToolStripMenuItem.Click += new System.EventHandler(this.barangToolStripMenuItem_Click);
            // 
            // kurirToolStripMenuItem
            // 
            this.kurirToolStripMenuItem.Name = "kurirToolStripMenuItem";
            this.kurirToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.kurirToolStripMenuItem.Text = "Kurir";
            this.kurirToolStripMenuItem.Click += new System.EventHandler(this.kurirToolStripMenuItem_Click);
            // 
            // pengirimanToolStripMenuItem
            // 
            this.pengirimanToolStripMenuItem.Name = "pengirimanToolStripMenuItem";
            this.pengirimanToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.pengirimanToolStripMenuItem.Text = "Pengiriman";
            this.pengirimanToolStripMenuItem.Click += new System.EventHandler(this.pengirimanToolStripMenuItem_Click);
            // 
            // statusPengirimanToolStripMenuItem
            // 
            this.statusPengirimanToolStripMenuItem.Name = "statusPengirimanToolStripMenuItem";
            this.statusPengirimanToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.statusPengirimanToolStripMenuItem.Text = "Status Pengiriman";
            this.statusPengirimanToolStripMenuItem.Click += new System.EventHandler(this.statusPengirimanToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Program Pengiriman Paket";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pelangganToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kurirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pengirimanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusPengirimanToolStripMenuItem;
    }
}

