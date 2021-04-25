using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("PH book");
            book.AddGrade(89.1);
            book.AddGrade(90.50);
            book.AddGrade(77.5);

            var statistics = book.GetStatistics();
            Console.WriteLine($"The lowest grade is {statistics.Low}");
            Console.WriteLine($"The highest grade is {statistics.High}");
            Console.WriteLine($"Result: {statistics.Average:N1}");
            Console.WriteLine($"Letter Grade: {statistics.Letter}");

        }
    }
}
