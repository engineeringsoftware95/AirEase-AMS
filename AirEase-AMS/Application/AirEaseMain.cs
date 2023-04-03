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
            int num = HLib.GenerateFiveDigitID();
            Console.WriteLine(num);
            Console.WriteLine("Thank you for playing Wing Commander");
        }
    }
}