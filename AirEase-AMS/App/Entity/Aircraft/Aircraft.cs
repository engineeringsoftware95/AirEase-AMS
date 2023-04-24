using AirEase_AMS.App.Defs;
using System.Data;

namespace AirEase_AMS.App.Entity.Aircraft;

public class Aircraft : IAircraft, IComparable<Aircraft>
{
    public Aircraft()
    {
    }

    private string _aircraftId;
    private string _modelName;
    private int _numberOfSeats;
    private int _cruisingSpeed;
    private int _fuelCapacity;


    public Aircraft(string aircraftId) //TODO: statement or branch uncovered
    {
        _aircraftId = aircraftId;
        DatabaseAccessObject dao = new DatabaseAccessObject();
        string query = String.Format("SELECT * FROM PLANE WHERE PlaneID = {0};", aircraftId);
        System.Data.DataTable dt = dao.Retrieve(query);

        
        if (dt == null || dt.Rows.Count != 1)
        {
            _aircraftId = "-1";
            _modelName= "";
            _numberOfSeats = -1;
        }
        else //TODO: statement or branch uncovered
        {
            DataRow aircraft = dt.Rows[0]; //TODO: statement uncovered - needs test  
            _modelName = aircraft["Aircraft"].ToString() ?? "";
            _numberOfSeats = int.Parse(aircraft["NumberOfSeats"].ToString() ?? "-1");
        }
    }

    public Aircraft(string modelName, int numberOfSeats) //TODO: statement or branch uncovered
    {
        _aircraftId = HLib.GenerateSixDigitId().ToString();
        _modelName = modelName;
        _numberOfSeats = numberOfSeats;
    }

    /// <summary>
    /// Attempts to upload the current rendition of this class to the database.
    /// </summary>
    /// <returns>Whether or not the function succeeded.</returns>
    public bool UploadAircraft() //TODO: statement or branch uncovered
    {
        string query = String.Format("INSERT INTO PLANE VALUES({0}, '{1}', {2});", _aircraftId, _modelName, _numberOfSeats);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        return (dao.Update(query) == 1);
    }
    public void SetAircraftId(string aircraftId)
    {
        _aircraftId = aircraftId;
    }

    public void SetCruisingSpeed(int speed)
    {
        _cruisingSpeed = speed;
    }

    public void SetModelName(String name)
    {
        _modelName = name;
    }

    public void SetFuelCapacity(int cap)
    {
        _fuelCapacity = cap;
    }

    public void SetNumberOfSeats(int seats)
    {
        _numberOfSeats = seats;
    }

    public int GetCruisingSpeed()
    {
        return _cruisingSpeed;
    }

    public string GetModelName()
    {
        return _modelName;
    }

    public int GetNumberOfSeats()
    {
        return _numberOfSeats;
    }

    public int GetFuelCapacity()
    {
        return _fuelCapacity;
    }
    
    public int CompareTo(Aircraft? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return String.Compare(GetModelName(), other.GetModelName(), StringComparison.Ordinal);
    }
    
    public string GetAircraftId() { return _aircraftId;  }
}