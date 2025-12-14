using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHW
{
    public struct Room
    {
        public Unit UnitInstance;
        public Weapon WeaponInstance;

        public Room(Unit u, Weapon w) {
            UnitInstance = u;
            WeaponInstance = w;
        }
    }
}
