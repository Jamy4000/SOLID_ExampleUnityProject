using UnityEngine;

namespace Solid.OCP
{
    /// <summary>
    /// This class doesn't respect the Open-Closed Principle, as we will have to modify this pre-existing code everytime we want to add a new type of ammunition.
    /// EG, This class is not open for extension, and is not closed for modification.
    /// </summary>
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
            // This is where we break the Open-Closes Principle
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