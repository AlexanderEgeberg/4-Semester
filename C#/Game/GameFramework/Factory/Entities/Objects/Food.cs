using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework
{
    public class Food : WorldObject
    {
        public int Value { get; set; }

        public Food(Position position, bool loot, string name, string symbol, bool block, bool reusable, int value) : base(position, loot, name, symbol, block, reusable)
        {
            Value = value;
        }
        public override void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {

            if (Loot)
            {
                creature.Eat(Value);
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
