using System;
using System.Collections;
using System.Collections.Specialized;

namespace OrderedDictionaries
{
    /// <summary>
    /// OrderedDictionary is a collection of key-value pairs where the items
    /// added to it are maintained in the order that they were added.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new OrderedDictionary.
            var mod = new OrderedDictionary();

            // Add some key-value pairs in a particular order.
            mod.Add("item1", "value1");
            mod.Add("item2", "value2");
            mod.Add("item3", "value3");
            mod.Add("item4", "value4");

            // Print the contents of the dictionary.
            PrintDictionary(mod);

            // Remove an existing item and add a new one.
            mod.Remove("item3");
            mod.Add("item5", "value5");

            // Modify the value of an item in the dict.
            mod["item2"] = "new value2";

            // Add another item
            mod.Add("item6", "value6");

            PrintDictionary(mod);
        }

        static void PrintDictionary(OrderedDictionary dict)
        {
            foreach (DictionaryEntry entry in dict)
                Console.WriteLine($"Key = {entry.Key}, Value = {entry.Value}");

            Console.WriteLine("-----------------------");
        }
    }
}