using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, noun, people;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            people = Console.ReadLine();

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Roses are " + color);
            Console.WriteLine(noun + " are " + "blue");
            Console.WriteLine("I love "+ people +"!");

            Console.ReadLine();
        }
    }
}
