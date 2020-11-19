using System;

namespace APDotCom
{
    class Program
    {
        static void Main(string[] args)
        {
            Bestel();
            BestelMetVraagEnAanbod_1();
            BestelMetVraagEnAanbod_2();
            BestelConditioneel();
        }

        static public void Bestel()
        {
            Console.WriteLine("Prijs van een boek?");
            float prijsBoek = float.Parse(Console.ReadLine());
            Console.WriteLine("Prijs van een CD?");
            float prijsCD = float.Parse(Console.ReadLine());
            Console.WriteLine("Prijs van een servies?");
            float prijsServies = float.Parse(Console.ReadLine());
            Console.WriteLine("Prijs van een springkasteel?");
            float prijsSpringkasteel = float.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel boeken?");
            int aantalBoeken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel CD's?");
            int aantalCDs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel servies?");
            int aantalServies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel springkastelen?");
            int aantalSpringkastelen = Convert.ToInt32(Console.ReadLine());

            float totaalBoeken = (aantalBoeken * prijsBoek);
            float totaalCDs = (aantalCDs * prijsCD);
            float totaalServies = (aantalServies * prijsServies);
            float totaalSpringkastelen = (aantalSpringkastelen * prijsSpringkasteel);

            Console.WriteLine("Hoeveel percent korting krijgt u?");
            float korting = float.Parse(Console.ReadLine());

            float totaalVoorKorting = (totaalBoeken + totaalCDs + totaalServies + totaalSpringkastelen);

            float totaalNaKorting = (totaalVoorKorting * (1 - (korting / 100)));

            Console.WriteLine("Uw kasticket");
            Console.WriteLine("------------");
            Console.WriteLine($"boek x {aantalBoeken}: {totaalBoeken:F2}");
            Console.WriteLine($"CD x {aantalCDs}: {totaalCDs:F2}");
            Console.WriteLine($"Servies x {aantalServies}: {totaalServies:F2}");
            Console.WriteLine($"Springkasteel x {aantalSpringkastelen}: {totaalSpringkastelen:F2}");
            Console.WriteLine($"KORTING: {korting}%");
            Console.WriteLine($"TOTAAL VOOR KORTING: {totaalVoorKorting:F2}");
            Console.WriteLine($"TOTAAL NA KORTING: {totaalNaKorting:F2}");
        }

