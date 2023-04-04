﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Collections;

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

        /// <summary>
        /// A function which accepts a password and salt and outputs a sha512 conversion string.
        /// </summary>
        /// <param name="password">The password to be converted.</param>
        /// <param name="salt">The salt to be appended to the password.</param>
        /// <returns>A SHA512 encryption of the password and salt.</returns>
        public static string EncryptPassword(string password, string salt)
        {
            //Concat password and salt for hashing
            string concatPassword = password + salt;
            
            SHA512 sha512 = SHA512.Create();

            //Get byte array result from the hash (64 bytes or 512 bits)
            byte[] bytePassword = sha512.ComputeHash(Encoding.ASCII.GetBytes(concatPassword));

            //Return the string conversion
            return BitConverter.ToString(bytePassword);
        }

        /// <summary>
        /// This function takes in a byte array size and returns a salt.
        /// </summary>
        /// <param name="byteSize">The number of bytes in the original byte array.</param>
        /// <returns>A random string. The result will NOT have the same number of characters as the input, but it will be proportional.</returns>
        public static string GenerateSalt(int byteSize)
        {
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                //Size of stringSize bytes
                byte[] bytes = new byte[byteSize];

                //Get a random array of bytes
                rng.GetBytes(bytes);


                return BitConverter.ToString(bytes);
            }
        }

    }

}