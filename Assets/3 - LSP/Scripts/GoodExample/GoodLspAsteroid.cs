using UnityEngine;

namespace Solid.LSP
{
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
            _startingDirection = new Vector3(Random.Range(-1, 1), 0.0f, Random.Range(-1, 1));
            _startingRotation = new Vector3(0, Random.Range(-1, 1), Random.Range(-1, 1));
        }

        private void Update()
        {
            MoveInSpace();
            RotateInSpace();
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