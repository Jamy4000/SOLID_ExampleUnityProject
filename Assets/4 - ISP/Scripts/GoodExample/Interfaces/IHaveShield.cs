namespace Solid.ISP
{
    /// <summary>
    /// This interface only contain the ShieldIsOn field, taken from the previous IHaveStats interface, fitting the Interface Segregation Principle.
    /// </summary>
    public interface IHaveShield
    {
        bool ShieldIsOn { get; set; }
    }
}
