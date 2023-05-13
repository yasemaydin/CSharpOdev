using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasemin_Aydin
{
    internal interface IRezervasyon
    {
        int biletNo { get; set; }
        int ucret { get; set; }
        DateTime ucusTarihi { get; set; }
        int koltukNumarasi { get; set; }
    }
}
