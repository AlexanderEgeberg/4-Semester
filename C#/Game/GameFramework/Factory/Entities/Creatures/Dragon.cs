using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Factory.Entities.Creatures
{
    class Dragon : Monster
    {
        public Dragon(Position position, string name, string symbol, int attackDamage, int defense, int hp) : base(position, name, symbol, attackDamage, defense, hp)
        {
        }
    }
}
