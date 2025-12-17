using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHW
{
    public class Weapon
    {
        private const int DefaultMinDamage = 1;
        private const int DefaultMaxDamage = 10;
        public string Name
        {
            get;
        }
        public Interval Damage;


        public float Durability
        {
            get;
        }
        public Weapon(string name)
        {
            Name = name;
            Durability = 1f;
        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            SetDamageParams(minDamage, maxDamage);
        }
        public void SetDamageParams(int minDamage, int maxDamage)
        {

            this.Damage = new Interval(minDamage, maxDamage);

        }

        public int GetDamage()
        {
            return (Damage.Max + Damage.Min) / 2;
        }
    }
}
