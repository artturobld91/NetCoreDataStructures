using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    /// <summary>
    /// HashSet is an unordered collection of unique elements.
    /// The HashSet class implements the ICollection, IEnumerable, IReadOnlyCollection, ISet, IEnumerable, IDeserializationCallback, and ISerializable interfaces.
    /// In HashSet, the order of the element is not defined.You cannot sort the elements of HashSet.
    /// In HashSet, the elements must be unique.
    /// In HashSet, duplicate elements are not allowed.
    /// Is provides many mathematical set operations, such as intersection, union, and difference.
    /// The capacity of a HashSet is the number of elements it can hold.
    /// A HashSet is a dynamic collection means the size of the HashSet is automatically increased when the new elements are added.
    /// In HashSet, you can only store the same type of elements.
    /// </summary>
    public class HashSetStructure
    {
        public void HashSetExample()
        {
            // Creating HashSet
            // Using HashSet class
            HashSet<string> myhash1 = new HashSet<string>();

            // Add the elements in HashSet
            // Using Add method
            myhash1.Add("C");
            myhash1.Add("C++");
            myhash1.Add("C#");
            myhash1.Add("Java");
            myhash1.Add("Ruby");
            Console.WriteLine("Elements of myhash1:");

            // Accessing elements of HashSet
            // Using foreach loop
            foreach (var val in myhash1)
            {
                Console.WriteLine(val);
            }

            // Creating another HashSet
            // using collection initializer
            // to initialize HashSet
            HashSet<int> myhash2 = new HashSet<int>() {10,10,
                               100,1000,10000,100000};

            // Display elements of myhash2
            Console.WriteLine("Elements of myhash2:");
            foreach (var value in myhash2)
            {
                Console.WriteLine(value);
            }
        }
    }
}
