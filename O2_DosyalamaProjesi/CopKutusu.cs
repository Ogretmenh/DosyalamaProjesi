using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O2_DosyalamaProjesi
{
    public class CopKutusu
    {
        public List<Dosya> TarihiGecenDosyalar { get; set; }

        private static CopKutusu _copKutusu;

        public static CopKutusu AktifCopKutusu 
        {
            get
            {
                if (_copKutusu == null)
                    _copKutusu = new CopKutusu();
                return _copKutusu;
            }
        }

        private CopKutusu()
        {
            TarihiGecenDosyalar = new List<Dosya>();
        }
    }
}
