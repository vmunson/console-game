using System;
class Enemy : IGameTurn
{
  private int _healthPoints;
  private int _attackPoints;
  public string WeaponName { get; set; }
  public int HealthPoints
  {
      get { return _healthPoints;}
      set { _healthPoints = value;}
  }
  public int AttackPoints
  {
      get { return _attackPoints;}
      set { _attackPoints = value;}
  }
  
  public void Health(int health, int attack)
  {
    _healthPoints = health - attack;
  }
  public virtual void Attack()
  {
    Random number = new Random();
    _attackPoints = number.Next(1);
  }
}