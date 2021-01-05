using UnityEngine;

namespace Solid.ISP
{
    public class GoodAlien : MonoBehaviour, IHaveSpeed, IHaveHealth, IDealDamage
    {
        [SerializeField]
        private int _damage;
        [SerializeField]
        private int _maxHealth;

        public int ReduceHealth(int amount)
        {
            Health -= amount;
            return Health;
        }

        public void DealDamage(IHaveHealth target)
        {
            target.ReduceHealth(Damage);
        }

        public float CurrentSpeed { get; set; }

        public int Damage => _damage;

        public int HealthMax => _maxHealth;

        public int Health { get; set; }
    }
}
