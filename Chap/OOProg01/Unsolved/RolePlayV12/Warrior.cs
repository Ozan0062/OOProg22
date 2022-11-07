
public class Warrior
{
    #region Instance fields
    private string _name;
    private int _hitPoints;
    private int _maxDamage;
    private int _minDamage;
    private Sword _sword;
    #endregion

    #region Constructor
    public Warrior(string name, int hitPoints, int maxDamage, Sword sword)
    {
        _name = name;
        _hitPoints = hitPoints;
        _maxDamage = maxDamage;
        _minDamage = _maxDamage / 4;
        _sword = sword;
    }
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
    }

    public int HitPoints
    {
        get { return _hitPoints; }
    }

    public bool Dead
    {
        get { return _hitPoints <= 0; }
    }


    #endregion

    #region Methods
    public void ReceiveDamage(int points)
    {
        _hitPoints = _hitPoints - points;
    }

    public int DealDamage()
    {
        return _sword.DealDamage();
    }

    public string GetInfo()
    {
        return $"{Name} has {HitPoints} hit points ({(Dead ? "dead" : "alive")})";
    }
    #endregion
}
