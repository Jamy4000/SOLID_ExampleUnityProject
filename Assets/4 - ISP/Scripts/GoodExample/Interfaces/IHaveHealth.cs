namespace Solid.ISP
{
    public interface IHaveHealth
    {
        int Health { get; set; }
        int HealthMax { get; }

        int ReduceHealth(int amount);
    }
}