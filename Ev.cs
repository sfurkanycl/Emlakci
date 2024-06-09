using System;

namespace Emlakciuyglib
{
    public class Ev
    {
        public int Odasayisi { get; set; }
        public int Katno { get; set; }
        public int Alan { get; set; }

       
        public Ev() 
        { 
        //default
        }

        public Ev(int odasayisi, int katno, int alan)
        {
           this.Odasayisi = odasayisi;
            this.Katno = katno;
            this.Alan = alan;
        }
        public string Evbilgilerigetir()
        {
            return $"Odasayisi: {this.Odasayisi} \n Katno: {this.Katno}\n Alan: {this.Alan}";
        }
        
    }
}
