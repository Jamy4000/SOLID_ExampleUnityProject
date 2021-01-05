using System;
using UnityEngine;

namespace Solid.SRP
{
    /// <summary>
    /// Class taking care of capturing the inputs for the ship, and assign the values to the fields / fire events when applicable
    /// </summary>
    public class ShipInput : MonoBehaviour
    {
        public float Horizontal { get; private set; }
        public float Vertical { get; private set; }
        public bool FireWeapons { get; private set; }

        public event Action OnFire = delegate { };

        void Update()
        {
            Horizontal = Input.GetAxis("Horizontal");
            Vertical = Input.GetAxis("Vertical");
            FireWeapons = Input.GetButtonDown("Fire1");
            if (FireWeapons)
                OnFire();
        }
    }
}
