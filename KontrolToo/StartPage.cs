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
                try
                {
                    Console.WriteLine("Tere tulemast KontrolToo rakendusse!");
                    Console.WriteLine();
                    Console.WriteLine("Vali funktsioon:");
                    Console.WriteLine("1 - Kütusekalkulaator");
                    Console.WriteLine("2 - Isikuandmete analüüs");
                    Console.WriteLine("3 - Täringumäng");
                    Console.WriteLine("4 - Palgaarvestus");
                    Console.WriteLine("0 - Välju");
                    Console.Write("Sisesta valik (1, 2, 3, 4, 0): ");

                    string choice = Console.ReadLine();
                    if (!int.TryParse(choice, out int opt))
                    {
                        Console.WriteLine("VIGA: Palun sisesta number (0-4).");
                        continue;
                    }

                    switch (opt)
                    {
                        case 1:
                            Alamfunktsioonid.KytuseKalkulaator();
                            break;
                        case 2:
                            Alamfunktsioonid.HindaIsikukood();
                            break;
                        case 3:
                            Alamfunktsioonid.TaringuMang();
                            break;
                        case 4:
                            Console.Write("Sisesta brutopalk: ");
                            string palkInput = Console.ReadLine();
                            if (!double.TryParse(palkInput, out double brutopalk))
                            {
                                Console.WriteLine("VIGA: Palun sisesta korrektne number brutopalgaks.");
                                break;
                            }
                            var result = Alamfunktsioonid.ArvutaPalk(brutopalk);
                            Console.WriteLine($"Maksuvaba tulu: {result.Item1}. Neto palk: {result.Item2}");
                            break;
                        case 0:
                            return;
                        default:
                            Console.WriteLine("VIGA: Valik ei kehtiv!");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }
            }
        }
    }
}
