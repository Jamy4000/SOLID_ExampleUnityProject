using UnityEngine;

namespace Solid.ISP
{
    public class GoodNPC : MonoBehaviour, IHaveHealth, IHaveSpeed
    {
        [SerializeField]
        private int _maxHealth;

        public int ReduceHealth(int amount)
        {
            Health -= amount;
            return Health;
        }

        public float CurrentSpeed { get; set; }

        public int HealthMax => _maxHealth;

        public int Health { get; set; }
    }
}
