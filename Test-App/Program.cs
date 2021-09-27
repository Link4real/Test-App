using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {

            string characterName = "Merlin";   //string
            int characterAge;               //int (for numbers)
            characterAge = 1000000000;
            Console.WriteLine("There once was a man called " + characterName + ".");
            Console.WriteLine("He was " + characterAge + " years old!");
            characterName = "PAPST FRANZISKUS";
            Console.WriteLine("He liked the name " + characterName + ".");
            Console.WriteLine("But didn't like being " + characterAge + " years old!");
        
            Console.ReadLine();
        }
    }
}
