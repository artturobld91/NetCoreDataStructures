using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    /// <summary>
    /// A LinkedList is a linear data structure which stores element in the non-contiguous location. 
    /// The elements in a linked list are linked with each other using pointers. 
    /// Or in other words, LinkedList consists of nodes where each node contains a data field and a reference(link) to the next node in the list.
    /// It also supports enumerators.
    /// You can remove nodes and reinsert them, either in the same list or in another list, which results in no additional objects allocated on the heap.
    /// Every node in a LinkedList<T> object is of the type LinkedListNode<T>.
    /// It does not support chaining, splitting, cycles, or other features that can leave the list in an inconsistent state.
    /// If the LinkedList is empty, the First and Last properties contain null.
    /// The capacity of a LinkedList is the number of elements the LinkedList can hold.
    /// In LinkedList, it is allowed to store duplicate elements but of the same type.
    /// AddAfter: This method is used to add a new node or value after an existing node in the LinkedList.
    /// AddBefore: This method is used to add a new node or value before an existing node in the LinkedList.
    /// AddFirst: This method is used to add a new node or value at the start of the LinkedList.
    /// AddLast: This method is used to add a new node or value at the end of the LinkedList.
    /// </summary>
    public class LinkedListStructure
    {
        public void LinkedListExamples()
        { 
            
        }

        private void BasicExample()
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");

            Console.WriteLine("Best students of XYZ university:");

            // Accessing the elements of
            // LinkedList Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }
        }

        private void RemoveRemoveLastExample()
        {
            // Creating a linkedlist
            // Using LinkedList class
            LinkedList<String> my_list = new LinkedList<String>();

            // Adding elements in the LinkedList
            // Using AddLast() method
            my_list.AddLast("Zoya");
            my_list.AddLast("Shilpa");
            my_list.AddLast("Rohit");
            my_list.AddLast("Rohan");
            my_list.AddLast("Juhi");
            my_list.AddLast("Zoya");

            // Initial number of elements
            Console.WriteLine("Best students of XYZ " +
                             "university initially:");

            // Accessing the elements of
            // Linkedlist Using foreach loop
            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(LinkedListNode)
            // method
            Console.WriteLine("Best students of XYZ" +
                             " university in 2000:");

            my_list.Remove(my_list.First);

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Remove(T) method
            Console.WriteLine("Best students of XYZ" +
                             " university in 2001:");

            my_list.Remove("Rohit");

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using RemoveFirst() method
            Console.WriteLine("Best students of XYZ" +
                             " university in 2002:");

            my_list.RemoveFirst();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using RemoveLast() method
            Console.WriteLine("Best students of XYZ" +
                             " university in 2003:");

            my_list.RemoveLast();

            foreach (string str in my_list)
            {
                Console.WriteLine(str);
            }

            // After using Clear() method
            my_list.Clear();
            Console.WriteLine("Number of students: {0}",
                                         my_list.Count);
        }


    }
}
