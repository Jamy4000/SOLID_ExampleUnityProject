using UnityEngine;

namespace Solid.ISP
{
    /// <summary>
    /// This example is breaking the Interface Segregation Principle for the reason provided below in the different summaries
    /// </summary>
    public class BadIspNPC : MonoBehaviour, IHaveStats
    {
        [SerializeField]
        private int _maxHealth;

        /// <summary>
        /// Useless Method as a NPC do not have a level
        /// </summary>
        public void LevelUp(int newDamage, int newHealth)
        {
        }

        public int ReduceHealth(int amount)
        {
            Health -= amount;
            return Health;
        }

        /// <summary>
        /// Useless Method as a NPC doesn't deal Damages
        /// </summary>
        public void DealDamage(IHaveStats target)
        {
        }

        public float CurrentSpeed { get; set; }

        /// <summary>
        /// Useless Field as a NPC doesn't deal Damages
        /// </summary>
        public int Damage => 0;

        public int HealthMax => _maxHealth;

        public int Health { get; set; }

        /// <summary>
        /// Useless Field as a NPC do not have shield
        /// </summary>
        public bool ShieldIsOn { get; set; }

        /// <summary>
        /// Useless Field as NPC do not have a level
        /// </summary>
        public int CurrentLevel { get; set; }
    }
}
