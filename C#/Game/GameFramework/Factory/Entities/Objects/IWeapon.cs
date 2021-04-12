using System;
using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Objects
{
    public interface IWeapon : IWorldObject
    {
        void AscendPlayer(ref IPlayer player);
       // IPlayer Use(IPlayer player);
    }
}