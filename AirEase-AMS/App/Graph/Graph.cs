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
                    Route
                        start_route =
                            new Route(); // so initialize the route which connects the origin city (start point) and the potential layover spot.
                    foreach (Route d in orig_airport.DepartingFlights()) // find the start route
                    {
                        if (d.GetDestinationCity() == airport.GetCityName())
                        {
                            start_route = d;
                            break;
                        }
                    }

                    foreach (Route k in
                             airport
                                 .DepartingFlights()) // now, for each route in the potential layover spot's departures
                    {
                        if (k.GetDestinationCity() == destination) // if it conencts to the destination,
                        {
                            layover_depth1.Add(start_route); // add the first leg
                            layover_depth1.Add(k); // add the second leg.
                        }

                        if (k.GetDestinationCity() == destination)
                            continue; // if the final destination is the destination of the route k, then we don't need to look for further layovers.

                        Airport
                            lo2 = GetAirport(k
                                .GetDestinationCity()); // similarly, the airport could also have a flight to another layover spot
                        foreach (Route layover in
                                 lo2.DepartingFlights()) // so get the destination airport and check its departures.
                        {
                            if (layover.GetDestinationCity() ==
                                destination) // if the departuring route from the airport located is:  Origin -> (potential layover) -> (potential layover) -> destination
                            {
                                layover_depth2.Add(start_route); // add the first leg (origin -> layover1)
                                layover_depth2.Add(k); // add the second leg (layover1 -> layover 2)
                                layover_depth2.Add(layover); // add the third leg (layover 2 -> desetination
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
}