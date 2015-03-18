using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Progression_Level_System
{
    #region CLASS_PRAGMA
    class Program
    {
        static void Main(string[] args)
        {
            Progression_BY_XP();
        }

        #region PROGRESSION_BY_XP
        public static void Progression_BY_XP()
        {
            string name = "Hail";
            double xp_amount = 0.0;
            int xp_mpy = 2;
            int lvl = 0;
            double xp_count = 0;
            List<double> XP_Amount = new List<double>();
            
            for (int i = 0; i < 11; i++)
            {
                xp_count = i * 1000 / 2;
                XP_Amount.Add(xp_count);

            }

            Dictionary<string, int> Monsters = new Dictionary<string, int>();
            Monsters.Add("Skeleton", 1500);
            Monsters.Add("Orc", 1000);

            foreach (var entry in Monsters)
            {
                if (entry.Key == "Skeleton")
                {
                    xp_amount = entry.Value * xp_mpy;
                }
            }

            foreach (var element in XP_Amount)
            {
                if (xp_amount >= element)
                {
                    lvl++;
                    Console.WriteLine("Congratz, {0}, You leveled up {1}", name, lvl);
                }
            }
                
            
        
        }
        #endregion
    }
    #endregion
}
