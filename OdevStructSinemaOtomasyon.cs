using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev31Aralık
{
    class Program
    {
        struct sinemadata
        {
            public void sinamedata(string biletbilgi,string kisibilgi,string salonbilgi)
            {
                Console.WriteLine("Bilet Bilgi: "+biletbilgi);
                Console.WriteLine("Kişi Bilgi: "+kisibilgi);
                Console.WriteLine("Salon Bilgi: "+salonbilgi);
            }
        }

        static void Main(string[] args)
        {
            baslangic:
            Console.Clear();
            int filmsecim;
            string isim;
            sinemadata sinema = new sinemadata();
            Console.WriteLine("Film Seçin:");
            Console.WriteLine("1)Spiderman Homecoming");
            Console.WriteLine("2)Şansımı Seveyim");
            Console.WriteLine("3)Kayıp Balık Nemo");
            Console.WriteLine("-->");
            filmsecim = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adınız: ");
            isim = Console.ReadLine();

            switch (filmsecim)
            {
                case 1:
                    sinema.sinamedata("Spiderman Homecoming", isim, "2.Salon 10D");
                    break;
                case 2:
                    sinema.sinamedata("Şansımı Seveyim", isim, "3.Salon 8A");
                    break;
                case 3:
                    sinema.sinamedata("Kayıp Balık Nemo", isim, "1.Salon 11B");
                    break;
                default:
                    goto baslangic;
            }
            Console.Read();
        }
    }
}
