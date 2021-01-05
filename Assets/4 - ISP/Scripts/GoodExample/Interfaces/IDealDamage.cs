namespace Solid.ISP
{
    public interface IDealDamage
    {
        int Damage { get; }
        void DealDamage(IHaveHealth target);
    }
}