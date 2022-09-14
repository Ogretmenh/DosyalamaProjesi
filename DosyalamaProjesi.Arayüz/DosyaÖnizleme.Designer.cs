namespace DosyalamaProjesi.Arayüz
{
    partial class DosyaÖnizleme
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cmbUzantılar = new System.Windows.Forms.ComboBox();
            this.lstwÖnizleme = new System.Windows.Forms.ListView();
            this.clmAd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmBoyut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmAçıklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGeçerlilikTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtAçıklama = new System.Windows.Forms.TextBox();
            this.btnTarihDüzenle = new System.Windows.Forms.Button();
            this.btnAçıklamaDüzenle = new System.Windows.Forms.Button();
            this.dtpGeçerlilikTarihi = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmbUzantılar);
            this.flowLayoutPanel1.Controls.Add(this.lstwÖnizleme);
            this.flowLayoutPanel1.Controls.Add(this.dtpGeçerlilikTarihi);
            this.flowLayoutPanel1.Controls.Add(this.btnTarihDüzenle);
            this.flowLayoutPanel1.Controls.Add(this.txtAçıklama);
            this.flowLayoutPanel1.Controls.Add(this.btnAçıklamaDüzenle);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(689, 617);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cmbUzantılar
            // 
            this.cmbUzantılar.FormattingEnabled = true;
            this.cmbUzantılar.Location = new System.Drawing.Point(3, 3);
            this.cmbUzantılar.Name = "cmbUzantılar";
            this.cmbUzantılar.Size = new System.Drawing.Size(665, 21);
            this.cmbUzantılar.TabIndex = 0;
            this.cmbUzantılar.SelectedIndexChanged += new System.EventHandler(this.cmbUzantılar_SelectedIndexChanged);
            // 
            // lstwÖnizleme
            // 
            this.lstwÖnizleme.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmAd,
            this.clmBoyut,
            this.clmGeçerlilikTarihi,
            this.clmAçıklama});
            this.lstwÖnizleme.FullRowSelect = true;
            this.lstwÖnizleme.GridLines = true;
            this.lstwÖnizleme.HideSelection = false;
            this.lstwÖnizleme.Location = new System.Drawing.Point(3, 30);
            this.lstwÖnizleme.Name = "lstwÖnizleme";
            this.lstwÖnizleme.Size = new System.Drawing.Size(665, 350);
            this.lstwÖnizleme.TabIndex = 1;
            this.lstwÖnizleme.UseCompatibleStateImageBehavior = false;
            this.lstwÖnizleme.View = System.Windows.Forms.View.Details;
            // 
            // clmAd
            // 
            this.clmAd.Text = "Dosya Adı";
            this.clmAd.Width = 125;
            // 
            // clmBoyut
            // 
            this.clmBoyut.Text = "Boyut (Byte)";
            this.clmBoyut.Width = 73;
            // 
            // clmAçıklama
            // 
            this.clmAçıklama.Text = "Açıklama";
            this.clmAçıklama.Width = 328;
            // 
            // clmGeçerlilikTarihi
            // 
            this.clmGeçerlilikTarihi.Text = "Geçerlilik Tarihi";
            this.clmGeçerlilikTarihi.Width = 125;
            // 
            // txtAçıklama
            // 
            this.txtAçıklama.Location = new System.Drawing.Point(3, 441);
            this.txtAçıklama.Multiline = true;
            this.txtAçıklama.Name = "txtAçıklama";
            this.txtAçıklama.Size = new System.Drawing.Size(204, 129);
            this.txtAçıklama.TabIndex = 3;
            // 
            // btnTarihDüzenle
            // 
            this.btnTarihDüzenle.Location = new System.Drawing.Point(3, 412);
            this.btnTarihDüzenle.Name = "btnTarihDüzenle";
            this.btnTarihDüzenle.Size = new System.Drawing.Size(124, 23);
            this.btnTarihDüzenle.TabIndex = 4;
            this.btnTarihDüzenle.Text = "Tarihi Düzenle";
            this.btnTarihDüzenle.UseVisualStyleBackColor = true;
            this.btnTarihDüzenle.Click += new System.EventHandler(this.btnTarihDüzenle_Click);
            // 
            // btnAçıklamaDüzenle
            // 
            this.btnAçıklamaDüzenle.Location = new System.Drawing.Point(3, 576);
            this.btnAçıklamaDüzenle.Name = "btnAçıklamaDüzenle";
            this.btnAçıklamaDüzenle.Size = new System.Drawing.Size(124, 23);
            this.btnAçıklamaDüzenle.TabIndex = 5;
            this.btnAçıklamaDüzenle.Text = "Açıklama Düzenle";
            this.btnAçıklamaDüzenle.UseVisualStyleBackColor = true;
            // 
            // dtpGeçerlilikTarihi
            // 
            this.dtpGeçerlilikTarihi.Location = new System.Drawing.Point(3, 386);
            this.dtpGeçerlilikTarihi.Name = "dtpGeçerlilikTarihi";
            this.dtpGeçerlilikTarihi.Size = new System.Drawing.Size(204, 20);
            this.dtpGeçerlilikTarihi.TabIndex = 6;
            // 
            // DosyaÖnizleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 617);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DosyaÖnizleme";
            this.Text = "Dosya Önizleme";
            this.Load += new System.EventHandler(this.DosyaÖnizleme_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cmbUzantılar;
        private System.Windows.Forms.ListView lstwÖnizleme;
        private System.Windows.Forms.ColumnHeader clmAd;
        private System.Windows.Forms.ColumnHeader clmBoyut;
        private System.Windows.Forms.ColumnHeader clmAçıklama;
        private System.Windows.Forms.ColumnHeader clmGeçerlilikTarihi;
        private System.Windows.Forms.DateTimePicker dtpGeçerlilikTarihi;
        private System.Windows.Forms.Button btnTarihDüzenle;
        private System.Windows.Forms.TextBox txtAçıklama;
        private System.Windows.Forms.Button btnAçıklamaDüzenle;
    }
}