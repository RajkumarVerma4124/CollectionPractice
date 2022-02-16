using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPractice
{
    /// <summary>
    /// Generic List Program Demo
    /// </summary>
    public class ListProgram
    {
        //Method to use generic list collection methods
        public static void ListDemo()
        {
            try
            {
                //Creating the primitive type or value type collection
                var cities = new List<string>();
                var studentList = new List<StudentProgram>();
                var studentNewList = new List<StudentProgram>();

                //Adding the non-primitive type or reference type colletion
                studentList.Add(new StudentProgram() { Name = "Raj", Age = 23, Id = 1 });
                studentList.Add(new StudentProgram() { Name = "Yash", Age = 24, Id = 2 });
                studentList.Add(new StudentProgram() { Name = "Ajay", Age = 22, Id = 3 });
                studentNewList.Add(new StudentProgram() { Name = "Omkar", Age = 20, Id = 1 });
                studentNewList.Add(new StudentProgram() { Name = "Mansi", Age = 21, Id = 2 });
                studentNewList.Add(new StudentProgram() { Name = "Aman", Age = 18, Id = 3 });
                studentList.AddRange(studentNewList);

                Console.WriteLine("Student Details Are Listed Below");
                foreach (StudentProgram student in studentList)
                {
                    Console.WriteLine(student);
                }

                //Array for adding in list
                string[] popularCities = new string[3] { "NewYork", " Canada", "Italy" };

                //Addding cities to new list
                cities.Add("New York");
                cities.Add("Newzland");
                cities.Add("Paris");
                cities.Add("San fransico");

                //list is accessed
                Console.WriteLine("\nCities lists are :\n");
                foreach (var city in cities)
                {
                    Console.WriteLine("The cities are : {0} ", city);
                }

                //AddRange for adding range of elements
                cities.AddRange(new string[3] { "London", " Germany", "France" });
                cities.AddRange(popularCities);
                Console.WriteLine("\nAfter adding more cities list are :\n ");
                foreach (var city in cities)
                {
                    Console.WriteLine("The cities are : {0} ", city);
                }

                Console.WriteLine("The Capacity Of Cities List : " + cities.Capacity);
                Console.WriteLine("The Capacity Of Student List : " + studentList.Capacity);
                Console.WriteLine("The Capacity Of New Student List : " + studentNewList.Capacity);
                cities.TrimExcess();
                studentNewList.TrimExcess();
                studentList.TrimExcess();
                Console.WriteLine("The Capacity Of Cities List After Trimming : " + cities.Capacity);
                Console.WriteLine("The Capacity Of Student List After Trimming : " + studentList.Capacity);
                Console.WriteLine("The Capacity Of New Student List After Trimming : " + studentNewList.Capacity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