        public static void BestelMetVraagEnAanbod_1()
        {
            Console.Write($"Basisprijs van een boek?\n> ");
            double basisprijsBoek = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Basisprijs van een CD?\n> ");
            double basisprijsCd = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Basisprijs van een servies?\n> ");
            double basisprijsServies = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Basisprijs van een springkasteel?\n> ");
            double basisprijsSpringkasteel = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Aantal boeken?\n> ");
            double aantalBoeken = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Aantal CD's?\n> ");
            double aantalCds = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Aantal serviezen?\n> ");
            double aantalServiezen = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Aantal springkastelen?\n> ");
            double aantalSpringkastelen = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Percentage korting?\n> ");
            double percentageKorting = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Uw kasticket
------------");
            Random percentage = new Random();
            double percentageBoek = percentage.Next(-50, 51);
            Console.WriteLine($"vraag en aanbod boeken: {percentageBoek}%");
            double percentageCd = percentage.Next(-50, 51);
            Console.WriteLine($"vraag en aanbod CD's: {percentageCd}%");
            double percentageServies = percentage.Next(-50, 51);
            Console.WriteLine($"vraag en aanbod serviezen: {percentageServies}%");
            double percentageSpringkasteel = percentage.Next(-50, 51);
            Console.WriteLine($"vraag en aanbod springkastelen: {percentageSpringkasteel}%");

            double totaalBoeken = (aantalBoeken * ((1 + (percentageBoek / 100)) * basisprijsBoek));
            Console.WriteLine($"boek x {aantalBoeken}: {totaalBoeken:F2}");
            double totaalCds = (aantalCds * ((1 + (percentageCd / 100)) * basisprijsCd));
            Console.WriteLine($"CD x {aantalCds}: {totaalCds:F2}");
            double totaalServiezen = (aantalServiezen * ((1 + (percentageServies / 100)) * basisprijsServies));
            Console.WriteLine($"servies x {aantalServiezen}: {totaalServiezen:F2}");
            double totaalSpringkastelen = (aantalSpringkastelen * ((1 + (percentageSpringkasteel / 100)) * basisprijsSpringkasteel));
            Console.WriteLine($"springkasteel x {aantalSpringkastelen}: {totaalSpringkastelen:F2}");
            Console.WriteLine($"KORTING: {percentageKorting}%");

            double totaal = (totaalBoeken + totaalCds + totaalServiezen + totaalSpringkastelen);
            Console.WriteLine($"TOTAAL VOOR KORTING: {totaal:F2}");
            double korting = (1 - (percentageKorting / 100));
            Console.WriteLine($"TOTAAL: {totaal * korting:F2}");

            Console.ReadKey();
        }
        static public void BestelMetVraagEnAanbod_2()
        {
            Console.WriteLine("Basisprijs van een boek?");
            float prijsBoek = float.Parse(Console.ReadLine());
            Console.WriteLine("Basisprijs van een CD?");
            float prijsCD = float.Parse(Console.ReadLine());
            Console.WriteLine("Basisprijs van een servies?");
            float prijsServies = float.Parse(Console.ReadLine());
            Console.WriteLine("Basisprijs van een springkasteel?");
            float prijsSpringkasteel = float.Parse(Console.ReadLine());

            Console.WriteLine("Hoeveel boeken?");
            int aantalBoeken = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel CD's?");
            int aantalCDs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel servies?");
            int aantalServies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hoeveel springkastelen?");
            int aantalSpringkastelen = Convert.ToInt32(Console.ReadLine());

            Random rnd1 = new Random();
            float randomPercentageBoeken = rnd1.Next(-50, 50);
            Random rnd2 = new Random();
            float randomPercentageCDs = rnd2.Next(-50, 50);
            Random rnd3 = new Random();
            float randomPercentageServies = rnd3.Next(-50, 50);
            Random rnd4 = new Random();
            float randomPercentageSpringkastelen = rnd4.Next(-50, 50);

            Console.WriteLine("Hoeveel percent korting krijgt u?");
            float korting = float.Parse(Console.ReadLine());

            float nieuwePrijsBoek = prijsBoek * (1 + (randomPercentageBoeken) / 100);
            float nieuwePrijsCD = prijsCD * (1 + (randomPercentageCDs) / 100);
            float nieuwePrijsServies = prijsServies * (1 + (randomPercentageServies) / 100);
            float nieuwePrijsSpringkasteel = prijsSpringkasteel * (1 + (randomPercentageSpringkastelen) / 100);

            float totaalBoeken = (aantalBoeken * nieuwePrijsBoek);
            float totaalCDs = (aantalCDs * nieuwePrijsCD);
            float totaalServies = (aantalServies * nieuwePrijsServies);
            float totaalSpringkastelen = (aantalSpringkastelen * nieuwePrijsSpringkasteel);

            float totaalVoorKorting = (totaalBoeken + totaalCDs + totaalServies + totaalSpringkastelen);
            float totaalNaKorting = (totaalVoorKorting * (1 - (korting / 100)));

            Console.WriteLine("Uw kasticket");
            Console.WriteLine("------------");

            Console.WriteLine($"Vraag en aanbod boeken: {randomPercentageBoeken}%");
            Console.WriteLine($"Vraag en aanbod CD: {randomPercentageCDs}%");
            Console.WriteLine($"Vraag en aanbod servies: {randomPercentageServies}%");
            Console.WriteLine($"Vraag en aanbod springkasteel: {randomPercentageSpringkastelen}%");

            Console.WriteLine($"boek x {aantalBoeken}: {totaalBoeken:F2}");
            Console.WriteLine($"CD x {aantalCDs}: {totaalCDs:F2}");
            Console.WriteLine($"Servies x {aantalServies}: {totaalServies:F2}");
            Console.WriteLine($"Springkasteel x {aantalSpringkastelen}: {totaalSpringkastelen:F2}");
            Console.WriteLine($"KORTING: {korting}%");
            Console.WriteLine($"TOTAAL VOOR KORTING: {totaalVoorKorting:F2}");
            Console.WriteLine($"TOTAAL NA KORTING: {totaalNaKorting:F2}");
        }
        public static void BestelConditioneel()
        {
            Console.WriteLine("Prijs van een boek?");
            double priceBook = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Prijs van een CD?");
            double priceCD = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Prijs van een servies?");
            double priceTableware = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Prijs van een springkasteel?");
            double priceBouncyCastle = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Aantal boeken?");
            int countBooks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aantal CD's?");
            int countCDs = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aantal serviezen?");
            int countTablewares = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Aantal springkastelen?");
            int countBouncyCastles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Percentage korting?");
            int discount = Convert.ToInt32(Console.ReadLine());
            if (discount > 30)
            {
                Console.WriteLine("Waarschuwing: het ingevoerde percentage is hoog!");
            }

            Console.WriteLine();
            Console.WriteLine("Worden prijsstijgingen en -dalingen toegepast? (J/N)");
            string choice = Console.ReadLine();

            Random r = new Random();
            double total = 0.0;
            int priceChangeBook = 0, priceChangeCD = 0, priceChangeTableware = 0, priceChangeBouncyCastle = 0;

            Console.WriteLine();
            Console.WriteLine("Uw kasticket");
            Console.WriteLine("------------");

            if (choice == "J")
            {
                //Bereken de prijswijziging voor boeken
                priceChangeBook = r.Next(-50, 50);
                Console.Write("vraag en aanbod boeken: ");
                if (priceChangeBook > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (priceChangeBook < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"{priceChangeBook}%");
                Console.ResetColor();

                //Bereken de prijswijziging voor CD's
                priceChangeCD = r.Next(-50, 50);
                Console.Write("vraag en aanbod CD's: ");
                if (priceChangeCD > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (priceChangeCD < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"{priceChangeCD}%");
                Console.ResetColor();

                //Bereken de prijswijziging voor servies
                priceChangeTableware = r.Next(-50, 50);
                Console.Write("vraag en aanbod serviezen: ");
                if (priceChangeTableware > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (priceChangeTableware < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"{priceChangeTableware}%");
                Console.ResetColor();

                //Bereken de prijswijziging voor springkastelen
                priceChangeBouncyCastle = r.Next(-50, 50);
                Console.Write("vraag en aanbod springkastelen: ");
                if (priceChangeBouncyCastle > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (priceChangeBouncyCastle < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                Console.WriteLine($"{priceChangeBouncyCastle}%");
                Console.ResetColor();
            }

            double totalBooks = countBooks * priceBook * (100 + priceChangeBook) / 100d;
            total += totalBooks;
            Console.WriteLine($"boek x {countBooks}: {totalBooks:F2}");
            double totalCDs = countCDs * priceCD * (100 + priceChangeCD) / 100d;
            total += totalCDs;
            Console.WriteLine($"CD x {countCDs}: {totalCDs:F2}");
            double totalTablewares = countTablewares * priceTableware * (100 + priceChangeTableware) / 100d;
            total += totalTablewares;
            Console.WriteLine($"servies x {countTablewares}: {totalTablewares:F2}");
            double totalBouncyCastles = countBouncyCastles * priceBouncyCastle * (100 + priceChangeBouncyCastle) / 100d;
            total += totalBouncyCastles;
            Console.WriteLine($"springkasteel x {countBouncyCastles}: {totalBouncyCastles:F2}");
            Console.WriteLine($"KORTING: {discount}%");
            Console.WriteLine($"TOTAAL VOOR KORTING: {total:F2}");
            Console.WriteLine($"KORTING: {total * (100 - discount) / 100d:F2}");
        }
    } 
}
