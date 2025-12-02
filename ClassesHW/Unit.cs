using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHW
{
    internal class Unit
    {
        private float _health;
        private int _damage = 5;
        private float _armor = 0.6f;

        public string name
        {
            get;
        }
        public float Health
        {
            get { return _health; }
        }

        public int Damage
        {
            get;
        }
        public float Armor
        {
            get { return _armor; }
        }


        public Unit()
        {
            this.name = "Unknown Unit";
        }
        public Unit(string name)
        {
            this.name;
        }
    }

}
