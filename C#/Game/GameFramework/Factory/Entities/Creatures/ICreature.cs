using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework
{
    public interface ICreature: ICreatureObserver
    {
        public int HP { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public int AttackDamage { get; set; }
        public int Defense { get; set; }

        public Position Position { get; set; }

        int Hit(ICreature enemy);
        void ReceiveHit(int damage);
        bool IsAlive();
    }
}
