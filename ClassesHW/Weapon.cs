using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHW
{
    internal class Weapon
    {
        public string Name
        {
            get;
        }
        public int MinDamage
        {
            get; private set;
        }
        public int MaxDamage
        {
            get; private set;
        }

        public float Durability
        {
            get;
        }
        public Weapon()
        {
            Durability = 1f;
        }
        public Weapon(string name)
        {
            Name = name;
        }
        public Weapon(string name, int minDamage, int maxDamage) : this(name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            SetDamageParams(minDamage, maxDamage);
        }
        public void SetDamageParams(int minDamage, int maxDamage)
        {
            if (minDamage > maxDamage)
            {
                //числа меняются местами
                minDamage = maxDamage;
                maxDamage = minDamage;
                Console.WriteLine($"Incorrect input");
            }
            else if (minDamage < 1)
            {
                //минимальный урон оружия задается значением f
                minDamage = ;
                Console.WriteLine("Forced setting of the minimum value");
            }
            else if (maxDamage <= 1)
            {
                maxDamage = 10;
            }
        }
        public int GetDamage()
        {
            return (MaxDamage - MinDamage) / 2;
        }
    }
}
