using System;
class Enemy
{
  // private int _healthPoints;
  private int _attackPoints;
  public string WeaponName { get; set; }
  public int HealthPoints
  {
      get ;
      set ;
  }
  public int AttackPoints
  {
      get { return _attackPoints;}
      set { _attackPoints = value;}
  }
  
  public void EnemyHealth(int health, int attack)
  {
    HealthPoints = health - attack;
  }
  public virtual void EnemyAttack()
  {
    Random number = new Random();
    _attackPoints = number.Next(1);
  }
}