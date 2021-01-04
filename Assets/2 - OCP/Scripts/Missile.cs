using UnityEngine;

namespace Solid.OCP
{
    public class Missile : MonoBehaviour
    {
        [SerializeField]
        private float _missileSpeed = 1.0f;

        private Transform _target;

        private void FixedUpdate()
        {
            MoveMissile();
        }

        private void MoveMissile()
        {
            if (_target == null)
            {
                Destroy(gameObject);
                return;
            }

            Vector3 direction = (_target.position - transform.position).normalized;
            transform.position += direction * _missileSpeed * Time.deltaTime;
        }

        public void SetTarget(Transform target)
        {
            _target = target;
        }
    }
}