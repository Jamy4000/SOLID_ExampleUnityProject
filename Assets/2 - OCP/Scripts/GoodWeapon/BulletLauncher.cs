using UnityEngine;

namespace Solid.OCP
{
    public class BulletLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField]
        private Bullet _bulletPrefab;
        [SerializeField]
        private Transform _shipRoot;

        public void Launch(GoodWeaponSystem weapon)
        {
            Bullet bullet = Instantiate(_bulletPrefab, transform.position, Quaternion.identity);
            bullet.Launch(_shipRoot.forward);
        }
    }
}
