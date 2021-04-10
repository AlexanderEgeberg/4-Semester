using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using GameFramework.Factory.Entities.Creatures;
using GameFramework.Factory.Entities.Objects;

namespace GameFramework
{
    public abstract class Player : Creature, IPlayer
    {
        public bool HasKey { get; set; }
        protected Player(Position position, string name, string symbol, int attackDamage, int defense, int hp) : base(position, name, symbol, attackDamage, defense, hp)
        {
        }

        public void Move(InputKey move)
        {
            switch (move)
            {
                case InputKey.FORWARD:
                    Position.Row--;
                    break;
                case InputKey.BACK:
                    Position.Row++;
                    break;
                case InputKey.RIGHT:
                    Position.Col++;
                    break;
                case InputKey.LEFT:
                    Position.Col--;
                    break;
            }
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
    }
}
