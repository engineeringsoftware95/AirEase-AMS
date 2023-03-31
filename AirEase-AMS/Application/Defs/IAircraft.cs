namespace AirEase_AMS.Application.Defs;

public interface IAircraft
{

    void SetCruisingSpeed();
    void SetModelName();
    void SetFuelCapacity();

    int GetCruisingSpeed();
    string GetModelName();
    int GetFuelCapacity();

}