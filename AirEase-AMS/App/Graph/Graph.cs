using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;

namespace AirEase_AMS.App.Graph;

public class Graph : IGraph
{
    private List<IGraphNode> _airports;
    
    public void AddNode(IGraphNode node)
    {
        if (!_airports.Contains(node))
        {
            _airports.Add(node);
        }
    }

    public void SetEdge(IGraphNode origin, IGraphNode destination, IRoute flight)
    {
        if (origin.DepartingFlights().Contains(flight)) return;
        origin.DepartingFlights().Add(flight);
        if (_airports.Contains(destination))
        {
            AddNode(destination);
        }
    }

    public List<ITicket> CreateSortedTicketList(IGraphNode origin, IGraphNode destination, string date, string flightTime, bool sortByTime)
    {
        throw new NotImplementedException();
    }
}