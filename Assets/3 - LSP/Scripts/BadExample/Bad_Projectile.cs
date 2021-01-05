using UnityEngine;

namespace Solid.LSP
{
    public class Bad_Projectile : MonoBehaviour
    {
        [SerializeField]
        private int _damage = 5;
        [SerializeField]
        private float _timeBeforeDestroy = 5.0f;
        [SerializeField]
        private bool _isPlayerProjectile = true;

        private void Start()
        {
            Destroy(gameObject, _timeBeforeDestroy);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Bad_ShipHealth ship = collision.collider.GetComponent<Bad_ShipHealth>();
            if (ShouldSendDamage(ship))
            {
                SendDamages(ship);
                Destroy(gameObject);
            }
        }

        private void SendDamages(Bad_ShipHealth ship)
        {
            int damage = _damage;

            if (ship is Bad_PlayerShipHealth)
                damage *= 3;
            else if (ship is Bad_TransporterShipHealth)
                damage *= 5;
            else if (ship is Bad_DeathStarHealth)
                damage = 0;

            ship.TakeDamage(damage);
        }

        private bool ShouldSendDamage(Bad_ShipHealth ship)
        {
            return ship != null && ((_isPlayerProjectile && !ship.IsPlayerShip) || (!_isPlayerProjectile && ship.IsPlayerShip));
        }
    }
}