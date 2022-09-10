using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;

namespace RomanNumerals.Tests
{
    public class NumbersToRomanNumeralsTest
    {
        private NumbersToRomanNumerals _numbersToRomanNumerals;
        [SetUp]
        public void Setup()
        {
            _numbersToRomanNumerals = new NumbersToRomanNumerals();
        }

        [Test]
        public void Convert_Under_Four()
        {
            _numbersToRomanNumerals.UnderHundredCalculator(1).Should().Be("I");
            _numbersToRomanNumerals.UnderHundredCalculator(2).Should().Be("II");
            _numbersToRomanNumerals.UnderHundredCalculator(3).Should().Be("III");
        }

        [Test]
        public void Convert_Fourteen_And_ThirtyFour()
        {
            _numbersToRomanNumerals.UnderHundredCalculator(14).Should().Be("XIV");
            _numbersToRomanNumerals.UnderHundredCalculator(34).Should().Be("XXXIV");
        }

        [Test]
        public void Convert_Five_And_FortyFive()
        {
            _numbersToRomanNumerals.UnderHundredCalculator(5).Should().Be("V");
            _numbersToRomanNumerals.UnderHundredCalculator(45).Should().Be("XXXXV");
        }

        [Test]
        public void Convert_Ten_And_Twenty()
        {
            _numbersToRomanNumerals.UnderHundredCalculator(10).Should().Be("X");
            _numbersToRomanNumerals.UnderHundredCalculator(20).Should().Be("XX");
        }
    }

}
