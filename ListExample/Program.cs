using System;
using System.Collections.Generic;

namespace ListExample
{
    static class Program
    {
        private static void Main(string[] args)
        {
            // BASIC LIST OPERATIONS
            // Define some strings to add to the list.
            string[] comedians =
            {
                "Leo Gallagher", "Rodney Dangerfield", "George Carlin",
                "Lenny Bruce", "Eddie Murphy", "Louie Anderson"
            };

            // Create a list.
            var strList = new List<string>(10);

            // Add some existing elements to the list from an existing array.
            strList.AddRange(comedians);

            // Add a single item to the list.
            strList.Add("Tina Fey");
            strList.Add("Amy Poehler");

            // Examine the count and capacity.
            Console.WriteLine ($"Count/Capacity: {strList.Count}/{strList.Capacity}");
            PrintList(strList);

            // Access an item by an index.
            Console.WriteLine($"Fourth Item: {strList[4]}");

            // Remove items from the list.
            strList.RemoveAt(2);
            strList.Remove("Tina Fey");

            // Sort the list content.
            strList.Sort();
            PrintList(strList);
        }

        private static void PrintList(IEnumerable<string> list)
        {
            // Enumerate the items in the list with a foreach loop.
            foreach (var str in list)
            {
                Console.WriteLine(str);
            }
        }
    }
}
