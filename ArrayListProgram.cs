using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// ArrayList Program Demo
    /// </summary>
    public class ArrayListProgram
    {
        //Method to use Arraylist collection methods
        public static void ArrayListDemo()
        {
            try
            {
                //Creating object array
                object[] sampleArr = new object[] { "Raj", 1, 4.5, 7.2, "Verma" };

                // adding elements using object initializer syntax
                var list = new ArrayList() { 2, "Steve", "", true, 4.5, null };
                var arlist2 = new ArrayList() { 1, "Bill", " ", false, 4.5, null };

                //Adding elements using ArrayList.Add() method
                list.Add("Ajay");
                list.Add(50);
                list.Add(6.5);
                list.Add(77.49f);
                list.Add("Matakar");

                //Adding elements from object array
                list.AddRange(sampleArr);

                //Adding the non-primitive type or reference type colletion
                list.AddRange(list);
                Console.WriteLine("Number Of Elements In ArrayList", list.Count);

                //Declaring int array
                int[] arr = { 100, 200, 300, 400 };

                //Creating object for queue
                Queue myQ = new Queue();
                myQ.Enqueue("Hello");
                myQ.Enqueue("World!");
                list.AddRange(arlist2); //adding arraylist in arraylist 
                list.AddRange(arr); //adding array in arraylist 
                list.AddRange(myQ); //adding Queue in arraylist 
                ArrayList lisOne = new ArrayList(list);
                foreach (var i in lisOne)
                {
                    Console.WriteLine("The Array List Included : " + i);
                }
                Console.WriteLine();
                Console.WriteLine("Before trimming the capacity of arraylist : " + list.Capacity);
                list.TrimToSize();
                Console.WriteLine("After trimming the capacity of arraylist : " + list.Capacity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
