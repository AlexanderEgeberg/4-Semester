using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using GameFramework.Entities;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework
{
    public class DeathObserver : IObserver
    {

        public void Update(ICreature creature)
        {
            TraceWorker.Write(TraceEventType.Information, 2, $"{creature.GetType().Name} {creature.Name} was killed");


            //if (creature.HP <= 0)
            //{

            //    //whenever this is ran I observed Creature hp turning to 0

            //    if (creature.GetType() == typeof(IPlayer))
            //    {
            //        Console.WriteLine("player died");
            //        Console.ReadLine();
            //        TraceWorker.Write(TraceEventType.Information,2,$"Player {creature.Name} was killed");
            //    }
            //    else if (creature.GetType() == typeof(IMonster))
            //    {
            //        Console.WriteLine("Monster died");

            //        Console.ReadLine();
            //        TraceWorker.Write(TraceEventType.Information,2, $"Enemy {creature.Name} killed");
            //    }

            //}
        }
    }
}
