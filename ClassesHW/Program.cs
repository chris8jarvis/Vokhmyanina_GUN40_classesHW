namespace ClassesHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your Unit name");
            //string UserInputName = Console.ReadLine();
            //Unit TestUnit = new Unit(UserInputName);
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
            //}
            //else
            //{
            //    Console.WriteLine("Your Unit survived");
            //    Console.WriteLine($"New Real Health: {TestUnit.GetRealHealth()}");
            //}
            //////////////////////////////////////////////////////

            
            Dungeon test = new Dungeon();
            test.ShowRooms();

        }
    }
}