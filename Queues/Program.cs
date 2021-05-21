using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a queue.
            var myQ = new Queue<string>();

            // Add items to the end of a queue.
            myQ.Enqueue("one");
            myQ.Enqueue("two");
            myQ.Enqueue("three");
            myQ.Enqueue("four");
            myQ.Enqueue("five");

            // Iterate over a queue.
            foreach (var item in myQ)
                Console.WriteLine(item);
            Console.WriteLine();

            // Determine how many items are in a queue.
            Console.WriteLine($"Count: {myQ.Count}\n");

            // Peek at the front of a queue.
            var str = myQ.Peek();
            Console.WriteLine($"Peeked {str}\n");

            // Remove an item from the front of a queue.
            str = myQ.Dequeue();
            Console.WriteLine($"Dequeued {str}\n");
            str = myQ.Dequeue();
            Console.WriteLine($"Dequeued {str}\n");

            // Determine whether a queue contains a given value.
            Console.WriteLine($"Queue contains \"one\": {myQ.Contains("one")}");
            Console.WriteLine($"Queue contains \"four\": {myQ.Contains("four")}\n");

            // Remove all items from a queue.
            myQ.Clear();
            Console.WriteLine($"Count: {myQ.Count}");
        }
    }
}