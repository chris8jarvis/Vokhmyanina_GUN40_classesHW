namespace ClassesHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Unit name");
            string name = Console.ReadLine();
            Unit TestUnit = new Unit(name);
            Console.WriteLine($"Hello {TestUnit.Name}");
            Console.WriteLine($"{TestUnit.Name} your current health is {TestUnit.GetRealHealth()}");

            int damage = 0;
            bool isValidInput = false;

            while (!isValidInput)
            {
                Console.Write("Enter your damage: ");
                string damageInput = Console.ReadLine();

                if (int.TryParse(damageInput, out damage))
                {
                    Console.WriteLine($"Your chosen damage is {damage}");
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter a number.");
                }
            }

            bool isDead = TestUnit.SetDamage(damage);
            if (isDead)
            {
                Console.WriteLine("Your Unit is dead");
                return;
            }
            Console.WriteLine("Your Unit survived");
            Console.WriteLine($"New Real Health: {TestUnit.GetRealHealth()}");



            //Unit object1 = new Unit();
            //Console.WriteLine(object1.Name);

            //Console.WriteLine(object1.Damage);
            //Console.WriteLine(object1.Health);
            //Console.WriteLine(object1.Armor);

            //Console.WriteLine(object1.GetRealHealth());
            //Console.WriteLine(object1.SetDamage(200f));



            //Unit object2 = new Unit("Foo");
            //Console.WriteLine(object2.Name);
            //Console.WriteLine(object2.Damage);
            //Console.WriteLine(object2.Health);
            //Console.WriteLine(object2.Armor);

        }
    }
}