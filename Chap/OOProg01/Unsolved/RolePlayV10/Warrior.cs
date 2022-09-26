
public class Warrior
{
    // Instance Fields
    private string _name;
    private int _level;
    

    public Warrior(string name)
    {
        _name = name;
        _level = 1;
    }

    public string Name
    {
        // Property
        get { return _name; }
    }
    public int Level
    {
        get { return _level; }
    }
    public void UpgradeLevel()
    {
        _level = _level + 1;
    }
}
