using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Objects
{
    public abstract class Weapon : WorldObject, IWeapon
    {
        public Weapon(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public abstract void AscendPlayer(ref IPlayer player);

        //Hoped I could change the Use function for Weapon classes 
        //public abstract IPlayer Use(IPlayer player);
    }
}