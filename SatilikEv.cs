using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakciuyglib
{
    public class SatilikEv:Ev
    {
        public int Depozito { get; set; }
        public int Fiyat { get; set; }

        public SatilikEv() { }
        public SatilikEv(int depozito, int fiyat, int odasayisi, int katno, int alan) : base(odasayisi, katno, alan)
        {
            this.Depozito = depozito;
            this.Fiyat = Fiyat;

        }
        public string SatilikEvBilgileri()
        {
            return $"Depozito: {this.Depozito} \n Fiyat: {this.Fiyat}\n Odasayisi: {base.Odasayisi} \n Katno: {base.Katno} \n Alan: {base.Alan} ";
        }
    }
}
