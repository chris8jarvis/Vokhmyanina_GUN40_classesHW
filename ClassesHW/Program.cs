namespace ClassesHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your Unit name");
            //string name = Console.ReadLine();
            //Unit TestUnit = new Unit(name);
            //Console.WriteLine($"Hello {TestUnit.Name}");
            //Console.WriteLine($"{TestUnit.Name} your current health is {TestUnit.GetRealHealth()}");

            //int damage = 0;
            //bool isValidInput = false;

            //while (!isValidInput)
            //{
            //    Console.Write("Enter your damage: ");
            //    string damageInput = Console.ReadLine();

            //    if (int.TryParse(damageInput, out damage))
            //    {
            //        Console.WriteLine($"Your chosen damage is {damage}");
            //        isValidInput = true;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Please enter a number.");
            //    }
            //}

            //bool isDead = TestUnit.SetDamage(damage);
            //if (isDead)
            //{
            //    Console.WriteLine("Your Unit is dead");
            //    return;
            //}else {
            //Console.WriteLine("Your Unit survived");
            //Console.WriteLine($"New Real Health: {TestUnit.GetRealHealth()}");}
            //////////////////////////////////////////////////////

            //Console.WriteLine("Enter your Weapon name");
            //string inputWeaponName = Console.ReadLine();
            
            //Weapon TestWeapon = new Weapon(inputWeaponName);
            //Console.WriteLine($"Name of your weapon is {TestWeapon.Name}");
            
            //Console.WriteLine("Set minimum damage");
            //int inputMinDamage = int.Parse(Console.ReadLine());
            //Console.WriteLine("Set maximum damage");
            //int inputMaxDamage = int.Parse(Console.ReadLine());
            
            //TestWeapon.SetDamageParams(inputMinDamage, inputMaxDamage);
            //Console.WriteLine($"Min damage: {TestWeapon.MinDamage}, max damage: {TestWeapon.MaxDamage}");

            //Console.WriteLine($"Weapon: {TestWeapon.Name}. Damage: {TestWeapon.GetDamage()}");
            ///////////////////////////////////////////////////////////////////////////////////
            
           // Interval object1 = new Interval(minValue, maxValue);
            Console.WriteLine("Set minimum boundary of the interval");
            int minValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your minimum boundary of the interval: {minValue}");
            Console.WriteLine();
            Console.WriteLine("Set maximum boundary of the interval");
            int maxValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Your maximum boundary of the interval: {maxValue}");
            Interval object1 = new Interval(minValue, maxValue);

            Console.WriteLine();
            Console.WriteLine($"Random number of min and max numbers: {object1.Get}");

            //var rand = new Random();
            //int num = rand.Next(object1.Min, object1.Max);
            //Console.WriteLine($"{num}");

            //for (int i = 0; i < 300; i++)
            //{
            //    Console.WriteLine($"Random number \t {object1.Get}");
            //}








            ///////////////////////////////////////////////////////////////////////////////
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