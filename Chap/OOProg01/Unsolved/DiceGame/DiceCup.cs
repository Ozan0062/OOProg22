﻿/// <summary>
/// This class represents a dice cup containing two dice.
/// </summary>
public class DiceCup
{
    #region Instance fields
    private Die _die1;
    private Die _die2;
    private Die _die3;
    private int _totalValue;
    #endregion

    #region Constructor
    public DiceCup()
    {
        _die1 = new Die();
        _die2 = new Die();
        _die3 = new Die();
    }
    #endregion

    // Implement a property TotalValue: the sum of 
    // the face values of the dice in the cup
    //
    public int TotalValue 
    {
        get { return _totalValue; }
    }
        

// Implement a method Shake: all the dice in the cup should be rolled
//
public void Shake()
    {
  _totalValue = RandomNumberGenerator.Generate(1, 18);

    }
}
