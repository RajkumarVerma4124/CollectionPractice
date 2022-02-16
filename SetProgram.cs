using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// Generic HashSet Program Demo
    /// </summary>
    public class SetProgram
    {
        //Method to use generic hashset methods
        public static void SetDemo()
        {
            try 
            {
                //Creating the Hashset object
                HashSet<string> hash = new HashSet<string>();

                //Adding the elements in HashSet using add method
                hash.Add("C#");
                hash.Add("Java");
                hash.Add("Ruby");
                hash.Add("Python");
                hash.Add("Python");
                hash.Add("C++");
                hash.Add("C++");
                hash.Add("C++");
                hash.Add("C");
                Console.WriteLine("\nAdding elements to first hashset : ");
                foreach (var element in hash)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
                HashSet<string> newHash = new HashSet<string>();

                //Adding the elements in HashSet using add method
                newHash.Add("PHP");
                newHash.Add("C++");
                newHash.Add("Perl");
                newHash.Add("Perl");
                newHash.Add("Java");
                Console.WriteLine("\nAdding elements to second hashset : ");
                foreach (var element in newHash)
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();

                //Using UnionWith method to combine both hasSet
                Console.WriteLine("\nAfter combining both hashsets : ");
                hash.UnionWith(newHash);
                foreach (var element in hash)
                {
                    Console.Write(element + " ");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
