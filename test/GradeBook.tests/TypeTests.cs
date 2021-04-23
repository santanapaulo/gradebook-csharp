using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("", book1.Name);
            Assert.Equal("", book2.Name);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}