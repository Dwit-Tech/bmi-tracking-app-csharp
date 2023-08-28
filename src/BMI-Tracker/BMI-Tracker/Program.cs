using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace BMI_Tracker
{

    internal class Program
    {
        static List<Person> persons;
        static void Main(string[] args)
        {
            persons = new List<Person>();
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Welcome to the BMI tracker app");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Menu");
            Console.WriteLine("1. Add : add name of patient to database, add height to database, add weight to database, add value for severe underweight to database, add value for underweight to database, add value for healthy to database, add value for overweight to database, add value for slightly obese to database, add value for obese to database, add value for severely obese to database");
            Console.WriteLine("2. Remove : remove patient name from database");
            Console.WriteLine("3. Edit : edit patient name in database, edit height in data base, edit weight in database.");
            Console.WriteLine("4. View : view all patients details on the database.");
            Console.WriteLine("5. Find : find information about specified patients");

            Console.WriteLine("Enter your selected option to proceed");
            string input = Console.ReadLine();

            if (input == "1")
            {
                PerformAddPerson();
                Menu();
            }
        }

        public static void PerformAddPerson()
        {
            Console.WriteLine("Time to add a person.");
            Console.WriteLine("What is the name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is the height?");
            string height = Console.ReadLine();

            Console.WriteLine("What is the weight?");
            string weight = Console.ReadLine();

            Person person = new Person { Name = name, Height = height, Weight = weight };
            persons.Add(person);

            Console.WriteLine("Person succesfully added!");

        }
    }
}
