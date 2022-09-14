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
        public DosyaÖnizleme(string kaynak, string hedef)
        {
            InitializeComponent();
            Kaynak = kaynak;
            Hedef = hedef;
        }
        private List<DosyaTurleri> _dosyalarım;
        private string Kaynak { get; }
        private string Hedef { get; }

        private void DosyaÖnizleme_Load(object sender, EventArgs e)
        {
            DosyalamaProgram.AktifDosyalamaProgram.DosyalariTurlerineGoreAyir(Kaynak, Hedef);
            _dosyalarım = DosyalamaProgram.AktifDosyalamaProgram.DosyaTurleri;

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
                            dosya.GecerlilikTarihi.ToString(),
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
            string tarih = dtpGeçerlilikTarihi.Text;
            lstwÖnizleme.SelectedItems[0].SubItems[clmGeçerlilikTarihi.Index].Text = tarih;
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

    }
}
