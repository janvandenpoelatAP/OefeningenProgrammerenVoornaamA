using System;

namespace OefeningenProgrammeren
{
    class Program
    {
        static void Main(string[] args)
        {
            /*

            // Door ondertsaande regelsal dan niet in commentaar te zetten kies je welke methode wordt uitgevoerd
            // Hoofdstuk H01
            H01.MijnEersteProgramma();
            H01.ZegGoedendag();
            H01.RommelZin();
            H01.GekleurdeRommelzin();

            // Hoofdstuk H02
            H02.VariabelenHoofdletters();
            H02.Optellen_1();
            H02.Optellen_2();
            H02.VerbruikWagen_1();
            H02.VerbruikWagen_2();
            H02.Gemiddelde();
            H02.Maaltafels();
            H02.Ruimte();

            // Hoofdstuk H03
            H03.Maaltafels();
            H03.Ruimte();
            H03.BerekenenBtw();
            H03.LeetSpeak_1();
            H03.LeetSpeak_2();
            H03.Instructie_1();
            H03.Instructie_2();
            H03.Lotto_1();
            H03.Lotto_2();
            H03.SuperLotto_1();
            H03.SuperLotto_2();
            */
            Hoofdmenu();
        }

        static void Hoofdmenu()
        {
            string keuze;
            Console.WriteLine(@"Kies uit de volgende klasse door een cijfer in te geven
1 - Hoofdstuk 1
2 - Hoofdstuk 2
3 - Hoofdstuk 3
4 - Hoofdstuk 4
5 - Hoofdstuk 5");
            Console.WriteLine();
            keuze = Console.ReadLine();
            Console.Clear();
            if (keuze == "1")
            {
                H01.Keuzemenu();
            }
            if (keuze == "2")
            {
                H02.Keuzemenu();
            }
            if (keuze == "3")
            {
                H03.Keuzemenu();
            }
            if (keuze == "4")
            {
                H04.Keuzemenu();
            }
            if (keuze == "5")
            {
                H05.Keuzemenu();
            }
        }
    }
}

