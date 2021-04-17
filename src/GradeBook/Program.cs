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
            Console.WriteLine($"grade: {book.grades[0]}");

            var grade = new List<double>() {12.7, 10.3, 6.11,4.1};

            var result = 0.0;

            foreach(var number in grade)
            {
                result += number;
            }

            result /= grade.Count;

            Console.WriteLine($"Resultado: {result:N1}");
        }
    }
}
