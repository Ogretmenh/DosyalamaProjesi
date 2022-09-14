using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace O2_DosyalamaProjesi
{
    public class DosyalamaProgram
    {
        private string[] DizindekiDosyalar { get; set; }

        public List<DosyaTurleri> DosyaTurleri { get; set; }

        #region Singleton Pattern
        private DosyalamaProgram()
        {
            DosyaTurleri = new List<DosyaTurleri>();
        }

        private static DosyalamaProgram _dosyalamaProgram;

        public static DosyalamaProgram AktifDosyalamaProgram
        {
            get
            {
                if (_dosyalamaProgram == null)
                    _dosyalamaProgram = new DosyalamaProgram();
                return _dosyalamaProgram;
            }
        }

        #endregion

        private void DosyalarıAyir(string dizin)
        {
            DosyaSec(dizin);
            DosyalarıTürleriBelirle();
        }
        #region DosyalariAyir

        private void DosyaSec(string dizin)
        {
            DizindekiDosyalar = Directory.GetFiles(dizin);
        }

        private void DosyalarıTürleriBelirle()
        {
            foreach (string item in DizindekiDosyalar)
            {
                FileInfo fileInfo = new FileInfo(item);

                Dosya dosya = new Dosya(fileInfo);

                DosyaTuruListele(dosya);
            }
        }

        private void DosyaTuruListele(Dosya dosya)
        {
            foreach (DosyaTurleri item in DosyaTurleri)
            {
                if (item.DosyaTuruVarsaEkle(dosya))
                {
                    return;
                }
            }

            DosyaTurleri dosyaTurleri = new DosyaTurleri(dosya);
            DosyaTurleri.Add(dosyaTurleri);
        }
        #endregion


        private void YeniDosyalama(string hedefDizin)
        {
            TurlereGoreDosyaOlustur(hedefDizin);
            DosyalarıTurlereGoreKopyala();
        }

        #region YeniDosyalama

        private void TurlereGoreDosyaOlustur(string hedefDizin)
        {
            foreach (DosyaTurleri item in DosyaTurleri)
            {
                item.Konum = hedefDizin + "\\" + item.DosyaTuru;

                Directory.CreateDirectory(item.Konum);
            }
        }

        private void DosyalarıTurlereGoreKopyala()
        {
            foreach (DosyaTurleri tur in DosyaTurleri)
            {
                foreach (Dosya dosya in tur.Dosyalar)
                {
                    string hedefDosya = tur.Konum + "\\" + dosya.DosyaAdi;

                    if (!AynıIsimVarmi(hedefDosya))
                    {
                        File.Copy(dosya.Konum, hedefDosya);
                        dosya.Konum = hedefDosya;
                    }
                }
            }
        }

        private bool AynıIsimVarmi(string hedefDosya)
        {
            if (File.Exists(hedefDosya))
            {
                return true;
            }
            return false;
        }
        #endregion


        #region Islemler


        /// <summary>
        /// dizin : Dosyaların bulundugu klasor dizini, hedefDizin : dosyaların kopyalanmak istendiği klasor dizini
        /// </summary>
        /// <param name="dizin"></param>
        /// <param name="hedefDizin"></param>
        public void DosyalariTurlerineGoreAyir(string dizin, string hedefDizin)
        {
            DosyalarıAyir(dizin);
            YeniDosyalama(hedefDizin);
        }

        /// <summary>
        /// Girilen dizine JSonKayıt adında bir klasor olusturur.
        /// Bu klasor ıcerısıne girilen KayitAdi isminde .json uzantılı kayıt dosyası olusturur.
        /// </summary>
        /// <param name="Dizin"></param>
        public void Yedekle(string Dizin, string KayitAdi)
        {
            string kayitKlasor = Dizin + "\\JSonKayıt";
            string kayitDizin = kayitKlasor + "\\" + KayitAdi + ".json";

            Directory.CreateDirectory(kayitKlasor);

            var settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                TypeNameHandling = TypeNameHandling.All
            };

            var json = JsonConvert.SerializeObject(DosyaTurleri, settings);

            File.WriteAllText(kayitDizin, json);
        }

        /// <summary>
        /// Girilen dizinde belirtilen isimde, .json uzantılı kayıt klasorunu varsa siler.
        /// </summary>
        /// <param name="Dizin"></param>
        /// <exception cref="Exception"></exception>
        public void YedekleriTemizle(string Dizin, string kayitAdi)
        {
            string kayitDizin = Dizin + "\\" + kayitAdi + ".json";

            if (File.Exists(kayitDizin))
            {
                File.Delete(kayitDizin);
            }
        }


        /// <summary>
        /// Girilen dizinde belirtilen isimde .json uzantılı dosya bulunuyorsa geri yukler.
        /// </summary>
        /// <param name="Dizin"></param>
        /// <exception cref="Exception"></exception>
        public void YedektenCagir(string Dizin, string kayitAdi)
        {
            string kayitDizin = Dizin + "\\" + kayitAdi + ".json";
            if (File.Exists(kayitDizin))
            {
                string json = File.ReadAllText(kayitDizin);

                var settings = new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    TypeNameHandling = TypeNameHandling.All
                };

                DosyaTurleri = JsonConvert.DeserializeObject<List<DosyaTurleri>>(json, settings);              
            }
        }

        /// <summary>
        /// Tarihi gecen dosyaları Copkutusu nesnesinde bir listede tutar.
        /// Girilen dizinde bir Cop Kutusu klasoru olusturur ve bu dosyaları buraya tasır.
        /// </summary>
        public void TarihiGeceniTasi(string dizin)
        {
            string copDizin = dizin + "\\Cop Kutusu";
            
            Directory.CreateDirectory(copDizin);

            foreach (DosyaTurleri item in DosyaTurleri)
            {
                foreach (Dosya dosya in item.TarihiGecenDosyalariGetir())
                {
                    CopKutusu.AktifCopKutusu.TarihiGecenDosyalar.Add(dosya);
                    string hedef = copDizin + "\\" + dosya.DosyaAdi;
                    File.Move(dosya.Konum, hedef);
                    dosya.Konum = hedef;
                }
            }
        }

        #endregion

    }
}
