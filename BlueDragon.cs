using System;

class BlueDragon : Enemy
{
    public string WeaponName { get; set; }

    public override void EnemyAttack()
  {
    Random number = new Random();
    AttackPoints = number.Next(10, 21);
  }

}