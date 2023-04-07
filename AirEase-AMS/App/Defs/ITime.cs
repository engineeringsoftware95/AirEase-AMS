namespace AirEase_AMS.App.Defs;

public interface ITime
{
    void SetHour(int hour);
    void SetMinute(int min);

    int GetHour();
    int GetMinute();

    bool IsWithinNMinutes(int n, ITime x);
    bool IsWithinNHours(int n, ITime x);
    bool IsEqual(ITime x, ITime y);

}