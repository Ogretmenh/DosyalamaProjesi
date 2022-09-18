using O2_DosyalamaProjesi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DosyalamaProjesi.Arayüz
{
    public partial class Yedeklemeİşlemi : Form
    {
        List<DosyaTurleri> _yedeklenecekdosyalar;
        public Yedeklemeİşlemi(List<DosyaTurleri> dosyalarım)
        {
            InitializeComponent();
            btnYedeklemeİşlemi.Click += BtnYedeklemeİşlemi_Click;
            _yedeklenecekdosyalar = dosyalarım;
        }

        private void BtnYedeklemeİşlemi_Click(object sender, EventArgs e)
        {
            string yedekAdı = txtYedekDosyaAdı.Text;
            string yedekDosyaKonumu = txtYedeklemeKonumu.Text;

            DosyalamaProgram.AktifDosyalamaProgram.Yedekle(yedekDosyaKonumu, yedekAdı);
            MessageBox.Show("Yedekleme işlemi başarı ile tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void txtYedeklemeKonumu_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog dlgYedekleme = new FolderBrowserDialog();
            if(dlgYedekleme.ShowDialog() == DialogResult.OK)
            {
                string dizin = dlgYedekleme.SelectedPath;
                txtYedeklemeKonumu.Text = dizin;
            }
        }
        public Yedeklemeİşlemi()
        {
            InitializeComponent();
            btnYedeklemeİşlemi.Click += BtnYedekİşlemi_Click;
            btnYedeklemeİşlemi.Text = "Yedekten Çağır";
            label1.Text = "Yedek Adı :";
            label2.Text = "Yedek Konumu :";
            this.FormClosed += Yedeklemeİşlemi_FormClosed;
        }

        private void Yedeklemeİşlemi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form frm = new DosyaÖnizleme(DosyalamaProgram.AktifDosyalamaProgram.DosyaTurleri);
            frm.ShowDialog();
        }

        private void Yedeklemeİşlemi_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form frm = new DosyaÖnizleme(DosyalamaProgram.AktifDosyalamaProgram.DosyaTurleri);
            frm.ShowDialog();

        }

        private void BtnYedekİşlemi_Click(object sender, EventArgs e)
        {
            string yedekAdı = txtYedekDosyaAdı.Text;
            string yedekDosyaKonumu = txtYedeklemeKonumu.Text;

            DosyalamaProgram.AktifDosyalamaProgram.YedektenCagir(yedekDosyaKonumu, yedekAdı);
            MessageBox.Show("Yedekten çağırma işlemi başarılı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            this.Close();
        }
    }
}
