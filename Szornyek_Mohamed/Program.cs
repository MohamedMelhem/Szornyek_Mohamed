using System;

namespace Szornyek_Mohamed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SzornyAdatbazis szornyek = new SzornyAdatbazis();
            List<Szorny> szornyLista = szornyek.Feltolt();
            Szornyelemzo elemzo = new Szornyelemzo(szornyLista);
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine("Melhem Mohamed Dolgozat  2026.11.17");
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(
                "1. feladat: Összes szörny száma: "
                + elemzo.OsszesSzornySzama()
            );
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(
                "2. feladat: Veszélyes szörnyek nevei: "
                + string.Join(", ", elemzo.VeszelyesSzornyekNevei())
            );
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(
                "3. feladat: Egyedi élőhelyek: "
                + string.Join(", ", elemzo.EgyediElohelyek())
            );
            Console.WriteLine(
                "4. feladat: Átlagos veszélyességi szint: "
                + elemzo.AtlagosVeszelyessegSzint()
            );
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(
                "5. feladat: Legveszélyesebb szörnyek: "
                + string.Join(", ", elemzo.LegveszelyesebbSzornyek().Select(s => s.Nev))
            );
            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine(
                "6. feladat: Tűzre Gyenge  és legalább 5 veszélyességi szintű szörnyek: "
                + string.Join(", ", elemzo.VanExtremTuzGyengeSzorny())
            );
            Console.WriteLine("-------------------------------------------------------------");


        }
    }
}