

using System.Collections;
using System.Net;

class Collections
{
    static void basicsArray()
    {
        List<string> numbers = new List<string>(10);

        numbers.Add("Sarbajit");
        numbers.Add("Nandy");

        foreach(string name in numbers) {
            Console.WriteLine(name);
        }

        numbers.Where(p => p.StartsWith("S"))
        .ToList()
        .ForEach(p => Console.WriteLine(p));

        Console.WriteLine(numbers.Capacity);
    }
    static void learnHashtable()
    {
        Hashtable hashtable = new Hashtable();

        hashtable.Add("roll", "Sarbajit");
        hashtable.Add(2, "Nandy");

        foreach (DictionaryEntry entry in hashtable)
        {
            // print type of the key
            Console.WriteLine($"Key Type: {entry.Key.GetType()}");
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }

        foreach(string value in hashtable.Values)
        {
            Console.WriteLine(value);
        }
         foreach(string key in hashtable.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine(hashtable.ContainsKey("roll"));
        Console.WriteLine(hashtable.ContainsKey("rolls"));
        Console.WriteLine(hashtable.ContainsValue("Sarbajit"));
        Console.WriteLine(hashtable.ContainsValue("Sarbajitt"));
    }
    static void learnDictionary()
    {
        Dictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(1, "Sarbajit");
        dictionary.Add(2, "Shalmoli");

        if (dictionary.TryAdd(2, "Nandy")) { // will not add as key 2 already exists
            Console.WriteLine("Added successfully");
        } else {
            Console.WriteLine("Key already exists");
        }

        foreach (KeyValuePair<int, string> entry in dictionary)
        {
            Console.WriteLine($"{entry.Key} : {entry.Value}");
        }

        foreach(string value in dictionary.Values)
        {
            Console.WriteLine(value);
        }
         foreach(int key in dictionary.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine(dictionary.ContainsKey(1));
        Console.WriteLine(dictionary.ContainsKey(3));
        Console.WriteLine(dictionary.ContainsValue("Sarbajit"));
        Console.WriteLine(dictionary.ContainsValue("Sarbajitt"));

        dictionary[1] = "Nandy"; // update value for key 1

        // other way to initialize a dictionary
        var dick2 = new Dictionary<int, string>()
        {
            { 1, "One" },
            { 2, "Two" },
            { 3, "Three" }
        };

        if (dick2.TryGetValue(2, out string state))
        {
            Console.WriteLine($"Value for key 2 is {state}");
        } else {
            Console.WriteLine("Key not found");
        }
    }
    
    
    
    
    static void Main(string[] args)
    {
        // basicsArray();

        // learnHashtable();
        learnDictionary();

        // PrintDictionaryValues();
    }
}


