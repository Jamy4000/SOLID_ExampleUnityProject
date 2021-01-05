using UnityEngine;

namespace Solid.LSP
{
    /// <summary>
    /// Abstraction of a flying object, moving, rotating and accelerating in space. 
    /// </summary>
    public abstract class BadFlyingObject : MonoBehaviour
    {
        [SerializeField]
        private float _accelerationSpeed = 2.0f;

        protected float _currentAccelerationRate;
        protected bool _isAccelerating;

        protected virtual void Update()
        {
            SetIsAccelerating();
            Accelerate();
            MoveInSpace();
            RotateInSpace();
        }

        protected abstract void SetIsAccelerating();

        protected abstract void MoveInSpace();

        protected abstract void RotateInSpace();

        protected void Accelerate()
        {
            if (_isAccelerating)
                _currentAccelerationRate = Mathf.Clamp01(_currentAccelerationRate + (_accelerationSpeed * Time.deltaTime));
            else
                _currentAccelerationRate = Mathf.Clamp01(_currentAccelerationRate - (_accelerationSpeed * Time.deltaTime));
        }
    }
}
