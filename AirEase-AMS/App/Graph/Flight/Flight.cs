using AirEase_AMS.App.Entity.Aircraft;

namespace AirEase_AMS.App.Graph.Flight;

public class Flight : Route, IEquatable<Flight>
{
    private readonly DateTime _flightTime;
    private readonly Aircraft _aircraft;
    
    public DateTime GetTime()
    {
        return _flightTime;
    }
    
public bool Equals(Flight? other)
    {
        if (ReferenceEquals(null, other)) return false;
        if (ReferenceEquals(this, other)) return true;
        return    _flightTime.Equals(other._flightTime)
               && _aircraft.Equals(other._aircraft)
               && Origin().Equals(other.Origin())
               && Destination().Equals(other.Destination());
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Flight)obj);
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(_flightTime, _aircraft);
    }


}