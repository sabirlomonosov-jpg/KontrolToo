using System;
using System.Collections.Generic;
using System.Text;

namespace KontrolToo
{
    internal class StartPage
    {
        static void Main(string[] args)
        {
            while (true)
            {


                Console.WriteLine("Tere tulemast KontrolToo rakendusse!");
                Console.WriteLine(" ");
                Console.WriteLine("Vali funktsioon:");
                Console.WriteLine("1 - Kütusekalkulaator");
                Console.WriteLine("2 - Isikuandmete analüüs");
                Console.WriteLine("3 - Täringumäng");
                Console.WriteLine("4 - Palgaarvestus");
                Console.WriteLine("0 - Välju");
                Console.Write("Sisesta valik (1, 2, 3, 4, 0): ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Alamfunktsioonid.KytuseKalkulaator();
                        break;
                    case "2":
                        Alamfunktsioonid.HindaIsikukood();
                        break;
                    case "3":
                        Alamfunktsioonid.TaringuMang();
                        break;
                    case "4":
                        Alamfunktsioonid.ArvutaPalk(0);
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("VIGA: Valik ei kehtiv!");
                        break;

                }

            }
        }
    }
}
