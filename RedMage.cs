using System;

class RedMage : Enemy
{
  public override void Attack()
  {
    Random number = new Random();
    AttackPoints = number.Next(11);
  }

}