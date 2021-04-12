using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework
{
    public class DeathObserver : IObserver
    {

        public void Update(ICreature creature)
        {
            TraceWorker.Write(TraceEventType.Information, 2, $"{creature.GetType().Name} {creature.Name} was killed");

        }
    }
}
