using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    /// <summary>
    /// A Queue is used to represent a first-in, first out(FIFO) collection of objects.
    /// When you add an item in the list, it is called enqueue.
    /// when you remove an item, it is called dequeue.
    /// Queue accepts null as a valid value for reference types.
    /// As elements are added to a Queue, the capacity is automatically increased as required by reallocating the internal array.
    /// In Queue, you are allowed to store duplicate elements.
    /// The capacity of a Queue is the number of elements the Queue can hold.
    /// </summary>
    public class QueueStructure
    {
        public void QueueExamples()
        {
            BasicExample();
            EnqueueDequeueExample();
            PeekDequeueExample();
        }

        private void BasicExample()
        {
            // Create a queue
            // Using Queue class
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(null);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Geeks123");

            // Accessing the elements
            // of my_queue Queue
            // Using foreach loop
            foreach (var ele in my_queue)
            {
                Console.WriteLine(ele);
            }
        }

        private void EnqueueDequeueExample()
        {
            // Create a queue
            // Using Queue class
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue("GFG");
            my_queue.Enqueue(1);
            my_queue.Enqueue(100);
            my_queue.Enqueue(2.4);
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
            my_queue.Dequeue();

            // After Dequeue method
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Remove all the elements from the queue
            my_queue.Clear();

            // After Clear method
            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
        }

        private void PeekDequeueExample()
        {
            // Create a queue
            // Using Queue class
            Queue my_queue = new Queue();

            // Adding elements in Queue
            // Using Enqueue() method
            my_queue.Enqueue("GFG");
            my_queue.Enqueue("Geeks");
            my_queue.Enqueue("GeeksforGeeks");
            my_queue.Enqueue("geeks");
            my_queue.Enqueue("Geeks123");

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue
            // Using Dequeue method
            Console.WriteLine("Topmost element of my_queue"
                         + " is: {0}", my_queue.Dequeue());


            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);

            // Obtain the topmost element of my_queue
            // Using Peek method
            Console.WriteLine("Topmost element of my_queue is: {0}",
                                                   my_queue.Peek());

            Console.WriteLine("Total elements present in my_queue: {0}",
                                                        my_queue.Count);
        }
    }
}
