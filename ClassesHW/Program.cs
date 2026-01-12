using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Text;

namespace ClassesHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 task concatenation.");
            Console.WriteLine();
            Console.WriteLine("Write first word");
            string input1 = Console.ReadLine();
            Console.WriteLine("Write second word");
            string input2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Result of concatenation:");
            ConcatenateStrings(input1, input2);

            Console.WriteLine();
            Console.WriteLine("2 task greeting.");
            Console.WriteLine();
            Console.WriteLine("Write name:");
            string name = Console.ReadLine();
            Console.WriteLine("Write age");
            int age = int.Parse(Console.ReadLine()); //tryparse как из последней работы
            GreetUser(name, age);

            Console.WriteLine();
            Console.WriteLine("3 task string info.");
            Console.WriteLine();
            Console.WriteLine("Write a word:");
            string input = Console.ReadLine();
            Console.WriteLine(StringInformation(input));

            Console.WriteLine();
            Console.WriteLine("4 task first five symbols of a string.");
            Console.WriteLine();
            Console.WriteLine("Write a word:");
            string symbols = Console.ReadLine();
            Console.WriteLine(FirstFiveSymbols(symbols));

            Console.WriteLine();
            Console.WriteLine("5 task.");
            string[] strings = new string[] { "test", "task5" };
            StringBuilder test = MakeSentence(strings);
            Console.WriteLine(test.ToString());

            Console.WriteLine();
            Console.WriteLine("6 task.");
            string result = ReplaceWords("Hello world", "world", "universe");
            Console.WriteLine(result);
        }

        static string ConcatenateStrings(string input1, string input2)
        {
            string concat = string.Concat(input1, input2);
            Console.WriteLine(concat);
            return concat;
            //var builder = new StringBuilder();
            //builder.Append(input1);
            //builder.Append(input2);
            //Console.WriteLine(builder.ToString());
        }

        static string GreetUser(string name, int age)
        {
            string message = $"Hello, {name}!\nYou are {age} years old.";
            Console.WriteLine(message);
            return message;
        }

        static string StringInformation(string input)
        {
            return $"Word length is {input.Length}, upper case is {input.ToUpper()}, lower case is {input.ToLower()}";

            //Console.WriteLine(input.Length);
            //Console.WriteLine(input.ToUpper());
            //Console.WriteLine(input.ToLower());
        }

        static string FirstFiveSymbols(string symbols)
        {
            var firstFiveSymbols = symbols.Substring(0, 5);
            return firstFiveSymbols;
        }

        static StringBuilder MakeSentence(string[] strings)
        {
            var builder = new StringBuilder();

            foreach (var s in strings)
            {
                builder.Append(s + " ");
                
            }   
            return builder;
        }

        static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)// => inputString.Replace(wordToReplace, replacementWord);
        {
            return inputString.Replace(wordToReplace, replacementWord);
        }

    }
}