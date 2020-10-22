using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZnakLiczby
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0) Console.WriteLine("Dana liczba jest dodatnia.");
            else
                
            if (a < 0) Console.WriteLine("Dana liczba jest ujemna.");

            else Console.WriteLine("Podałeś liczbę zero.");

            Console.ReadKey();


        }
    }
}
