using System;

namespace Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            AnagramApp anagram = new AnagramApp();
            Console.WriteLine("Hi! Welcome to program <Anagram>");
            Console.Write("Enter your string: ");
            string inputString = Console.ReadLine();
            
            while (anagram.Reverse(inputString) == "String is null" || anagram.Reverse(inputString) == "String is empty")
            {
                Console.Write("Enter not empty string: ");
                inputString = Console.ReadLine();                 
            }

            Console.WriteLine("Result of Program <Anagram>: " + anagram.Reverse(inputString));
            Console.ReadLine();
        }
    }
}
