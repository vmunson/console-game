using System;

class GreenBeast : Enemy
{
    public string WeaponName { get; set; }

    public override void EnemyAttack()
  {
    Random number = new Random();
    AttackPoints = number.Next(5, 16);
  }

}