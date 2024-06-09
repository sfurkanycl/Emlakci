using Emlakciuyglib;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Emlakciuyg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Ev> list = new List<Ev>();
            string SatilikEvYol = @"C:\Users\yucel\OneDrive\Masaüstü\satilikEv.txt";
            string KiralikEvYol = @"C:\Users\yucel\OneDrive\Masaüstü\kiralikEv.txt";
            Console.Write("1-Kiralık Ev \n 2-Satılık Ev \n Seç> ");
            string cevap = Console.ReadLine();
            if (cevap == "1")
            {

                Console.WriteLine("A-kayıtlı ev görüntüleme \n B-yeni ev girisi");
                string cevap2 = Console.ReadLine();
                if (cevap2 == "a".ToLower())
                {
                    bilgileriGoruntule(KiralikEvYol);


                }
                else if (cevap2 == "b".ToLower())
                {
                    KiralikEvEkle(KiralikEvYol, list);
                }
                else
                {
                    Console.WriteLine("YANLIŞ BİR DEĞER GİRDİNİZ!");
                }

            }
            else if(cevap== "2")
            {
                Console.WriteLine("A-kayıtlı ev görüntüleme \n B-yeni ev girisi");
                string cevap2 = Console.ReadLine();
                if (cevap2 == "a".ToLower())
                {
                    bilgileriGoruntule(SatilikEvYol);


                }
                else if (cevap2 == "b".ToLower())
                {
                    SatilikEvEkle(SatilikEvYol,list);
                }
                else
                {
                    Console.WriteLine("YANLIŞ BİR DEĞER GİRDİNİZ!");
                }
            }
        }
        public static void KiralikEvEkle(string path,List<Ev> homeList)
        {
            string yanit;
            int sayac = 0;
            do
            {
                sayac++;
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    Console.Write($"{sayac}. Evin Kirasi: ");
                    int kira = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Depozitosu: ");
                    int depozito = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Oda Sayisi: ");
                    int odasayi = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Katno: ");
                    int katno = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Alani: ");
                    int alan = int.Parse(Console.ReadLine());

                    KiralikEv Kev = new KiralikEv(kira, depozito, odasayi, katno, alan);
                    homeList.Add(Kev);
                    sw.WriteLine($"{sayac}. Evin Fiyati: {kira} \n{sayac}. Evin Depozitosu: {depozito} \n{sayac}. Evin Oda Sayisi: {odasayi} \n{sayac}. Evin Kat No: {katno} \n{sayac}.Evin Alani {alan}");
                    sw.WriteLine("*********************");


                }


                Console.WriteLine("Tamam mı ? / Devam mı?");
                yanit = Console.ReadLine();
            } while (yanit == "d".ToLower());
            Console.WriteLine("KAYDINIZI BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR !");

        }


        public static void SatilikEvEkle(string path , List<Ev> homeList)
        {
            string yanit;
            int sayac = 0;
            do
            {
                sayac++;
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    Console.Write($"{sayac}. Evin Kirasi: ");
                    int kira = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Depozitosu: ");
                    int depozito = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Oda Sayisi: ");
                    int odasayi = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Katno: ");
                    int katno = int.Parse(Console.ReadLine());
                    Console.Write($"{sayac}. Evin Alani: ");
                    int alan = int.Parse(Console.ReadLine());

                    KiralikEv Kev = new KiralikEv(kira, depozito, odasayi, katno, alan);
                    homeList.Add(Kev);
                    sw.WriteLine($"{sayac}. Evin Fiyati: {kira} \n{sayac}. Evin Depozitosu: {depozito} \n{sayac}. Evin Oda Sayisi: {odasayi} \n{sayac}. Evin Kat No: {katno} \n{sayac}.Evin Alani {alan}");
                    sw.WriteLine("*********************");


                }


                Console.WriteLine("Tamam mı ? / Devam mı?");
                yanit = Console.ReadLine();
            } while (yanit == "d".ToLower());
            Console.WriteLine("KAYDINIZI BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR !");
        }
     


        public static void bilgileriGoruntule(string read)
        {

            using (StreamReader sr = new StreamReader(read))
            {
                string bilgiGetir = sr.ReadToEnd();
                Console.WriteLine(bilgiGetir);
            }
        }
    }
}