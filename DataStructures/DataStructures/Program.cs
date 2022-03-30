using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "One");
            myDictionary.Add(2, "Two");

            Hashtable myHashtable = new Hashtable(myDictionary);

            string valueOfOne = (string)myHashtable[1];
            Console.WriteLine($"Value of One = {valueOfOne}");

            myHashtable.Remove(1);

            myHashtable.ContainsValue("One");

            foreach (DictionaryEntry value in myHashtable)
            {
                Console.WriteLine($"Key: {value.Key}, value: {value.Value}");
            }
        }
    }
}