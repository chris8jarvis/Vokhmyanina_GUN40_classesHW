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

        //public int MinDamage
        //{
        //    get; private set;
        //}
        //public int MaxDamage
        //{
        //    get; private set;
        //}

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
            //if (minDamage > maxDamage)
            //{
            //    //числа меняются местами
            //    int buff = minDamage;
            //    minDamage = maxDamage;
            //    maxDamage = buff;
            //    Console.WriteLine($"Weapon: {this.Name}. Incorrect input");
            //}

            //if (minDamage < DefaultMinDamage)
            //{
            //    //минимальный урон оружия задается значением f
            //    minDamage = DefaultMinDamage;
            //    Console.WriteLine($"Weapon: {this.Name}. Forced setting of the minimum value to {DefaultMinDamage}");
            //}

            //if (maxDamage <= 1)
            //{
            //    maxDamage = DefaultMaxDamage;
            //    Console.WriteLine($"Weapon: {this.Name}. Forced setting of the maximum value to {DefaultMaxDamage}");
            //}

            this.Damage = new Interval(minDamage, maxDamage);

        }

        public int GetDamage()
        {
            return (Damage.Max + Damage.Min) / 2;
        }
    }
}
