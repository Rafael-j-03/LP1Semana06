using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private Difficulty difficulty;
        Foe[] roomFoes;
        
        public GameLevel(int numRooms, Difficulty difficulty)
        {
            this.difficulty = difficulty;
            roomFoes = new Foe[numRooms];
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            roomFoes[room - 1] = foe;
        }

        public Difficulty GetDifficulty()
        {
            return difficulty;
        }

        public int GetNumRooms()
        {
            return roomFoes.Length;
        }

        public int GetNumFoes()
        {
            return roomFoes.Count(foe => foe != null);
        }

        public void PrintFoes()
        {
            for (int i = 0; i < roomFoes.Length; i++)
            {
                if (roomFoes[i] != null)
                {
                    Console.WriteLine($"Room {i + 1}: {roomFoes[i].GetName()}");
                }
            }
        }
    }
}