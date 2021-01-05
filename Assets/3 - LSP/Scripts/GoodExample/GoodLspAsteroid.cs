using UnityEngine;

namespace Solid.LSP
{
    /// <summary>
    /// We can see that the asteroid now extend the SpaceObject base class instead of the FlyingObject base class.
    /// This change in implementation fix the broken Liskov Substition principle from the previous example.
    /// </summary>
    public class GoodLspAsteroid : SpaceObject
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

        public override void MoveInSpace()
        {
            transform.position += Time.deltaTime * _startingDirection * _speed;
        }

        public override void RotateInSpace()
        {
            transform.Rotate(_startingRotation * _turnSpeed * Time.deltaTime);
        }
    }
}