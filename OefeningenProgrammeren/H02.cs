using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningenProgrammeren
{
    class H02
    {
        static public void Keuzemenu()
        {
            Console.WriteLine(@"Kies uit de volgende methodes door een cijfer in te geven
1 - VariabelenHoofdletters
2 - Optellen_1
3 - VerbruikWagen_1
4 - BeetjeWiskunde
5 - Gemiddelde
6 - Maaltafels
7 - Ruimte
A - Optellen_2
B - VerbruikWagen_2");

            Console.WriteLine();
            string keuze = Console.ReadLine();
            Console.Clear();
            if (keuze == "1")
            {
                VariabelenHoofdletters();
            }
            if (keuze == "2")
            {
                Optellen_1();
            }
            if (keuze == "3")
            {
                VerbruikWagen_1();
            }
            if (keuze == "4")
            {
                BeetjeWiskunde();
            }
            if (keuze == "5")
            {
                Gemiddelde();
            }
            if (keuze == "6")
            {
                Maaltafels();
            }
            if (keuze == "7")
            {
                Ruimte();
            }
            if (keuze == "A")
            {
                Optellen_2();
            }
            if (keuze == "B")
            {
                VerbruikWagen_2();
            }
        }
        static public void VariabelenHoofdletters()
        {
            // Schrijf de volgende vraag in de console.
            Console.WriteLine("Dit is mijn eerste C# programma!");
            Console.WriteLine("********************************");
            Console.Write("Typ je naam: ");
            // Lees de gebruikersinvoer van de console
            // en slaag dit op in de string variabele 'naam'
            string naam = Console.ReadLine();
            // Schrijf "Hallo " gevolg door de
            // gebruikersinvoer naam in hoofdletters in de console
            Console.WriteLine("Hallo " + naam.ToUpper());
        }

        static public void Optellen_1()
        {
            // Afspraak: denk aan de 'naming conventions'
            // variabelen beginnen met kleine letters & kies betekeningsvolle namen!
            // Let op: denk goed na over het gebruikte datatype (niet te groot, maar ook niet te klein)
            // hou altijd controle en geef de variabelen een beginwaarde mee (wees controle-freak)
            int getal1 = 0;
            int getal2 = 0;
            int som = 0;
            //string invoer1 = string.Empty;
            //string invoer2 = string.Empty;
            string invoer = string.Empty;
            // invoer (inlezen getallen):
            Console.WriteLine("Geef het eerste getal: ");
            //invoer1 = Console.ReadLine();
            invoer = Console.ReadLine();
            // zet de tekst om naar een numerische waarde
            // 1e manier (oude schrijfwijze)
            //getal1 = Convert.ToInt32(invoer);
            // 2e manier (object oriented)
            //getal1 = int.Parse(invoer1);
            getal1 = int.Parse(invoer);
            Console.WriteLine("Geef het tweede getal: ");
            invoer = Console.ReadLine();
            getal2 = int.Parse(invoer);
            // voer de berekening uit
            som = getal1 + getal2;
            // geef resultaat weer
            Console.WriteLine("De som is: " + som);
        }
               
        static public void Optellen_2()
        {
            Console.WriteLine("Wat is het eerste getal?");
            int getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            int getal2 = Convert.ToInt32(Console.ReadLine());
            int som = getal1 + getal2;
            Console.WriteLine("De som is " + som);
        }

        static public void VerbruikWagen_1()
        {
            // declareer de variabelen met initialisatie
            double kilometerstandBijAanvang = 0d;
            double kilometerstandBijAankomst = 0d;
            double aantalLiterinTankBijVertrek = 0d;
            double aantalLiterinTankBijAankomst = 0d;
            double verbruik = 0d;
            // Vraag alle info op aan gebruiker en bewaar
            Console.Write("Geef het aantal liter in tank voor de rit: ");
            aantalLiterinTankBijVertrek = double.Parse(Console.ReadLine());
            Console.Write("Geef het aantal liter in tank na de rit: ");
            aantalLiterinTankBijAankomst = double.Parse(Console.ReadLine());
            Console.Write("Geef kilometerstand van je auto voor de rit: ");
            kilometerstandBijAanvang = double.Parse(Console.ReadLine());
            Console.Write("Geef kilometerstand van je auto na de rit: ");
            kilometerstandBijAankomst = double.Parse(Console.ReadLine());
            // bereken verbruik
            verbruik = 100 * (aantalLiterinTankBijVertrek - aantalLiterinTankBijAankomst) /
                             (kilometerstandBijAankomst - kilometerstandBijAanvang);
            // verbruik weergeven
            Console.WriteLine("Het verbruik van de auto is: " + verbruik);
            // afgerond:
            Console.WriteLine("Het afgeronde verbruik van de auto is: " +  Math.Round(verbruik, 2));
        }
    

        static public void VerbruikWagen_2()
        {
            Console.Write("Geef het aantal liter in tank voor de rit: ");
            double literVoorRit = double.Parse(Console.ReadLine());
            Console.Write("Geef het aantal liter in tank na de rit: ");
            double literNaRit = double.Parse(Console.ReadLine());
            Console.Write("Geef kilometerstand voor de rit: ");
            double kmVoorRit = double.Parse(Console.ReadLine());
            Console.Write("Geef kilometerstand na de rit: ");
            double kmNaRit = double.Parse(Console.ReadLine());
            double verbruik = (100 * (literVoorRit - literNaRit) / (kmNaRit - kmVoorRit));
            Console.WriteLine("Het verbruik van de auto is: " + verbruik);
            Console.WriteLine("Het afgeronde verbruik van de auto is: " + Math.Round(verbruik, 2));
            }
        static public void BeetjeWiskunde()
        {
            Console.WriteLine("Berekening met gebruik van integers");
            // met ints
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine();
            Console.WriteLine("Berekening met gebruik van floats");
            //met floats
            Console.WriteLine(-1 + 4.0f * 6);
            Console.WriteLine((35.0f + 5) % 7);
            Console.WriteLine(14 + -4.0f * 6 / 11);
            Console.WriteLine(2 + 15.0f / 6 * 1 - 7.0f % 2);
        }

        static public void Gemiddelde()
        {
            Console.WriteLine("Een beetje wiskunde: gemiddelde");
            Console.WriteLine();
            Console.WriteLine("Berekening gemiddelde met gebruik van integers");
            Console.WriteLine((18 + 11 + 8) / 3);
            Console.WriteLine();
            Console.WriteLine("Berekening gemiddelde met gebruik van floats");
            Console.WriteLine((18.0f + 11 + 8) / 3);
        }
        static public void Maaltafels()
        {
            int number = 411;
            Console.WriteLine("1 * " + number + " = " + number);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("2 * " + number + " = " + number * 2);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("3 * " + number + " = " + number * 3);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("4 * " + number + " = " + number * 4);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("5 * " + number + " = " + number * 5);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("6 * " + number + " = " + number * 6);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("7 * " + number + " = " + number * 7);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("8 * " + number + " = " + number * 8);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("9 * " + number + " = " + number * 9);
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("10 * " + number + " = " + number * 10);
        }
        static public void Ruimte()
        {
            Console.Write("Geef je gewicht in kg: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Op Mercurius voel je je alsof je " + Math.Round((gewicht * 0.38),2) + "kg weegt.");
            Console.WriteLine("Op Venus voel je je alsof je " + Math.Round((gewicht * 0.91),2) + "kg weegt.");
            Console.WriteLine("Op Aarde voel je je alsof je " + gewicht + "kg weegt.");
            Console.WriteLine("Op Mars voel je je alsof je " + Math.Round((gewicht * 0.38),2) + "kg weegt.");
            Console.WriteLine("Op Jupiter voel je je alsof je " + Math.Round((gewicht * 2.34),2) + "kg weegt.");
            Console.WriteLine("Op Saturnus voel je je alsof je " + Math.Round((gewicht * 1.06),2) + "kg weegt.");
            Console.WriteLine("Op Uranus voel je je alsof je " + Math.Round((gewicht * 0.92),2) + "kg weegt.");
            Console.WriteLine("Op Neptunus voel je je alsof je " + Math.Round((gewicht * 1.19),2) + "kg weegt.");
            Console.WriteLine("Op Pluto voel je je alsof je " + Math.Round((gewicht * 0.06),2) + "kg weegt.");
        }
    }
}
