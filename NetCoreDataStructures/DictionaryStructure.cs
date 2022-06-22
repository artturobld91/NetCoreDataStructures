using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    /// <summary>
    /// Dictionary is a generic collection which is generally used to store key/value pairs.
    /// In Dictionary, the key cannot be null, but value can be.
    /// In Dictionary, key must be unique.Duplicate keys are not allowed if you try to use duplicate key then compiler will throw an exception.
    /// In Dictionary, you can only store same types of elements.
    /// The capacity of a Dictionary is the number of elements that Dictionary can hold.
    /// </summary>
    public class DictionaryStructure
    {
        public void DictionaryExamples()
        {
            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> My_dict1 = new Dictionary<int, string>();

            // Adding key/value pairs 
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "GeeksforGeeks");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}", ele1.Key, ele1.Value);
            }
            Console.WriteLine();

            // Creating another dictionary
            // using Dictionary<TKey,TValue> class
            // adding key/value pairs without
            // using Add method
            Dictionary<string, string> My_dict2 = new Dictionary<string, string>(){ {"a.1", "Dog"}, {"a.2", "Cat"}, {"a.3", "Pig"} };

            foreach (KeyValuePair<string, string> ele2 in My_dict2)
            {
                Console.WriteLine("{0} and {1}", ele2.Key, ele2.Value);
            }
        }
    }
}
