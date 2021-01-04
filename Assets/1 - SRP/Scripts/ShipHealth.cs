using System;
using UnityEngine;

namespace Solid.SRP
{
    public class ShipHealth : MonoBehaviour
    {
        [SerializeField]
        private int _maxHealth = 100;
        [SerializeField]
        private bool _isPlayerShip = true;

        private int _currentHealth;

        public event Action OnDie = delegate { };

        private void Awake()
        {
            _currentHealth = _maxHealth;
        }

        private void OnCollisionEnter(Collision collision)
        {
            Projectile projectile = collision.collider.GetComponent<Projectile>();
            if (projectile != null && ShouldTakeDamage(projectile.IsPlayerProjectile))
            {
                TakeDamage(projectile.Damage);
                Destroy(projectile.gameObject);
            }
        }

        private bool ShouldTakeDamage(bool isPlayerProjectile)
        {
            return (isPlayerProjectile && !_isPlayerShip) || (!isPlayerProjectile && _isPlayerShip);
        }

        private void TakeDamage(int damage)
        {
            _currentHealth -= damage;
            if (_currentHealth <= 0)
                Die();
        }

        private void Die()
        {
            OnDie();
            Destroy(gameObject);
        }
    }
}