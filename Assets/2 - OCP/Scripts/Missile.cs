using UnityEngine;

namespace Solid.OCP
{
    /// <summary>
    /// A simple type of projectile that follow a specified target 
    /// </summary>
    public class Missile : Projectile
    {
        [SerializeField]
        private float _missileSpeed = 5.0f;

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