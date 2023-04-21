using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameSixFriday
{
    public class GameLevel
    {
        private int numRooms;
        private Difficulty difficulty;
        Foe[] roomFoes;
        
        public GameLevel(int numRooms, Difficulty difficulty)
        {
            this.numRooms = numRooms;
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
            return numRooms;
        }
    }
}