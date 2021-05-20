using System.Collections.Generic;
using System.Linq.Expressions;
using System;
using System.Collections;
using System.Linq;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define some strings that represent song names.
            string[] strArr =
            {
                "Shout", "Satisfaction", "Help!", "Stairway to Heaven",
                "Come Sail Away", "All Night Long", "Right Here Right Now"
            };

            // Create a LinkedList that holds strings.
            LinkedList<string> songs = new LinkedList<string>(strArr);

            // The items can be added at the front or the back of a LinkedList
            songs.AddFirst("Africa");
            songs.AddLast("Twist and Shout");

            PrintList(songs);

            // `First` and `Last` properties return `LinkedListNode`s
            var first = songs.First;
            var last = songs.Last;

            Console.WriteLine($"First value: {first.Value}");
            Console.WriteLine($"Last value: {last.Value}");
            Console.WriteLine();

            // Items can be added or removed relative to an existing item
            songs.AddAfter(first, "Here Comes the Sun");
            PrintList(songs);

            // Determine whether a LinkedList contains a given value
            Console.WriteLine(songs.Contains("Here Comes the Sun"));

            // Return the first element in a LinkedList that has the given value
            Console.WriteLine(songs.Find("Help!")?.Value);

            // Traverse the LinkedList
            Console.WriteLine(first.Next?.Value);
            Console.WriteLine(last.Previous?.Value);
        }

        static void PrintList(IEnumerable<string> collection)
        {
            foreach (var item in collection)
                Console.WriteLine(item);

            Console.WriteLine();
        }
    }
}