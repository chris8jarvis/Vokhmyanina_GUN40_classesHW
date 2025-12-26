using System.Collections.Generic;
using System.Xml.Serialization;

namespace ClassesHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1, 2 or 3 to check task 1, 2 or 3");
            string input = Console.ReadLine();
            int.TryParse(input, out int task);

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
                default:
                    Console.WriteLine("Input is incorrect");
                    break;
            }
        }

        private class ListTask
        {
            private List<string> _shoppingList;

            public void TaskLoop()
            {
                _shoppingList = new List<string>() { "toilet paper", "bread", "milk" };

                Console.WriteLine("Items in your basket: ");
                Console.WriteLine(string.Join(", ", _shoppingList));
                Console.WriteLine();

                Console.Write("Add an item you need to buy in a shop: ");
                string inputItemToAddInEnd = Console.ReadLine();
                _shoppingList.Add(inputItemToAddInEnd);
                Console.WriteLine();

                Console.WriteLine("Updated items in your basket: ");
                Console.WriteLine(string.Join(", ", _shoppingList));
                Console.WriteLine();

                Console.Write("Add one more item you need to buy in a shop: ");
                string inputItemToAddInMiddle = Console.ReadLine();
                Console.WriteLine();

                int middleIndex = _shoppingList.Count / 2;
                _shoppingList.Insert(middleIndex, inputItemToAddInMiddle);
                Console.WriteLine("Updated items in your basket: ");
                Console.WriteLine(string.Join(", ", _shoppingList));

            }
        }

        private class DictionaryTask
        {
            private Dictionary<string, int> _studentsBook;
            public DictionaryTask()
            {
                _studentsBook = new Dictionary<string, int>();
            }

            public void TaskLoop()
            {
                int studentGrade = 2;
                int maxStudents = 30;
                int studentsCounter = 0;

                while (studentsCounter < maxStudents)
                {
                    Console.Write("Input student name (or 'exit' to finish): ");
                    string input = Console.ReadLine();
                    if (input == "exit")
                    {
                        break;
                    }
                    string inputStudentName = input;

                    bool isValidInput = false;
                    while (!isValidInput)
                    {
                        Console.Write("Input student grade: ");
                        string inputGrade = Console.ReadLine();


                        if (int.TryParse(inputGrade, out studentGrade))
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
                        else
                        {
                            Console.WriteLine("Incorrect input. Please write a number");
                        }
                    }

                    if (!_studentsBook.TryAdd(inputStudentName, studentGrade))
                    {
                        Console.WriteLine($"Student {inputStudentName} already exsist");
                        continue;
                    }
                    studentsCounter++;
                }

                Console.WriteLine();
                Console.Write("Input student name to find grade: ");
                string requiredName = Console.ReadLine(); // может Required?

                if (_studentsBook.ContainsKey(requiredName))
                {
                    int foundGrade = _studentsBook[requiredName];
                    Console.WriteLine($"Student {requiredName} has grade {foundGrade}");
                }
                else
                {
                    Console.WriteLine($"Error: Student '{requiredName}' does not exist in the list.");
                }
            }
        }
    
        private class LinkedListTask
        {
            private LinkedList<string> _wishList;

            public void TaskLoop()
            {

                Console.WriteLine("Create a wish-list containing from 3 to 6 elements.");

                _wishList = new LinkedList<string>();
                int maxWishes = 6;
                int minWishes = 3;

                while(_wishList.Count <= maxWishes)
                {
                    Console.Write("Add wish or 'exit' to finish: ");
                    string userInput = Console.ReadLine();

                    if (userInput == "exit")
                    {
                        if (_wishList.Count < minWishes)
                        {
                            Console.WriteLine($"You have to add at least {minWishes} wishes");
                            continue;
                        }
                        break;
                    }
                    
                    _wishList.AddLast(userInput);
                }

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
