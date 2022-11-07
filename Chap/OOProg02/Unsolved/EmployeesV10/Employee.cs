#region Instance Fields
public class Employee
{
    protected string _name;
    protected int _hoursPerWeek;

    #endregion
    #region Constructor
    public Employee(string name, int hoursPerWeek)
    {
        _name = name;
        _hoursPerWeek = hoursPerWeek;
    }


    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int HoursPerWeek
    {
        get { return _hoursPerWeek; }
        set { _hoursPerWeek = value; }
    }
}
#endregion