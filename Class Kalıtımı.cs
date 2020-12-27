using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev27Aralik
{
    class ekranyazdir
    {
        static public void yazdir()
        {
            Console.WriteLine("Hüseyin Arda");
        }
    }

    class Program : ekranyazdir
    {
        static void Main(string[] args)
        {
            yazdir();
        }
    }

}
