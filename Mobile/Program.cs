using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Mobile
{

    public enum Memory
    {
        less = 16,
        mid = 32,
        more = 64
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Mobile> Mobiles = new List<Mobile>()
            {
            new Iphone9(ConsoleColor.DarkGreen),
            new SamsungA10(ConsoleColor.DarkYellow,Memory.more),
            new NokiaX6()
            };
            foreach (var item in Mobiles)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            List<Mobile> Brends = new List<Mobile>()
            {
               new Apple(),
               new Samsung(),
               new Nokia()
            };
            foreach (var item in Brends)
            {
                Console.WriteLine(item);
            }
        }
    }
}
