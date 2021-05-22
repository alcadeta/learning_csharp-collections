using System;
using System.Collections;
using System.Collections.Specialized;

namespace HybridDictionaries
{
    /// <summary>
    /// ListDictionary is a collection that implements a dictionary using a
    /// LinkedList. It's faster than a regular dictionary for small collections
    /// (10- members).
    ///
    /// HybridDictionary is a collection that starts out as a ListDictionary but
    /// then morphs into a regular dictionary when the numbers of elements gets
    /// larger.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Create a HybricDictionary.
            var myHbd = new HybridDictionary(20);

            // Add items to a HybridDictionary.
            myHbd.Add("item1", "value1");
            myHbd.Add("item2", "value2");
            myHbd.Add("item3", "value3");
            myHbd.Add("item4", "value4");

            // Determine the number of items in a HybridDictionary.
            Console.WriteLine($"Number of items: {myHbd.Count}");

            // Determine whether a value is in a HybridDictionary.
            Console.WriteLine($"Contains \"item1\": {myHbd.Contains("item1")}");

            // Remove an item from a HybridDictionary.
            myHbd.Remove("item3");

            // Iterate over a HybridDictionary.
            foreach (DictionaryEntry de in myHbd) 
                Console.WriteLine($"{de.Key}, {de.Value}");

            // Remove all items form a HybridDictionary.
            myHbd.Clear();
            Console.WriteLine($"Number of items: {myHbd.Count}");
        }
    }
}
