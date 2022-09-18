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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string dizin = dlg.SelectedPath;
                Button btn = (Button)sender;
                switch (btn.Tag)
                {
                    case "1": txtKaynakGöster.Text = dizin;break;
                    case "2": txtTaşınacakDizin.Text = dizin;break;
                }
            }
        }

        private void btnDosyalarıDüzenle_Click(object sender, EventArgs e)
        {
            string kaynak = @"C:\Users\hakan\Desktop\Dosyalama App\DataBase";//txtKaynakGöster.Text;
            string hedef = @"C:\Users\hakan\Desktop\Dosyalama App\Hedef"; // txtTaşınacakDizin.Text;
            DosyalamaProgram.AktifDosyalamaProgram.DosyalariTurlerineGoreAyir(kaynak, hedef);
            Form frm = new DosyaÖnizleme(DosyalamaProgram.AktifDosyalamaProgram.DosyaTurleri);
            this.Hide();
            frm.ShowDialog();
            this.Show();
            DosyalamaProgram.AktifDosyalamaProgram.DosyaTurleri.Clear();
        }

        private void btnYedektenÇağır_Click(object sender, EventArgs e)
        {
            Form yedekleme = new Yedeklemeİşlemi();
            this.Hide();
            yedekleme.ShowDialog();
            DosyalamaProgram.AktifDosyalamaProgram.DosyaTurleri.Clear();
            this.Show();
        }

    }
}
