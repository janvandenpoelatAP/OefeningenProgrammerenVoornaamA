using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OefeningenProgrammeren
{
    class H01
    {
        static public void MijnEersteProgramma()
        {
            Console.WriteLine("Dit is mijn eerste C# programma");
            Console.WriteLine("*******************************");
            Console.WriteLine("Typ je voornaam:");
            string voornaam = Console.ReadLine();
            Console.WriteLine("Typ je achternaam");
            string achternaam = Console.ReadLine();
            Console.WriteLine("Dus je naam is: " + achternaam + " " + voornaam);
            Console.WriteLine("Of: " + voornaam + " " + achternaam);
        }

        static public void ZegGoedendag()
        {
            Console.WriteLine("Hoe heet je?");
            string invoer = Console.ReadLine();
            Console.WriteLine(invoer + ", ik wens je goedendag!");
        }
        static public void RommelZin()
        {
            string favColor;
            string favFood;
            string favCar;
            string favMovie;
            string favBook;
            Console.WriteLine("Wat is je favoriete kleur?");
            favColor = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete eten?");
            favFood = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete auto?");
            favCar = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete film?");
            favMovie = Console.ReadLine();
            Console.WriteLine("Wat is je favoriete boek?");
            favBook = Console.ReadLine();
            Console.WriteLine("Je favoriete kleur is " + favFood + (". Je eet graag " + favCar + ". Je lievelingsfilm is " + favBook + " en je favoriete boek is " + favMovie + "."));
        }

        static public void GekleurdeRommelzin()
        {
            string favColor;
            string favFood;
            string favCar;
            string favMovie;
            string favBook;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Wat is je favoriete kleur?");
            Console.ResetColor();
            favColor = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Wat is je favoriete eten?");
            Console.ResetColor();
            favFood = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Wat is je favoriete auto?");
            Console.ResetColor();
            favCar = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Wat is je favoriete film?");
            Console.ResetColor();
            favMovie = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ResetColor();
            Console.WriteLine("Wat is je favoriete boek?");
            favBook = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Je favoriete kleur is " + favFood + (". Je eet graag " + favCar + ". Je lievelingsfilm is " + favBook + " en je favoriete boek is " + favMovie + "."));
            Console.ResetColor();
        }
    }
}
