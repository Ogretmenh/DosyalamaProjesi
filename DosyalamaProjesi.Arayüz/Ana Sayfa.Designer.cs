namespace DosyalamaProjesi.Arayüz
{
    partial class Form1
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
            this.txtKaynakGöster = new System.Windows.Forms.TextBox();
            this.btnGetir = new System.Windows.Forms.Button();
            this.txtTaşınacakDizin = new System.Windows.Forms.TextBox();
            this.btnTaşınacakDizin = new System.Windows.Forms.Button();
            this.btnDosyalarıDüzenle = new System.Windows.Forms.Button();
            this.btnYedektenÇağır = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKaynakGöster
            // 
            this.txtKaynakGöster.Location = new System.Drawing.Point(26, 12);
            this.txtKaynakGöster.Name = "txtKaynakGöster";
            this.txtKaynakGöster.ReadOnly = true;
            this.txtKaynakGöster.Size = new System.Drawing.Size(458, 20);
            this.txtKaynakGöster.TabIndex = 0;
            // 
            // btnGetir
            // 
            this.btnGetir.Location = new System.Drawing.Point(502, 10);
            this.btnGetir.Name = "btnGetir";
            this.btnGetir.Size = new System.Drawing.Size(113, 23);
            this.btnGetir.TabIndex = 1;
            this.btnGetir.Tag = "1";
            this.btnGetir.Text = "Kaynak Dizin";
            this.btnGetir.UseVisualStyleBackColor = true;
            this.btnGetir.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // txtTaşınacakDizin
            // 
            this.txtTaşınacakDizin.Location = new System.Drawing.Point(26, 38);
            this.txtTaşınacakDizin.Name = "txtTaşınacakDizin";
            this.txtTaşınacakDizin.ReadOnly = true;
            this.txtTaşınacakDizin.Size = new System.Drawing.Size(458, 20);
            this.txtTaşınacakDizin.TabIndex = 0;
            // 
            // btnTaşınacakDizin
            // 
            this.btnTaşınacakDizin.Location = new System.Drawing.Point(502, 36);
            this.btnTaşınacakDizin.Name = "btnTaşınacakDizin";
            this.btnTaşınacakDizin.Size = new System.Drawing.Size(113, 23);
            this.btnTaşınacakDizin.TabIndex = 1;
            this.btnTaşınacakDizin.Tag = "2";
            this.btnTaşınacakDizin.Text = "Taşınacak Dizin";
            this.btnTaşınacakDizin.UseVisualStyleBackColor = true;
            this.btnTaşınacakDizin.Click += new System.EventHandler(this.btnGetir_Click);
            // 
            // btnDosyalarıDüzenle
            // 
            this.btnDosyalarıDüzenle.Location = new System.Drawing.Point(502, 65);
            this.btnDosyalarıDüzenle.Name = "btnDosyalarıDüzenle";
            this.btnDosyalarıDüzenle.Size = new System.Drawing.Size(113, 22);
            this.btnDosyalarıDüzenle.TabIndex = 2;
            this.btnDosyalarıDüzenle.Text = "Dosyaları Düzenle";
            this.btnDosyalarıDüzenle.UseVisualStyleBackColor = true;
            this.btnDosyalarıDüzenle.Click += new System.EventHandler(this.btnDosyalarıDüzenle_Click);
            // 
            // btnYedektenÇağır
            // 
            this.btnYedektenÇağır.Location = new System.Drawing.Point(502, 93);
            this.btnYedektenÇağır.Name = "btnYedektenÇağır";
            this.btnYedektenÇağır.Size = new System.Drawing.Size(113, 23);
            this.btnYedektenÇağır.TabIndex = 3;
            this.btnYedektenÇağır.Text = "Yedekten Çağır";
            this.btnYedektenÇağır.UseVisualStyleBackColor = true;
            this.btnYedektenÇağır.Click += new System.EventHandler(this.btnYedektenÇağır_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 206);
            this.Controls.Add(this.btnYedektenÇağır);
            this.Controls.Add(this.btnDosyalarıDüzenle);
            this.Controls.Add(this.btnTaşınacakDizin);
            this.Controls.Add(this.btnGetir);
            this.Controls.Add(this.txtTaşınacakDizin);
            this.Controls.Add(this.txtKaynakGöster);
            this.Name = "Form1";
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKaynakGöster;
        private System.Windows.Forms.Button btnGetir;
        private System.Windows.Forms.TextBox txtTaşınacakDizin;
        private System.Windows.Forms.Button btnTaşınacakDizin;
        private System.Windows.Forms.Button btnDosyalarıDüzenle;
        private System.Windows.Forms.Button btnYedektenÇağır;
    }
}

