using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zestaw_m4
{
    class Program
    {
        private static Serwis serwis = new Serwis();
        private static char klawisz;
        public static void Legenda()
        {
            Console.WriteLine("co chcesz zrobic");
            Console.WriteLine(" A - dodaj tv");
            Console.WriteLine(" B - dodaj komputer");
            Console.WriteLine(" C1 - polacz ");
            Console.WriteLine(" C2 - podziel ");
            Console.WriteLine(" D - napraw");
            Console.WriteLine(" D - napraw po numerze seryjnym");
            Console.WriteLine(" X - wyjscie z aplikacji");
        }

        public static void WczytajKlawisz()
        {
            klawisz = Convert.ToChar(Console.ReadLine());
        }

        public static void Dzialanie()
        {
            if (klawisz == 'A' || klawisz == 'A')
            {


                Console.WriteLine("podaj numer seryjny telewizora");
                int numerSeryjny = 0;
                string wej2 = "";
                while (numerSeryjny <= 0)
                {
                    Console.WriteLine("dodaj numer");
                    wej2 = Console.ReadLine();
                    Int32.TryParse(wej2, out numerSeryjny);
                }

                string marka = "";
                while (String.IsNullOrEmpty(marka))
                {
                    Console.WriteLine("podaj marke");
                    wej2 = Console.ReadLine();

                }
                string usterka = "";
                while (String.IsNullOrEmpty(usterka))
                {
                    Console.WriteLine("podaj usterke");
                    wej2 = Console.ReadLine();
                }

                serwis.DodajTelewizor(marka, numerSeryjny, usterka);

            }
            else if (klawisz == 'B' || klawisz == 'b')
            {
                Console.WriteLine("podaj numer seryjny komputera");
                int numerSeryjny = 0;
                string wej2 = "";
                while (numerSeryjny <= 0)
                {
                    Console.WriteLine("dodaj numer");
                    wej2 = Console.ReadLine();
                    Int32.TryParse(wej2, out numerSeryjny);
                }

                string marka = "";
                while (String.IsNullOrEmpty(marka))
                {
                    Console.WriteLine("podaj marke");
                    wej2 = Console.ReadLine();

                }
                string usterka = "";
                while (String.IsNullOrEmpty(usterka))
                {
                    Console.WriteLine("podaj usterke");
                    wej2 = Console.ReadLine();
                }

                serwis.Dodajkomputer(marka, numerSeryjny, usterka);
            }


        }


        static void Main(string[] args)
        {
            Legenda();
            WczytajKlawisz();

            Console.ReadKey();
        }


    }
}