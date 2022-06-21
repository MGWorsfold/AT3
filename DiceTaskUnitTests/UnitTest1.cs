using System;
using Xunit;
using DiceTask;

namespace DiceTaskUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 7, 3, 11, 2, 2, 4.50)]
        public void GetAverageTestOne(int input1, int input2, int input3, int input4, int input5, int input6, double expected)
        {
            ClGame C = new ClGame();
            
            C.Results.Add(input1);
            C.Results.Add(input2);
            C.Results.Add(input3);
            C.Results.Add(input4);
            C.Results.Add(input5);
            C.Results.Add(input6);

            double total = C.GetTotal();
            double result = total / C.Results.Count;
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(18, 4, 6, 12, 19, 11.80)]
        public void GetAverageTestTwo(int input1, int input2, int input3, int input4, int input5, double expected)
        {
            ClGame C = new ClGame();
            
            C.Results.Add(input1);
            C.Results.Add(input2);
            C.Results.Add(input3);
            C.Results.Add(input4);
            C.Results.Add(input5);

            double total = C.GetTotal();
            double result = total / C.Results.Count;
            Assert.Equal(expected, result); 
        }
        [Theory]
        [InlineData(5, 5)]
        public void GetAverageTestThree(int input1, double expected)
        {
            ClGame C = new ClGame();

            C.Results.Add(input1);

            double total = C.GetTotal();
            double result = total / C.Results.Count;
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(0, 0)]
        public void GetAverageTestFour(int input1, double expected)
        {
            ClGame C = new ClGame();

            C.Results.Add(input1);

            double total = C.GetTotal();
            double result = total / C.Results.Count;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(2, 7, 3, 11, 2, 2, 27)]
        public void GetTotalTestOne(int input1, int input2, int input3, int input4, int input5, int input6, int expected)
        {
            ClGame C = new ClGame();

            C.Results.Add(input1);
            C.Results.Add(input2);
            C.Results.Add(input3);
            C.Results.Add(input4);
            C.Results.Add(input5);
            C.Results.Add(input6);

            int result = C.GetTotal();
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(18, 4, 6, 12, 19, 59)]
        public void GetTotalTestTwo(int input1, int input2, int input3, int input4, int input5, int expected)
        {
            ClGame C = new ClGame();

            C.Results.Add(input1);
            C.Results.Add(input2);
            C.Results.Add(input3);
            C.Results.Add(input4);
            C.Results.Add(input5);

            int result = C.GetTotal();
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(5, 5)]
        public void GetTotalTestThree(int input1, int expected)
        {
            ClGame C = new ClGame();

            C.Results.Add(input1);

            int result = C.GetTotal();
            Assert.Equal(expected, result);
        }
        [Theory]
        [InlineData(0, 0)]
        public void GetTotalTestFour(int input1, int expected)
        {
            ClGame C = new ClGame();

            C.Results.Add(input1);

            int result = C.GetTotal();
            Assert.Equal(expected, result);
        }
    }
}