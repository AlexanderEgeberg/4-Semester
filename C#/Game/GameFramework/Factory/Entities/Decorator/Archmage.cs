using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using GameFramework.Decorator;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Decorator
{
    public class Archmage : PlayerDecorator
    {
        public Archmage(IPlayer aPlayer) : base(aPlayer)
        {
            this.Symbol = "X";
        }

        public override int Hit(ICreature enemy)
        {

            if (enemy is Dragon)
            {
                //if enemy is a Zombie double the damage
                return base.Hit(enemy) * 2;
            }
            return base.Hit(enemy);
        }
    }
}
