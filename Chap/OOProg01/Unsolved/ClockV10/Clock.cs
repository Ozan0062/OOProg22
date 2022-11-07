
using System.Data;

public class Clock
{
    private int _hours;
    private int _minutes;

public Clock(int hours, int minutes)
{
        SetTime(hours, minutes);
}

    private void Hours()
    {
        _hours = 24;
    }

    private void Minutes()
    {
        _minutes = 60;
    }

    public int hours
{
    get { return _hours; }

}
    public int minutes
    {

        get { return _minutes; }    

    }



