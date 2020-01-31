using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Kolokwium
{
    class Program
    {

        
        static void Zadanie1()
        {
            Random liczbaPkt = new Random();
            Random liczbaZw = new Random();
            var ostAkt = DateTime.Today;
            Random dataOgr = new Random();
            var gracze = new Gracz[100];


            for (int i = 0; i < gracze.GetLength(0); i++)
            {

                gracze[i] = new Gracz(liczbaPkt.Next(1, 100), liczbaZw.Next(1, 200), ostAkt.AddDays(-dataOgr.Next(1, 100)));
            }

       
            IEnumerable<Gracz> lista = gracze.ToList();
          
           


            Console.WriteLine("Ranking wg punktow: ");
            lista.OrderByDescending(x => liczbaPkt);
            int miejsce = 1;
            foreach (var item in lista)
            {
                Console.WriteLine($"{miejsce}  {liczbaPkt}, {liczbaZw}, {ostAkt}");
                miejsce++;
            }

            Console.WriteLine("Ranking wg zwyciestw: ");
            lista.OrderByDescending(x => liczbaZw);
            miejsce = 1;
            foreach (var item in lista)
            {
                Console.WriteLine($"{miejsce}  {liczbaPkt}, {liczbaZw}, {ostAkt}");
                miejsce++;
            }

        }


       

        static void WyswietlPlik()
        {
            using (StreamReader plik = new StreamReader("kol.txt"))
            {
                Console.WriteLine(plik.ReadLine());
            }
           
        }
        static void Main(string[] args)
        {
            //Zadanie 1
            Zadanie1();
          
            //Zadanie 2
            
            //Zadanie 3
           
            //Zadanie 4

            //Zadanie 5

        }
    }
}
