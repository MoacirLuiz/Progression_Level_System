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
            Vocation vc = new Vocation();
            vc.addClass();
            vc.showClasses();
        }
    }
    #endregion
}
