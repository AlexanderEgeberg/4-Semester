namespace GameFramework.Factory.Entities.Creatures
{
    public class Zombie : Monster
    {
        public Zombie(Position position, string name, string symbol, int attackDamage, int defense, int hp) : base(position, name, symbol, attackDamage, defense, hp)
        {
        }
    }
}
