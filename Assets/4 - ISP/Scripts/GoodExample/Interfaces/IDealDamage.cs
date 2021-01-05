namespace Solid.ISP
{
    /// <summary>
    /// This interface contains everything we need for objects that can deal damages, fitting the Interface Segregation Principle.
    /// </summary>
    public interface IDealDamage
    {
        int Damage { get; }
        void DealDamage(IHaveHealth target);
    }
}