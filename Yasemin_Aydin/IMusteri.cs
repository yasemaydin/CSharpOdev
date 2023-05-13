using System;

namespace Yasemin_Aydin
{
    internal interface IMusteri
    {
        string TC { get; set; }
        string ad { get; set; }
        string soyad { get; set; }
        string telefon { get; set; }
        int yas { get; set; }
        string cinsiyet { get; set; }
        string engel { get; set; }

        void musteriOlustur();
    }
}
