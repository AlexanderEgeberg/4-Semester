using System;
using System.Collections.Generic;
using System.Text;
using GameFramework.Factory.Entities.Creatures;

namespace GameFramework
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ICreature creature);
    }
}
