using UnityEngine;

namespace Solid.ISP
{
    /// <summary>
    /// The following script follow the Interface Segregation Principle, as it only use the interfaces, and, by extension, the fields and methods it needs.
    /// </summary>
    public class GoodIspPlayerShip : MonoBehaviour, IHaveSpeed, IDealDamage, IHaveHealth, IHaveLevel, IHaveShield
    {
        [SerializeField]
        private int _damage;
        [SerializeField]
        private int _maxHealth;

        public void LevelUp(int newDamage, int newHealth)
        {
            _maxHealth = newHealth;
            Health = newHealth;
            _damage = newDamage;
        }

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

        public int Damage => _damage * CurrentLevel;

        public int HealthMax => _maxHealth;

        public int Health { get; set; }

        public bool ShieldIsOn { get; set; }

        public int CurrentLevel { get; set; } = 1;
    }
}
