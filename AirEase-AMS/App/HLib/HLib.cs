using AirEase_AMS.App.Entity.User;
using AirEase_AMS.App.Graph.Flight;
using AirEase_AMS.App.Graph;
using System.Security.Cryptography;
using System.Text;
using AirEase_AMS.App.Ticket;
using AirEase_AMS.App.Entity.User.Employees;
using AirEase_AMS.App.Entity.Aircraft;
using AirEase_AMS.Transaction;
using System.Data;
// ReSharper disable All

namespace AirEase_AMS.App
{
    public class HLib
    {
        /// <summary>
        /// Generates some number between 10000 and 99999.
        /// </summary>
        public static int GenerateFiveDigitId()
        {
            var rand = new Random();
            //Generate some number between 10000 and 99999.
            return rand.Next(10000, 100000);
        }

        /// <summary>
        /// Generates some number between 100000 and 999999.
        /// </summary>
        public static int GenerateSixDigitId()
        {
            var rand = new Random();
            //Generate some number between 100000 and 999999.
            return rand.Next(100000, 999999);
        }

        /// <summary>
        /// Prepends a digit to an integer number.
        /// </summary>
        /// <param name="digit">The number to be prepended.</param>
        /// <param name="number">The number being prepended to.</param>
        public static int PrependNumberToInteger(int digit, int number)
        {

            if (Math.Abs(digit) > 9) return -1;
            //Prepend 1 to 9600:
            //10000 + 9600 = 19600
            
            //This is the rounded down log10 of number. Used to figure out how large to make the prepended integer.
            int numberOfDigits = Convert.ToInt32(Math.Floor(Math.Log10((number <= 0) ? 1 : number)));
            //The prepended digit will be one order of magnitude larger than number.
            numberOfDigits++;
            int prependedInteger = (Math.Abs(digit) * Convert.ToInt32(Math.Pow(10, numberOfDigits))) + Math.Abs(number);
            return prependedInteger;
        }

