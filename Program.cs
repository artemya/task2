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
            int year = 2019;
            // Console.WriteLine("Enter the month(number): ");
            int month = 7;
            DrawCalendar(year, month);
            DrawCalendar();
            DrawCalendar(month);
            
        }

        static void CreateHeader(int year, int month)
        {
            String[] months = {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"}; 
            DateTime start = new DateTime(year, month, 1);
            Console.WriteLine($"\t\t{year} {months[start.Month-1]}\t");
            Console.WriteLine("Mo\tTu\tWe\tTh\tFr\tSa\tSu");
        }
        
        static void DrawCalendar(int year, int month)
        {
            CreateHeader(year, month);
            int[,] dates = new int[6, 7];
            DateTime start = new DateTime(year, month, 1);
            int countDays = DateTime.DaysInMonth(year, month);
            DateTime end = new DateTime(year, month, countDays);
            int firstDay = 1;
            int numberDay = (int)start.DayOfWeek;
            // Console.WriteLine(numberDay);
            DateTime localDate = DateTime.Now;
            for (int i = 0; i < dates.GetLength(0); i++)
            {
                for (int j = 0; j < dates.GetLength(1) && firstDay - numberDay + 1 <= countDays; j++)
                {
                    dates[i, j] = firstDay - numberDay + 1;
                    firstDay++;
                    if (dates[i,j] < 1) {
                        Console.Write("\t");
                    } else if(dates[i,j] <= countDays) {
                        if(j < 5)
                        {
                            Console.Write($"{dates[i, j]}\t");
                        } else if (dates[i,j] == localDate.Day) {
                            Console.Write($"{dates[i, j]}\t", Color.Pink);
                        }
                        else {
                            Console.Write($"{dates[i, j]}\t", Color.Red);
                        }
                        
                    }

                }
                Console.WriteLine();
            }
        }

        static void DrawCalendar()
            {
                DateTime localDate = DateTime.Now;
                // Console.WriteLine(localDate);
                DrawCalendar(localDate.Year, localDate.Month);
            }

        static void DrawCalendar(int month)
            {
                DateTime localDate = DateTime.Now;
                // Console.WriteLine(localDate);
                DrawCalendar(localDate.Year, month);
            }
    }
}
