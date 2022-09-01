using System;

namespace StringInterpolation
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.Now;
            Console.WriteLine($"{date,40:MMMM dd, yyyy}");
            Console.WriteLine($"{date:yyyy.MM.dd}");
            Console.WriteLine($"Day {date:dd} of {date:MMMM, yyyy}");
            Console.WriteLine($"Year: {date:yyyy}, Month: {date:MM}, Day: {date:dd}");
            Console.WriteLine($"{date.DayOfWeek,10}");
            Console.WriteLine($"{date,10:t}{date.DayOfWeek,10}");
            Console.WriteLine($"h:{date:hh}, m:{date:mm}, s:{date:ss}");
            Console.WriteLine($"{date:yyyy.MM.dd.hh.mm.ss}");
            
            var pi = Math.PI;
            Console.WriteLine($"{pi:C}");
            Console.WriteLine($"{pi,10:F3}");
        }
    }
}