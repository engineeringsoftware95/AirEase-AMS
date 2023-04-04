using AirEase_AMS.App.HLib;
using AirEase_AMS.Interface;
using AirEase_AMS.Application;

namespace AirEase_AMS.Application
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Temporary example of using an HLib function. Delete whenever
            int num = HLib.GenerateFiveDigitId();
            Console.WriteLine(num);
            string salt = HLib.GenerateSalt(2);
            string hash = HLib.EncryptPassword("SomePassword88!", salt);
            Console.WriteLine("Password: " + hash + " \nWhere salt is " + salt);
            Console.WriteLine("Thank you for playing Wing Commander");
        }
    }
}