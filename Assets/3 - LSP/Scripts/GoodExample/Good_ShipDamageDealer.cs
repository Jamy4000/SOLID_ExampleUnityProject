using UnityEngine;

namespace Solid.LSP
{
    [RequireComponent(typeof(Projectile))]
    public class Good_ShipDamageDealer : MonoBehaviour
    {
        private Projectile _projectile;

        private void Awake()
        {
            _projectile = GetComponent<Projectile>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            Good_ShipHealth ship = collision.collider.GetComponent<Good_ShipHealth>();
            if (ship != null && ShouldTakeDamage(_projectile.IsPlayerProjectile, ship.IsPlayerShip))
            {
                ship.TakeDamage(_projectile.Damage);
                Destroy(ship.gameObject);
            }
        }

        private bool ShouldTakeDamage(bool isPlayerProjectile, bool isPlayerShip)
        {
            return (isPlayerProjectile && !isPlayerShip) || (!isPlayerProjectile && isPlayerShip);
        }
    }
}