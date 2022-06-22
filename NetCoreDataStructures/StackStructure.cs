using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCoreDataStructures
{
    /// <summary>
    /// A Stack represents a last-in, first-out collection of objects.
    /// In a stack, you can store elements of the same type or different types. 
    /// When you add an item in the list, it is called pushing the element.
    /// When you remove it, it is called popping the element.
    /// The capacity of a Stack is the number of elements the Stack can hold. As elements are added to a Stack, the capacity is automatically increased as required through reallocation.
    /// In Stack, you are allowed to store duplicate elements.
    /// A Stack accepts null as a valid value for reference types.
    /// </summary>
    public class StackStructure
    {
        public void StackExamples()
        {

            BasicExample();
            PopClearExample();
            PopPeekExample();
        }

        private void BasicExample()
        {
            // Create a stack
            // Using Stack class
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("Geeks");
            my_stack.Push("geeksforgeeks");
            my_stack.Push('G');
            my_stack.Push(null);
            my_stack.Push(1234);
            my_stack.Push(490.98);

            // Accessing the elements
            // of my_stack Stack
            // Using foreach loop
            foreach (var elem in my_stack)
            {
                Console.WriteLine(elem);
            }
        }
        private void PopClearExample()
        {
            // Create a stack
            // Using Stack class
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("Geeks");
            my_stack.Push("geeksforgeeks");
            my_stack.Push("geeks23");
            my_stack.Push("GeeksforGeeks");

            Console.WriteLine("Total elements present in" + " my_stack: {0}", my_stack.Count);

            my_stack.Pop();

            // After Pop method
            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);


            // Remove all the elements
            // from the stack
            my_stack.Clear();

            // After Pop method
            Console.WriteLine("Total elements present in " + "my_stack: {0}", my_stack.Count);
        }

        private void PopPeekExample()
        {
            // Create a stack
            // Using Stack class
            Stack my_stack = new Stack();

            // Adding elements in the Stack
            // Using Push method
            my_stack.Push("Geeks");
            my_stack.Push("geeksforgeeks");
            my_stack.Push("geeks23");
            my_stack.Push("GeeksforGeeks");

            Console.WriteLine("Total elements present in" + " my_stack: {0}", my_stack.Count);

            // Obtain the topmost element
            // of my_stack Using Pop method
            Console.WriteLine("Topmost element of my_stack" + " is: {0}", my_stack.Pop());

            Console.WriteLine("Total elements present in" + " my_stack: {0}", my_stack.Count);

            // Obtain the topmost element
            // of my_stack Using Peek method
            Console.WriteLine("Topmost element of my_stack " + "is: {0}", my_stack.Peek());


            Console.WriteLine("Total elements present " + "in my_stack: {0}", my_stack.Count);
        }
    }
}
