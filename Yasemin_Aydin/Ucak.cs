using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yasemin_Aydin
{
    internal class Ucak : IUcak
    {
        public string kod { get; set; }
        public int kapasite { get; set; }

        public void ucakOlustur(string kod, int kapasite)
        {
            this.kod = kod;
            this.kapasite = kapasite;
        }
    }
}
