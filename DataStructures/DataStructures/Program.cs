using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            //myDictionary.Add(1, "One");
            //myDictionary.Add(2, "Two");

            //Hashtable myHashtable = new Hashtable(myDictionary);

            //string valueOfOne = (string)myHashtable[1];
            //Console.WriteLine($"Value of One = {valueOfOne}");

            //myHashtable.Remove(1);

            //myHashtable.ContainsValue("One");

            //foreach (DictionaryEntry value in myHashtable)
            //{
            //    Console.WriteLine($"Key: {value.Key}, value: {value.Value}");
            //}


            int[] nums = new int[4];
            nums[0] = 0;
            nums[1] = 1;
            nums[2] = 2;
            nums[3] = 3;
            checkDuplicates(nums);
        }
        public static bool checkDuplicates(int[] nums)
        {
            HashSet<int> sets = new HashSet<int>(nums.Length);
            foreach (int value in nums)
            {
                if (sets.Contains(value))
                {
                    return true;
                }
                sets.Add(value);
            }
            return false;
        }
    }
}