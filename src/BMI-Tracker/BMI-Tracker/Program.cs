using System;

namespace BMI_Tracker
{
    internal class Program
    {
        static void Main(string[] args)
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
        }
    }
}
