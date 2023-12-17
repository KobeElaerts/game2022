using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game2022
{
    internal class Consumable
    {
        public string Name;
        public int Healing;
        public Consumable(string name, int healing) 
        {
            Name = name;
            Healing = healing;
        }
    }
}
