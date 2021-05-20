using System;
using System.Collections.Generic;

namespace Dictionaries
{
    /// <summary>
    /// Dictionaries map keys to values. Keys must be unique.
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            var fileTypes = new Dictionary<string, string>();

            // Add some key-value pairs to the dictionary.
            fileTypes.Add(".bmp", "Bitmap File");
            fileTypes.Add(".txt", "Text File");
            fileTypes.Add(".html", "HTML Document");
            fileTypes.Add(".jpg", "JPEG Image");

            // Use the `Count` property to see how many items there are
            Console.WriteLine($"File types count: {fileTypes.Count}.\n");

            // Trying to add an existing key will throw an exception.
            // fileTypes.Add(".txt", "Text File");

            // The `TryAdd` method makes it convenient to see if there are any duplicates
            var res = fileTypes.TryAdd(".txt", "Text File");
            Console.WriteLine($"Value was added: {res}.\n");

            // Dictionaries are like associative arrays
            Console.WriteLine($".txt Value: {fileTypes[".txt"]}.\n");

            // Use a pre-existing key to overwrite its value
            Console.WriteLine($".html Value: {fileTypes[".html"]}.\n");
            fileTypes[".html"] = "Web Page";
            Console.WriteLine($".html Value: {fileTypes[".html"]}.\n");

            // Determine whether a dictionary contains a key or a value
            Console.WriteLine("Contains key \".bmp\": " +
                              fileTypes.ContainsKey(".bmp"));
            Console.WriteLine("Contains value \"HTML Document\": " +
                              fileTypes.ContainsValue("HTML Document"));

            // Remove an item from a dictionary
            fileTypes.Remove(".bmp");
            Console.WriteLine("Contains key \".bmp\": " +
                              fileTypes.ContainsKey(".bmp"));
        }
    }
}