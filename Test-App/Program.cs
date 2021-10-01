using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] luckyNumbers = { 4, 8, 5, 88, 1};
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }

            Console.ReadKey();
        }
    }
}
