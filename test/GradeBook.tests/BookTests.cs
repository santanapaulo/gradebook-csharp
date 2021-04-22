using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var book = new Book("Test");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            var result = book.GetStatistics();
            Assert.Equal(85.6, result.average, 1);
            Assert.Equal(90.5, result.high, 1);
            Assert.Equal(77.3, result.low, 1);

        }
    }
}
