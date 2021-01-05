namespace Solid.ISP
{
    public interface IHaveStats
    {
        float CurrentSpeed { get; set; }
        int Damage { get; }
        int Health { get; set; }
        int HealthMax { get; }
        bool ShieldIsOn { get; set; }
        int CurrentLevel { get; set; }

        int ReduceHealth(int amount);
        void DealDamage(IHaveStats target);
        void LevelUp(int newDamage, int newHealth);
    }
}