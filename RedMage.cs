using System;

class RedMage : Enemy
{
    public string WeaponName { get; set; }

    public override void EnemyAttack()
  {
    Random number = new Random();
    AttackPoints = number.Next(11);
  }

}