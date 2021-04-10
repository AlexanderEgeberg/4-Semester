using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework
{
    public abstract class WorldObject : IWorldObject
    {

        public Position Position { get; set; }

        public bool Loot { get; set; }
        public string Name { get; set; }

        public string Symbol { get; set; }
        public bool Block { get; set; }

        public bool Reusable { get; set; }

        protected WorldObject(Position position, bool loot, string name, string symbol, bool block, bool reusable) 
        {
            Position = position;
            Loot = loot;
            Name = name;
            Symbol = symbol;
            Block = block;
            Reusable = reusable;
        }

        public abstract void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction);
    }

}