namespace Solid.LSP
{
    public class Good_TransporterShipHealth : Good_ShipHealth
    {
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage * 5);
        }
    }
}