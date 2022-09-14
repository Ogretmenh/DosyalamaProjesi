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
            foreach (Dosya item in this.Dosyalar)
            {
                if (item.TarihinGectiMi)
                {
                    tarihiGecenDosyaList.Add(item);
                    this.Dosyalar.Remove(item);
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
