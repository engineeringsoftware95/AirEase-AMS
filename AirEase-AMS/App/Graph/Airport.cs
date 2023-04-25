using AirEase_AMS.App.Defs;
using AirEase_AMS.App.Defs.Struct;
using System.Data;
using System.Diagnostics;

namespace AirEase_AMS.App.Graph;

public class Airport : IGraphNode
{
    private List<IRoute> _departingEdges;
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
        {//TODO: statement or branch uncovered
            DataRow airport = dt.Rows[0];                       //TODO: statement uncovered - needs test  
            _city = airport["City"].ToString() ?? "";           //TODO: statement uncovered - needs test  
            _airportName = airport["Airport"].ToString() ?? ""; //TODO: statement uncovered - needs test  
            _airportId = airportId;                             //TODO: statement uncovered - needs test  
        }
        _departingEdges = new List<IRoute>();
    }

    public Airport(string city, string airportName)//TODO: statement uncovered - needs test  
    {//TODO: statement or branch uncovered
        _departingEdges = new List<IRoute>();//TODO: statement uncovered - needs test  
        _city = city;                        //TODO: statement uncovered - needs test  
        _airportId = GenerateId();           //TODO: statement uncovered - needs test  
        _airportName = DatabaseAccessObject.SanitizeString(airportName);          //TODO: statement uncovered - needs test  
    }

    public Airport()
    {
        _departingEdges = new List<IRoute>();
        _airportId = GenerateId();
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
        while (dao.Retrieve("SELECT * FROM AIRPORT WHERE AirportID=" + _airportId + ";").Rows.Count > 0)
        {
            //Set ID until one is unique
            _airportId = (GenerateId());
        }

        string query = String.Format("INSERT INTO AIRPORT VALUES({0}, '{1}', '{2}');", _airportId, _city, _airportName);
        return (dao.Update(query) >= 1);
    }

    public void AddDeparture(IGraphNode destination, IRoute flight)
    {
        if(!_departingEdges.Contains(flight))
        {
         _departingEdges.Add(flight);
        }
    }
    
    public List<IRoute>? DepartingFlights()
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

    public string GetAirportName() { return _airportName; }
    
    
}