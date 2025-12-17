using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassesHW
{
    public class Unit
    {

        private float _health;
        public string Name
        {
            get;
        }

        public float Health
        {
            get { return _health; }
        }

        public Interval Damage;

        //public int Damage
        //{
        //    get;
        //}
        public float Armor
        {
            get;
        }
        public Unit()
        {
            Name = "Unknown Unit";
            Damage = new Interval(0, 10);
            Armor = 0.6f;
            _health = 100;
        }

        public Unit(string name) :this()
        {
            Name = name;
        }

        public Unit(string name, int minDamage, int maxDamage) : this(name)
        {
            this.Damage = new Interval(minDamage, maxDamage);
        }

        public float GetRealHealth()
        {
            return Health * (1f + Armor); // 100(1+0.6)
        }


        public bool SetDamage(float value)
        {
            _health = Health - value * Armor;

            if (Health <= 0f)
            {
                return true;
            }
            return false;
        }

    }

    }


