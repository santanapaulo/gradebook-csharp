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
            Console.WriteLine($"The lowest grade is {statistics.low}");
            Console.WriteLine($"The highest grade is {statistics.high}");
            Console.WriteLine($"Resultado: {statistics.average:N1}");

        }
    }
}
