using System;
using Xunit;

namespace GradeBook.tests
{
    public class BookTests
    {

        [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(x);
            Assert.Equal(3, x);
        }

        private void SetInt(int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpIsPassByRef()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
            book.Name = name;
        }

        // [Fact]
        // public void CSharpIsPassByValue()
        // {
        //     var book1 = GetBook("Book 1");
        //     GetBookSetName(book1, "New Name");
        //     Assert.Equal("New Name", book1.Name);
        // }

        // private void GetBookSetName(Book book, string name)
        // {
        //     book = new Book(name);
        //     book.Name = name;
        // }

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            setName(book1, "New Name");
            Assert.Equal("New Name", book1.Name);
        }

        private void setName(Book book1, string name)
        {
            book1.Name = name;
        }

        [Fact]
        public void TwoVarsCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            Assert.Same(book1, book2);
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
