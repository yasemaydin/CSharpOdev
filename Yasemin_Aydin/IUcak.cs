using System;

namespace Yasemin_Aydin
{
    internal interface IUcak
    {
        string kod { get; set; }
        int kapasite { get; set; }

        void ucakOlustur(string kod, int kapasite);
    }
}
