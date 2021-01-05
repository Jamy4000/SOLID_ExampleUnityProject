using UnityEngine;

namespace Solid.OCP
{
    /// <summary>
    /// This will be use by the GoodWeaponSystem to launch a bullet. 
    /// The only thing we need to do is to make this class extend the ILauncher interface, and place it on the same GameObject as the GoodWeaponSystem.
    /// </summary>
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
