namespace Solid.ISP
{
    /// <summary>
    /// This interface only contain the CurrentSpeed field, taken from the previous IHaveStats interface, fitting the Interface Segregation Principle.
    /// </summary>
    public interface IHaveSpeed
    {
        float CurrentSpeed { get; set; }
    }
}