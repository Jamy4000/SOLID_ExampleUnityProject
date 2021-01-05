using UnityEngine;

namespace Solid.SRP
{
    [RequireComponent(typeof(ShipInput))]
    public class ProjectileLauncher : MonoBehaviour
    {
        [SerializeField]
        private GameObject _projecticlePrefab;
        [SerializeField]
        private Transform _weaponMountPoint;
        [SerializeField]
        private float _fireForce = 300.0f;

        private void Awake()
        {
            GetComponent<ShipInput>().OnFire += FireWeapon;
        }

        private void FireWeapon()
        {
            Rigidbody spawnedProjectile = Instantiate(_projecticlePrefab, _weaponMountPoint.position, _weaponMountPoint.rotation).GetComponent<Rigidbody>();
            spawnedProjectile.AddForce(transform.forward * _fireForce);
        }
    }
}