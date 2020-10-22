using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Podaj rok");
            // int.TryParse(Console.ReadLine(), out int rok);

            Obliczenia.WypiszCzyRokJestPrzestepny(2020);
            Obliczenia.WypiszCzyRokJestPrzestepny(2021);
            Obliczenia.WypiszCzyRokJestPrzestepny(2022);
            Obliczenia.WypiszCzyRokJestPrzestepny(2023);
            Obliczenia.WypiszCzyRokJestPrzestepny(2024);

            Console.ReadKey();
        }
    }
}
