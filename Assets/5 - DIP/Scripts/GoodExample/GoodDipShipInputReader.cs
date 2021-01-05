using UnityEngine;

namespace Solid.DIP
{
    /// <summary>
    /// Second DIP Statement fulfilled: The abstraction (IShipInputReader) does not depend upon details (GoodShipInputReader), but the details depend upon the abstraction.
    /// This means that if the details change (ie. we want to use the AI Input instead of this class), it won't change the abstraction level (ie. the interface)
    /// </summary>
    public class GoodDipShipInputReader : IShipInputReader
    {
        public float Rotation { get; private set; }

        public float Thrust { get; private set; }

        public void UpdateInput()
        {
            Rotation = Input.GetAxis("Horizontal");
            Thrust = Input.GetAxis("Vertical");
        }
    }
}