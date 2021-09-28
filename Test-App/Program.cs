using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isCool = true;
            bool isTall = false;

            if (isCool && isTall)
            {
                Console.WriteLine("You are a cool and tall person!");
            } else if (isCool && !isTall) {

                Console.WriteLine("You are cool but short (like tisigue)");
            } else if (!isCool && isTall)
            {

                Console.WriteLine("You are not cool but tall! (like me)");
            } else
            {
                Console.WriteLine("You aren't cool and very short!");
            }

            Console.ReadLine();
        }
    }
}
