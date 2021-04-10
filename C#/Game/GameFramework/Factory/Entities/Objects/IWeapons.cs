using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Objects
{
    public interface IWeapons
    {
        IPlayer AscendPlayer(IPlayer player);
        void Use(IPlayer creature, List<IWorldObject> objList, Action<IWorldObject> testAction);
    }
}