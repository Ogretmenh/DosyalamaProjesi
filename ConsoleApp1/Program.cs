using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using O2_DosyalamaProjesi;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FileInfo fileInfo = new FileInfo(@"C: \Users\erdin\OneDrive\Masaüstü\KaroAs\DERSLER\CALISMALAR\Bireysel\Dosyalama App\DataBase");

            //O2_DosyalamaProjesi.Dosya dosya = new Dosya(fileInfo);

            string kaynak = @"C:\Users\erdin\OneDrive\Masaüstü\KaroAs\DERSLER\CALISMALAR\Bireysel\Dosyalama App\DataBase\JSonKayıt";

            //DosyalamaProgram.AktifDosyalamaProgram.DosyalariTurlerineGoreAyir(kaynak, kaynak);

            //foreach (var item in DosyalamaProgram.AktifDosyalamaProgram.DosyaTurleri)
            //{
            //    if (item.DosyaTuru == ".bmp")
            //    {
            //        foreach (var dosya in item.Dosyalar)
            //        {
            //            Console.WriteLine(dosya.DosyaAdi);
            //        }
            //    }
            //    //Console.WriteLine(item.DosyaTuru);
            //}

            //DosyalamaProgram.AktifDosyalamaProgram.TarihiGeceniTasi(kaynak);


            //DosyalamaProgram.AktifDosyalamaProgram.Yedekle(kaynak, "Yedek");

            DosyalamaProgram.AktifDosyalamaProgram.YedektenCagir(kaynak, "Yedek");


            Console.ReadLine();
        }
    }
}
