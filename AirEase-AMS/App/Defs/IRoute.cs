﻿using AirEase_AMS.App.Defs.Struct;
using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Defs;

public interface IRoute
{
    bool FlightExists(IRoute flight);
    double GetDistance();
    IGraphNode Origin();
    int PopulateFlightsOnRoute();
    IGraphNode Destination();
    List<Flight>? FindFlightsInRange(DateTime begin, DateTime end);
    bool IsDestination(string city);
    bool IsOrigin(string city);
    void SetDestination(string destination);
    void SetOrigin(string origin);
    void AddFlight(Flight flight);
    List<Flight> GetFlightsOnRoute();
}