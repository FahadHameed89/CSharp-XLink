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
    }
}
