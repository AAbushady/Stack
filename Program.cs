using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();
            var popCounter = 0;

            Console.WriteLine("Welcome to the stack! " +
                              "\nType in a value and press enter and it will be added to the stack!" +
                              "\nWhen you are done just type 'quit' and press enter.");

            while (true)
            {
                var input = Console.ReadLine();

                if (input.ToLower() == "quit")
                {
                    break;
                }

                popCounter++;
                stack.Push(input);
            }

            Console.WriteLine("\nHere are all of the values you typed in from Last to First!\n");

            while (popCounter != 0)
            {
                Console.WriteLine(stack.Pop());
                popCounter--;
            }

            stack.Push("Hello");
            stack.Push(123);
            stack.Push("World");

            stack.Clear();
        }
    }
}
