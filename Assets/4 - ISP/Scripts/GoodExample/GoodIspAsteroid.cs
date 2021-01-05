using UnityEngine;

namespace Solid.ISP
{
    /// <summary>
    /// The following script follow the Interface Segregation Principle, as it only use the interfaces, and, by extension, the fields and methods it needs.
    /// </summary>
    public class GoodIspAsteroid : MonoBehaviour, IHaveSpeed, IDealDamage
    {
        [SerializeField]
        private int _baseDamageValue;

        public void DealDamage(IHaveHealth target)
        {
            target.ReduceHealth(Damage);
        }

        public float CurrentSpeed { get; set; }

        public int Damage => (int)(_baseDamageValue * CurrentSpeed);
    }
}
