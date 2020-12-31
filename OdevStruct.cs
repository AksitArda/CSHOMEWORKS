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
            sinemadata sinema = new sinemadata();
            sinema.sinamedata("Spiderman Homecoming", "Hüseyin Arda Akşit", "2.Salon 10D");
            Console.Read();
        }
    }
}
