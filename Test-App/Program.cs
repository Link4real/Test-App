using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 16, 15, 45, 11 };
            string[] friends = new string[5];
            friends[0] = "a";
            friends[1] = "b";
            Console.WriteLine(luckyNumbers[0] + luckyNumbers[3] + " = " + friends[0]);

            Console.ReadLine();
        }
    }
}
