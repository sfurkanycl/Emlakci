using System;
using System.Collections.Generic;
using System.Text;

namespace Emlakciuyglib
{
    public class KiralikEv:Ev
    {
        public int Depozito { get; set; }
        public int Kira { get; set; }

        public KiralikEv() { }
        public KiralikEv(int depozito, int kira , int odasayisi,int katno , int alan):base(odasayisi,katno,alan) 
        {
            this.Depozito = depozito;
            this.Kira = kira;
           
        }
        public string KiralikEvBilgileri() 
        {
            return $"Depozito: {this.Depozito} \n Kira: {this.Kira}\n Odasayisi: {base.Odasayisi} \n Katno: {base.Katno} \n Alan: {base.Alan} ";
        }
    }
}
