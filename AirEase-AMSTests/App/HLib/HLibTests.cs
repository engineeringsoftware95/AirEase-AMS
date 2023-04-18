using NUnit.Framework;
using AirEase_AMS.App;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.Utilities;

namespace AirEase_AMS.App.Tests
{
    [TestFixture()]
    public class HLibTests
    {
        [Test()]
        [TestCase(0)]
        [TestCase(-2)]
        [TestCase(10.00)]
        [TestCase(1.2)]
        [TestCase(10.25)]
        [TestCase(10.257)]
        [TestCase(264.04)]

        public void ConvertToPointsTest(decimal input)
        {
            //ARRANGE


            //ACT
            int output = HLib.ConvertToPoints(input);
            int compOut = (int)(Math.Floor(input * 100.00m));
            if (input < 0) compOut = -1;
            Console.WriteLine("Input = " + input + " results in output = " + output);

            //ASSERT

            Assert.AreEqual(compOut, output);
        }

        [Test()]
        [TestCase(12, 3456)]
        [TestCase(1, 23456)]
        [TestCase(9, 8)]
        [TestCase(0, 8)]
        [TestCase(1, 0)]
        [TestCase(0, 1)]
        [TestCase(0, 0)]
        [TestCase(-1, -1)]
        [TestCase(-10, -1)]



        public void PrependNumberToIntegerTest(int input1, int input2)
        {

            //ARRANGE


            //ACT
            int output = HLib.PrependNumberToInteger(input1, input2);
            string comparisonString = Math.Abs(input1).ToString() + Math.Abs(input2).ToString();
            if (Math.Abs(input1) > 9) comparisonString = "-1";
            Console.WriteLine("Input1 = " + input1 + " input2 = " + input2 + " Results in " + output);
            //ASSERT
            Assert.AreEqual(Int32.Parse(comparisonString), output);
        }

        [Test()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        [TestCase()]
        public void GenerateFiveDigitIdTest()
        {

            string result = HLib.GenerateFiveDigitId().ToString();
            Console.WriteLine("Result = " + result);
            Assert.AreEqual(result.Length, 5);
        }

        [Test()]
        [TestCase("somepassword", "AB54Dad")]
        [TestCase("Password123!", "SaltyBoi")]
        [TestCase("Pass65", "BiggerSalt67")]
        [TestCase("PassWORDisBIGandSECURE!!!YESitIS--o", "smolsalt")]
        [TestCase("PassWORDisBIGandSECURE!!!YESitIS--o", "THISsaltIShuge!!!rtrtrtdfdfdste")]

        public void EncryptPasswordTest(string password, string salt)
        {
            string result1 = HLib.EncryptPassword(password, salt);
            string result2 = HLib.EncryptPassword(password, salt);

            //Displays hex values with '-' inbetween - that's where the 64 * 3 - 1 comes from. That's the ACTUAL string len
            Assert.AreEqual(result1, result2);
            Assert.AreEqual(64 * 3 - 1, result2.Length);
        }

        [Test()]
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(99)]
        public void GenerateSaltTest(int saltSize)
        {
            string result = HLib.GenerateSalt(saltSize);
            int outLen = saltSize * 3 - 1;
            if (outLen < 0) outLen = 0;
            Assert.AreEqual(outLen, result.Length);
        }

        [Test()]
        public void GenerateSixDigitIdTest()
        {
            string result = HLib.GenerateSixDigitId().ToString();
            Console.WriteLine("Result = " + result);
            Assert.AreEqual(result.Length, 6);
        }
    }
}