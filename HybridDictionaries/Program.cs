using System;
using System.Collections;
using System.Collections.Specialized;

namespace HybridDictionaries
{
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
            Console.WriteLine($"Contins \"item1\": {myHbd.Contains("item1")}");

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
