using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using GameFramework.Decorator;
using GameFramework.Entities;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Decorator
{
    class Archer : PlayerDecorator
    {
        private Random _rnd;
        public Archer(Position position, string name, string symbol, int attackDamage, int defense, int hp, IPlayer aPlayer) : base(position, name, symbol, attackDamage, defense, hp, aPlayer)
        {
            _rnd = new Random();
        }

        public override int Hit(ICreature enemy)
        {
            if (enemy is Zombie)
            {
                //if enemy is a Zombie double the damage
                return base.Hit(enemy) + _rnd.Next(0,5);
            }
            return base.Hit(enemy);
        }
    }
}
