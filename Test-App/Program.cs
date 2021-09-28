using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("This is your name: " + name);
            Console.WriteLine("This is your age: " + age);
            Console.ReadLine();
        }
    }
}
