using System;
class Enemy
{
  private int _healthPoints;
  private int _attackPoints;
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
  
  public void EnemyHealth(int health, int attack)
  {
    _healthPoints = health - attack;
  }
  public virtual void EnemyAttack()
  {
    Random number = new Random();
    _attackPoints = number.Next(1);
  }
}