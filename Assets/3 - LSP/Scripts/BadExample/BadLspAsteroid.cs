using UnityEngine;

namespace Solid.LSP
{
    /// <summary>
    /// This is where the LSP principle is broken: we're narrowing down the BadFlyingObject as an Asteroid cannot Accelerate. 
    /// This means that this asteroid should use a different type of base class, or not extend the BadFlyingObject in the first place.
    /// </summary>
    public class BadLspAsteroid : BadFlyingObject
    {
        [SerializeField]
        private float _speed = 1.0f;
        [SerializeField]
        private float _turnSpeed = 70.0f;

        private Vector3 _startingDirection;
        private Vector3 _startingRotation;

        private void Awake()
        {
            _startingDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0.0f, Random.Range(0.0f, 1.0f));
            _startingRotation = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f));
        }

        protected override void MoveInSpace()
        {
            transform.position += Time.deltaTime * _startingDirection * _speed;
        }

        protected override void RotateInSpace()
        {
            transform.Rotate(_startingRotation * _turnSpeed * Time.deltaTime);
        }

        protected override void SetIsAccelerating()
        {
            _isAccelerating = true;
        }
    }
}