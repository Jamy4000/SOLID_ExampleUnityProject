using UnityEngine;

namespace Solid.ISP
{
    public class GoodAsteroid : MonoBehaviour, IHaveSpeed, IDealDamage
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
