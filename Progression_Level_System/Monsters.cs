﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression_Level_System
{
    class Monsters
    {
        public Dictionary<string, int> Monsters_Inc = new Dictionary<string, int>();

        public void addMonsters()
        {
            Monsters_Inc.Add("Rat", 10);
            Monsters_Inc.Add("Skeleton", 30);
            Monsters_Inc.Add("Slime", 50);
            Monsters_Inc.Add("Orc", 100);
        }
        public void showMonsters()
        {
            foreach (var key in Monsters_Inc)
            {
                Console.WriteLine("Name, Exp: {0}", key.ToString());
            }

        }
    }
}
