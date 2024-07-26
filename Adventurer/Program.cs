using System;

// Adrian Arteaga: Adventurer Program (Yahara)

namespace Adventurer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Adventurer adventurer = new Adventurer();

            Console.WriteLine("Enter a string of directions (e.g. F2R3B4L2): ");
            string input = Console.ReadLine();

            // Update position of adventurer
            adventurer.updatePosition(input);
            double totalDistance = adventurer.getEuclidean();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
