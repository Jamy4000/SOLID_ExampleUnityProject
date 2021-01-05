namespace Solid.ISP
{
    /// <summary>
    /// This interface contains everything we need for objects with Health, fitting the Interface Segregation Principle.
    /// </summary>
    public interface IHaveHealth
    {
        int Health { get; set; }
        int HealthMax { get; }

        int ReduceHealth(int amount);
    }
}