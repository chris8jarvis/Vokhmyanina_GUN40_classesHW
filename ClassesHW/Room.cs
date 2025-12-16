using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHW
{
    public struct Room
    {
        public Unit Unit;
        public Weapon Weapon;

        public Room(Unit u, Weapon w) {
            Unit = u;
            Weapon = w;
        }
    }
}
