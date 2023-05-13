using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasemin_Aydin
{
    internal class Musteri : IMusteri
    {
        public string TC { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string telefon { get; set; }
        public int yas { get; set; }
        public string cinsiyet { get; set; }
        public string engel { get; set; }

        public void musteriOlustur()
        {
            int sayi;

            do
            {
                Console.Write("TC Kimlik Numarınızı giriniz: ");
                TC = Console.ReadLine();
            } while (TC.Length != 11 || !Int64.TryParse(TC, out long INT64));

            Console.Write("Adınızı giriniz: ");
            ad = Console.ReadLine();

            Console.Write("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();

            do
            {
                Console.Write("Telefon Numaranızı giriniz: ");
                telefon = Console.ReadLine();
            } while (telefon.Length != 11 || !Int64.TryParse(telefon, out long INT64));

            do
            {
                Console.Write("Yaşınızı giriniz: ");

                try
                {
                    yas = Convert.ToInt32(Console.ReadLine());
                }
                catch { }                
            } while (!(yas > 0 && yas < 101) || !int.TryParse(yas.ToString(), out sayi));

            int cSecim = 0;

            do
            {
                Console.WriteLine("1) Erkek");
                Console.WriteLine("2) Kadın");
                Console.Write("Cinsiyetinizi giriniz (1, 2): ");
                cinsiyet = Console.ReadLine();
                try
                {
                    cSecim = Convert.ToInt32(cinsiyet);
                }
                catch { }
            } while (!(cSecim == 1 || cSecim == 2) || !int.TryParse(cinsiyet.ToString(), out sayi));

            switch (cinsiyet)
            {
                case "1":
                    cinsiyet = "Erkek";
                    break;
                case "2":
                    cinsiyet = "Kadın";
                    break;
            }

            int eSecim = 0;

            do
            {
                Console.WriteLine("1) Var");
                Console.WriteLine("2) Yok");
                Console.Write("Engel durumunuzu giriniz (1, 2): ");
                engel = Console.ReadLine();

                try
                {
                    eSecim = Convert.ToInt32(engel);
                }
                catch { }
            } while (!(eSecim == 1 || eSecim == 2) || !int.TryParse(engel.ToString(), out sayi));

            switch (engel)
            {
                case "1":
                    engel = "Var";
                    break;
                case "2":
                    engel = "Yok";
                    break;
            }
        }
    }
}
