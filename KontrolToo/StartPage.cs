using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolToo
{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tere tulemast KontrolToo rakendusse!");
            Console.WriteLine("Vali funktsioon:");
            Console.WriteLine("1 - Kütusekalkulaator");
            Console.WriteLine("2 - Isikuandmete analüüs");
            Console.WriteLine("3 - Täringumäng");
            Console.WriteLine("4 - Välju rakendusest");
            Console.Write("Sisesta valik (1, 2, 3, 4): ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Subfunctions.KütuseHind();
                    break;
                case "2":
                    Subfunctions.HindaPsikukuude();
                    break;
                case "3":
                    Subfunctions.DiceMang();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("VIGA: Valik ei kehtiv!");
                    break;
            }
        }
    }
}
