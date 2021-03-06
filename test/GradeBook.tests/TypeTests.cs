using System;
using Xunit;

namespace GradeBook.tests
{
    public delegate string WriteLogDelegate(string logMessage);
    public class BookTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;

            log += ReturnMessage;
            log += ReturnMessageLowerCase;

            var result = log("hello");
            Assert.Equal(count, 3);
        }

        string ReturnMessageLowerCase(string message)
        {   count += 1;
            return message.ToLower();
        }

        string ReturnMessage(string message)
        {   count += 1;
            return message;
        }

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

        private void GetBookSetName(ref InMemoryBook book, string name)
        {
            book = new InMemoryBook(name);
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

        private void setName(InMemoryBook book1, string name)
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

        InMemoryBook GetBook(string name)
        {
            return new InMemoryBook(name);
        }
    }
}
