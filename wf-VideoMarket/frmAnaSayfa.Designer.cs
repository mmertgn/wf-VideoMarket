﻿namespace wf_VideoMarket
{
    partial class frmAnaSayfa
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
            this.mnuAnaSayfa = new System.Windows.Forms.MenuStrip();
            this.filmBilgileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmTanimlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmTuruTanımlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.müşterilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriTanımlama = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmMusteriSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.satışİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmFilmSatis = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmSatisSorgulama = new System.Windows.Forms.ToolStripMenuItem();
            this.raporlamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmDetayliSatisAnalizi = new System.Windows.Forms.ToolStripMenuItem();
            this.mitmCikis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAnaSayfa
            // 
            this.mnuAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmBilgileriToolStripMenuItem,
            this.müşterilerToolStripMenuItem,
            this.satışİşlemleriToolStripMenuItem,
            this.raporlamaToolStripMenuItem,
            this.mitmCikis});
            this.mnuAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.mnuAnaSayfa.Name = "mnuAnaSayfa";
            this.mnuAnaSayfa.Size = new System.Drawing.Size(857, 24);
            this.mnuAnaSayfa.TabIndex = 1;
            this.mnuAnaSayfa.Text = "menuStrip1";
            // 
            // filmBilgileriToolStripMenuItem
            // 
            this.filmBilgileriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmFilmTanimlama,
            this.mitmFilmTuruTanımlama,
            this.mitmFilmSorgulama});
            this.filmBilgileriToolStripMenuItem.Name = "filmBilgileriToolStripMenuItem";
            this.filmBilgileriToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.filmBilgileriToolStripMenuItem.Text = "&Film Bilgileri";
            // 
            // mitmFilmTanimlama
            // 
            this.mitmFilmTanimlama.Name = "mitmFilmTanimlama";
            this.mitmFilmTanimlama.Size = new System.Drawing.Size(188, 22);
            this.mitmFilmTanimlama.Text = "Film &Tanımlama";
            this.mitmFilmTanimlama.Click += new System.EventHandler(this.mitmFilmTanimlama_Click);
            // 
            // mitmFilmTuruTanımlama
            // 
            this.mitmFilmTuruTanımlama.Name = "mitmFilmTuruTanımlama";
            this.mitmFilmTuruTanımlama.Size = new System.Drawing.Size(188, 22);
            this.mitmFilmTuruTanımlama.Text = "F&ilm Türü Tanımlama";
            this.mitmFilmTuruTanımlama.Click += new System.EventHandler(this.mitmFilmTuruTanımlama_Click);
            // 
            // mitmFilmSorgulama
            // 
            this.mitmFilmSorgulama.Name = "mitmFilmSorgulama";
            this.mitmFilmSorgulama.Size = new System.Drawing.Size(188, 22);
            this.mitmFilmSorgulama.Text = "Film &Sorgulama";
            this.mitmFilmSorgulama.Click += new System.EventHandler(this.mitmFilmSorgulama_Click);
            // 
            // müşterilerToolStripMenuItem
            // 
            this.müşterilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmMusteriTanımlama,
            this.mitmMusteriSorgulama});
            this.müşterilerToolStripMenuItem.Name = "müşterilerToolStripMenuItem";
            this.müşterilerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.müşterilerToolStripMenuItem.Text = "&Müşteriler";
            // 
            // mitmMusteriTanımlama
            // 
            this.mitmMusteriTanımlama.Name = "mitmMusteriTanımlama";
            this.mitmMusteriTanımlama.Size = new System.Drawing.Size(177, 22);
            this.mitmMusteriTanımlama.Text = "Müşteri &Tanımlama";
            this.mitmMusteriTanımlama.Click += new System.EventHandler(this.mitmMusteriTanımlama_Click);
            // 
            // mitmMusteriSorgulama
            // 
            this.mitmMusteriSorgulama.Name = "mitmMusteriSorgulama";
            this.mitmMusteriSorgulama.Size = new System.Drawing.Size(177, 22);
            this.mitmMusteriSorgulama.Text = "Müşteri &Sorgulama";
            this.mitmMusteriSorgulama.Click += new System.EventHandler(this.mitmMusteriSorgulama_Click);
            // 
            // satışİşlemleriToolStripMenuItem
            // 
            this.satışİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmFilmSatis,
            this.mitmSatisSorgulama});
            this.satışİşlemleriToolStripMenuItem.Name = "satışİşlemleriToolStripMenuItem";
            this.satışİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.satışİşlemleriToolStripMenuItem.Text = "&Satış İşlemleri";
            // 
            // mitmFilmSatis
            // 
            this.mitmFilmSatis.Name = "mitmFilmSatis";
            this.mitmFilmSatis.Size = new System.Drawing.Size(158, 22);
            this.mitmFilmSatis.Text = "&Film Satış";
            this.mitmFilmSatis.Click += new System.EventHandler(this.mitmFilmSatis_Click);
            // 
            // mitmSatisSorgulama
            // 
            this.mitmSatisSorgulama.Name = "mitmSatisSorgulama";
            this.mitmSatisSorgulama.Size = new System.Drawing.Size(158, 22);
            this.mitmSatisSorgulama.Text = "Satış &Sorgulama";
            this.mitmSatisSorgulama.Click += new System.EventHandler(this.mitmSatisSorgulama_Click);
            // 
            // raporlamaToolStripMenuItem
            // 
            this.raporlamaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mitmDetayliSatisAnalizi});
            this.raporlamaToolStripMenuItem.Name = "raporlamaToolStripMenuItem";
            this.raporlamaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.raporlamaToolStripMenuItem.Text = "&Raporlama";
            // 
            // mitmDetayliSatisAnalizi
            // 
            this.mitmDetayliSatisAnalizi.Name = "mitmDetayliSatisAnalizi";
            this.mitmDetayliSatisAnalizi.Size = new System.Drawing.Size(175, 22);
            this.mitmDetayliSatisAnalizi.Text = "Detaylı &Satış Analizi";
            this.mitmDetayliSatisAnalizi.Click += new System.EventHandler(this.mitmDetayliSatisAnalizi_Click);
            // 
            // mitmCikis
            // 
            this.mitmCikis.Name = "mitmCikis";
            this.mitmCikis.Size = new System.Drawing.Size(44, 20);
            this.mitmCikis.Text = "&Çıkış";
            this.mitmCikis.Click += new System.EventHandler(this.mitmCikis_Click);
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 387);
            this.Controls.Add(this.mnuAnaSayfa);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuAnaSayfa;
            this.Name = "frmAnaSayfa";
            this.ShowIcon = false;
            this.Text = "Video Market Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuAnaSayfa.ResumeLayout(false);
            this.mnuAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuAnaSayfa;
        private System.Windows.Forms.ToolStripMenuItem filmBilgileriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşterilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmTanimlama;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmTuruTanımlama;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmSorgulama;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriTanımlama;
        private System.Windows.Forms.ToolStripMenuItem mitmMusteriSorgulama;
        private System.Windows.Forms.ToolStripMenuItem satışİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmFilmSatis;
        private System.Windows.Forms.ToolStripMenuItem mitmSatisSorgulama;
        private System.Windows.Forms.ToolStripMenuItem raporlamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mitmDetayliSatisAnalizi;
        private System.Windows.Forms.ToolStripMenuItem mitmCikis;
    }
}