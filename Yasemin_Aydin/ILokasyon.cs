using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasemin_Aydin
{
    internal interface ILokasyon
    {
        string kalkisYeri { get; set; }
        string varisYeri { get; set; }

        Lokasyon lokasyonOlustur(string kalkisYeri, string varisYeri);
    }
}
