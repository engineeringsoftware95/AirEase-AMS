namespace AirEase_AMS.App.Defs;

public interface IAircraft
{

    void SetCruisingSpeed(int speed);
    void SetModelName(string name);
    void SetFuelCapacity(int capacity);
    void SetNumberOfSeats(int seats);

    int GetCruisingSpeed();
    string GetModelName();
    int GetFuelCapacity();
    int GetNumberOfSeats();
}