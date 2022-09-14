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
using System.IO;
using System.Runtime.CompilerServices;

namespace DosyalamaAppFormProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string dizin = "C://Users//erdin//OneDrive//Masaüstü//KaroAs//DERSLER//CALISMALAR//Bireysel//Dosyalama App//DataBase";

            string hedefDizin = "C://Users//erdin//OneDrive//Masaüstü//KaroAs//DERSLER//CALISMALAR//Bireysel//Dosyalama App//Hedef";          

            DosyalamaProgram Islemler = DosyalamaProgram.AktifDosyalamaProgram;

            

            Islemler.DosyalariTurlerineGoreAyir(dizin, hedefDizin);

            Islemler.Yedekle(hedefDizin, "Yedek");

            string yedekDizin = "C://Users//erdin//OneDrive//Masaüstü//KaroAs//DERSLER//CALISMALAR//Bireysel//Dosyalama App//Hedef//JsonKayıt";

            //Islemler.YedekleriTemizle(yedekDizin, "Yedek");

            //Islemler.YedektenCagir(yedekDizin, "Yedek");

            //Islemler.TarihiGeceniTasi(hedefDizin);
        }
    } 
}
