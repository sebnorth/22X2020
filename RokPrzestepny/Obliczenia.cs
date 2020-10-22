using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RokPrzestepny
{
    class Obliczenia
    {
        public static void WypiszCzyRokJestPrzestepny(int rok_parametr) {

            if ((rok_parametr % 4 == 0 && rok_parametr % 100 != 0) || rok_parametr % 400 == 0)
                Console.WriteLine("Rok {0} jest rokiem przestępnym.", rok_parametr);
            else
                Console.WriteLine("Rok {0} nie jest rokiem przestępnym.", rok_parametr);
        }
    }
}
