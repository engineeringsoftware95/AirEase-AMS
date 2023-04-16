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
        string query = String.Format("SELECT * FROM PLANE WHERE PlaneID = {0};");
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
        throw new NotImplementedException();
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
    
}