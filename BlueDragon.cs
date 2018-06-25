using System;

class BlueDragon : Enemy
{
  public override void Attack()
  {
    Random number = new Random();
    AttackPoints = number.Next(10, 21);
  }

}