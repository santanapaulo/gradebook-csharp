﻿using System;
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

            book.ShowStats();
        }
    }
}
