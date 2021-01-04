using System;
using UnityEngine;

namespace Solid.LSP
{
    public abstract class Good_ShipHealth : MonoBehaviour
    {
        public bool IsPlayerShip;

        [SerializeField]
        private int _maxHealth = 100;

        private int _currentHealth;

        public event Action OnDie = delegate { };

        private void Awake()
        {
            _currentHealth = _maxHealth;
        }

        public virtual void TakeDamage(int damage)
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
