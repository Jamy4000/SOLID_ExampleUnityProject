using UnityEngine;

namespace Solid.LSP
{
    [RequireComponent(typeof(Projectile))]
    public class Bad_ShipDamageDealer : MonoBehaviour
    {
        private Projectile _projectile;

        private void Awake()
        {
            _projectile = GetComponent<Projectile>();
        }

        private void OnCollisionEnter(Collision collision)
        {
            Bad_ShipHealth ship = collision.collider.GetComponent<Bad_ShipHealth>();
            if (ship != null && ShouldTakeDamage(_projectile.IsPlayerProjectile, ship.IsPlayerShip))
            {
                SendDamages(ship);
                Destroy(ship.gameObject);
            }
        }

        private void SendDamages(Bad_ShipHealth ship)
        {
            int damage = _projectile.Damage;

            if (ship is Bad_PlayerShipHealth)
                damage *= 3;
            else if (ship is Bad_TransporterShipHealth)
                damage *= 5;
            else if (ship is Bad_DeathStarHealth)
                damage = 0;

            ship.TakeDamage(damage);
        }

        private bool ShouldTakeDamage(bool isPlayerProjectile, bool isPlayerShip)
        {
            return (isPlayerProjectile && !isPlayerShip) || (!isPlayerProjectile && isPlayerShip);
        }
    }
}