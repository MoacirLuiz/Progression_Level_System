using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression_Level_System
{
    class Vocation
    {
        List<RPGClass> rpg_Classes = new List<RPGClass>();

        public void addClass()
        {
           rpg_Classes.Add(new RPGClass() { ClassName = "Warrior", Strenght = 12, Vitallity = 12, Dexterity = 10, Intelligence = 8 });
           rpg_Classes.Add(new RPGClass() { ClassName = "Mage", Strenght = 12, Vitallity = 12, Dexterity = 10, Intelligence = 8 });
           rpg_Classes.Add(new RPGClass() { ClassName = "Knight", Strenght = 12, Vitallity = 12, Dexterity = 10, Intelligence = 8 });

        }

        public void showClasses()
        {
            foreach (var classes in rpg_Classes)
            {
                Console.WriteLine("You may choose one class: {0}\n", classes.ClassName.ToString());
            }
        }
    }
}
