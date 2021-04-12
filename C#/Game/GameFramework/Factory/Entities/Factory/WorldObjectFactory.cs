using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using GameFramework.Enum;
using GameFramework.Factory.Entities.Objects;

namespace GameFramework.Factory
{
    public static class WorldObjectFactory
    {
        public static IWorldObject GetWorldObject(WorldObjectType type, Position position, bool loot, string name,bool reusable, int value, bool block,string symbol)
        {
            switch (type)
            {
                case WorldObjectType.Food: return new Food(position,loot,name,symbol,block,reusable,value);
                case WorldObjectType.Wall: return new Wall(position, loot, name, symbol, block, reusable);
                case WorldObjectType.Key: return new Key(position, loot, name, symbol, block, reusable);
                case WorldObjectType.Wand: return new Wand(position, loot, name, symbol, block, reusable);
                case WorldObjectType.Bow: return new Bow(position, loot, name, symbol, block, reusable);
                case WorldObjectType.Sword: return new Sword(position, loot, name, symbol, block, reusable);
            }
            return null;
        }
    }
}
