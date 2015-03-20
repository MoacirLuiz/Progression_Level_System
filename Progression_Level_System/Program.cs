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
            XP_Storage xp = new XP_Storage();
            xp.getExpFromMonster();
        }
    }
    #endregion
}
