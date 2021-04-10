﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using GameFramework.Decorator;
using GameFramework.Entities;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Decorator
{
    public class Archmage : PlayerDecorator
    {
        public Archmage(Position position, string name, string symbol, int attackDamage, int defense, int hp, IPlayer aPlayer) : base(position, name, symbol, attackDamage, defense, hp, aPlayer)
        {
        }

        public override int Hit(ICreature enemy)
        {
            if (enemy is Zombie)
            {
                //if enemy is a Zombie double the damage
                return base.Hit(enemy) * 2;
            }
            return base.Hit(enemy);
        }
    }
}