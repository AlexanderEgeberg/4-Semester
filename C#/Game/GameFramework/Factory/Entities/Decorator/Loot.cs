using System.Collections.Generic;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory.Entities.Decorator
{
    public class Loot : MonsterDecorator
    {
        public Loot(IMonster monster, List<IWorldObject> lootList) : base(monster)
        {
            if (lootList != null)
            {
                foreach (var loot in lootList)
                {
                    LootDropList.Add(loot);
                }
            }
        }
    }
}