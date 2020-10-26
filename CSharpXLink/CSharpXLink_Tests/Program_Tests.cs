using CSharpXLink;
using System;
using Xunit;

namespace CSharpXLink_Tests
{
    public class Program_Tests
    {
        [Theory]
        [InlineData(2, 1)]
        public void DivideByTwo_Valid(int input, int expected)
        {
            // Arrange Step - Set up any data, variables, objects, etc for testing.
            int output;

            // Act - Call the method, setter, whatever you're testing.
            output = Program.DivideByTwo(input);

            // Asset - Check the result to make sure it matches what's expected.
        }
    }
}
