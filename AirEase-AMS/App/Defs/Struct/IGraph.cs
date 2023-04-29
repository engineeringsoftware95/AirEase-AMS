using AirEase_AMS.App.Graph.Flight;

namespace AirEase_AMS.App.Defs.Struct;

public interface IGraph
{ List<List<IRoute>> FindRoutes(string origin, string destination);

    List<List<Flight>>  GetFlightsInRange(string origin, string destination, DateTime begin,
        DateTime end);

}