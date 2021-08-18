using System;

namespace VaccineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vaccine Registration!");

            Console.WriteLine("");
            Console.WriteLine("Name: ");
            String Name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Surname: ");
            string Surname = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Gender: ");
            string Gender = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Date of Birth: ");
            string DOB = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("ID: ");
            var Idnum = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Do you have money: ");
            string  money = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Congradulations " + Name +" "+ Surname + " you have successfully registered for your vaccine");
        }
    }
}
