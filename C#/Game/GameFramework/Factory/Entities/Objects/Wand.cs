using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;
using GameFramework.Factory.Entities.Decorator;

namespace GameFramework.Factory.Entities.Objects
{
    public class Wand : Weapon, IWeapons
    {
        public Wand(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public override IPlayer AscendPlayer(IPlayer player)
        {
            if (player is Mage)
            {
                return new Archmage(player.Position, player.Name, "X", player.AttackDamage, 0, 5, player);

            }
            else
            {
                return player;
            }
        }

        public override void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {
            if (creature is Mage)
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