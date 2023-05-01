using System.ComponentModel;
using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;
using AirEase_AMS.App.Graph.Flight;
using Microsoft.IdentityModel.Tokens;

// ReSharper disable All
namespace AirEase_AMS.App.Graph;

public class Graph : IGraph
{
    private List<IGraphNode>? _airports;

    public Graph()
    {
        _airports = new List<IGraphNode>();
    }

    public void add_node(Airport airport)
    {
        _airports?.Add(airport);
    }



    public List<List<IRoute>> FindRoutes(string origin, string destination)
    {
        List<List<IRoute>>? master_list = new List<List<IRoute>>();
        if (_airports != null)
        {
            // find origin:
            Airport orig_airport = GetAirport(origin);

            if (orig_airport != null)
            {
                List<IRoute> dir_flights = new List<IRoute>();
                List<Airport> not_dest = new List<Airport>();
                foreach (Route r in orig_airport.DepartingFlights())
                {
                    if (r.GetDestinationCity() == destination)
                    {
                        dir_flights.Add(r);
                        break;
                    }
                    else
                    {
                        not_dest.Add(GetAirport(r.GetDestinationCity()));
                    }
                }

                master_list.Add(dir_flights);
                // find layovers depth 1
                List<IRoute>
                    layover_depth1 = new List<IRoute>(); // init two lists for layovers. depth 1 for 1-stop flights
                List<IRoute> layover_depth2 = new List<IRoute>(); // depth 2 for 2-stop.
                foreach (Airport airport in
                         not_dest) // for each airport which is not the destination, it could be a layover stop.
                {
                    if (airport.GetCityName() == orig_airport.GetCityName()) continue;
                    // so initialize the route which connects the origin city (start point) and the potential layover
                    Route start_route = new Route(); 
                    foreach (Route d in orig_airport.DepartingFlights()) // find the start route
                    {
                        if (d.GetDestinationCity() == airport.GetCityName())
                        {
                            start_route = d; // result: origin city -> airport.
                            break;
                        }
                    }

                    Route destination_city = new Route();
                    List<IRoute> notLayover = new List<IRoute>();
                    foreach (Route k in airport.DepartingFlights()) // now, for each route in the potential layover spot's departures
                    {// if the final destination is the destination of the route k, then we don't need to look for further layovers.
                        if (k == destination_city) continue; 
                        if (k.GetDestinationCity() == destination && destination != orig_airport.GetCityName()) // if it conencts to the destination,
                        {
                            destination_city = k;
                            layover_depth1.Add(start_route); // add the first leg
                            layover_depth1.Add(k); // add the second leg.
                        }
                    }
                    foreach (Route L in airport.DepartingFlights()) // now, for each route in the potential layover spot's departures
                    {
                        foreach (Route r in L.Destination().DepartingFlights())
                        {
                            if (r.GetDestinationCity() == destination)
                            {
                                layover_depth1.Add(start_route); // add the first leg
                                layover_depth1.Add(L); // add the second leg.
                                layover_depth2.Add(r);// add the last
                            }
                        }
                    }
                }
                master_list.Add(layover_depth1);
                master_list.Add(layover_depth2);
            }
        }
        return master_list;
    }
    public Airport GetAirport(string city)
    {
        Airport orig_airport = new Airport();

        foreach (Airport airport in _airports)
        {
            if (airport.GetCityName() == city)
            {
                return airport;
            }
        }

        return null;
    }

    public List<List<Flight.Flight>> GetFlightsInRange(string origin, string destination, DateTime begin,
        DateTime end)
    {
        List<List<Flight.Flight>> foundFlights = new List<List<Flight.Flight>>();
        List<Flight.Flight> flightList = new List<Flight.Flight>();
        List<List<IRoute>> allRoutes = new List<List<IRoute>>();
        allRoutes = FindRoutes(origin, destination);

        foreach (List<IRoute> route in allRoutes)
        {
            foreach (Route r in route)
            {
                foreach (Flight.Flight flight in r.FindFlightsInRange(begin, end))
                {
                    flightList.Add(flight);
                }
            }
        }
        return foundFlights;
    }



    public void GraphInit()
    {
        _airports = HLib.SelectAllAirports();
        foreach (Airport airport in _airports)
        {
            airport.PopulateEdges();
            foreach (IRoute route in airport.DepartingFlights())
            {
                route.PopulateFlightsOnRoute();
            }
        }
        
    }
    
    
}