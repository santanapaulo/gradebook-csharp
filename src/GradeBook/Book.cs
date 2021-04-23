using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public List<double> grades;
        public string Name;

        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.High = double.MinValue;
            statistics.Low = double.MaxValue;
            foreach(var grade in grades)
            {
                statistics.Low = Math.Min(grade, statistics.Low);
                statistics.High = Math.Max(grade, statistics.High);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;
            return statistics;
        }
    }
}