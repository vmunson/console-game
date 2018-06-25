using System;

class GreenBeast : Enemy
{

  public override void Attack()
  {
    Random number = new Random();
    AttackPoints = number.Next(5, 16);
  }

}