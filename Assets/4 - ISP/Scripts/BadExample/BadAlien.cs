using UnityEngine;

namespace Solid.ISP
{
    public class BadAlien : MonoBehaviour, IHaveStats
    {
        [SerializeField]
        private int _damage;
        [SerializeField]
        private int _maxHealth;

        /// <summary>
        /// Useless Method as aliens do not have a level
        /// </summary>
        public void LevelUp(int newDamage, int newHealth)
        {
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

        public int Damage => _damage;

        public int HealthMax => _maxHealth;

        public int Health { get; set; }

        /// <summary>
        /// Useless Field as Aliens can't have a shield
        /// </summary>
        public bool ShieldIsOn { get; set; }

        /// <summary>
        /// Useless Field as aliens do not have a level
        /// </summary>
        public int CurrentLevel { get; set; }
    }
}
