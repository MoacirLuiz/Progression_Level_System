using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression_Level_System
{
    class Monsters
    {
        public Dictionary<string, int> Monsters_Inc = new Dictionary<string, int>();
           
        public void AddMonsters(string monsterName, int monsterXP)
        {
            Monsters_Inc.Add("Rat", 10);
            Monsters_Inc.Add("Slime", 50);
            Monsters_Inc.Add("Skeleton", 150);
        }
    }
}
