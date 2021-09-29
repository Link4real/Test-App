using System;

namespace Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(1));
            Console.ReadLine();
        }
        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                case 5:
                    dayName = "Saturday";
                    break;
                case 6:
                    dayName = "Sunday";
                    break;
                default:
                    dayName = "Invalid day number!";
                    break;
            }

            return dayName;
        }
    }
}
