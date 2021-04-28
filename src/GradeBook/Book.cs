using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public class Book
    {
        public List<double> grades;
        public string Name { get; set; }
        public event GradeAddedDelegate GradeAdded;


        public Book(string name)
        {
            grades = new List<double>();
            Name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
            if(GradeAdded != null)
            {
                GradeAdded(this, new EventArgs());
            }
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

            switch(statistics.Average)
            {
                case var average when average >= 90:
                    statistics.Letter = 'A'; 
                    break;

                case var average when average >= 80:
                    statistics.Letter = 'B'; 
                    break;
                
                case var average when average >= 70:
                    statistics.Letter = 'C'; 
                    break;

                case var average when average >= 60:
                    statistics.Letter = 'D'; 
                    break;

                default:
                    statistics.Letter = 'F';
                    break;
            }
            return statistics;
        }
    
    }
}