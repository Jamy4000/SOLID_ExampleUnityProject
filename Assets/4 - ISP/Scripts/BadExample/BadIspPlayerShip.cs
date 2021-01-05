using UnityEngine;

namespace Solid.ISP
{
    /// <summary>
    /// This first example is the perfect one to show how the IHaveStats interface wanted to be used.
    /// All fields and methods are used, meaning that we do not break the Interface Segregation Principle here.
    /// </summary>
    public class BadIspPlayerShip : MonoBehaviour, IHaveStats
    {
        [SerializeField]
        private int _damage;
        [SerializeField]
        private int _maxHealth;

        public void LevelUp(int newDamage, int newHealth)
        {
            CurrentLevel++;
            _maxHealth = newHealth;
            Health = newHealth;
            _damage = newDamage;
        }

        public int ReduceHealth(int amount)
        {
            Health -= amount;
            return Health;
        }

        public void DealDamage(IHaveStats target)
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
