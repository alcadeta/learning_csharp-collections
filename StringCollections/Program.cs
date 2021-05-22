using System;
using System.Collections.Specialized;

namespace StringCollections
{
    /// <summary>
    /// StringCollection is a collection that is used to manipulate groups of
    /// string objects.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            // Define an initial set of strings.
            string[] colors =
            {
                "red", "orange", "yellow", "green", "blue", "indigo", "purple"
            };

            // Create the StringCollection.
            var strColl = new StringCollection();
            strColl.AddRange(colors);

            // Add a new string.
            strColl.Add("white");

            // Add a new string at a specific position.
            strColl.Insert(0, "black");

            // Determine the number of items.
            Console.WriteLine($"Number of items: {strColl.Count}\n");

            // Iterate over each string in the collection.
            foreach (var str in strColl)
                Console.WriteLine(str);
            Console.WriteLine();

            // Access an individual item.
            Console.WriteLine($"The item at 3 is {strColl[3]}");

            // Determine whether a string exists in the collection.
            Console.WriteLine($"Contains \"blue\": {strColl.Contains("blue")}");

            // Determine the index of a specific string in the collection.
            Console.Write($"\"green\" is at {strColl.IndexOf("green")}");

            // Empty out the StringCollection instance.
            strColl.Clear();
            Console.WriteLine($"Number of items: {strColl.Count}\n");

        }
    }
}