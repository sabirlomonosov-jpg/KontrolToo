
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace KontrolToo
{
    internal class Alamfunktsioonid
    {
        public static void KytuseKalkulaator()
        {
            try
            {
                Console.Write("Sisesta vahemaa: ");
                if (!int.TryParse(Console.ReadLine(), out int km))
                {
                    Console.WriteLine("VIGA: Palun sisesta korrektne täisarv vahemaaks.");
                    return;
                }

                Console.Write("Sisesta kütusekulu 100 km kohta(liitrit): ");
                if (!int.TryParse(Console.ReadLine(), out int l))
                {
                    Console.WriteLine("VIGA: Palun sisesta korrektne täisarv kütusekulu jaoks.");
                    return;
                }

                Console.Write("Sisesta kütuse hind: ");
                if (!double.TryParse(Console.ReadLine(), out double hind))
                {
                    Console.WriteLine("VIGA: Palun sisesta korrektne number kütuse hinna jaoks.");
                    return;
                }

                double kütuseKogus = (km / 100.0) * l;
                double kütuseHind = (km / 100.0) * l * hind;
                Console.WriteLine($"kütuse kogus: {kütuseKogus} liitrit. kütuse hind: {kütuseHind}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        public static void HindaIsikukood()
        {
            try
            {
                Console.Write("Sisesta teie isikukood: ");
                string isik = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(isik))
                {
                    Console.WriteLine("VIGA: Isikukood ei tohi olla tühi.");
                    return;
                }

                if (isik.Length != 11)
                {
                    Console.WriteLine("VIGA: Teie isikukood on vale pikkusega (oodatud 11).");
                    return;
                }

               
                for (int i = 0; i < isik.Length; i++)
                {
                    if (!char.IsDigit(isik[i]))
                    {
                        Console.WriteLine("VIGA: Isikukood peab sisaldama ainult numbreid.");
                        return;
                    }
                }

                
                string sugu;
                char first = isik[0];
                if (first == '1' || first == '3' || first == '5' || first == '7')
                    sugu = "mees";
                else if (first == '2' || first == '4' || first == '6' || first == '8')
                    sugu = "naine";
                else
                    sugu = "tundmatu";

                string yy = isik.Substring(1, 2);
                string mm = isik.Substring(3, 2);
                string dd = isik.Substring(5, 2);

                Console.WriteLine($"Te olete {sugu}, sündinud {dd}.{mm}.{yy}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
        public static void TaringuMang()
        {
            var rnd = new Random();
            var sums = new List<int>();
            int doublesCount = 0;
            int totalSum = 0;

            for (int i = 0; i < 10; i++)
            {
                int d1 = rnd.Next(1, 7);
                int d2 = rnd.Next(1, 7);
                int sum = d1 + d2;
                sums.Add(sum);
                if (d1 == d2) doublesCount++;
                totalSum += sum;
            }

            Console.WriteLine("Viska summasid: " + string.Join(", ", sums));
            Console.WriteLine($"Identsete numbrite arv: {doublesCount}");
            Console.WriteLine($"Kõigi visete kogusumma: {totalSum}");

        }

        public static Tuple<double, double> ArvutaPalk(double brutopalk)
        {
            double maksuvabatulu = 0;

            if (brutopalk < 1200)
            {
                maksuvabatulu = 654;
            }

            double tulubaas = brutopalk - maksuvabatulu;

            double tookindlustus = brutopalk * 0.016;
            double kogumispension = brutopalk * 0.02;

            double netopalk = brutopalk - tookindlustus - kogumispension;

            return new Tuple<double, double>(maksuvabatulu, netopalk);
        }
    }
}
         