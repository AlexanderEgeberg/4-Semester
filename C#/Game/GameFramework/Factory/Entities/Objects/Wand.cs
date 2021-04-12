using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;
using GameFramework.Factory.Entities.Decorator;

namespace GameFramework.Factory.Entities.Objects
{
    public class Wand : Weapon
    {
        public Wand(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public override void AscendPlayer(ref IPlayer player)
        {
            if (player is Mage)
            {
                player = new Archmage(player);
            }

        }

        public override void Use(ref IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {
            if (creature is Archmage)
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

            //Console.WriteLine("You're not a Mage");
        }
    }
}