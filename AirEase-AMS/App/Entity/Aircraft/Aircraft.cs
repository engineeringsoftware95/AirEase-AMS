using AirEase_AMS.App.Defs;

namespace AirEase_AMS.App.Entity.Aircraft;

public class Aircraft : IAircraft, IComparable<Aircraft>
{
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