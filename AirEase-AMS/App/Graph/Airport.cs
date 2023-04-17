using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;
using System.Data;
using System.Diagnostics;

namespace AirEase_AMS.App.Graph;

public class Airport : IGraphNode
{
    private List<IRoute> _departingEdges;
    private List<IRoute> _arrivingEdges;
    private string _city;
    private string _airportId;
    private string _airportName;    

    /// <summary>
    /// Uses the key airportId to get set this class to some instance from the database with an identical key.
    /// </summary>
    /// <param name="airportId">The key used to set the class.</param>
    public Airport(string airportId) 
    {
        string query = String.Format("SELECT * FROM AIRPORT WHERE AirportID = {0}", airportId);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        System.Data.DataTable dt = dao.Retrieve(query);

        if(dt == null || dt.Rows.Count != 1)
        {
            _city = "";
            _airportId = "-1";
            _airportName = "";
        }
        else
        {
            DataRow airport = dt.Rows[0];
            _city = airport["City"].ToString() ?? "";
            _airportName = airport["Airport"].ToString() ?? "";
            _airportId = airportId;
        }
        _departingEdges = new List<IRoute>();
        _arrivingEdges = new List<IRoute>();
    }

    public Airport(string city, string airportName)
    {
        _departingEdges = new List<IRoute>();
        _arrivingEdges = new List<IRoute>();
        _city = city;
        _airportId = GenerateId();
        _airportName = airportName;
    }

    protected string GenerateId()
    {
        return HLib.GenerateSixDigitId().ToString();
    }

    public string GetAirportId()
    {
        return _airportId;
    }


    /// <summary>
    /// Attempts to upload the current rendition of this class to the database.
    /// </summary>
    /// <returns>Returns whether or not the function succeeded.</returns>
    public bool UploadAirport()
    {
        DatabaseAccessObject dao = new DatabaseAccessObject();
        //While the ID isn't unique, make a new one.
        _airportId = (GenerateId());
        while (dao.Retrieve("SELECT * FROM AIRPORT WHERE UserID=" + _airportId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _airportId = (GenerateId());
        }
        string query = String.Format("INSERT INTO AIRPORT VALUES({0}, {1}, {2})", _airportId, _city, _airportName);
        return (dao.Update(query) == 1);
    }

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