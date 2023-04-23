using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AirEase_AMS.App.Entity.BoardingPass
{
    public class BoardingPass
    {
        string flightID_;
        string firstName_;
        string lastName_;
        string originCity_;
        string destinationCity_;
        DateTime departureTime_;
        DateTime arrivalTime_;
        string userID_;

        //TODO: statement or branch uncovered
        BoardingPass(string flightID, string firstName, string lastName, string originCity, string destinationCity,
            DateTime departureTime, DateTime arrivalTime, string userID)
        { 
            // search database for the given user
            flightID_ = flightID;
            firstName_ = firstName;
            lastName_ = lastName;
            originCity_ = originCity;
            destinationCity_ = destinationCity;
            departureTime_ = departureTime;
            arrivalTime_ = arrivalTime;
            userID_ = userID;
        }

        string printBoardingPass() //TODO: statement or branch uncovered
        {
            string boardingPass = createBoardingClassString();
            return boardingPass;
        }
        
        string createBoardingClassString() //TODO: statement or branch uncovered
        {
            string boardingPass = "" + flightID_ + "," + firstName_ + "," + lastName_ + "," + originCity_ + "," +
                destinationCity_ + "," + departureTime_ + "," + arrivalTime_ + "," + userID_ + "\0";
            return boardingPass;
        }
    }
}
