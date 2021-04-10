using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Objects
{
    public abstract class Weapon : WorldObject, IWeapons
    {
        public Weapon(Position position, bool loot, string name, string symbol, bool block, bool reusable) : base(position, loot, name, symbol, block, reusable)
        {
        }

        public abstract IPlayer AscendPlayer(IPlayer player);
    }
}