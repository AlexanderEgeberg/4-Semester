using System;
using System.Collections.Generic;
using System.Text;

namespace GameFramework.Factory.Entities.Creatures
{


    // SOLID - SRP Single responsibility, DeathObserver has their own class to seperate functions
    public class CreatureObserver : ICreatureObserver
    {
        private List<IObserver> _observers = new List<IObserver>();

        // The subscription management methods.
        public void Attach(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        // Trigger an update in each subscriber.
        public void Notify(ICreature creature)
        {
            foreach (var observer in _observers)
            {
                observer.Update(creature);
            }
        }

    }
}
