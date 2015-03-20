using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression_Level_System
{
    class Character
    {
        public string name;
        public int level = 1;
        public double xp = 0.0;

        public void showCharacterInfo()
        {
            Console.WriteLine("Name: {0}, Your Level: {1}, And XP: {2}", name, level, xp);
        }
    }

}
