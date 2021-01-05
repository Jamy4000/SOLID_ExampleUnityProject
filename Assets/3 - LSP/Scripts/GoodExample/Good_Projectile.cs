using UnityEngine;

namespace Solid.LSP
{
    public class Good_Projectile : MonoBehaviour
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
            Good_ShipHealth ship = collision.collider.GetComponent<Good_ShipHealth>();
            if (ShouldSendDamage(ship))
            {
                ship.TakeDamage(_damage);
                Destroy(gameObject);
            }
        }

        private bool ShouldSendDamage(Good_ShipHealth ship)
        {
            return ship != null && ((_isPlayerProjectile && !ship.IsPlayerShip) || (!_isPlayerProjectile && ship.IsPlayerShip));
        }
    }
}