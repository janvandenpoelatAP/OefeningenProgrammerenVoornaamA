using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningenProgrammeren
{
    class H05
    {
        static public void Keuzemenu()
        {
            Console.WriteLine(@"Kies uit de volgende methodes door een cijfer in te geven
1 - BMIBerekenaar
2 - Schoenverkoper_1
3 - WetVanOhm
4 - Schrikkeljaar_1
5 - SimpeleRekenmachine_1
A - Schoenverkoper_2
B - Schrikkeljaar_2
C - SimpeleRekenmachine_2");
            Console.WriteLine();
            string keuze = Console.ReadLine();
            Console.Clear();
            if (keuze == "1")
            {
                BMIBerekenaar();
            }
            if (keuze == "2")
            {
                Schoenverkoper_1();
            }
            if (keuze == "3")
            {
                WetVanOhm();
            }
            if (keuze == "4")
            {
                Schrikkeljaar_1();
            }
            if (keuze == "5")
            {
                SimpeleRekenmachine_1();
            }
            if (keuze == "A")
            {
                Schoenverkoper_2();
            }
            if (keuze == "B")
            {
                Schrikkeljaar_2();
            }
            if (keuze == "C")
            {
                SimpeleRekenmachine_2();
            }
        }

        static public void BMIBerekenaar()
        {
            Console.WriteLine("Hoeveel weeg je in kg?");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hoe groot ben je in m?");
            double grootte = Convert.ToDouble(Console.ReadLine());
            grootte = Math.Pow(grootte, 2);
            double bmi = (gewicht / grootte);
            Console.WriteLine($"Je BMI is {bmi:F2}");
            if (bmi < 18.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ondergewicht");
                Console.ResetColor();
            }
            if (bmi > 18.5 && bmi < 25)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("normaal gewicht");
            }
            if (bmi > 25 && bmi < 30)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("overgewicht");
            }
            if (bmi > 30 && bmi < 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zwaarlijvig");
            }
            if (bmi > 40)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("ernstige obesitas");
            }
            Console.ResetColor();
        }

        public static void Schoenverkoper_1()
        {
            const int price = 20;
            const int reducedPrice = 10;
            int largeOrder = 10;
            int total = 0;

            /* Uitbreiding START */
            Console.WriteLine("Vanaf welk aantal geldt de korting?");
            largeOrder = Convert.ToInt32(Console.ReadLine());
            /* Uitbreiding END */

            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            int pairs = Convert.ToInt32(Console.ReadLine());

            if (pairs >= largeOrder)
            {
                total = reducedPrice * pairs;
            }
            else
            {
                total = price * pairs;
            }
            Console.WriteLine($"Je moet {total} euro betalen.");
        }
        static public void Schoenverkoper_2()
        {
            Console.WriteLine("Vanaf wel aantal geldt de korting?");
            int aantalVoorKorting = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel paar schoenen wil je kopen?");
            int aantalSchoenen = Convert.ToInt32(Console.ReadLine());
            int prijsSchoenen = 20;

            if (aantalSchoenen >= aantalVoorKorting)
            {
                prijsSchoenen = 10;
            }

            int totaal = aantalSchoenen * prijsSchoenen;
            Console.WriteLine($"Je moet {totaal} euro betalen.");
        }

        static public void WetVanOhm()
        {
            Console.WriteLine("Wat wil je berekenen? spanning, weerstand of stroomsterkte?");
            string welkeWaardeBerekenen = Console.ReadLine();
            float spanning = 0;
            float weerstand = 0;
            float stroomsterkte = 0;
            float resultaat = 0;

            if (welkeWaardeBerekenen == "spanning")
            {
                Console.WriteLine("Wat is de weerstand?");
                weerstand = float.Parse(Console.ReadLine());
                Console.WriteLine("Wat is de stroomsterkte?");
                stroomsterkte = float.Parse(Console.ReadLine());
                resultaat = stroomsterkte * weerstand;
                Console.WriteLine($"De spanning bedraagt {resultaat} Volt.");
            }
            if (welkeWaardeBerekenen == "weerstand")
            {
                Console.WriteLine("Wat is de spanning?");
                spanning = float.Parse(Console.ReadLine());
                Console.WriteLine("Wat is de stroomsterkte?");
                stroomsterkte = float.Parse(Console.ReadLine());
                resultaat = spanning / stroomsterkte;
                Console.WriteLine($"De weerstand bedraagt {resultaat} Ohm.");
            }
            if (welkeWaardeBerekenen == "stroomsterkte")
            {
                Console.WriteLine("wat is de weerstand?");
                weerstand = float.Parse(Console.ReadLine());
                Console.WriteLine("Wat is de spanning?");
                spanning = float.Parse(Console.ReadLine());
                resultaat = spanning / weerstand;
                Console.WriteLine($"De stroomsterkte bedraagt {resultaat} Ampère.");
            }
        }
        public static void Schrikkeljaar_1()
        {

            int year = Convert.ToInt32(Console.ReadLine());

            bool leapYear = false; //geen schrikkeljaar, tenzij hieronder anders aangetoond.

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        leapYear = true; //deelbaar door 4, 100 én 400
                    }
                    else
                    {
                        leapYear = false; //deelbaar door 4 en 100, maar niet door 400
                    }
                }
                else
                {
                    leapYear = true; //deelbaar door 4, niet door 100
                }
            }

            if (!leapYear)
            {
                Console.Write("geen ");
            }
            Console.WriteLine("schrikkeljaar");
        }
        static public void Schrikkeljaar_2()
        {
            Console.Write("Geef een jaartal in: ");
            float jaar = float.Parse(Console.ReadLine());
            Console.WriteLine();

            if (jaar % 4 != 0)
            {
                Console.WriteLine("Geen schrikkeljaar");
            }
            else if (jaar % 4 == 0 && jaar % 100 == 0 && jaar % 400 == 0)
            {
                Console.WriteLine("Schrikkeljaar");
            }
            else if (jaar % 4 == 0 && jaar % 100 == 0)
            {
                Console.WriteLine("Geen schrikkeljaar");
            }
            else
            {
                Console.WriteLine("Schrikkeljaar");
            }
        }
        public static void SimpeleRekenmachine_1()
        {
            Console.WriteLine("Welke berekening wil je maken? (+,-,*,/)");
            string calculation = Console.ReadLine();
            Console.WriteLine("Geef twee getallen in, gescheiden door een spatie:");
            string input = Console.ReadLine();
            int a = Convert.ToInt32(input.Substring(0, input.IndexOf(" ")));
            int b = Convert.ToInt32(input.Substring(input.IndexOf(" ") + 1));

            if (calculation == "+")
            {
                Console.WriteLine($"De uitkomst is: {a + b}");
            }

            if (calculation == "-")
            {
                Console.WriteLine($"De uitkomst is: {a - b}");
            }

            if (calculation == "*")
            {
                Console.WriteLine($"De uitkomst is: {a * b}");
            }

            if (calculation == "/")
            {
                Console.WriteLine($"De uitkomst is: {a / b}");
            }
        }
        static public void SimpeleRekenmachine_2()
        {
            Console.Write("Geef het eerste getal in: ");
            float getal1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Geef het tweede getal in: ");
            float getal2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("welke bewerking wil je uitvoeren? +, -, * of / ==> ");
            string bewerking = Console.ReadLine();
            Console.WriteLine();
            float resultaat = 0;

            if (bewerking == "+")
            {
                resultaat = getal1 + getal2;
                Console.WriteLine($"Het resultaat is: {resultaat}");
            }

            if (bewerking == "-")
            {
                resultaat = getal1 - getal2;
                Console.WriteLine($"Het resultaat is: {resultaat}");
            }

            if (bewerking == "*")
            {
                resultaat = getal1 * getal2;
                Console.WriteLine($"Het resultaat is: {resultaat}");
            }

            if (bewerking == "/")
            {
                resultaat = getal1 / getal2;
                Console.WriteLine($"Het resultaat is: {resultaat}");
            }
        }
    }
}
