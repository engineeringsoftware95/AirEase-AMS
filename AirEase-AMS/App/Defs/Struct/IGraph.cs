﻿using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Defs.Struct;

public interface IGraph
{
    IRoute? FindFlight(string origin, string destination);

    List<Flight>? GetFlightsInRange(string origin, string destination, DateTime begin,
        DateTime end);

}