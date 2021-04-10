namespace GameFramework.Factory.Entities.Creatures
{
    public interface ICreatureObserver
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(ICreature creature);
    }
}