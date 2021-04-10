using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;
using GameFramework.Factory.Entities.Decorator;

namespace GameFramework.Factory.Entities.Objects
{
    public class Bow : Weapon, IWeapons
    {
        public Bow(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public override IPlayer AscendPlayer(IPlayer player)
        {
            if (player is Ranger)
            {
                return new Archer(player.Position, player.Name, "X", player.AttackDamage, player.Defense, player.HP, player);

            }
            else
            {
                return player;
            }
        }

        public override void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction)
        {
            if (creature is Ranger)
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