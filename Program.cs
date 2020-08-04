using System;
using System.Drawing;
using Console = Colorful.Console;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter the year: ");
            int year = 2020;
            // Console.WriteLine("Enter the month(number): ");
            int month = 2;
            Drawcalendar(year, month);
            
        }

        static void CreateHeader(int year, int month)
        {
            DateTime start = new DateTime(year, month, 1);
            Console.WriteLine($"\t\t{year} {start}\t");
            Console.WriteLine("Mo\tTu\tWe\tTh\tFr\tSa\tSu");
        }
        
        static void Drawcalendar(int year, int month)
        {
            CreateHeader(year, month);
            int[,] dates = new int[6, 7];
            DateTime start = new DateTime(year, month, 1);
            int countDays = DateTime.DaysInMonth(year, month);
            DateTime end = new DateTime(year, month, countDays);
            int firstDay = 1;
            int numberDay = (int)start.DayOfWeek;
            // Console.WriteLine(numberDay);
            
            for (int i = 0; i < dates.GetLength(0); i++)
            {
                for (int j = 0; j < dates.GetLength(1) && firstDay - numberDay + 1 <= countDays; j++)
                {
                    dates[i, j] = firstDay - numberDay + 1;
                    firstDay++;
                    if (dates[i,j] < 1) {
                        Console.Write("\t");
                    } else if(dates[i,j] <= countDays) {
                        Console.Write($"{dates[i, j]}\t");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
