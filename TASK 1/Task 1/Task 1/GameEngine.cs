using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class GameEngine
    {
        public int finishedRounds = 0;
        bool finishedActions = false;

        Map map = new Map();
        MeleeUnit meleeUnit = new MeleeUnit(0, 0, 7, 7, 2, 4, 1, "Melee", "M");
        RangedUnit rangedUnit = new RangedUnit(0, 0, 5, 5, 4, 2, 3, "Ranged", "R");

    }
}
