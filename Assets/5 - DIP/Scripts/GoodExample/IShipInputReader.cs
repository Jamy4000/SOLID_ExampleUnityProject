namespace Solid.DIP
{
    /// <summary>
    /// Second DIP Statement fulfilled: The abstraction (IShipInputReader) does not depend upon details (GoodShipInputReader OR GoodShipAI), but the details depend upon the abstraction.
    /// This means that if the details change (ie. we want to use the Keyboard Input instead of the AI, and Vice Versa), we won't have to change the abstraction level (ie. this interface).
    /// </summary>
    public interface IShipInputReader
    {
        float Rotation { get; }

        float Thrust { get; }

        void UpdateInput();
    }
}
