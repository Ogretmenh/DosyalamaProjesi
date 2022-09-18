namespace DosyalamaProjesi.Arayüz
{
    partial class Yedeklemeİşlemi
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
            this.txtYedekDosyaAdı = new System.Windows.Forms.TextBox();
            this.btnYedeklemeİşlemi = new System.Windows.Forms.Button();
            this.txtYedeklemeKonumu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtYedekDosyaAdı
            // 
            this.txtYedekDosyaAdı.Location = new System.Drawing.Point(125, 12);
            this.txtYedekDosyaAdı.Name = "txtYedekDosyaAdı";
            this.txtYedekDosyaAdı.Size = new System.Drawing.Size(238, 20);
            this.txtYedekDosyaAdı.TabIndex = 0;
            // 
            // btnYedeklemeİşlemi
            // 
            this.btnYedeklemeİşlemi.Location = new System.Drawing.Point(262, 89);
            this.btnYedeklemeİşlemi.Name = "btnYedeklemeİşlemi";
            this.btnYedeklemeİşlemi.Size = new System.Drawing.Size(101, 33);
            this.btnYedeklemeİşlemi.TabIndex = 1;
            this.btnYedeklemeİşlemi.Text = "Yedekle";
            this.btnYedeklemeİşlemi.UseVisualStyleBackColor = true;
            // 
            // txtYedeklemeKonumu
            // 
            this.txtYedeklemeKonumu.Location = new System.Drawing.Point(125, 48);
            this.txtYedeklemeKonumu.Name = "txtYedeklemeKonumu";
            this.txtYedeklemeKonumu.Size = new System.Drawing.Size(238, 20);
            this.txtYedeklemeKonumu.TabIndex = 0;
            this.txtYedeklemeKonumu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtYedeklemeKonumu_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yedekleme Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Yedekleme Konumu :";
            // 
            // Yedeklemeİşlemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(381, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYedeklemeİşlemi);
            this.Controls.Add(this.txtYedeklemeKonumu);
            this.Controls.Add(this.txtYedekDosyaAdı);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Yedeklemeİşlemi";
            this.Text = "Yedekleme İşlemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtYedekDosyaAdı;
        private System.Windows.Forms.Button btnYedeklemeİşlemi;
        private System.Windows.Forms.TextBox txtYedeklemeKonumu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}