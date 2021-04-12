using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameFramework;
using GameFramework.Config;
using GameFramework.Enum;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Factory
{
    public static class CreatureFactory
    {
        static List<string> names = CreatureConfig.LoadJson();

        public static IMonster GetCreature(CreatureType type, Position position, int hp, string name, string symbol,int attackDamage, int defense)
        {
            //TODO implement creature level,attack, and defense
            //TODO attack and defense based on level

            switch (type)
            {
                case CreatureType.Zombie: return new Zombie(position, GetRandomName(names),symbol,attackDamage,defense,hp);
                case CreatureType.Dragon: return new Dragon(position, name, symbol, attackDamage, defense, hp);

            }

            return null;
        }
        public static IMonster GetCreature(CreatureType type, Position position, int hp, string symbol, int attackDamage, int defense)
        {
            //TODO implement creature level,attack, and defense
            //TODO attack and defense based on level

            switch (type)
            {
                case CreatureType.Zombie: return new Zombie(position, GetRandomName(names), symbol, attackDamage, defense, hp);
                case CreatureType.Dragon: return new Dragon(position, GetRandomName(names), symbol, attackDamage, defense, hp);

            }

            return null;
        }

        static string GetRandomName(List<string> names)
        {
            return names.OrderBy(s => Guid.NewGuid()).First(); ;
        }
    }
}
