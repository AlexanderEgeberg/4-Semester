using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameFramework;
using GameFramework.Entities;
using GameFramework.Enum;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory
{
    public static class CreatureFactory
    {
        public static ICreature GetCreature(CreatureType type, Position position, int hp, string name, string symbol,int attackDamage, int defense)
        {
            //TODO implement creature level,attack, and defense
            //TODO attack and defense based on level

            switch (type)
            {
                case CreatureType.Zombie: return new Zombie(position, GetRandomName(),symbol,attackDamage,defense,hp);
                case CreatureType.Mage: return new Mage(position, name, symbol, attackDamage, defense,hp);
            }

            return null;
        }

        static string GetRandomName()
        {
            List<string> Names = new List<string>()
            {
                "Walker",
                "Lurker",
                "Biter",
                "Roamer",
                "Infected",
            };
            return Names.OrderBy(s => Guid.NewGuid()).First(); ;
        }
    }
}
