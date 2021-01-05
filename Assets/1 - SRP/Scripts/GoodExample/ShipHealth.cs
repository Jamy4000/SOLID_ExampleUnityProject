using System;
using UnityEngine;

namespace Solid.SRP
{
    /// <summary>
    /// Class taking care of the health of the ship, and checking if the ship need to be destroy after taking too much damages
    /// </summary>
    public class ShipHealth : MonoBehaviour
    {
        [SerializeField]
        private int _maxHealth = 100;
        [SerializeField]
        private bool _isPlayerShip = true;

        public bool IsPlayerShip { get { return _isPlayerShip; } }

        private int _currentHealth;

        public event Action OnDie = delegate { };

        private void Awake()
        {
            _currentHealth = _maxHealth;
        }

        public void TakeDamage(int damage)
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