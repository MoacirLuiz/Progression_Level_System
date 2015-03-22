using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression_Level_System
{
    class XP_Storage
    {
        Dictionary<string, double> xp_Storage = new Dictionary<string, double>();
        Monsters mn = new Monsters();
        Character ch = new Character();

        int xp_mpy = 2;

        //Get exp from the Monsters list and multiply by 2.
        public void getExpFromMonster()
        {
            mn.addMonsters();
            foreach (var element in mn.Monsters_Inc)
            {
                double getExpMultiply = element.Value * xp_mpy;
                xp_Storage.Add(element.Key, getExpMultiply);
            }
        }

        public void LevelUP()
        {
            foreach(var element1 in mn.Monsters_Inc)
            {
                if (ch.xp >= element1.Value)
                {
                    ch.level++;
                    Console.WriteLine("You leveled up: {0}, {1}", ch.level, ch.xp);
                }
            }
        }


        public void attributesLevelUP()
        {
            
        }
    }
}
