using UnityEngine;

namespace Solid.LSP
{
    /// <summary>
    /// This class is here to fix the broken LSP from the Bad Example: 
    /// A FlyingObject can indeed move in space and rotate in space (like a spaceship), so it can extend the SpaceObject class
    /// </summary>
    public abstract class GoodFlyingObject : SpaceObject
    {
        [SerializeField]
        private float _accelerationSpeed = 2.0f;

        protected float _currentAccelerationRate;
        protected bool _isAccelerating;

        protected override void Update()
        {
            SetIsAccelerating();
            Accelerate();
            base.Update();
        }

        protected abstract void SetIsAccelerating();

        protected void Accelerate()
        {
            if (_isAccelerating)
                _currentAccelerationRate = Mathf.Clamp01(_currentAccelerationRate + (_accelerationSpeed * Time.deltaTime));
            else
                _currentAccelerationRate = Mathf.Clamp01(_currentAccelerationRate - (_accelerationSpeed * Time.deltaTime));
        }
    }
}