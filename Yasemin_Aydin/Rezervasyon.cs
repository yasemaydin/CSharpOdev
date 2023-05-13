using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasemin_Aydin
{
    internal class Rezervasyon : IRezervasyon
    {
        public int biletNo { get; set; }
        public int ucret { get; set; }
        public DateTime ucusTarihi { get; set; }
        public int koltukNumarasi { get; set; }

        public Random rastgele = new Random();

        public DateTime[] tarihler = new DateTime[14];

        public void biletOlustur(int kapasite)
        {
            biletNo = rastgele.Next(1, kapasite);
        }

        public void ucretOlustur(int yas, string engel)
        {
            int ucret = rastgele.Next(0, 1000);

            if (yas > 50 && yas < 100)
                ucret = Convert.ToInt32(ucret * 0.5);

            if (engel == "Var")
                ucret = Convert.ToInt32(ucret * 0.5);

            this.ucret = ucret;
        }

        public void tarihOlustur()
        {
            int tarih = DateTime.Now.Year;

            for (int sayac = 0; sayac < tarihler.Length; sayac++)
            {
                DateTime rastgeleTarih = new DateTime(rastgele.Next(tarih, tarih + 1), rastgele.Next(1, 13), rastgele.Next(1, 29));

                if ((tarihler.Contains(rastgeleTarih) == false) && (rastgeleTarih.Year == DateTime.Now.Year) && (rastgeleTarih.Month > DateTime.Now.Month))
                    tarihler[sayac] = rastgeleTarih;
                else
                    sayac--;
            }

            Array.Sort(tarihler, (D1, D2) => D1.CompareTo(D2));

            for (int sayac = 1; sayac <= tarihler.Length; sayac++)
            {
                Console.WriteLine(sayac + ") " + tarihler[sayac - 1].ToString("dd/MM/yyyy"));
            }

            int sira = 0;

            do
            {
                Console.Write("Tarih Seçiniz: ");
                try
                {
                    sira = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
            } while (!(sira > 0 && sira < tarihler.Length + 1) || !int.TryParse(sira.ToString(), out sira));

            ucusTarihi = tarihler[sira - 1];
        }

        public void koltukOlustur(int kapasite)
        {
            int[] koltuklar = new int[kapasite];

            int[] artisDeger = new int[] { 2, 3, 4, 5 };
            int artis = artisDeger[rastgele.Next(0, 4)];
            int siraArtis = 1;

            for (int sayac = 1; sayac <= kapasite; sayac += artis)
            {
                Console.WriteLine(siraArtis + ") " + sayac);
                koltuklar[siraArtis] = sayac;
                siraArtis++;
            }

            int sira = 0;

            do
            {
                Console.Write("Koltuk Seçiniz: ");
                try
                {
                    sira = Convert.ToInt32(Console.ReadLine());
                }
                catch { }
            } while (!(sira > 0 && sira < siraArtis) || !int.TryParse(sira.ToString(), out sira));

            koltukNumarasi = koltuklar[sira];
        }
    }
}
