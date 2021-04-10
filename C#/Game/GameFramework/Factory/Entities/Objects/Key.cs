using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Channels;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Objects
{
    public class Key : WorldObject
    {
        public Key(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }


        public override void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {

            if (Loot)
            {
                creature.HasKey = true;
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
