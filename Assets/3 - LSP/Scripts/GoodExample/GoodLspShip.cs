using Solid.SRP;
using UnityEngine;

namespace Solid.LSP
{
    /// <summary>
    /// We can see in this class that the GoodFlyingObject abstract class does fit for this specific object, as a spaceship can indeed move, rotate, and accelerate in space
    /// </summary>
    [RequireComponent(typeof(ShipInput))]
    public class GoodLspShip : GoodFlyingObject
    {
        [SerializeField]
        private float _speed = 1.0f;
        [SerializeField]
        private float _turnSpeed = 70.0f;

        private ShipInput _shipInput;

        private void Awake()
        {
            _shipInput = GetComponent<ShipInput>();
        }

        public override void MoveInSpace()
        {
            transform.position += Time.deltaTime * (_shipInput.Vertical * _currentAccelerationRate) * transform.forward * _speed;
        }

        public override void RotateInSpace()
        {
            transform.Rotate(transform.up * _shipInput.Horizontal * _turnSpeed * Time.deltaTime);
        }

        protected override void SetIsAccelerating()
        {
            _isAccelerating = _shipInput.Vertical != 0;
        }
    }
}