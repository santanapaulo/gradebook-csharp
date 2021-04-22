using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book
    {
        public List<double> grades;
        public string name;

        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.high = double.MinValue;
            statistics.low = double.MaxValue;
            foreach(var grade in grades)
            {
                statistics.low = Math.Min(grade, statistics.low);
                statistics.high = Math.Max(grade, statistics.high);
                statistics.average += grade;
            }

            statistics.average /= grades.Count;
            return statistics;
        }
    }
}