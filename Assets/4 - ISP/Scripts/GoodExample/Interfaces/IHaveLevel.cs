namespace Solid.ISP
{
    /// <summary>
    /// This interface contains everything we need for objects that can level up, fitting the Interface Segregation Principle.
    /// </summary>
    public interface IHaveLevel
    {
        int CurrentLevel { get; set; }

        void LevelUp(int newDamage, int newHealth);
    }
}