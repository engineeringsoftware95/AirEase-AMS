﻿namespace AirEase_AMS.App.Defs.Struct;

public interface IGraphNode
{

   string GetCityName();
   List<IRoute>? DepartingFlights();
   void AddDeparture(IGraphNode destination, IRoute flight);
   void SetCity(string city);
   string GetAirportId();
}