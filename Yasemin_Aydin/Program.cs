using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasemin_Aydin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rezervasyon Sistemi");
            
            Ucak ucak = new Ucak();
            ucak.ucakOlustur("Airbus A320", 200);

            Lokasyon lokasyon = new Lokasyon();
            lokasyon.lokasyonEkle();

            Musteri musteri = new Musteri();
            musteri.musteriOlustur();

            lokasyon.lokasyonSec();

            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.biletOlustur(ucak.kapasite);
            rezervasyon.ucretOlustur(musteri.yas, musteri.engel);
            rezervasyon.tarihOlustur();
            rezervasyon.koltukOlustur(ucak.kapasite);

            Console.WriteLine("Sayın, " + musteri.ad + " " + musteri.soyad);
            Console.WriteLine("AEB - " + rezervasyon.biletNo + " numaralı rezarvasyon bilgileriniz aşağıdaki gibidir:");
            Console.WriteLine("Kalkış yeriniz: " + lokasyon.kalkisYeri);
            Console.WriteLine("Varış yeriniz: " + lokasyon.varisYeri);
            Console.WriteLine("Uçuş tarihiniz: " + rezervasyon.ucusTarihi.ToString("dd / MM / yyyy"));
            Console.WriteLine("Koltuk numaranız: " + rezervasyon.koltukNumarasi);
            Console.WriteLine("Uçuş ücretiniz: " + rezervasyon.ucret);

            Console.Write("İyi uçuşlar dileriz.");

            Console.ReadKey();
        }
    }
}
