
public class Warrior
{
    #region Instance fields
    private string _name;
    private int _level;
    private int _hitPoint;
    private int _dealdamage;

   
    #endregion

    #region Constructor
    public Warrior(string name, int hitPoint, int dealdamage)
    {
        _name = name;
        _level = 1;
        _hitPoint = hitPoint;
        _dealdamage = dealdamage;
    }

  
    #endregion

    #region Properties
    public string Name
    {
        get { return _name; }
    }

    public int Level
    {
        get { return _level; }
    }
    public int HitPoint
    {
        get { return _hitPoint; }
    }
    public int DealDamage
    {
        get { return _dealdamage; }
    }

    public bool Dead
    {
        get { return _hitPoint <= 0; }
    }
    #endregion

    #region Methods
    public void LevelUp()
    {
        _level = _level + 1;
    }

    public void Damage(int point)
    {
        _hitPoint -= point;
    }

    public void Dealdamage()
    {
        _dealdamage = RandomNumberGenerator.Generate(10, 30);
    }

    #endregion

}
