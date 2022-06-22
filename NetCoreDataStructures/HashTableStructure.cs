using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    /// <summary>
    /// A Hashtable is a collection of key/value pairs that are arranged based on the hash code of the key.
    /// In Hashtable, the key cannot be null, but value can be.
    /// In Hashtable, key objects must be immutable as long as they are used as keys in the Hashtable.
    /// The capacity of a Hashtable is the number of elements that Hashtable can hold.
    /// A hash function is provided by each key object in the Hashtable.
    /// The Hashtable class implements the IDictionary, ICollection, IEnumerable, ISerializable, IDeserializationCallback, and ICloneable interfaces.
    /// In hashtable, you can store elements of the same type and of the different types.
    /// The elements of hashtable that is a key/value pair are stored in DictionaryEntry, so you can also cast the key/value pairs to a DictionaryEntry.
    /// In Hashtable, key must be unique. Duplicate keys are not allowed.
    /// </summary>
    public class HashTableStructure
    {
        public void HashTableExamples()
        {
            // Create a hashtable
            // Using Hashtable class
            Hashtable my_hashtable1 = new Hashtable();

            // Adding key/value pair
            // in the hashtable
            // Using Add() method
            my_hashtable1.Add("A1", "Welcome");
            my_hashtable1.Add("A2", "to");
            my_hashtable1.Add("A3", "GeeksforGeeks");

            Console.WriteLine("Key and Value pairs from my_hashtable1:");

            foreach (DictionaryEntry ele1 in my_hashtable1)
            {
                Console.WriteLine("{0} and {1} ", ele1.Key, ele1.Value);
            }

            // Create another hashtable
            // Using Hashtable class
            // and adding key/value pairs
            // without using Add method
            Hashtable my_hashtable2 = new Hashtable() {
                                      {1, "hello"},
                                          {2, 234},
                                        {3, 230.45},
                                         {4, null}};

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele2 in my_hashtable2.Keys)
            {
                Console.WriteLine("{0}and {1}", ele2,
                                my_hashtable2[ele2]);
            }
        }
    }
}
