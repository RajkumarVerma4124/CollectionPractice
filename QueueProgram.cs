using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// Queue Generic Collection Demo
    /// </summary>
    public class QueueProgram
    {
        //Method to use generic queue methods
        public static void QueueDemo()
        {
            try
            {
                //Creating object of queue
                Queue<string> coloursQueue = new Queue<string>();

                //Adding the elements into the queue
                coloursQueue.Enqueue("Black");
                coloursQueue.Enqueue("Blue");
                coloursQueue.Enqueue("Red");
                Console.WriteLine("\nQueue elements are :");
                foreach (var c in coloursQueue)
                {
                    Console.WriteLine(c);
                }
                Console.WriteLine("\nTotal number of values in queue : " + coloursQueue.Count);
                string dequeue = coloursQueue.Dequeue();
                Console.WriteLine("\nDequeue element are :\n" + dequeue);
                Queue<string>.Enumerator enumerator = coloursQueue.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    Console.WriteLine(enumerator.Current);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
