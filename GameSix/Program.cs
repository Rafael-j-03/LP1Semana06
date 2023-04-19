using System;

namespace GameSix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for the number of foes
            Console.Write("How many foes? ");
            int numberOfFoes = int.Parse(Console.ReadLine());

            // Store the foes in an array
            Foe[] foes = new Foe[numberOfFoes];
        }
    }
}
