using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using GameFramework.Decorator;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Decorator
{
    class Archer : PlayerDecorator
    {
        private Random _rnd;

        public Archer(IPlayer aPlayer) : base(aPlayer)
        {
            _rnd = new Random();
        }
        public override int Hit(ICreature enemy)
        {
            return base.Hit(enemy) * _rnd.Next(1,10);
        }

    }
}
