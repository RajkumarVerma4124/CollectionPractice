using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// Dictionary Demo Program
    /// </summary>
    public class DictionaryProgram
    {
        public static void DictionaryDemo()
        {
            try
            {
                IDictionary<int, string> numberNames = new Dictionary<int, string>();
                numberNames.Add(1, "One"); //adding a key/value using the Add() method
                numberNames.Add(2, "Two");
                numberNames.Add(3, "Three");

                //The following throws run-time exception: key already added.
                numberNames.Add(4, "Three");
                numberNames.Add(5, "Three");
                numberNames.Add(7, "Three");
                numberNames.Add(10, "Three");
                numberNames.Add(12, "Three");
                //creating a dictionary using collection-initializer syntax
                var cities = new Dictionary<string, string>(){
                        {"UK", "London, Manchester, Birmingham"},
                        {"USA", "Chicago, New York, Washington"},
                        {"India", "Mumbai, New Delhi, Pune"}
                    };
                Console.WriteLine("Fetching value : " + numberNames[12]);
                Console.WriteLine("Displaying cities");
                foreach (var city in cities)
                    Console.WriteLine("Key: {0}, Value: {1}", city.Key, city.Value);
                Console.WriteLine("Diplaying both key and values");
                foreach (var numName in numberNames)
                    Console.WriteLine("Key: {0}, Value: {1}", numName.Key, numName.Value);
                Console.WriteLine("Displaying keys");
                foreach (var key in numberNames.Keys)
                    Console.WriteLine("Key: {0}", key);
                Console.WriteLine("Displaying values");
                foreach (var value in numberNames.Values)
                    Console.WriteLine("Key: {0}", value);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
