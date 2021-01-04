namespace Solid.LSP
{
    public class Good_DeathStarHealth : Good_ShipHealth
    {
        public override void TakeDamage(int damage)
        {
            // Death Star doesn't take damages
        }
    }
}