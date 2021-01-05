namespace Solid.OCP
{
    /// <summary>
    /// This will be use by the GoodWeaponSystem to launch an ammunition. 
    /// The only thing we need to do is create a new type of Launcher evrytime we have a new type of ammunition, and place it on the same GameObject as the GoodWeaponSystem.
    /// </summary>
    public interface ILauncher
    {
        void Launch(GoodWeaponSystem weapon);
    }
}
