using System;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public double High;
        public double Low;
        public char Letter
        {
            get
            {
                switch(Average)
                {
                    case var average when average >= 90:
                        return 'A';
                    case var average when average >= 80:
                        return 'B';                
                    case var average when average >= 70:
                        return 'C';
                    case var average when average >= 60:
                        return 'D';
                    default:
                        return 'F';
                }
            }
        }
        
        public double Sum;
        public int Count;
        public void Add(double number)
        {
            Sum += number;
            Count += 1;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }


        public Statistics()
        {
            Count = 0;
            High = double.MinValue;
            Low = double.MaxValue;
        }
    }
}