        /// <summary>
        /// Takes in a double cost in USD, converts it to points by multiplying the cost by 100 and rounding down.
        /// </summary>
        /// <param name="cost">The price to be converted into points.</param>
        /// <returns></returns>
        public static int ConvertToPoints(decimal cost)
        {

            if (cost < 0) return -1;
            //This even works on numbers without exactly two digits of precision.
            //Floor(19.3294 * 100) = Floor(1932.94) = 1932

            //Points must be an integer.
            //Points are, in essence, the number of pennies required to make up
            //the total dollar amount its being converted from.
            //1 point = 1 penny

            return Convert.ToInt32(Math.Floor(cost * 100));
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
            //Get byte array result from the hash (64 bytes or 512 bits)
            byte[] bytePassword = SHA512.HashData(Encoding.ASCII.GetBytes(concatPassword));
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

        /// <summary>
        /// Generate a yearWeekID using a datetime object
        /// </summary>
        /// <param name="dateTime">The time to use when generating the yearWeekID</param>
        /// <returns>The generated yearWeekID</returns>
        public static string GenerateYearWeekID(DateTime dateTime)
        {
            string yearWeekId = dateTime.Year.ToString();
            yearWeekId += ((int)Math.Floor(dateTime.DayOfYear / 7.0)).ToString();
            return yearWeekId;
        }

        /// <summary>
        /// Select all flights stored in the database.
        /// </summary>
        /// <returns>A list of all flights.</returns>
        public static List<Flight> SelectAllFlights()
        {
            string query = "SELECT * FROM FLIGHT_DEPARTURES;";
            DatabaseAccessObject dao = new DatabaseAccessObject();
            DataTable dataTable = dao.Retrieve(query);
            List<Flight> flights = new List<Flight>();
            foreach(DataRow row in dataTable.Rows)
            { 
                string flightId = row["FlightID"].ToString() ?? "-1";
                string departureeId = row["DepartureID"].ToString() ?? "-1";
                flights.Add(new Flight(flightId, departureeId));
            }
            return flights;
        }

        /// <summary>
        /// Select all routes stored in the database.
        /// </summary>
        /// <returns>A list of all routes.</returns>
        public static List<Route> SelectAllRoutes()
        {
            string query = "SELECT * FROM FLIGHTROUTE;";
            DatabaseAccessObject dao = new DatabaseAccessObject();
            DataTable dataTable = dao.Retrieve(query);
            List<Route> routes = new List<Route>();
            foreach (DataRow row in dataTable.Rows)
            {
                string id = row["RouteID"].ToString() ?? "-1";
                routes.Add(new Route(id));
            }
            return routes;
        }

        /// <summary>
        /// Selects all aircraft stored in the database.
        /// </summary>
        /// <returns>A list of all aircraft.</returns>
        public static List<Aircraft> SelectAllAircraft()
        {
            string query = "SELECT * FROM PLANE;";
            DatabaseAccessObject dao = new DatabaseAccessObject();
            DataTable dataTable = dao.Retrieve(query);
            List<Aircraft> planes = new List<Aircraft>();
            foreach (DataRow row in dataTable.Rows)
            {
                string id = row["PlaneID"].ToString() ?? "-1";
                planes.Add(new Aircraft(id));
            }
            return planes;
        }

        /// <summary>
        /// Selects all airports from the database.
        /// </summary>
        /// <returns>A list of all airports.</returns>
        public static List<Airport> SelectAllAirports()
        {
            string query = "SELECT * FROM AIRPORT;";
            DatabaseAccessObject dao = new DatabaseAccessObject();
            DataTable dataTable = dao.Retrieve(query);
            List<Airport> airports = new List<Airport>();
            foreach (DataRow row in dataTable.Rows)
            {
                string id = row["AirportID"].ToString() ?? "-1";
                airports.Add(new Airport(id));
            }
            return airports;
        }


        /// <summary>
        /// Earn ten points on the dollar. 100$ would return 10 points.
        /// </summary>
        /// <param name="cost">The cost to be converted to earned points.</param>
        /// <returns>The number of points earned on this transaction.</returns>
        public static int PointsEarned(decimal cost)
        {
            return Convert.ToInt32(Math.Floor((cost * 10.0m)));
        }

        /// <summary>
        /// Deletes everything in the database. This exists for debugging.
        /// </summary>
        public static void NuclearRedButton()
        {
            DatabaseAccessObject dao = new DatabaseAccessObject();

            //Delete absolutely everything -- dear god
            dao.Update("EXEC DeleteAllRecords;");
        }

        public static void LoadDatabase()
        {

            AirEase_AMS.App.Entity.Aircraft.Aircraft defaultAircraft = new AirEase_AMS.App.Entity.Aircraft.Aircraft("B-52", 5);
            defaultAircraft.SetAircraftId("111111");
            defaultAircraft.UploadAircraft();

            Aircraft boeing737 = new Aircraft("Boeing 737 MAX", 180);
            boeing737.UploadAircraft();
            Aircraft boeing757 = new Aircraft("Boeing 757", 200);
            boeing757.UploadAircraft();
            Aircraft boeing787 = new Aircraft("Boeing 787-8 Dreamliner", 248);
            boeing787.UploadAircraft();    
            Aircraft boeing777 = new Aircraft("Boeing 777", 320);
            boeing777.UploadAircraft();

            //This should be a good baseline
            Airport tennessee = new Airport("Nashville", "Nashville International Aiport");
            tennessee.UploadAirport();
            Airport cleveland = new Airport("Cleveland", "Cleveland Hopkins International Airport");
            cleveland.UploadAirport();
            Airport washington = new Airport("Seattle", "Seattle-Tacoma International Aiport");
            washington.UploadAirport();
            Airport newyork = new Airport("New York", "LaGuardia International Airport");
            newyork.UploadAirport();
            Airport illinois = new Airport("Chicago", "O'Hare International Airport");
            illinois.UploadAirport();
            Airport california = new Airport("Los Angeles", "LAX International Airport");
            california.UploadAirport();
            Airport texas = new Airport("Houston", "George Bush Intercontinental Airport");
            texas.UploadAirport();
            Airport florida = new Airport("Orlando", "Orlando International Airport");
            florida.UploadAirport();
            Airport arizona = new Airport("Phoenix", "Phoenix Sky Harbor International Airport");
            arizona.UploadAirport();
            Airport michigan = new Airport("Detroit", "Detroit Metropolitan Airport");
            michigan.UploadAirport();
            Airport newjersey = new Airport("Newark", "Newark Liberty International Airport");
            newjersey.UploadAirport();
            Airport virginia = new Airport("Arlington", "Ronald Reagan Washington National Airport");
            virginia.UploadAirport();
            Airport nebraska = new Airport("Omaha", "Eppley Airport");
            nebraska.UploadAirport();
            Airport maryland = new Airport("Baltimore", "Baltimore/Washington International Airport");
            maryland.UploadAirport();
            Airport utah = new Airport("Salt Lake City", "Salt Lake City International Airport");
            utah.UploadAirport();

            List<string> routeIds= new List<string>();

            //Upload a good selection but leave some room for testing (add routes)
            Route illinoisnewyork = new Route(illinois.GetAirportId(), newyork.GetAirportId(), 918);
            illinoisnewyork.UploadRoute();
            routeIds.Add(illinoisnewyork.GetRouteId());
            Route newyorkillinois = new Route(newyork.GetAirportId(), illinois.GetAirportId(), 918);
            newyorkillinois.UploadRoute();
            routeIds.Add(newyorkillinois.GetRouteId());

            Route tennesseecleveland = new Route(tennessee.GetAirportId(), cleveland.GetAirportId(), 584);
            tennesseecleveland.UploadRoute();
            routeIds.Add(tennesseecleveland.GetRouteId());
            Route clevelandtennessee = new Route(cleveland.GetAirportId(), tennessee.GetAirportId(), 584);
            clevelandtennessee.UploadRoute();
            routeIds.Add(clevelandtennessee.GetRouteId());

            Route clevelandnewjersey = new Route(cleveland.GetAirportId(), newjersey.GetAirportId(), 484);
            clevelandnewjersey.UploadRoute();
            routeIds.Add(clevelandnewjersey.GetRouteId());
            Route newjerseycleveland = new Route(newjersey.GetAirportId(), cleveland.GetAirportId(), 484);
            newjerseycleveland.UploadRoute();
            routeIds.Add(newjerseycleveland.GetRouteId());

            Route clevelandflorida = new Route(cleveland.GetAirportId(), tennessee.GetAirportId(), 1110);
            clevelandflorida.UploadRoute();
            routeIds.Add(clevelandflorida.GetRouteId());
            Route floridacleveland = new Route(florida.GetAirportId(), cleveland.GetAirportId(), 1110);
            floridacleveland.UploadRoute();
            routeIds.Add(floridacleveland.GetRouteId());


            Route tennesseeillinois = new Route(tennessee.GetAirportId(), illinois.GetAirportId(), 503);
            tennesseeillinois.UploadRoute();
            routeIds.Add(tennesseeillinois.GetRouteId());
            Route illinoistennessee = new Route(illinois.GetAirportId(), tennessee.GetAirportId(), 503);
            illinoistennessee.UploadRoute();
            routeIds.Add(illinoistennessee.GetRouteId());

            Route clevelandillinois = new Route(cleveland.GetAirportId(), illinois.GetAirportId(), 472);
            clevelandillinois.UploadRoute();
            routeIds.Add(clevelandillinois.GetRouteId());
            Route illinoiscleveland = new Route(illinois.GetAirportId(), cleveland.GetAirportId(), 472);
            illinoiscleveland.UploadRoute();
            routeIds.Add(illinoiscleveland.GetRouteId());

            Route losangelesseattle = new Route(california.GetAirportId(), washington.GetAirportId(), 1136);
            losangelesseattle.UploadRoute();
            routeIds.Add(losangelesseattle.GetRouteId());
            Route seattlelosangeles = new Route(washington.GetAirportId(),california.GetAirportId(), 1136);
            seattlelosangeles.UploadRoute();
            //routeIds.Add(seattlelosangeles.GetRouteId());

            Route seattlenebraska = new Route(washington.GetAirportId(), nebraska.GetAirportId(), 1501);
            seattlenebraska.UploadRoute();
            routeIds.Add(seattlenebraska.GetRouteId());
            Route nebraskaseattle = new Route(nebraska.GetAirportId(), washington.GetAirportId(), 1501);
            nebraskaseattle.UploadRoute();
            routeIds.Add(nebraskaseattle.GetRouteId());

            Route nebraskacleveland = new Route(nebraska.GetAirportId(), cleveland.GetAirportId(), 1018);
            nebraskacleveland.UploadRoute();
            routeIds.Add(nebraskacleveland.GetRouteId());
            Route clevelandnebraska = new Route(cleveland.GetAirportId(), nebraska.GetAirportId(), 1018);
            clevelandnebraska.UploadRoute();

            Route nebraskaillinois = new Route(nebraska.GetAirportId(), illinois.GetAirportId(), 633);
            nebraskaillinois.UploadRoute();
            routeIds.Add(nebraskaillinois.GetRouteId());
            Route illinoisnebraska = new Route(illinois.GetAirportId(), nebraska.GetAirportId(), 633);
            illinoisnebraska.UploadRoute();
            routeIds.Add(illinoisnebraska.GetRouteId());

            Route clevelandnewyork = new Route(cleveland.GetAirportId(), newyork.GetAirportId(), 463);
            clevelandnewyork.UploadRoute();
            routeIds.Add(clevelandnewyork.GetRouteId());
            Route newyorkcleveland = new Route(newyork.GetAirportId(), cleveland.GetAirportId(), 463);
            newyorkcleveland.UploadRoute();
            routeIds.Add(newyorkcleveland.GetRouteId());

            Route tennesseemichigan = new Route(tennessee.GetAirportId(), michigan.GetAirportId(), 709);
            tennesseemichigan.UploadRoute();
            routeIds.Add(tennesseemichigan.GetRouteId());
            Route michigantennessee = new Route(michigan.GetAirportId(), tennessee.GetAirportId(), 709);
            michigantennessee.UploadRoute();
            routeIds.Add(michigantennessee.GetRouteId());

            Route clevelandmichigan = new Route(cleveland.GetAirportId(), michigan.GetAirportId(), 369);
            clevelandmichigan.UploadRoute();
            routeIds.Add(clevelandmichigan.GetRouteId());

            Route texascalifornia = new Route(texas.GetAirportId(), california.GetAirportId(), 1406);
            texascalifornia.UploadRoute();
            routeIds.Add(texascalifornia.GetRouteId());

            List<Flight> listOfFlights = new List<Flight>();

            //Upload a fair selection of flights for the next seven months
            foreach(string routeid in routeIds)
            {
                Random rand = new Random();
                DateTime dateTime;
                //Sufficiently randomize the date and hours
                dateTime = DateTime.Now.AddMonths(rand.Next(0, 7)).AddDays(rand.Next(0, 27));
                dateTime.AddHours(rand.Next(0, 23)).AddMinutes(rand.Next(0, 59));
                Flight flight = new Flight(routeid, HLib.GenerateYearWeekID(dateTime), dateTime);
                flight.UploadFlight();
                //Depending on the distance, set the plane appropriately
                if (flight.GetDistance() > 900)
                    flight.SetPlaneForFlight(boeing777.GetAircraftId());
                else if (flight.GetDistance() > 600)
                    flight.SetPlaneForFlight(boeing787.GetAircraftId());
                else flight.SetPlaneForFlight(boeing737.GetAircraftId());

                listOfFlights.Add(flight);
            }

            List<Customer> customerList = new List<Customer>();
            //Create a varied list of customers
            Customer customer1 = new Customer("Bob", "Smith", "237 Berry, Houston, TX", DateTime.Now.AddYears(-22).AddMonths(-2).ToString(), "Password123!", "2203257678", "boberbs@gmail.com");
            customer1.AttemptAccountCreation();
            customerList.Add(customer1);

            Customer customer2 = new Customer("John", "Smith", "255 June Road, Cleveland, OH", DateTime.Now.AddYears(-26).ToString(), "CavsFan88#", "3326471123", "jonnytest@gmail.com");
            customer2.AttemptAccountCreation();
            customerList.Add(customer2);

            Customer customer3 = new Customer("Melissa", "Tost", "95 Amber Ave, Elyria, OH", DateTime.Now.AddYears(-54).AddMonths(-6).ToString(), "StraightOuttaCleveland#46", "1231234567", "melsocool@gmail.com");
            customer3.AttemptAccountCreation();
            customerList.Add(customer3);

            Customer customer4 = new Customer("Nate", "Oakley", "123 Shirley, Elyria, OH", DateTime.Now.AddYears(-52).AddMonths(-9).ToString(), "PlaneFlier22%", "3212345876", "NOp3sta@gmail.com");
            customer4.AttemptAccountCreation();
            customerList.Add(customer4);

            Customer customer5 = new Customer("Kiyle", "Styles", "666 Whirley Ave, Pigeon Forge, Pa", DateTime.Now.AddYears(-29).ToString(), "Kklafsfdv!#", "9876541122", "kiyle.styles@hotmail.com");
            customer5.AttemptAccountCreation();
            customerList.Add(customer5);

            Customer customer6 = new Customer("Trent", "Ward", "999 Bubba Ln, Hershey, PA", DateTime.Now.AddYears(-22).AddMonths(6).ToString(), "ThisIsStupid123%#", "1112223333", "tren.sc@gmail.com");
            customer6.AttemptAccountCreation();
            customerList.Add(customer6);

            Customer customer7 = new Customer("Harry", "Ren", "777 Angel Ln, Los Angeles, CA", DateTime.Now.AddYears(-22).AddMonths(-1).ToString(), "WhyThough234#2", "2221115555", "coolname@gmail.com");
            customer7.AttemptAccountCreation();
            customerList.Add(customer7);

            Customer customer8 = new Customer("Tom", "Wallace", "432 Green road, Nashville, TN", DateTime.Now.AddYears(-22).AddMonths(-3).ToString(), "adgddgdr!$", "7776665555", "tomshardware@hardware.com");
            customer8.AttemptAccountCreation();
            customerList.Add(customer8);

            foreach(Flight flight in listOfFlights)
            {
                Random rand = new Random();
                int customerIndex = rand.Next(0, customerList.Count);
                int purchase = rand.Next(0, 100);

               
                //Customer purchases the ticket (50%)
                if (purchase > 50)
                {
                    AirEase_AMS.App.Ticket.Ticket ticket = new Ticket.Ticket(flight.GetOriginCity(), flight.GetDestinationCity(), customerList[customerIndex].GetUserId().ToString(), false);
                    ticket.AddFlight(flight);
                    ticket.UploadTicket();
                    if (purchase > 90)
                    {
                        ticket.CancelTicket();
                    }
                }

            }

            //Create a varied list of employees
            Accountant acTabitha = new Accountant("Tabitha", "Shelton", "123 Tabby Street, Dallas, TX", DateTime.Now.AddYears(-35).AddMonths(12).ToString(), "SecureShelton$123", "1112223333", "tabitha.shelton@airease.com", "123456789");
            acTabitha.AttemptAccountCreation();
            Accountant acShuyster = new Accountant("Shuyster", "Bill", "123 Ball Ln, Dallas, TX", DateTime.Now.AddYears(-37).AddMonths(11).ToString(), "DFsfs#!32fdf", "2214435654", "shuyster.bill@airease.com", "987654321");
            acShuyster.AttemptAccountCreation();

            FlightManager fmRobert = new FlightManager("Robert", "Robertson", "123 Robby Road, Dallas, TX", DateTime.Now.AddYears(-42).AddMonths(1).ToString(), "PlaneCool@1", "2223334444", "rob.robertson@airease.com", "143456789");
            fmRobert.AttemptAccountCreation();
            FlightManager fmWilliam = new FlightManager("William", "Afton", "123 Purple Street, Dallas, TX", DateTime.Now.AddYears(-39).ToString(), "StressedOut$$12131", "2213149898", "will.afton@airease.com", "222113333");
            fmWilliam.AttemptAccountCreation();

            LoadEngineer leShelby = new LoadEngineer("Shelby", "Willy", "123 Engineer Street, Dallas, TX", DateTime.Now.AddYears(-47).AddMonths(1).ToString(), "R0ut3sWilly", "4445556666", "shelby.willy@airease.com", "323456789");
            leShelby.AttemptAccountCreation();
            LoadEngineer leNathan = new LoadEngineer("Nathan", "Polgram", "123 Rocky Road, Dallas, TX", DateTime.Now.AddYears(-28).AddMonths(4).ToString(), "454dg1sf@sAfwt46%%", "1237650989", "nate.polgram@airease.com", "999661111");
            leNathan.AttemptAccountCreation();

            MarketManager mmPatsy = new MarketManager("Patricia", "Pattinson", "123 Market Road, Dallas, TX", DateTime.Now.AddYears(-26).AddMonths(6).ToString(), "P4tsyP4tt1ns0n", "9991112222", "patsy.pattinson@airease.com", "123456789");
            mmPatsy.AttemptAccountCreation();
            MarketManager mmKate = new MarketManager("Kate", "Tate", " 440 Forest Hill Ln, Dallas, TX", DateTime.Now.AddYears(-26).AddMonths(8).ToString(), "vdg35435!$sAgdg4", "2214436677", "kate.tate@airease.com", "999887777");
            mmKate.AttemptAccountCreation();
        }
    }
}
