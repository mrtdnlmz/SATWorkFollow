namespace WF.WebFormsUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniİşEmriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniİşEmriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKartıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPersonelEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgwPersonel = new System.Windows.Forms.DataGridView();
            this.işEmirleriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİşEmriToolStripMenuItem,
            this.personelKartıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(932, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniİşEmriToolStripMenuItem
            // 
            this.yeniİşEmriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniİşEmriToolStripMenuItem1,
            this.işEmirleriListesiToolStripMenuItem});
            this.yeniİşEmriToolStripMenuItem.Name = "yeniİşEmriToolStripMenuItem";
            this.yeniİşEmriToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.yeniİşEmriToolStripMenuItem.Text = "İş Emirleri";
            // 
            // yeniİşEmriToolStripMenuItem1
            // 
            this.yeniİşEmriToolStripMenuItem1.Name = "yeniİşEmriToolStripMenuItem1";
            this.yeniİşEmriToolStripMenuItem1.ShowShortcutKeys = false;
            this.yeniİşEmriToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.yeniİşEmriToolStripMenuItem1.Text = "Yeni İş Emri Aç";
            // 
            // personelKartıToolStripMenuItem
            // 
            this.personelKartıToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelListesiToolStripMenuItem,
            this.yeniPersonelEkleToolStripMenuItem});
            this.personelKartıToolStripMenuItem.Name = "personelKartıToolStripMenuItem";
            this.personelKartıToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.personelKartıToolStripMenuItem.Text = "Personel Kartı";
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.personelListesiToolStripMenuItem.Text = "Personel Listesi";
            // 
            // yeniPersonelEkleToolStripMenuItem
            // 
            this.yeniPersonelEkleToolStripMenuItem.Name = "yeniPersonelEkleToolStripMenuItem";
            this.yeniPersonelEkleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.yeniPersonelEkleToolStripMenuItem.Text = "Yeni Personel Ekle";
            // 
            // dgwPersonel
            // 
            this.dgwPersonel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgwPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwPersonel.Location = new System.Drawing.Point(12, 27);
            this.dgwPersonel.Name = "dgwPersonel";
            this.dgwPersonel.Size = new System.Drawing.Size(908, 232);
            this.dgwPersonel.TabIndex = 1;
            // 
            // işEmirleriListesiToolStripMenuItem
            // 
            this.işEmirleriListesiToolStripMenuItem.Name = "işEmirleriListesiToolStripMenuItem";
            this.işEmirleriListesiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.işEmirleriListesiToolStripMenuItem.Text = "İş Emirleri Listesi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 473);
            this.Controls.Add(this.dgwPersonel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwPersonel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniİşEmriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKartıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgwPersonel;
        private System.Windows.Forms.ToolStripMenuItem yeniİşEmriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işEmirleriListesiToolStripMenuItem;
    }
}

