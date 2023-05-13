using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasemin_Aydin
{
    internal class Lokasyon : ILokasyon
    {
        public string kalkisYeri { get; set; }
        public string varisYeri { get; set; }

        public Lokasyon[] lokasyonlar = new Lokasyon[20];

        public Lokasyon lokasyonOlustur(string kalkisYeri, string varisYeri)
        {
            Lokasyon lokasyon = new Lokasyon();

            lokasyon.kalkisYeri = kalkisYeri;
            lokasyon.varisYeri = varisYeri;

            return lokasyon;
        }

        public void lokasyonEkle()
        {
            lokasyonlar[0] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Almanya - Düsseldorf - Düsseldorf Rhein Ruhr Uluslararası Havalimanı");
            lokasyonlar[1] = lokasyonOlustur("Almanya - Düsseldorf - Düsseldorf Rhein Ruhr Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[2] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "ABD - Washington DC - Dulles Uluslararası Havalimanı");
            lokasyonlar[3] = lokasyonOlustur("ABD - Washington DC - Dulles Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[4] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Arjantin - Buenos Aires - Ministro Pistarini Uluslararası Havalimanı");
            lokasyonlar[5] = lokasyonOlustur("Arjantin - Buenos Aires - Ministro Pistarini Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[6] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Azerbeycan - Bakü - Haydar Aliyev Uluslararası Havalimanı");
            lokasyonlar[7] = lokasyonOlustur("Azerbeycan - Bakü - Haydar Aliyev Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[8] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Birleşik Krallık - Durham - Teesside Uluslararası Havalimanı");
            lokasyonlar[9] = lokasyonOlustur("Birleşik Krallık - Durham - Teesside Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[10] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Çin - Guangzhou - Guangzhou Baiyun Uluslararası Havalimanı");
            lokasyonlar[11] = lokasyonOlustur("Çin - Guangzhou - Guangzhou Baiyun Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[12] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Güney Kore - Seul - Incheon Uluslararası Havalimanı");
            lokasyonlar[13] = lokasyonOlustur("Güney Kore - Seul - Incheon Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[14] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "İspanya - Madrid - Madrid Barajas Uluslararası Havalimanı");
            lokasyonlar[15] = lokasyonOlustur("İspanya - Madrid - Madrid Barajas Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[16] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Japonya - Tokyo - Narita Uluslararası Havalimanı");
            lokasyonlar[17] = lokasyonOlustur("Japonya - Tokyo - Narita Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");

            lokasyonlar[18] = lokasyonOlustur("Türkiye - Ankara - Ankara Esenboğa Havalimanı", "Kanada - Ottawa - Ottawa Macdonald - Cartier Uluslararası Havalimanı");
            lokasyonlar[19] = lokasyonOlustur("Kanada - Ottawa - Ottawa Macdonald - Cartier Uluslararası Havalimanı", "Türkiye - Ankara - Ankara Esenboğa Havalimanı");
        }

        public void lokasyonSec()
        {
            for (int sayac = 1; sayac <= lokasyonlar.Length; sayac++)
            {
                Console.WriteLine(sayac + ") " + lokasyonlar[sayac - 1].kalkisYeri + " " + lokasyonlar[sayac - 1].varisYeri);
            }

            int sira = 0;

            do
            {
                Console.Write("Lokasyon Seçiniz: ");
                try
                {
                    sira = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
            } while (!(sira > 0 && sira < lokasyonlar.Length + 1) || !int.TryParse(sira.ToString(), out sira));

            kalkisYeri = lokasyonlar[sira - 1].kalkisYeri;
            varisYeri = lokasyonlar[sira - 1].varisYeri;
        }
    }
}
