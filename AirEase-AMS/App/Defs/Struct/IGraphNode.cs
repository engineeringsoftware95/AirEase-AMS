namespace AirEase_AMS.App.Defs.Struct;

public interface IGraphNode
{
    List<IRoute> DepartingFlights();
    void PopulateNode(string city);
}