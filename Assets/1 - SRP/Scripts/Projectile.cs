using Solid.SRP;
using UnityEngine;

namespace Solid
{
    /// <summary>
    /// Not relevant for the presentation. Simply take care of the projectile lifetime
    /// </summary>
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

        private void OnCollisionEnter(Collision collision)
        {
            ShipHealth ship = collision.collider.GetComponent<ShipHealth>();
            if (ShouldSendDamage(ship))
            {
                ship.TakeDamage(Damage);
                Destroy(gameObject);
            }
        }

        private bool ShouldSendDamage(ShipHealth ship)
        {
            return ship != null && ((_isPlayerProjectile && !ship.IsPlayerShip) || (!_isPlayerProjectile && ship.IsPlayerShip));
        }
    }
}