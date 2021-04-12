using GameFramework.Factory.Entities.Creatures;

namespace GameFramework.Decorator
{
    public class Warrior : PlayerDecorator
    {
        public Warrior(IPlayer aPlayer) : base(aPlayer)
        {
        }

        public new int Hit(ICreature enemy)
        {
            return base.Hit(enemy) + 2;
        }
    }
}
