using System;
using System.Collections.Generic;

namespace Lists
{
    /// <summary>
    /// List represents a strongly typed list of objects that can be accessed by
    /// index. It provides methods to search, sort, and manipulate lists.
    /// </summary>

    static class Program
    {
        private static void Main(string[] args)
        {
            // BASIC OPERATIONS
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


            // SEARCHING LIST CONTENT
            // Determine if a list contains a given item.
            Console.WriteLine($"Is Found by `Contains`: {strList.Contains("Ron Gallagher")}");

            // Determine if a list contains any items that conform to a given condition.
            var found = strList.Exists(x => x.Length > 15);
            Console.WriteLine($"Is Found by `Exists`: {found}");

            // Return the first item (if any) in a list that conforms to a given condition.
            var item = "";
            item = strList.Find(x => x.StartsWith('L'));
            Console.WriteLine($"Item Returned by `Found`: {item}");

            // Return all items (if any) in a list that conform to a given condition.
            var itemList = new List<string>();
            itemList = strList.FindAll(x => x.StartsWith('L'));
            PrintList(itemList);

            // Determine whether all items in a list conform to a given condition.
            bool result = strList.TrueForAll(x => x.Length > 10);
            Console.WriteLine($"All True: {result}");
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
