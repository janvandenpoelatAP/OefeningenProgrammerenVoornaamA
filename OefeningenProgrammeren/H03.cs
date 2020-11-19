using System;
using System.Collections.Generic;
using System.Text;

namespace OefeningenProgrammeren
{
    class H03
    {
        static public void Keuzemenu()
        {
            Console.WriteLine(@"Kies uit de volgende methodes door een cijfer in te geven
1 - Maaltafels
2 - Ruimte
3 - BerekenenBtw
4 - LeetSpeak_1
5 - Instructies_1
6 - Lotto_1
7 - Superlotto_1
A - LeetSpeak_2
B - Instructies_2
C - Lotto_2
D - Superlotto_2");
            Console.WriteLine();
            string keuze = Console.ReadLine();
            Console.Clear();
            if (keuze == "1")
            {
                Maaltafels();
            }
            if (keuze == "2")
            {
                Ruimte();
            }
            if (keuze == "3")
            {
                BerekenenBtw();
            }
            if (keuze == "4")
            {
                LeetSpeak_1();
            }
            if (keuze == "5")
            {
                Instructie_1();
            }
            if (keuze == "6")
            {
                Lotto_1();
            }
            if (keuze == "7")
            {
                SuperLotto_1();
            }
            if (keuze == "A")
            {
                LeetSpeak_2();
            }
            if (keuze == "B")
            {
                Instructie_2();
            }
            if (keuze == "C")
            {
                Lotto_2();
            }
            if (keuze == "D")
            {
                SuperLotto_2();
            }
        }

        static public void Maaltafels()
        {
            int baseNumber = 411;
            Console.Clear();
            Console.WriteLine($"1 * {baseNumber} is {1 * baseNumber}.");
            Console.WriteLine($"2 * {baseNumber} is {2 * baseNumber}.");
            Console.WriteLine($"3 * {baseNumber} is {3 * baseNumber}.");
            Console.WriteLine($"4 * {baseNumber} is {4 * baseNumber}.");
            Console.WriteLine($"5 * {baseNumber} is {5 * baseNumber}.");
            Console.WriteLine($"6 * {baseNumber} is {6 * baseNumber}.");
            Console.WriteLine($"7 * {baseNumber} is {7 * baseNumber}.");
            Console.WriteLine($"8 * {baseNumber} is {8 * baseNumber}.");
            Console.WriteLine($"9 * {baseNumber} is {9 * baseNumber}.");
            Console.WriteLine($"10 * {baseNumber} is {10 * baseNumber}.");
        }
        static public void Ruimte()
        {
            Console.Write("Geef je gewicht in kg: ");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Op Mercurius voel je je alsof je {Math.Round((gewicht * 0.38), 2)}kg weegt.");
            Console.WriteLine($"Op Venus voel je je alsof je {Math.Round((gewicht * 0.91), 2)}kg weegt.");
            Console.WriteLine($"Op Aarde voel je je alsof je {gewicht}kg weegt.");
            Console.WriteLine($"Op Mars voel je je alsof je {Math.Round((gewicht * 0.38), 2)}kg weegt.");
            Console.WriteLine($"Op Jupiter voel je je alsof je {Math.Round((gewicht * 2.34), 2)}kg weegt.");
            Console.WriteLine($"Op Saturnus voel je je alsof je {Math.Round((gewicht * 1.06), 2)}kg weegt.");
            Console.WriteLine($"Op Uranus voel je je alsof je {Math.Round((gewicht * 0.92), 2)}kg weegt.");
            Console.WriteLine($"Op Neptunus voel je je alsof je {Math.Round((gewicht * 1.19), 2)}kg weegt.");
            Console.WriteLine($"Op Pluto voel je je alsof je {Math.Round((gewicht * 0.06), 2)}kg weegt.");
        }

        static public void BerekenenBtw()
        {
            Console.Write("Geef het bedrag in: ");
            double bedrag = Convert.ToDouble(Console.ReadLine());
            Console.Write("Geef BTW percentage in: ");
            int btw = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Het bedrag {bedrag} met {btw}% btw bedraagt {(bedrag) + ((bedrag) * btw / 100d)}.");
        }

        static public void LeetSpeak_1()
        {
            Console.WriteLine("Geef je tekst in:");
            string tekst = Console.ReadLine();
            tekst = tekst.Replace(" ", "");
            tekst = tekst.Replace("a", "@");
            Console.WriteLine($"De nieuwe tekst is: {tekst}");
            Console.ReadKey();
        }
        static public void LeetSpeak_2()
        {
            Console.WriteLine("Geef je tekst in");
            string tekst = Console.ReadLine();
            tekst = tekst.Replace("a", "@").Replace(" ", "");
            Console.WriteLine(tekst);
        }
        static public void Instructie_1()
        {
            Console.Write("Wat is je naam: ");
            string naam = Console.ReadLine();
            Console.Write("Geef de naam van de cursus: ");
            string map = Console.ReadLine();
            Console.WriteLine($@"Maak een map als volgt: \{naam.Substring(0, 3).ToUpper()}\{map}");
            Console.ReadKey();
        }
        static public void Instructie_2()
        {
            Console.WriteLine("Wat is je naam?");
            string naam = Console.ReadLine();
            Console.WriteLine("Wat is de naam van de cursus?");
            string cursus = Console.ReadLine();
            naam = naam.Substring(0, 3).ToUpper();
            Console.WriteLine($@"Maak een map als volgt: \{naam}\{cursus}");
        }

        static public void Lotto_1()
        {
            Console.Write("Geef je 6 getallen in voor de lotto (01->45),\ntelkens in 2 cijfers en gescheiden door een komma: ");
            string lotto = Console.ReadLine();
            //Methode 1
            //Console.WriteLine($"Je cijfers zijn:\n\t{lotto.Substring(0, 2)}\t{lotto.Substring(3, 2)}\t{lotto.Substring(6, 2)}\n\t{lotto.Substring(9, 2)}\t{lotto.Substring(12, 2)}\t{lotto.Substring(15, 2)}");
            //Methode 2
            Console.WriteLine($"Je cijfers zijn:\n\t{lotto.Replace(",", "\t").Substring(0, 8)}\n\t{lotto.Replace(",", "\t").Substring(9, 8)}");
            Console.ReadKey();
        }

        static public void Lotto_2()
        {
            Console.WriteLine("Wat zijn je cijfers? (tussen 01 en 45)");
            string cijfers = Console.ReadLine();
            Console.WriteLine($@"Je cijfers zijn: 
    {cijfers.Replace(",", "\t").Substring(0, 8)}
    {cijfers.Replace(",", "\t").Substring(9)}");
        }

        static public void SuperLotto_1()
        {
            Console.Write("Geef je 6 getallen in voor de lotto (01->45) en gescheiden door een komma: ");
            string lotto = Console.ReadLine();
            int positieKomma1 = lotto.IndexOf(",");
            int eersteCijfer = Convert.ToInt32(lotto.Substring(0, positieKomma1));
            int positieKomma2 = lotto.IndexOf(",", positieKomma1 + 1);
            int tweedeCijfer = Convert.ToInt32(lotto.Substring(positieKomma1 + 1, positieKomma2 - (positieKomma1 + 1)));
            positieKomma1 = positieKomma2;
            positieKomma2 = lotto.IndexOf(",", positieKomma1 + 1);
            int derdeCijfer = Convert.ToInt32(lotto.Substring(positieKomma1 + 1, positieKomma2 - (positieKomma1 + 1)));
            positieKomma1 = positieKomma2;
            positieKomma2 = lotto.IndexOf(",", positieKomma1 + 1);
            int vierdeCijfer = Convert.ToInt32(lotto.Substring(positieKomma1 + 1, positieKomma2 - (positieKomma1 + 1)));
            positieKomma1 = positieKomma2;
            positieKomma2 = lotto.IndexOf(",", positieKomma1 + 1);
            int vijfdeCijfer = Convert.ToInt32(lotto.Substring(positieKomma1 + 1, positieKomma2 - (positieKomma1 + 1)));
            positieKomma1 = positieKomma2;
            positieKomma2 = lotto.IndexOf(",", positieKomma1 + 1);
            int zesdeCijfer = Convert.ToInt32(lotto.Substring(positieKomma1 + 1));
            Console.WriteLine($"Je cijfers zijn:\n\t{eersteCijfer:D2}\t{tweedeCijfer:D2}\t{derdeCijfer:D2}\n\t{vierdeCijfer:D2}\t{vijfdeCijfer:D2}\t{zesdeCijfer:D2}");
        }
        static public void SuperLotto_2()
        {
            Console.Write("Geef je 6 getallen in voor de lotto (01->45) en gescheiden door een komma: ");
            string lotto = Console.ReadLine();
            int positieKomma = lotto.IndexOf(",");
            int eersteCijfer = Convert.ToInt32(lotto.Substring(0, positieKomma));
            lotto = lotto.Substring(positieKomma + 1);
            positieKomma = lotto.IndexOf(",");
            int tweedeCijfer = Convert.ToInt32(lotto.Substring(0, positieKomma));
            lotto = lotto.Substring(positieKomma + 1);
            positieKomma = lotto.IndexOf(",");
            int derdeCijfer = Convert.ToInt32(lotto.Substring(0, positieKomma));
            lotto = lotto.Substring(positieKomma + 1);
            positieKomma = lotto.IndexOf(",");
            int vierdeCijfer = Convert.ToInt32(lotto.Substring(0, positieKomma));
            lotto = lotto.Substring(positieKomma + 1);
            positieKomma = lotto.IndexOf(",");
            int vijfdeCijfer = Convert.ToInt32(lotto.Substring(0, positieKomma));
            int zesdeCijfer = Convert.ToInt32(lotto.Substring(positieKomma + 1));
            Console.WriteLine($"Je cijfers zijn:\n\t{eersteCijfer:D2}\t{tweedeCijfer:D2}\t{derdeCijfer:D2}\n\t{vierdeCijfer:D2}\t{vijfdeCijfer:D2}\t{zesdeCijfer:D2}");
        }
    }
}