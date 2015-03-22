using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progression_Level_System
{
    class Character
    {
        //Atributos da classe Character
        public string name = String.Empty;
        public string newName = String.Empty;
        public int level = 1; //Level inicial do personagem
        public double xp = 0.0;


        //Atributos base da classe Character
        //Todas setadas como zero
        public double att_str = 0.0;
        public double att_vit = 0.0;
        public double att_agi = 0.0;
        public double att_int = 0.0;

        //Método para pegar o nome do personagem
        public void getName()
        {
            Console.WriteLine("Enter your name, brave warrior: ");
            name = Console.ReadLine();
            Console.WriteLine("Are you sure your name will be: {0}," + " brave warrior?", name);

            switch (Console.ReadLine())
            {
                case "yes":
                    Console.WriteLine("Ok, now you are {0}, The Great Magician", name);
                    break;

                case "no":
                    Console.WriteLine("Enter your name then: ");
                    newName = Console.ReadLine();

                    while (newName == name)
                    {
                        Console.WriteLine("\nYou entered the same name, try again");
                        Console.WriteLine("Enter your name:");
                        newName = Console.ReadLine();

                             if (newName != name)
                             {
                               name = newName;
                               Console.WriteLine("\nYour new name is: {0}\n\r", name);
                             }
                     }
                    break;
            }
        }

        //Mostrar as informações do personagem
        public void showCharacterInfo()
        {
            if (name != String.Empty && level >= 1 && xp >= 0.0)
            {
                Console.WriteLine("\nYour name is: {0}\n\r" +
                                   "Your level is: {1}\n\r" +
                                      "Your xp is: {2}\n\r" , name, level, xp);
            }
            else if(name == String.Empty)
            {
                Console.WriteLine("Looks like your name is empty\n\r");
            }
            else if (level == 0)
            {
                Console.WriteLine("You level is 0\n\r");
            }
        }
    }

}
