namespace Solid.LSP
{
    public class Good_PlayerShipHealth : Good_ShipHealth
    {
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage * 3);
        }
    }
}