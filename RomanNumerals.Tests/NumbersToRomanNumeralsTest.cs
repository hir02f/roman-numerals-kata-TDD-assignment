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
        public void Exception_For_Zero()
        {
            var ex = Assert.Throws<ArgumentException>(() => _numbersToRomanNumerals.UnderHundredCalculator(0));
            Assert.That(ex.Message, Is.EqualTo("Romans do not have zeroes!"));
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

        [Test]
        public void Convert_Eleven_Sixteen_TwentyThree_ThirtyTwo()
        {
            _numbersToRomanNumerals.UnderHundredCalculator(11).Should().Be("XI");
            _numbersToRomanNumerals.UnderHundredCalculator(16).Should().Be("XVI");
            _numbersToRomanNumerals.UnderHundredCalculator(23).Should().Be("XXIII");
            _numbersToRomanNumerals.UnderHundredCalculator(32).Should().Be("XXXII"); 
        }

        [Test]
        public void Convert_Any_Number_From_50_To_89() // Now 50, 61, 73, 84, 89
        {
            /* _numbersToRomanNumerals.UnderHundredCalculator(50).Should().Be("L");
             _numbersToRomanNumerals.UnderHundredCalculator(61).Should().Be("LXI");
             _numbersToRomanNumerals.UnderHundredCalculator(73).Should().Be("LXXIII");
             _numbersToRomanNumerals.UnderHundredCalculator(84).Should().Be("LXXXIV");*/
        }
    }

}
