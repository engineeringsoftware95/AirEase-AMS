namespace AirEase_AMS.App.Defs;

public interface IDate
{
    int GetDay();
    int GetMonth();
    int GetYear();

    void SetDay(int day);
    void SetMonth(int month);
    void SetYear(int year);

    bool SameDay(ITime x);
    bool WithinAWeek(ITime x);
    bool WithinNMonths(int n, ITime x);
}