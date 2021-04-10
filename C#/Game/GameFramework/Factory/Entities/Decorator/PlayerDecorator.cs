using System;
using System.Runtime.CompilerServices;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Decorator
{
    public abstract class PlayerDecorator : Creature, IPlayer
    {
        private IPlayer Player;

        protected PlayerDecorator(Position position, string name, string symbol, int attackDamage, int defense, int hp,
            IPlayer aPlayer)
            : base(position, name, symbol, attackDamage, defense, hp)
        {
            this.Player = aPlayer;
        }

        public bool HasKey
        {
            get => Player.HasKey;
            set => Player.HasKey = value;
        }

        public void Eat(int food)
        {
            this.HP += food;
        }

        public bool Fight(ICreature enemy)
        {
            do
            {
                if (this.IsAlive())
                {
                    enemy.ReceiveHit(this.Hit(enemy));
                }

                if (enemy.IsAlive())
                {
                    this.ReceiveHit(this.Hit(enemy));
                }
            } while (this.IsAlive() && enemy.IsAlive());

            if (this.IsAlive())
            {
                return true;
            }
            if (enemy.IsAlive())
            {
                Console.WriteLine("You died");
                return false;
            }

            return true;
        }

        public virtual int Hit(ICreature enemy)
        {
            return this.Player.Hit(enemy);
        }

        public void Move(InputKey move)
        {
            Player.Move(move);
        }
    }
}