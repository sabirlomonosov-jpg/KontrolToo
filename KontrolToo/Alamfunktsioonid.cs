
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace KontrolToo
{
    internal class Alamfunktsioonid
    {
        public static void KytuseKalkulaator()
        {
            Console.Write("Sisesta vahemaa: ");
            int km = int.Parse(Console.ReadLine());

            Console.Write("Sisesta kütusekulu 100 km kohta(liitrit): ");
            int l = int.Parse(Console.ReadLine());

            Console.Write("Sisesta kütuse hind: ");
            int hind = int.Parse(Console.ReadLine());

            double kütuseKogus = (km / 100.0) * l;
            double kütuseHind = (km / 100.0) * l * hind;
            Console.WriteLine($"kütuse kogus: {kütuseKogus} liitrit. kütuse hind: {kütuseHind}");
        }
        public static void HindaIsikukood()
        {
            Console.Write("Sisesta teie isikukood: ");
            string isik = Console.ReadLine();

            int length = isik?.Length ?? 0;
            string lengthStr = length.ToString();

            int.TryParse(lengthStr, out int parsedLength);
            if (parsedLength == 11)
            {
                string sugu = "";
                if (isik[0] == '1' || isik[0] == '3' || isik[0] == '5')
                {
                    sugu = "mees";
                }
                else if (isik[0] == '2' || isik[0] == '4' || isik[0] == '6')
                {
                    sugu = "naine";
                }
                else
                {
                    sugu = "tundmatu";
                }
                string yy = isik.Substring(1, 2);
                string mm = isik.Substring(3, 2);
                string dd = isik.Substring(5, 2);

                Console.WriteLine($"Te olete {sugu}, sundinud {dd}.{mm}.{yy}");

            }
            else
            {
                Console.WriteLine("VIGA: Teie isikukood sisetanud valvesti!");
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
         