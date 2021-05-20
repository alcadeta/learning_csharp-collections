using System;
using System.Collections.Generic;

namespace Stacks {
    /// <summary>
    /// Stack is a data structure that stores elements in a way that's similar
    /// to an array except the items are added, or "pushed", on the top and then
    /// when you want to remove them, you "pop" them off the top.
    /// </summary>

    class Program {
        static void Main(string[] args) {
            // Create an empty stack.
            var myStack = new Stack<string>();

            // Push new elements onto a stack.
            myStack.Push("one");
            myStack.Push("two");
            myStack.Push("three");
            myStack.Push("four");
            myStack.Push("five");

            Print(myStack);

            // Determine how many elements are in a stack.
            Console.WriteLine($"Count: {myStack.Count}\n");

            // Examine the current top element but don't remove it
            var top = myStack.Peek();
            Console.WriteLine(top + "\n");

            // Pop an element from the top
            var item = myStack.Pop();
            Console.WriteLine(item + "\n");

            // Determine how many elements are in a stack.
            Console.WriteLine($"Count: {myStack.Count}\n");

            // Determine whether a given stack contains a certain value.
            Console.WriteLine($"Item Found: {myStack.Contains("five")}");
            Console.WriteLine($"Item Found: {myStack.Contains("four")}\n");
        }

        static void Print(Stack<string> stack)
        {
            foreach (var item in stack)
                Console.WriteLine(item);
            Console.WriteLine();
        }
    }
}