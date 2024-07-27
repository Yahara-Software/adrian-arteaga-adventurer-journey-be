using System;

// Adrian Arteaga: Adventurer Program (Yahara)

namespace Adventurer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Adventurer adventurer = new Adventurer();

            // Testing for user input
/*            Console.WriteLine("Enter a string of directions (e.g. F2R3B4L2): ");
            string input = Console.ReadLine();*/

            string input = "15F6B6B5L16R8B16F20L6F13F11R";

            // Update position of adventurer
            if (input != null)
            {
                adventurer.updatePosition(input);
                double totalDistance = Adventurer.getEuclidean(adventurer);
                
                //Testing to see adventurers position
                //Console.WriteLine($"Final position: ({adventurer.xPos}, {adventurer.yPos})");
                Console.WriteLine($"Euclidean distance from start to end: {totalDistance}");
            }
            else
            {
                Console.WriteLine("Given input was empty.");
            }
            

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
