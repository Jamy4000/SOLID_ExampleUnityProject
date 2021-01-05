using UnityEngine;

namespace Solid.ISP
{
    /// <summary>
    /// The following script follow the Interface Segregation Principle, as it only use the interfaces, and, by extension, the fields and methods it needs.
    /// </summary>
    public class GoodIspNPC : MonoBehaviour, IHaveHealth, IHaveSpeed
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
