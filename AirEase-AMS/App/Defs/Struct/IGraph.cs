namespace AirEase_AMS.App.Defs.Struct;

public interface IGraph
{
    void AddNode(IGraphNode node);
    void SetEdge(IGraphNode x, IGraphNode y, IRoute flight);

    List<ITicket> CreateSortedTicketList(IGraphNode origin, IGraphNode destination, string date, string flightTime,
        bool sortByTime);

}