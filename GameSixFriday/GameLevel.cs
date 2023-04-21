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
        Foe[] foes;
        
        public GameLevel(int numRooms, Difficulty difficulty)
        {
            this.numRooms = numRooms;
            this.difficulty = difficulty;
        }

        public void SetFoeInRoom(int room, Foe foe)
        {
            foes[room] = foe;
        }
    }
}