using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;
using GameFramework.Factory.Entities.Decorator;

namespace GameFramework.Factory.Entities.Objects
{
    public class Book : WorldObject
    {
        public Book(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public override void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {

            if (Loot)
            {

                if (!Reusable)
                {
                    objList.Remove(this);
                }
                else
                {
                    //gives this new x.y coordinates
                    //testAction.Invoke(this);
                }
            }
        }
    }
}