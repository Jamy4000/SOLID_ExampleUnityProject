using UnityEngine;

namespace Solid.OCP
{
    public class MissileLauncher : MonoBehaviour, ILauncher
    {
        [SerializeField]
        private Missile _missilePrefab;

        public void Launch(GoodWeaponSystem weapon)
        {
            Transform target = GameObject.FindGameObjectWithTag("Ennemy")?.transform;
            Missile missile = Instantiate(_missilePrefab, transform.position, Quaternion.identity);
            missile.SetTarget(target);
        }
    }
}
