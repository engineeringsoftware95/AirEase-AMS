using AirEase_AMS.App.Defs;
using System.Data;

namespace AirEase_AMS.App.Entity.Aircraft;

public class Aircraft : IAircraft, IComparable<Aircraft>
{
    private string _aircraftId { get; set; }
    private string _aircraftName { get; set; }
    private int _numberOfSeats { get; set; }


    public Aircraft(string aircraftId)
    {
        _aircraftId = aircraftId;
        DatabaseAccessObject dao = new DatabaseAccessObject();
        string query = String.Format("SELECT * FROM PLANE WHERE PlaneID = {0};", aircraftId);
        System.Data.DataTable dt = dao.Retrieve(query);
        if (dt == null || dt.Rows.Count != 1)
        {
            _aircraftId = "-1";
            _aircraftName= "";
            _numberOfSeats = -1;
        }
        else
        {
            DataRow aircraft = dt.Rows[0];
            _aircraftName = aircraft["Aircraft"].ToString() ?? "";
            _numberOfSeats = int.Parse(aircraft["NumberOfSeats"].ToString() ?? "-1");
        }
    }

    public Aircraft(string aircraftName, int numberOfSeats)
    {
        _aircraftId = HLib.GenerateSixDigitId().ToString();
        _aircraftName = aircraftName;
        _numberOfSeats = numberOfSeats;
    }

    /// <summary>
    /// Attempts to upload the current rendition of this class to the database.
    /// </summary>
    /// <returns>Whether or not the function succeeded.</returns>
    public bool UploadAircraft()
    {
        string query = String.Format("INSERT INTO PLANE VALUES({0}, '{1}', {2});", _aircraftId, _aircraftName, _numberOfSeats);
        DatabaseAccessObject dao = new DatabaseAccessObject();
        return (dao.Update(query) == 1);
    }
    public void SetCruisingSpeed()
    {
        throw new NotImplementedException();
    }

    public void SetModelName()
    {
        throw new NotImplementedException();
    }

    public void SetFuelCapacity()
    {
        throw new NotImplementedException();
    }

    public int GetCruisingSpeed()
    {
        throw new NotImplementedException();
    }

    public string GetModelName()
    {
        return _aircraftName;
    }

    public int GetNumberOfSeats()
    {
        return _numberOfSeats;
    }

    public int GetFuelCapacity()
    {
        throw new NotImplementedException();
    }
    
    public int CompareTo(Aircraft? other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        return String.Compare(GetModelName(), other.GetModelName(), StringComparison.Ordinal);
    }
    
    public string GetAircraftId() { return _aircraftId;  }
}