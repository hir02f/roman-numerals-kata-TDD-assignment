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
        private const char ROMAN_X = 'X';

        private const string ROMAN_IV = "IV";
        private const string ROMAN_V = "V";
        private const string ROMAN_IX = "IX";

        private const int FIVE = 5;
        public NumbersToRomanNumerals()
        {

        }

        public string ReturnRomanNumeral(char inputChar, int repetition)
        {      
            return new string(inputChar,repetition); // II, XXX etc
        }

        public string UnderHundredCalculator(int inputNumber) 
        {
            int remainder = inputNumber % 10;
            int quotient = inputNumber / 10;

            if (remainder == 4) // 4,14,24,34 etc
            {
                return ReturnRomanNumeral(ROMAN_X, quotient) + ROMAN_IV;
            }
            else if (remainder == 9) // 9,19,29,39 etc
            {
                return ReturnRomanNumeral(ROMAN_X, quotient) + ROMAN_IX;
            }
            else if (remainder == 5) // 5,15,25 etc
            {
                return ReturnRomanNumeral(ROMAN_X, quotient) + ROMAN_V;                
            }
            else if (remainder == 0)
            {
                return ReturnRomanNumeral(ROMAN_X, quotient);
            }
            else
            {
                return ReturnRomanNumeral(ROMAN_I, inputNumber);
            }
        }
    }
}
