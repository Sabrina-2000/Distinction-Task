using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_Killer
{
    class Gun
    {

      public string selectGun(int gunNumber, Inventory inventory)
        {
            string[] bag = inventory.bag;
            if (gunNumber == 1)
            {
                return bag[0];
            }
            else if (gunNumber == 2)
            {
                return bag[1];
            }
            else if(gunNumber == 3)
            {
                return "NormalGun";
            }
            else
                return "Empty Inventory";
        }
    }
}
