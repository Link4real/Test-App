﻿using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(5);
            Console.WriteLine(cubedNumber);
           Console.ReadLine();
        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }

    }
}
