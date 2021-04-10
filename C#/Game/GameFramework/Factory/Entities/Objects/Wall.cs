using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Objects
{
    public class Wall : WorldObject
    {
        public Wall(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public override void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {
            //Console.WriteLine("Secret wall");

        }
    }
}
