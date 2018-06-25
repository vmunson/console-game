using System;
class Player : IGameTurn
{
  private string _playerName;
  private int _attackPoints;
  private int _healthPoints;
  public string PlayerName
  {
      get { return _playerName;}
      set 
      { 
        if (string.IsNullOrWhiteSpace(value)) {
          throw new ArgumentException("Name can not be empty");
        }
        else
        {
          _playerName = value.Trim();
        }
      }
  }
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

  public bool Heal { get; set; }
  
  public void Health(int health, int attack)
  {
    _healthPoints = health - attack;
  }
  
  public void Attack()
  {
    Random number = new Random();
    _attackPoints = number.Next(26);
  }

  public void PlayerHeal()
  {
    Random number = new Random();
    _healthPoints += number.Next(26);
    Heal = false;
  }
}