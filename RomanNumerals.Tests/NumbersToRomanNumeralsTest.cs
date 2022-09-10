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
            _numbersToRomanNumerals.UnderTenCalculator(1).Should().Be("I");
            _numbersToRomanNumerals.UnderTenCalculator(2).Should().Be("II");
            _numbersToRomanNumerals.UnderTenCalculator(3).Should().Be("III");
        }
    }

}
