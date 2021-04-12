using System.Collections.Generic;

namespace GameFramework.Factory.Entities.Creatures
{
    public interface IMonster : ICreature
    {
        public List<IWorldObject> LootDropList { get; set; }
        void OnDeath(List<IWorldObject> objects);
    }
}