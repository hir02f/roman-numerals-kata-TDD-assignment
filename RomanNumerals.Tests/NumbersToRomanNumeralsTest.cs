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
        public void Test1()
        {
            _numbersToRomanNumerals.UnderTenCalculator().Should().Be("I");
        }
    }

}
