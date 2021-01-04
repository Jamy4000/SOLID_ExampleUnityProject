using UnityEngine;

namespace Solid
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField]
        private int _damage = 5;
        [SerializeField]
        private float _timeBeforeDestroy = 5.0f;
        [SerializeField]
        private bool _isPlayerProjectile = true;

        public bool IsPlayerProjectile { get { return _isPlayerProjectile; } }

        public int Damage { get { return _damage; } }

        private void Start()
        {
            Destroy(gameObject, _timeBeforeDestroy);
        }
    }
}