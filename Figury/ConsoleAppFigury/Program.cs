using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FiguryLibrary;

namespace ConsoleAppFigury
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat t1; // deklaracja zmiennej typu trojkat

            t1 = new Trojkat();

           // Trojkat t2 = new Trojkat(1, 2, 3);

            var t3 = new Trojkat(c: 1, b: 2, a: 2);

            Console.WriteLine(t1);
            Console.WriteLine(t1.getObwod());
            Console.WriteLine(t1.Obwod);
            Console.WriteLine($"pole = {t1.getPole()}");
            Console.WriteLine($"Pole = {t1.Pole}");

            try
            {
                t1.A = -1;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Nie wolno bokom przypisywac wartosci ujemnych");
            }
            
            Console.WriteLine(t1);
            Console.WriteLine(t1.Pole);

            Console.WriteLine("===========================");

            var t2 = new Trojkat(-1, 2, 1);
            Console.WriteLine(t2);

           // Console.WriteLine(t2);
            //Console.WriteLine(t3);

            
        }
    }
}
