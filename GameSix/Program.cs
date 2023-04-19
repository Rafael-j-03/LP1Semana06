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

            // Ask the user for the name of each foe
            for (int i = 0; i < numberOfFoes; i++)
            {
                Console.Write("Name of foe " + (i + 1) + ": ");
                string name = Console.ReadLine();
                foes[i] = new Foe(name);
            }

            // Print all foes's names
            for (int i = 0; i < numberOfFoes; i++)
            {
                Console.WriteLine("Foe " + (i + 1) + ": " + foes[i].GetName());
            }

            // Pickup Power Up test
            foes[0].PickupPowerUp(PowerUp.Health, 42.0f);
            foes[0].PickupPowerUp(PowerUp.Shield, 69.24f);

            // Take Damage test
            foes[0].TakeDamage(52.69f);

            // Print all foes's health and shield
            for (int i = 0; i < numberOfFoes; i++)
            {
                Console.WriteLine("Foe " + (i + 1) + ": " + foes[i].GetName() + " has " +
                foes[i].GetHealth() + " health and " + foes[i].GetShield() + " shield.");
            }

            // Print the power up count
            Console.WriteLine("Number of power ups: " + Foe.GetNumberOfPowerUps());


            Console.WriteLine("Thank you for using this program!");
        }
    }
}
