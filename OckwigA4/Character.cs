using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroNS
{
    abstract public class Character
    {
        public Character(string n = "Geralt", Global.RaceType r = Global.RaceType.WITCHER, short h = 200, short p = 50, Global.WeaponType w = Global.WeaponType.AXE)
        {
            Name = n;
            Race = r;
            Health = h;
        }


        public string Name { get; set; }
        public Global.RaceType Race { get; set; }
        public short Health { get; set; }

    }
}
