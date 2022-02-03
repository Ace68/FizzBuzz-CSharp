using System;
using System.Collections.Generic;
using Xunit;

namespace FizzBuzz.Test
{
    public class FizzBuzzTest
    {
        [Fact]
        public void Verify_Number_IsFizz()
        {
            var numberToVerify = 6;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal("Fizz", fizzBuzzLibrary.ChkNumber(numberToVerify));
        }

        [Fact]
        public void Verify_Number_IsBuzz()
        {
            var numberToVerify = 5;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal("Buzz", fizzBuzzLibrary.ChkNumber(numberToVerify));
        }

        [Fact]
        public void Verify_Number_IsFizzBuzz()
        {
            var numberToVerify = 15;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal("FizzBuzz",fizzBuzzLibrary.ChkNumber(numberToVerify));
        }

        [Fact]
        public void Verify_Number_IsNotFizzBuzz()
        {
            var numberToVerify = 7;

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal(fizzBuzzLibrary.ChkNumber(numberToVerify), numberToVerify.ToString("N"));
        }

        [Theory]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(7, "CiccioCalippo")]
        [InlineData(8, "8.00")]
        public void Verify_ChkFizzBuzz_With_Combinations(int numberToVerify, string stringExpected)
        {
            var combinations = new List<Tuple<int, string>>
            {
                new (3, "Fizz"),
                new (5, "Buzz"),
                new (7, "CiccioCalippo"),
            };

            var fizzBuzzLibrary = new FizzBuzzLibrary();

            Assert.Equal(stringExpected,fizzBuzzLibrary.ChkFizzBuzz(combinations, numberToVerify));
        }
    }
}
