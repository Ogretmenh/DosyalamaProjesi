using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace O2_DosyalamaProjesi
{

    public class Dosya
    {
        public string DosyaAdi { get; set; }

        public string Uzanti { get; set; }

        public string Konum { get;  set; }

        public long Boyut { get; set; }

        public Dosya(FileInfo fileInfo)
        {
            
            this.DosyaAdi = fileInfo.Name;
            this.Uzanti = fileInfo.Extension;
            this.Konum = fileInfo.FullName;
            this.Boyut = fileInfo.Length;
            this.GecerlilikTarihi = DateTime.Now.AddDays(7);
        }

        public DateTime GecerlilikTarihi { get; set; }

        public string DosyaAciklama { get; set; }

        public bool TarihinGectiMi 
        {
            get
            {
                if (this.GecerlilikTarihi < DateTime.Now)
                {
                    return true;
                }
                return false;
            } 
        }

        

        [JsonConstructor]
        private Dosya()
        {

        }
    }
}
