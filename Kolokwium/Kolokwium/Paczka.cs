using System;
using System.Collections.Generic;
using System.Text;

namespace Kolokwium
{
   public class Paczka //: IPrzesylka
    {
        public static string _lokalizacja { get; set; }
        public static string _waga;

       
        int Nadaj()
        {
            Console.WriteLine("Nadane");
            _lokalizacja = "Baza";
            Random _id = new Random();
            return _id.Next(1,1000);
        }

        void Przekaz(string przekaz) => Przekaz(_lokalizacja);

        void Odbierz(int odbierz)
        {
            Console.WriteLine(odbierz);
        }
        
        void Info()
        {
            Console.WriteLine();
        }

    }
}
