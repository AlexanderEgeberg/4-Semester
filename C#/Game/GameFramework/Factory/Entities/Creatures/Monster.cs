namespace GameFramework.Entities
{
    public abstract class Monster : Creature, IMonster
    {
        protected Monster(Position position, string name, string symbol, int attackDamage, int defense, int hp) : base(position, name, symbol, attackDamage, defense, hp)
        {
        }
    }
}