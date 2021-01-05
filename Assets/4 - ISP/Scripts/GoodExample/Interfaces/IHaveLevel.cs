namespace Solid.ISP
{
    public interface IHaveLevel
    {
        int CurrentLevel { get; set; }

        void LevelUp(int newDamage, int newHealth);
    }
}