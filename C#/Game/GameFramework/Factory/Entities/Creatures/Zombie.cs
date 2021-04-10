using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Entities
{
    public class Zombie : Monster
    {
        public Zombie(Position position, string name, string symbol, int attackDamage, int defense, int hp) : base(position, name, symbol, attackDamage, defense, hp)
        {
        }
    }
}
