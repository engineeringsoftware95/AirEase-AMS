using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirEase_AMS.Application
{
    class HLib
    {
        /// <summary>
        /// Generates some number between 10000 and 99999.
        /// </summary>
        public static int GenerateFiveDigitID()
        {
            Random rand = new Random();

            //Generate some number between 10000 and 99999.
            return rand.Next(10000, 100000);
        }

        /// <summary>
        /// Prepends a digit to an integer number.
        /// </summary>
        /// <param name="digit">The number to be prepended.</param>
        /// <param name="number">The number being prepended to.</param>
        public static int PrependNumberToInteger(int digit, int number)
        {
            //Prepend 1 to 9600:
            //10000 + 9600 = 19600

            //This is the rounded down log10 of number. Used to figure out how large to make the prepended integer.
            int numberOfDigits = Convert.ToInt32(Math.Floor(Math.Log10(number)));
            //The prepended digit will be one order of magnitude larger than number.
            numberOfDigits++;

            int prependedInteger = Convert.ToInt32(Math.Pow(10, numberOfDigits)) + number;
            return prependedInteger;
        }

        /// <summary>
        /// Takes in a double cost in USD, converts it to points by multiplying the cost by 100 and rounding down.
        /// </summary>
        /// <param name="cost">The price to be converted into points.</param>
        /// <returns></returns>
        public static int ConvertToPoints(double cost)
        {
            //This even works on numbers without exactly two digits of precision.
            //Floor(19.3294 * 100) = Floor(1932.94) = 1932

            //Points must be an integer.
            //Points are, in essence, the number of pennies required to make up
            //the total dollar amount its being converted from.
            //1 point = 1 penny

            return Convert.ToInt32(cost * 100);
        }

        public static string EncryptPassword(string password, string salt)
        {

            return "";
        }

        public static string GenerateSalt(int size)
        {

            return "";
        }

    }

}
