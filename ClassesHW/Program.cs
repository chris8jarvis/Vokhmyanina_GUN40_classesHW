using System.Collections.Generic;

namespace ClassesHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1, 2 or 3 to check task 1, 2 or 3");
            int task = int.Parse(Console.ReadLine());

            switch (task)
            {
                case 1:
                    CheckFirstTask();
                    break;
                case 2:
                    CheckSecondTask(); 
                    break;
                case 3:
                    CheckThirdTask();
                    break;
            }

            //Console.WriteLine("Task 1");

            //var shoppingList = new List<string>() { "toilet paper", "bread", "milk" };
            //Console.WriteLine("Items in your basket:");
            //Console.WriteLine(string.Join(", ", shoppingList));
            ////for(int i = 0; i < shoppingList.Count; i++)
            ////{
            ////    Console.WriteLine(shoppingList[i]);
            ////}
            //Console.WriteLine();
            //Console.WriteLine("Add an item you need to buy in a shop");
            //string item = Console.ReadLine();
            //shoppingList.Add(item);
            //Console.WriteLine();
            //Console.WriteLine("Updated items in your basket: ");
            //Console.WriteLine(string.Join(", ", shoppingList));
            //Console.WriteLine();
            //Console.WriteLine("Add one more item you need to buy in a shop");
            //string item2 = Console.ReadLine();
            //int middleIndex = shoppingList.Count / 2;
            //shoppingList.Insert(middleIndex, item2);
            //Console.WriteLine();
            //Console.WriteLine("Updated items in your basket: ");
            //Console.WriteLine(string.Join(", ", shoppingList));

            //////////////////////////////////////////////////////////////////////
            //Console.WriteLine();
            //Console.WriteLine("Task 2");
            //Console.WriteLine("Input student name");
            //string studentName = Console.ReadLine();
            //int studentGrade = 0;
            //bool isValidInput = false;


            //while (!isValidInput)
            //{
            //    Console.Write("Input student grade: ");
            //    string input = Console.ReadLine();


            //    if (int.TryParse(input, out studentGrade))
            //    {
            //        if (studentGrade >= 2 && studentGrade <= 5)
            //        {

            //            isValidInput = true;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Grade must be from 2 to 5");
            //        }
            //    }
            //}
            //Console.WriteLine($"Student: {studentName}, Grade: {studentGrade}");

            //var studentsBook = new Dictionary<string, int>();
            //studentsBook.Add(studentName, studentGrade);

            //Console.WriteLine("Input student name to find grade:");
            //string searchName = Console.ReadLine();

            //if (studentsBook.ContainsKey(searchName))
            //{
            //    int foundGrade = studentsBook[searchName];
            //    Console.WriteLine($"Student {searchName} has grade {foundGrade}");
            //}
            //else
            //{
            //    Console.WriteLine($"Error: Student '{searchName}' does not exist in the list.");
            //}
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine();
            //Console.WriteLine("Task 3");

            //Console.WriteLine("Create a wish-list containing from 3 to 6 elements.");
            //string element1 = Console.ReadLine();
            //string element2 = Console.ReadLine();
            //string element3 = Console.ReadLine();
            //string element4 = Console.ReadLine();
            //string element5 = Console.ReadLine();
            //string element6 = Console.ReadLine();
            //Console.WriteLine();


            //LinkedList<string> wishlist = new LinkedList<string>(new[] { element1, element2, element3, element4, element5, element6 });

            //var currentNode = wishlist.First;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Next;
                
            //}
            //Console.WriteLine();

            //currentNode = wishlist.Last;
            //while (currentNode != null)
            //{
            //    Console.WriteLine(currentNode.Value);
            //    currentNode = currentNode.Previous;
            //}
        }

        private class ListTask
        {
            private List<string> _shoppingList;

            public void TaskLoop()
            {
                _shoppingList = new List<string>() { "toilet paper", "bread", "milk" };

                Console.WriteLine("Items in your basket:");
                Console.WriteLine(string.Join(", ", _shoppingList));
                Console.WriteLine();

                Console.WriteLine("Add an item you need to buy in a shop");
                string item = Console.ReadLine();
                _shoppingList.Add(item);
                Console.WriteLine();

                Console.WriteLine("Updated items in your basket: ");
                Console.WriteLine(string.Join(", ", _shoppingList));
                Console.WriteLine();

                Console.WriteLine("Add one more item you need to buy in a shop");
                string item2 = Console.ReadLine();
                int middleIndex = _shoppingList.Count / 2;
                _shoppingList.Insert(middleIndex, item2);
                Console.WriteLine();//?
                Console.WriteLine("Updated items in your basket: ");
                Console.WriteLine(string.Join(", ", _shoppingList));

            }
        }

        private class DictionaryTask
        {
            private Dictionary<string, int> _studentsBook;

            public void TaskLoop()
            {
                Console.WriteLine("Input student name");
                string studentName = Console.ReadLine();
                int studentGrade = 0;
                bool isValidInput = false;


                while (!isValidInput)
                {
                    Console.Write("Input student grade: ");
                    string input = Console.ReadLine();


                    if (int.TryParse(input, out studentGrade))
                    {
                        if (studentGrade >= 2 && studentGrade <= 5)
                        {

                            isValidInput = true;
                        }
                        else
                        {
                            Console.WriteLine("Grade must be from 2 to 5");
                        }
                    }
                }
                Console.WriteLine($"Student: {studentName}, Grade: {studentGrade}");

                _studentsBook = new Dictionary<string, int>();
                _studentsBook.Add(studentName, studentGrade);

                Console.WriteLine("Input student name to find grade:");
                string searchName = Console.ReadLine();

                if (_studentsBook.ContainsKey(searchName))
                {
                    int foundGrade = _studentsBook[searchName];
                    Console.WriteLine($"Student {searchName} has grade {foundGrade}");
                }
                else
                {
                    Console.WriteLine($"Error: Student '{searchName}' does not exist in the list.");
                }
            }
        }

        private class LinkedListTask
        {
            private LinkedList<string> _wishList;

            public void TaskLoop()
            {
                Console.WriteLine("Create a wish-list containing from 3 to 6 elements.");
                string element1 = Console.ReadLine();
                string element2 = Console.ReadLine();
                string element3 = Console.ReadLine();
                string element4 = Console.ReadLine();
                string element5 = Console.ReadLine();
                string element6 = Console.ReadLine();
                Console.WriteLine();


                _wishList = new LinkedList<string>(new[] { element1, element2, element3, element4, element5, element6 });

                var currentNode = _wishList.First;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Next;

                }
                Console.WriteLine();

                currentNode = _wishList.Last;
                while (currentNode != null)
                {
                    Console.WriteLine(currentNode.Value);
                    currentNode = currentNode.Previous;
                }
            }
        }
        private static void CheckFirstTask()
        {
            var listTask = new ListTask();
            listTask.TaskLoop();
        }
        private static void CheckSecondTask()
        {
            var dictionaryTask = new DictionaryTask();
            dictionaryTask.TaskLoop();
        }
        private static void CheckThirdTask()
        {
            var linkedListTask = new LinkedListTask();
            linkedListTask.TaskLoop();
        }
    }
}
