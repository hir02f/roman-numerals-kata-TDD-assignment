using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class NumbersToRomanNumerals
    {
        // Internal data
        private const char ROMAN_I = 'I';
        private const char ROMAN_V = 'V';
        private const char ROMAN_X = 'X';
        private const char ROMAN_L = 'L';

        private const string ROMAN_IV = "IV";
        private const string ROMAN_IX = "IX";

        private const int FIVE = 5;
        private const int TEN = 10;
        private const int FIFTY = 50;

        public NumbersToRomanNumerals()
        {

        }

        public string ReturnRomanNumeral(char inputChar, int repetition)
        {      
            return new string(inputChar,repetition); // II, XXX etc
        }

        public string UnderHundredCalculator(int inputNumber) 
        {
            if (inputNumber == 0) 
            { 
                throw new ArgumentException("Romans do not have zeroes!"); 
            }

            if (inputNumber < 0)
            {
                throw new ArgumentException("Romans do not have negative numbers!");
            }

            // Breaking down the input number by 10, then 5
            int quotient_10 = inputNumber / TEN;
            int remainder_10 = inputNumber % TEN;
            int quotient_5 = remainder_10 / 5;
            int remainder_5 = remainder_10 % FIVE;

            string partialoutput = ReturnRomanNumeral(ROMAN_X, quotient_10) + ReturnRomanNumeral(ROMAN_V, quotient_5);

            if (remainder_5 == 4)
            {
                return partialoutput + ROMAN_IV;
            }
            else if (remainder_5 == 9)
            {
                return partialoutput + ROMAN_IX;
            }
            else
            {
                return partialoutput + ReturnRomanNumeral(ROMAN_I, remainder_5);
            }
        }
    }
}
