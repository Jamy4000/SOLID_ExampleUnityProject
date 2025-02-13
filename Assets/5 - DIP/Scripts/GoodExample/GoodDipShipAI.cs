﻿using UnityEngine;

namespace Solid.DIP
{
    /// <summary>
    /// Second DIP Statement fulfilled: The abstraction (IShipInputReader) does not depend upon details (GoodShipAI), but the details depend upon the abstraction.
    /// This means that if the details change (ie. we want to use the Keyboard Input instead of this class), it won't change the abstraction level (ie. the interface)
    /// </summary>
    public class GoodDipShipAI : IShipInputReader
    {
        public float Rotation { get; private set; }

        public float Thrust { get; private set; }

        public void UpdateInput()
        {
            Rotation = Random.Range(-1.0f, 1.0f);
            Thrust = Random.Range(-1.0f, 1.0f);
        }
    }
}