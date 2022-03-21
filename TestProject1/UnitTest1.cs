using ConsoleApp1;
using System;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        [Fact]
        public void Should_AddTwo()
        {
            // arrange 
            var adds = new Arithmetics();
            // act 
            var results = adds.AddTwoNums(1, 1);

            // assert
            Assert.Equal(2, results);
            
        }

    }
}
