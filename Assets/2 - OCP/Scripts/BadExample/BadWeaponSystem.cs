using UnityEngine;

namespace Solid.OCP
{
    public class BadWeaponSystem : MonoBehaviour
    {
        [SerializeField]
        private Bullet _bulletPrefab;
        [SerializeField]
        private Missile _missilePrefab;
        [SerializeField]
        private SRP.ShipInput _shipInput;

        private void OnEnable()
        {
            _shipInput.OnFire += FireWeapon;
        }

        private void OnDisable()
        {
            _shipInput.OnFire -= FireWeapon;
        }

        private void FireWeapon()
        {
            if (_bulletPrefab != null)
            {
                Bullet bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
                bullet.Launch(_shipInput.transform.forward);
            }
            else if (_missilePrefab)
            {
                Transform target = GameObject.FindGameObjectWithTag("Ennemy").transform;
                if (target == null)
                    return;

                Missile missile = Instantiate(_missilePrefab, transform.position, Quaternion.identity);
                missile.SetTarget(target);
            }
        }
    }
}