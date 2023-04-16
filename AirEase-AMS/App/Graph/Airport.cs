using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;

namespace AirEase_AMS.App.Graph;

public class Airport : IGraphNode
{
    private List<IRoute> _departingEdges;
    private List<IRoute> _arrivingEdges;
    private string _city;

    public void AddDeparture(IGraphNode destination, IRoute flight)
    {
        if(!_departingEdges.Contains(flight))
        {
         _departingEdges.Add(flight);
        }
    }
    
    public List<IRoute> ArrivingFlights()
    {
        return _departingEdges;
    }
    
    public List<IRoute> DepartingFlights()
    {
        return _departingEdges;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string GetCityName()
    {
        return _city;
    }

    public List<IRoute>? GetRoutes()
    {
        return _departingEdges;
    }
 


}