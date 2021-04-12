using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework
{
    public interface IWorldObject
    {
        public Position Position { get; set; }

        public bool Loot { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }
        public bool Block { get; set; }
        public bool Reusable { get; set; }
        public void Use(ref IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction); }
}