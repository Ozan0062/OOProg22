public class ITSupporter : Employee
{
    private string _name;
    private int _hoursPerWeek;
    private string _primaryWorkArea;

    public ITSupporter(string name, int hoursPerWeek, string primaryWorkArea)
        : base(name, hoursPerWeek)
    {
        _primaryWorkArea = primaryWorkArea;
    }

    public string PrimaryWorkArea
    {
        get { return _primaryWorkArea; }
        set { _primaryWorkArea = value; }
    }

    public string AllInformation
    {
        get
        {
            return $"IT-Supporter {Name} works {HoursPerWeek} hours/week, mostly with {PrimaryWorkArea}";
        }
    }
}