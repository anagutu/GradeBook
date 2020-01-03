using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var book = new Book("");
            book.AddGrade(20.3);
            book.AddGrade(30.4);
            book.AddGrade(40.5);

            //act
            var result = book.GetStatistics();

            //assert
            Assert.Equal(30.4, result.Average, 1);
            Assert.Equal(40.5, result.High, 1);
            Assert.Equal(20.3, result.Low, 1);
        }
    }
}
