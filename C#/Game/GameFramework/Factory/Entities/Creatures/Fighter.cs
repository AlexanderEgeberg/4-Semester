namespace GameFramework.Factory.Entities.Creatures
{
    public class Fighter : Player
    {
        public Fighter(Position position, string name, string symbol, int attackDamage, int defense, int hp) : base(position, name, symbol, attackDamage, defense, hp)
        {
        }
    }
}