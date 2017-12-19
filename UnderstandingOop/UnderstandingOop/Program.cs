using System;
using UnderstandingOop.Phone;
using UnderstandingOop.Phone.Graphics;

namespace UnderstandingOop
{
    class Program
    {
        static void Main(string[] args)
        {
            var scMobile = new SimCorpMobile();
            scMobile.Screen.Show(new Image());
            Console.WriteLine(scMobile);

            Console.WriteLine();

            var modernMobile = new ModernMobile();
            modernMobile.Screen.Show(new Image());
            Console.WriteLine(modernMobile);

            Console.WriteLine("\nPress any key to continue . . .");
            Console.ReadKey();
        }
    }
}
