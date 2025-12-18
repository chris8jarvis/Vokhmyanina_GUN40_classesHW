namespace ClassesHW
{
    internal class Collections
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine();

            var shoppingList = new List<string>() {"toilet paper", "bread", "milk" };
            Console.WriteLine("Items in your basket:");
            Console.WriteLine(string.Join(", ", shoppingList));
            //for(int i = 0; i < shoppingList.Count; i++)
            //{
            //    Console.WriteLine(shoppingList[i]);
            //}
            Console.WriteLine();
            Console.WriteLine("Add an item you need to buy in a shop");
            string item = Console.ReadLine();
            shoppingList.Add(item);
            Console.WriteLine();
            Console.WriteLine("Updated items in your basket: ");
            Console.WriteLine(string.Join(", ", shoppingList));
            Console.WriteLine();
            Console.WriteLine("Add one more item you need to buy in a shop");
            string item2 = Console.ReadLine();
            int middleIndex = shoppingList.Count / 2;
            shoppingList.Insert(middleIndex, item2);
            Console.WriteLine();
            Console.WriteLine("Updated items in your basket: ");
            Console.WriteLine(string.Join(", ", shoppingList));
        } 
    } 
}