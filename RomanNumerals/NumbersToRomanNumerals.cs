using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class NumbersToRomanNumerals
    {
        private const char ROMAN_I = 'I';
        private const char ROMAN_V = 'V';

        private const int FIVE = 5;
        public NumbersToRomanNumerals()
        {

        }

        public string UnderTenCalculator(int inputNumber)
        {
            int remainder = inputNumber % FIVE;          
            return new string(ROMAN_I,remainder);
        }
    }
}
