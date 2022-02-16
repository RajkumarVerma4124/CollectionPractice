using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// Generic Stack Demo Program
    /// </summary>
    public class StackProgram
    {
        //Method to use generic stack collection methods
        public static void StackDemo()
        {
            try
            {
                //Creating stack object
                Stack<StudentProgram> myStack = new Stack<StudentProgram>();

                //Pushing data into stack
                myStack.Push(new StudentProgram() { Name = "Raj", Age = 23, Id = 1 });
                myStack.Push(new StudentProgram() { Name = "Yash", Age = 24, Id = 2 });
                myStack.Push(new StudentProgram() { Name = "Ajay", Age = 22, Id = 3 });
                myStack.Push(new StudentProgram() { Name = "Omkar", Age = 20, Id = 1 });

                //Counting number of elements present in stack
                Console.Write("\nNumber of elements in Stack: {0} \n", myStack.Count);
                while (myStack.Count > 0)
                {
                    //Pop the element and print it
                    Console.WriteLine(myStack.Pop() + " ");
                }

                //Counting number of elements present in stack after popping
                Console.Write("\nNumber of elements in Stack after popping: {0}\n", myStack.Count);
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }           
        }
    }
}
