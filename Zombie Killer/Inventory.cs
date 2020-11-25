using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombie_Killer
{
    class Inventory
    {
        public string[] bag = new string[3];
        public int numberOfItem = 0;

        public bool collectItem(string item)
        {
            if (numberOfItem == 3)
            {
                return false;
            }
            else
            {
                bag[numberOfItem] = item;
                numberOfItem += 1;
                return true;
            }
        }

        
        public int numberOfGun()
        {
            return bag.Length;
        }

        public int numberOfGunCollected()
        {
            return numberOfItem;
        }
    }
}
