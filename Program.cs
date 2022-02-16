using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    public class Program
    {
        /// <summary>
        /// Main program for calling the methods of collection demo
        /// </summary>
        public static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Welcome to Collection Demo Program");
                    Console.WriteLine("1: List \n2: Stack \n3: Queue \n4: Set \n5: Dictionary \n6: ArrayList \n7: SortedList");
                    Console.Write("Enter a choice from above : ");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            //Calling the ListDemo method
                            ListProgram.ListDemo();
                            break;
                        case 2:
                            //Calling the StackDemo method
                            StackProgram.StackDemo();
                            break;
                        case 3:
                            //Calling the QueueDemo method
                            QueueProgram.QueueDemo();
                            break;
                        case 4:
                            //Calling the SetDemo method
                            SetProgram.SetDemo();
                            break;
                        case 5:
                            //Calling the DictionaryDemo method
                            DictionaryProgram.DictionaryDemo();
                            break;
                        case 6:
                            //Calling the ArrayListDemo method
                            ArrayListProgram.ArrayListDemo();
                            break;
                        case 7:
                            //Calling the SortedListDemo method
                            SortedListProgram.SortedListDemo();
                            break;
                        default:
                            Console.WriteLine("Wrong choice");
                            continue;
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
