using Solid.SRP;
using UnityEngine;

namespace Solid.LSP
{
    [RequireComponent(typeof(ShipInput))]
    public class BadLspShip : BadFlyingObject
    {
        [SerializeField]
        private float _speed = 1.0f;
        [SerializeField]
        private float _accelerationSpeed = 2.0f;
        [SerializeField]
        private float _turnSpeed = 70.0f;

        private float _accelerationRate;

        private ShipInput _shipInput;

        private void Awake()
        {
            _shipInput = GetComponent<ShipInput>();
        }

        private void Update()
        {
            Accelerate();
            MoveInSpace();
            RotateInSpace();
        }

        public override void Accelerate()
        {
            if (_shipInput.Vertical != 0.0f)
                _accelerationRate = Mathf.Clamp01((_accelerationRate + Time.deltaTime) * _accelerationSpeed); 
            else
                _accelerationRate = Mathf.Clamp01((_accelerationRate - Time.deltaTime) * _accelerationSpeed);
        }

        public override void MoveInSpace()
        {
            transform.position += Time.deltaTime * (_shipInput.Vertical * _accelerationRate) * transform.forward * _speed;
        }

        public override void RotateInSpace()
        {
            transform.Rotate(transform.up * _shipInput.Horizontal * _turnSpeed * Time.deltaTime);
        }
    }
}