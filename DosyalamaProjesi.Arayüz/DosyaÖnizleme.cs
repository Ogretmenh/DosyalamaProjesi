using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using O2_DosyalamaProjesi;

namespace DosyalamaProjesi.Arayüz
{
    public partial class DosyaÖnizleme : Form
    {
        public DosyaÖnizleme(List<DosyaTurleri> DosyaTurleri)
        {
            InitializeComponent();
            _dosyalarım = DosyaTurleri;

        }
        private List<DosyaTurleri> _dosyalarım;


        private void DosyaÖnizleme_Load(object sender, EventArgs e)
        {
            DosyalamaProgram.AktifDosyalamaProgram.TarihiGeceniTasi(@"C:\Users\hakan\Desktop\Dosyalama App\Hedef");
            foreach (DosyaTurleri item in _dosyalarım)
            {
                cmbUzantılar.Items.Add(item.DosyaTuru);
            }
        }
        private void cmbUzantılar_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstwÖnizleme.Items.Clear(); 
            foreach (DosyaTurleri item in _dosyalarım)
            {
                if (item.DosyaTuru == cmbUzantılar.SelectedItem.ToString())
                {
                    foreach (Dosya dosya in item.Dosyalar)
                    {
                        string[] satır =
                        {
                            dosya.DosyaAdi,
                            dosya.Boyut.ToString(),
                            dosya.GecerlilikTarihi.ToShortDateString(),
                            dosya.DosyaAciklama
                        };
                        var veri = new ListViewItem(satır);
                        lstwÖnizleme.Items.Add(veri);
                    }
                }
            }
        }

        private void btnTarihDüzenle_Click(object sender, EventArgs e)
        {
            DateTime tarih = dtpGeçerlilikTarihi.Value;
            lstwÖnizleme.SelectedItems[0].SubItems[clmGeçerlilikTarihi.Index].Text = tarih.ToShortDateString();
            DosyaDüzenleme();
        }

        private void DosyaDüzenleme()
        {
            foreach (DosyaTurleri item in _dosyalarım)
            {
                if (item.DosyaTuru == cmbUzantılar.SelectedItem.ToString())
                {
                    foreach (Dosya dosya in item.Dosyalar)
                    {
                        if(dosya.DosyaAdi == lstwÖnizleme.SelectedItems[0].SubItems[clmAd.Index].Text)
                        {
                            dosya.GecerlilikTarihi = dtpGeçerlilikTarihi.Value;
                        }
                    }
                }
            }
        }

        private void btnAçıklamaDüzenle_Click(object sender, EventArgs e)
        {
            lstwÖnizleme.SelectedItems[0].SubItems[clmAçıklama.Index].Text = txtAçıklama.Text;
            AçıklamaDüzenleme();
            txtAçıklama.Clear();
        }

        private void AçıklamaDüzenleme()
        {
            foreach (DosyaTurleri item in _dosyalarım)
            {
                if (item.DosyaTuru == cmbUzantılar.SelectedItem.ToString())
                {
                    foreach (Dosya dosya in item.Dosyalar)
                    {
                        if (dosya.DosyaAdi == lstwÖnizleme.SelectedItems[0].SubItems[clmAd.Index].Text)
                        {
                            dosya.DosyaAciklama = txtAçıklama.Text;
                        }
                    }
                }
            }
        }

        private void btnYedekle_Click(object sender, EventArgs e)
        {
            Form yedekle = new Yedeklemeİşlemi(_dosyalarım);
            yedekle.ShowDialog();
            
            
        }
    }
}
