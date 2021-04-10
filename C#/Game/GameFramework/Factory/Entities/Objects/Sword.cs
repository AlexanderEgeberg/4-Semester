using System;
using System.Collections.Generic;
using GameFramework.Decorator;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Objects
{
    public class Sword : Weapon
    {
        public Sword(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public override IPlayer AscendPlayer(IPlayer player)
        {
            if (player is Fighter)
            {
                return new Warrior(player.Position, player.Name, "X", player.AttackDamage, 3,  player.HP+5, player);

            }
            else
            {
                return player;
            }
        }

        public override void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {
            if (creature is Fighter)
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