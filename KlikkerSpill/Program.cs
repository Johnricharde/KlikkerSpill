using System.Runtime.ConstrainedExecution;

namespace KlikkerSpill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            int pointsPerClick = 1;
            int pointsPerClickIncrease = 1;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Kommandoer:\r\n" +
                "- SPACE = klikk(og få poeng)\r\n" +
                "- K = kjøp oppgradering \r\n      øker poeng per klikk koster 10 poeng\r\n" +
                "- S = kjøp superoppgradering øker \"poeng per klikk\" for den\n      vanlige oppgraderingen. koster 100 poeng\r\n" +
                "- X = avslutt applikasjonen\n");
    
                Console.WriteLine($"Du har {points} poeng.");
                Console.WriteLine("Trykk tast for ønsket kommando.");

                var command = Console.ReadKey().KeyChar;
            }
        }
    }
}

