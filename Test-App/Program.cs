using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Text \nLine";
            Console.WriteLine(phrase.Substring(6, 2));

            Console.ReadLine();
        }
    }
}
