namespace Solid.ISP
{
    /// <summary>
    /// In this case, we jave a big interface that describe an object that has stats in our game (like speed, health, damage, ...)
    /// Even if this method would fit a lot of objects in our game, some other may not need some of the field and methods described below.
    /// </summary>
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