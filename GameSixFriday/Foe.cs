using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class Foe
    {
        private string name;
        private float health;
        private float shield;

        private static int numberOfPowerUps;

        // Constructor
        public Foe(string name)
        {
            SetName(name);
            health = 100;
            shield = 0;
            numberOfPowerUps = 0;
        }

        public string GetName()
        {
            return name;
        }

        public float GetHealth()
        {
            return health;
        }

        public float GetShield()
        {
            return shield;
        }

        public void SetName(string name)
        {
            // Get the name without initial and final spaces
            name = name.Trim();
            // Set the name
            this.name = name;
        }

        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public void PickupPowerUp(PowerUp powerUp, float amount)
        {
            if (powerUp == PowerUp.Health)
            {
                health += amount;
                if (health > 100) health = 100;
            }
            else if (powerUp == PowerUp.Shield)
            {
                shield += amount;
                if (shield > 100) shield = 100;
            }

            numberOfPowerUps++;
        }

        public static int GetNumberOfPowerUps()
        {
            return numberOfPowerUps;
        }
    }
}