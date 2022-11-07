public class Wand : Weapon
{
    public const int InitialWandMinDamage = 10;
    public const int InitialWandMaxDamage = 30;

    #region Instance fields
    private bool _isEnchanted;
    #endregion

    #region Constructor
    public Wand(string description) : base(description, InitialWandMinDamage, InitialWandMaxDamage)
    {
        _isEnchanted = false;
    }
    #endregion

    #region Properties
    public bool IsEnchanted
    {
        get { return _isEnchanted; }
        set { _isEnchanted = value; }
    }
    #endregion

    #region Methods
    public int DamageFromWand()
    {
        return CalculateDamage() * (IsEnchanted ? 2 : 1);
    }
    #endregion
}
