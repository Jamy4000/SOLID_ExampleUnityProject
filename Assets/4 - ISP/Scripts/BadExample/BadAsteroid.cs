using UnityEngine;

namespace Solid.ISP
{
    public class BadAsteroid : MonoBehaviour, IHaveStats
    {
        [SerializeField]
        private float _baseDamageValue;

        /// <summary>
        /// Useless method as asteroïds do not have a level
        /// </summary>
        public void LevelUp(int newDamage, int newHealth)
        {
        }

        /// <summary>
        /// Useless method as asteroïds get destroyed after hitting something
        /// </summary>
        public int ReduceHealth(int amount)
        {
            return 0;
        }

        public void DealDamage(IHaveStats target)
        {
            target.ReduceHealth(Damage);
        }

        public float CurrentSpeed { get; set; }

        public int Damage => (int)(_baseDamageValue * CurrentSpeed);

        /// <summary>
        /// Useless Field as asteroïds have 1 of health
        /// </summary>
        public int HealthMax => 1;

        /// <summary>
        /// Useless Field as asteroïds have 1 of health
        /// </summary>
        public int Health { get; set; } = 1;

        /// <summary>
        /// Useless Field as asteroïds do not have a shield
        /// </summary>
        public bool ShieldIsOn { get; set; }

        /// <summary>
        /// Useless Field as asteroïds do not have a level
        /// </summary>
        public int CurrentLevel { get; set; }
    }
}
