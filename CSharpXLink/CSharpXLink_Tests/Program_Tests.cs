using CSharpXLink;
using System;
using Xunit;

namespace CSharpXLink_Tests
{
    public class Program_Tests
    {
        // A theory is meant for testing a method with a set of data. Typically you won't be able to test all permutations or possible inputs of the method (like math operations). It's good to test edge cases as well as areas around 0.
        // If your method works for all ints, check the max and min values, 0, -1, and 1 for example
        [Theory]
        [InlineData(2, 1)]
        [InlineData(4, 2)]
        [InlineData(3, 1)]
        [InlineData(0, 0)]
        [InlineData(-2, -1)]
        [InlineData(25000, 25)]
        [InlineData(int.MaxValue, 1073741823)]
        [InlineData(int.MinValue, -1073741824)]
        public void DivideByTwo_Valid(int input, int expected)
        {
            // Arrange Step - Set up any data, variables, objects, etc for testing.
            int output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.DivideByTwo(input);

            // Asset - Check the result to make sure it matches what's expected.
            // In this case, we are saying that the expected value is EQUAL to the output.
            Assert.Equal(expected, output);
        }

        [Theory]
        [InlineData(16, true)]
        [InlineData(25, true)]
        [InlineData(10, false)]
        [InlineData(100, false)]
        [InlineData(-1, false)]
        [InlineData(0, false)]
        [InlineData(int.MaxValue, false)]
        [InlineData(int.MinValue, false)]

        public void PerfectSquare_Valid(int input2, bool expected2)
        {
            // Arrange
            bool output2; 
            // Act
            output2 = Program.PerfectSquare(input2);

            // Asset 
            Assert.Equal(expected2, output2);

        }

        [Fact]
        public void MathPi_Value()
        {
            // Arrange

            // Act 

            // Asset
            Assert.Equal(3.141592653589793, Math.PI);
        }

        [Fact]
        public void Exception_Test()
        {
            // Arrange - 

            // Act

            // Asset 
            Assert.Throws<FormatException>(() => {
                // This code block should throw an exception of the type in the angle brackets, else it will fail!
                Program.ThrowsFormatException();
            });
        }

    }
}
