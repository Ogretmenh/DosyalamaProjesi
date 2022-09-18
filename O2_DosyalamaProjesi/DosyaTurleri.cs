using Newtonsoft.Json;
using System.Collections.Generic;

namespace O2_DosyalamaProjesi
{

    public class DosyaTurleri 
    {
        public List<Dosya> Dosyalar { get; set; }

        public string DosyaTuru { get; set; }

        public string Konum { get; set; }

        public DosyaTurleri(Dosya dosya)
        {
            this.Dosyalar = new List<Dosya>();

            this.DosyaTuru = dosya.Uzanti;

            this.Dosyalar.Add(dosya);
        }

        internal List<Dosya> TarihiGecenDosyalariGetir()
        {
            List<Dosya> tarihiGecenDosyaList = new List<Dosya>();
            for(int i = 0; i < this.Dosyalar.Count; i++)
            {
                if (this.Dosyalar[i].TarihinGectiMi)
                {
                    tarihiGecenDosyaList.Add(this.Dosyalar[i]);
                    this.Dosyalar.Remove(this.Dosyalar[i]);
                    i = 0;
                }
                if(this.Dosyalar.Count == 0)
                {
                    break;
                }
                
            }
            return tarihiGecenDosyaList;
        }

        public bool DosyaTuruVarsaEkle(Dosya dosya)
        {
            if (this.DosyaTuru==dosya.Uzanti)
            {
                this.Dosyalar.Add(dosya);
                return true;
            }
            return false;
        }

        [JsonConstructor]
        public DosyaTurleri()
        {

        }


    }
}
