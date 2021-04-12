using System.Collections.Generic;
using GameFramework.Factory.Entities.Objects;

namespace GameFramework.Factory.Entities.Creatures
{
    public interface IPlayer : ICreature
    {
        public bool HasKey { get; set; }
        void Move(InputKey move);
        void Eat(int food);
    }
}